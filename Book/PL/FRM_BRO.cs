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
    public partial class FRM_BRO : Form
    {
        public int ID;
        public FRM_BRO()
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
                    BL.CLS_BRO BLBR = new BL.CLS_BRO();
                    BLBR.Insert(Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value), Convert.ToString(dataGridView2.CurrentRow.Cells[1].Value), Convert.ToString(txt_date1.Value), Convert.ToString(txt_date2.Value), Convert.ToInt32(txt_title.Text));
                    PL.FRM_DADD fadd = new FRM_DADD();
                    fadd.Show();
                    this.Close();


                }
                else
                {
                    BL.CLS_BRO BLBR = new BL.CLS_BRO();
                    BLBR.update(Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value), Convert.ToString(dataGridView2.CurrentRow.Cells[1].Value), Convert.ToString(txt_date1.Value), Convert.ToString(txt_date2.Value), Convert.ToInt32(txt_title.Text), ID);
                    PL.FRM_DEDIT fedit = new FRM_DEDIT();
                    fedit.Show();
                    this.Close();

                }


            }
        }

        private void FRM_BRO_Load(object sender, EventArgs e)
        {
            BL.CLS_SELL BLSELL = new BL.CLS_SELL();
            DataTable dt1 = new DataTable();
            dt1 = BLSELL.LoadBOOKS();
            dataGridView2.DataSource = dt1;
            DataTable dt2 = new DataTable();
            dt2 = BLSELL.LoadST();
            dataGridView1.DataSource = dt2;
        }
    }
}
