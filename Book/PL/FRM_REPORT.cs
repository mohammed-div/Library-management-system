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
    public partial class FRM_REPORT : Form
    {
        BL.CLS_CAT BLCAT = new BL.CLS_CAT();
        BL.CLS_BOOKS BLBOOKS = new BL.CLS_BOOKS();
        BL.CLS_ST BLST = new BL.CLS_ST();
        BL.CLS_SELL BLSELL = new BL.CLS_SELL();
        BL.CLS_BRO BLBRO = new BL.CLS_BRO();
        BL.CLS_USERS BLUSER = new BL.CLS_USERS();
        public FRM_REPORT()
        {
            InitializeComponent();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            printDialog1.ShowDialog();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap img = new Bitmap(panel1.Width, panel1.Height);
            panel1.DrawToBitmap(img, new Rectangle(Point.Empty, panel1.Size));
            e.Graphics.DrawImage(img, 0, 0);
        }

        private void FRM_REPORT_Load(object sender, EventArgs e)
        {
            label20.Text = DateTime.Now.ToString();

            DataTable d = new DataTable();
            d = BLBOOKS.Load();

            label2.Text = d.Rows.Count.ToString();
            DataTable dt1 = new DataTable();

            dt1 = BLST.Load();
            label5.Text = dt1.Rows.Count.ToString();

            DataTable m = new DataTable();
            m = BLSELL.Load();
            label7.Text = m.Rows.Count.ToString();

            DataTable u = new DataTable();
            u = BLBRO.Load();
            label13.Text = u.Rows.Count.ToString();

            DataTable t = new DataTable();
            t = BLUSER.Load();
            label9.Text = t.Rows.Count.ToString();

            DataTable j = new DataTable();
            j = BLCAT.Load();
            label11.Text = j.Rows.Count.ToString();

        }
    }
}
