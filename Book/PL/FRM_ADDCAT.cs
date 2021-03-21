using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Book.PL
{
    public partial class FRM_ADDCAT : Form
    {
        public int ID;
        public FRM_ADDCAT()
        {
            InitializeComponent();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (txt_catname.Text == "")
            {
                PL.FRM_ERRORINSERT FError = new FRM_ERRORINSERT();
                FError.Show();
            }
            else
            {
                if (ID == 0)
                {
                    BL.CLS_CAT BLCAT = new BL.CLS_CAT();
                    BLCAT.Insert(txt_catname.Text);
                    PL.FRM_DADD fadd = new FRM_DADD();
                    fadd.Show();
                    this.Close();

                }
                else
                {
                    BL.CLS_CAT BLCAT = new BL.CLS_CAT();
                    BLCAT.Update(txt_catname.Text, ID);
                    PL.FRM_DEDIT fedit = new FRM_DEDIT();
                    fedit.Show();
                    this.Close();

                }


            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FRM_ADDCAT_Load(object sender, EventArgs e)
        {

        }
    }
}
