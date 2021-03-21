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
    public partial class FRM_START : Form
    {
        public FRM_START()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            BL.CLS_USERS user = new BL.CLS_USERS();
            DataTable dt = new DataTable();
            dt = user.startload();
            if (dt.Rows.Count > 0)
            {

                PL.FRM_MAIN frmmain = new  PL.FRM_MAIN();
                object lbname = dt.Rows[0]["CNAME"];
                object lbprem = dt.Rows[0]["CPREM"];
                frmmain.lb_name.Text = lbname.ToString();
                frmmain.lb_prem.Text = lbprem.ToString();
                frmmain.Show();
                this.Hide();
                timer1.Enabled = false;

            }
            else
            {
                PL.FRM_LOGIN frmlogin = new FRM_LOGIN();
                frmlogin.Show();
                this.Hide();
                timer1.Enabled = false;
            }
        }
    }
    }

