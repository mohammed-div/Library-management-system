using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Book.PL
{
    public partial class FRM_BACKUP : Form
    {
        int move;
        int movex;
        int movey;
        string DBNAME;
        string DBSVAEPATH;
        string DBRESTORENAME;
        public FRM_BACKUP()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            var rs = ofd.ShowDialog();
            if (rs == DialogResult.OK)
            {
                DBNAME = ofd.FileName;
            }
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog ofd = new FolderBrowserDialog();
            var rs = ofd.ShowDialog();
            if (rs == DialogResult.OK)
            {
                DBSVAEPATH = ofd.SelectedPath;
            }
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            var rs = ofd.ShowDialog();
            if (rs == DialogResult.OK)
            {
                DBRESTORENAME = ofd.FileName;
            }
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + DBNAME + ";Integrated Security=True");
                string FileName = DBSVAEPATH + "\\DBPRESRIPTION";
                string quarystr = "BACKUP DATABASE [" + DBNAME + "] TO DISK='" + FileName + ".bak'";
                SqlCommand cmd = new SqlCommand(quarystr, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("تم النسخ الاحتياطي بنجاح");

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + DBNAME + ";Integrated Security=True");
                string quarystr = "ALTER DATABASE [" + DBNAME + "] SET OFFLINE WITH ROLLBACK IMMEDIATE;RESTORE DATABASE [" + DBNAME + "] FROM DISK='" + DBRESTORENAME + "'";
                SqlCommand cmd = new SqlCommand(quarystr, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("تم استعادة النسخة بنجاح");

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void bunifuImageButton5_MouseDown(object sender, MouseEventArgs e)
        {
            move = 1;
            movex = e.X;
            movey = e.Y;
        }

        private void bunifuImageButton5_MouseUp(object sender, MouseEventArgs e)
        {
            move = 0;
        }

        private void bunifuImageButton5_MouseMove(object sender, MouseEventArgs e)
        {
            if (move == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movex, MousePosition.Y - movey);
            }
        }
    }
}
