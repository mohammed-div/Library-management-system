using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Book.PL
{
    public partial class FRM_ADDSTUDINT : Form
    {
        public int ID;
        public FRM_ADDSTUDINT()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();
            var result = OFD.ShowDialog();
            if (result == DialogResult.OK)
            {
                cover.Image = Image.FromFile(OFD.FileName);
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (txt_name.Text == "" || txt_location.Text == "" || txt_email.Text == "")
            {
                PL.FRM_ERRORINSERT FError = new FRM_ERRORINSERT();
                FError.Show();
            }
            else
            {
                MemoryStream ma = new MemoryStream();
                cover.Image.Save(ma, System.Drawing.Imaging.ImageFormat.Jpeg);
                if (ID == 0)
                {
                    BL.CLS_ST BLST = new BL.CLS_ST();
                    BLST.Insert(txt_name.Text, txt_location.Text, txt_phone.Text, txt_email.Text, txt_school.Text, txt_dep.Text, ma);

                    PL.FRM_DADD fadd = new FRM_DADD();
                    fadd.Show();
                    this.Close();


                }
                else
                {
                    BL.CLS_ST BLST = new BL.CLS_ST();
                    BLST.Update(txt_name.Text, txt_location.Text, txt_phone.Text, txt_email.Text, txt_school.Text, txt_dep.Text, ma, ID);
                    PL.FRM_DEDIT fedit = new FRM_DEDIT();
                    fedit.Show();
                    this.Close();

                }


            }
        }
    }
}
