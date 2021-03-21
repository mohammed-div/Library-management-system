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
    public partial class FRM_ADDBOOKS : Form
    {
        public int ID;
        public FRM_ADDBOOKS()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PL.FRM_ADDCAT FCAT = new FRM_ADDCAT();
            FCAT.btnadd.ButtonText = "اضافة";
            FCAT.ID = 0;
            FCAT.Show();
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
            if (txt_title.Text == "" || txt_auther.Text == "" || txt_price.Text == "")
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
                    BL.CLS_BOOKS BLBOOKS = new BL.CLS_BOOKS();
                    BLBOOKS.Insert(txt_title.Text, txt_auther.Text, comboBox1.Text, txt_price.Text, txt_rate.Value, ma);

                    PL.FRM_DADD fadd = new FRM_DADD();
                    fadd.Show();
                    this.Close();


                }
                else
                {
                    BL.CLS_BOOKS BLBOOKS = new BL.CLS_BOOKS();
                    BLBOOKS.Update(txt_title.Text, txt_auther.Text, comboBox1.Text, txt_price.Text, txt_rate.Value, ma, ID);
                    PL.FRM_DEDIT fedit = new FRM_DEDIT();
                    fedit.Show();
                    this.Close();

                }


            }
        }

        private void FRM_ADDBOOKS_Load(object sender, EventArgs e)
        {
            try
            {
                BL.CLS_BOOKS BLBOOKS = new BL.CLS_BOOKS();
                DataTable dt = new DataTable();
                dt = BLBOOKS.LOADCAT();
                object[] obj = new object[dt.Rows.Count];
                int i;
                for (i = 0; i < dt.Rows.Count; i++)
                {
                    obj[i] = dt.Rows[i]["CAT_NAME"];
                }
                comboBox1.Items.AddRange(obj);

            }
            catch
            {

            }
        }
    }
}
