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
    public partial class FRM_MAKESELL : Form
    {
        public int ID;
        public FRM_MAKESELL()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (txt_title.Text == "")
            {
                PL.FRM_ERRORINSERT FError = new FRM_ERRORINSERT();
                FError.Show();
            }
            else
            {
                if (ID == 0)
                {
                    BL.CLS_SELL BLSELL = new BL.CLS_SELL();
                    BLSELL.Insert(Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value), Convert.ToString(dataGridView2.CurrentRow.Cells[1].Value), Convert.ToInt32(txt_title.Text));
                    PL.FRM_DADD fadd = new FRM_DADD();
                    fadd.Show();
                    this.Close();


                }
                else
                {
                    BL.CLS_SELL BLSELL = new BL.CLS_SELL();
                    BLSELL.Update(Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value), Convert.ToString(dataGridView2.CurrentRow.Cells[1].Value), Convert.ToInt32(txt_title.Text), ID);
                    PL.FRM_DEDIT fedit = new FRM_DEDIT();
                    fedit.Show();
                    this.Close();

                }


            }
        }
    }
}
