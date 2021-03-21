using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Book.PL
{
    public partial class FRM_ADDUSER : Form
    {
        public int ID;
        public FRM_ADDUSER()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txt_timer.Text = DateTime.Now.ToString();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {

            if (txt_name.Text == "" || txt_password.Text == "")
            {
                PL.FRM_ERRORINSERT FError = new FRM_ERRORINSERT();
                FError.Show();
            }
            else
            {
                if (ID == 0)
                {
                    BL.CLS_USERS BLuser = new BL.CLS_USERS();
                    BLuser.Insert(txt_name.Text, txt_password.Text, txt_prem.Text, "false");

                    PL.FRM_DADD fadd = new FRM_DADD();
                    fadd.Show();
                    this.Close();


                }
                else
                {
                    BL.CLS_USERS BLuser = new BL.CLS_USERS();
                    BLuser.update(txt_name.Text, txt_password.Text, txt_prem.Text, ID);
                    PL.FRM_DEDIT fedit = new FRM_DEDIT();
                    fedit.Show();
                    this.Close();

                }


            }
        }
    }
    
}
