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
    public partial class FRM_LOGIN : Form
    {
        public FRM_LOGIN()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (txt_name.Text == "" || txt_password.Text == "")
            {
                MessageBox.Show("اكمل متطلبات الادخال ");
            }
            else
            {


                try
                {
                    BL.CLS_USERS CLUSER = new BL.CLS_USERS();
                    DataTable dt = new DataTable();
                    dt = CLUSER.Login(txt_name.Text, txt_password.Text);
                    if (dt.Rows.Count > 0)
                    {
                        CLUSER.updatelogin(txt_name.Text, txt_password.Text);
                        PL.FRM_MAIN frmmain = new  PL.FRM_MAIN();
                        object lbname = dt.Rows[0]["CNAME"];
                        object lbprem = dt.Rows[0]["CPREM"];
                        frmmain.lb_name.Text = lbname.ToString();
                        frmmain.lb_prem.Text = lbprem.ToString();
                        frmmain.Show();
                        this.Close();


                    }
                    else
                    {
                        MessageBox.Show("خطأ في معلومات تسجيل الدخول");
                    }

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
