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
using System.IO;
namespace Book.PL
{
    public partial class FRM_MAIN : Form
    {
        string state;
        int ID;
        BL.CLS_CAT BLCAT = new BL.CLS_CAT();
        BL.CLS_BOOKS BLBOOKS = new BL.CLS_BOOKS();
        BL.CLS_ST BLST = new BL.CLS_ST();
        BL.CLS_SELL BLSELL = new BL.CLS_SELL();
        BL.CLS_BRO BLBRO = new BL.CLS_BRO();
        BL.CLS_USERS BLUSER = new BL.CLS_USERS();
        public FRM_MAIN()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;


            }



            else
            {

                this.WindowState = FormWindowState.Normal;

            }
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {

           PL. FRM_BACKUP backup = new PL. FRM_BACKUP();
            backup.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            P_HOME.Visible = true;
            P_MAIN.Visible = false;
            Lb_Title.Text = "الرئيسية";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            P_MAIN.Visible = true;
            P_HOME.Visible = false;
            bunifuThinButton24.Visible = true;

            state = "BOOKS";
            Lb_Title.Text = "الكتب";
            DataTable dt = new DataTable();

            try
            {
                dt = BLBOOKS.Load();
                dataGridView1.DataSource = dt;

                dataGridView1.Columns[0].HeaderText = "التسلسل";
                dataGridView1.Columns[1].HeaderText = "اسم الكتاب";
                dataGridView1.Columns[2].HeaderText = "المؤلف";

                dataGridView1.Columns[3].HeaderText = "التقييم";

                dataGridView1.Columns[4].HeaderText = "السعر";




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            P_MAIN.Visible = true;
            P_HOME.Visible = false;
            bunifuThinButton24.Visible = false;

            state = "ST";
            Lb_Title.Text = "الطلاب";
            DataTable dt = new DataTable();

            try
            {
                dt = BLST.Load();
                dataGridView1.DataSource = dt;
                dataGridView1.Columns[0].HeaderText = "التسلسل";
                dataGridView1.Columns[1].HeaderText = "اسم الطالب";
                dataGridView1.Columns[2].HeaderText = "السكن";
                dataGridView1.Columns[3].HeaderText = "رقم الهاتف";
                dataGridView1.Columns[4].HeaderText = "ايميل";
                dataGridView1.Columns[5].HeaderText = "الكلية";
                dataGridView1.Columns[6].HeaderText = "القسم";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            P_MAIN.Visible = true;
            P_HOME.Visible = false;
            bunifuThinButton24.Visible = false;

            state = "SELL";
            Lb_Title.Text = "البيع";
            DataTable dt = new DataTable();

            try
            {
                dt = BLSELL.Load();
                dataGridView1.DataSource = dt;
                dataGridView1.Columns[0].HeaderText = "التسلسل";
                dataGridView1.Columns[1].HeaderText = "المشتري";
                dataGridView1.Columns[2].HeaderText = "اسم الكتاب";
                dataGridView1.Columns[3].HeaderText = "السعر";



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            P_MAIN.Visible = true;
            P_HOME.Visible = false;
            bunifuThinButton24.Visible = false;

            state = "BRO";
            Lb_Title.Text = "الاستعارة";
            DataTable dt = new DataTable();

            try
            {
                dt = BLBRO.Load();
                dataGridView1.DataSource = dt;
                dataGridView1.Columns[0].HeaderText = "التسلسل";
                dataGridView1.Columns[1].HeaderText = "اسم المشتري";
                dataGridView1.Columns[2].HeaderText = "اسم الكتاب";
                dataGridView1.Columns[3].HeaderText = "بداية الاستعارة";
                dataGridView1.Columns[4].HeaderText = "تهاية الاستعارة";
                dataGridView1.Columns[5].HeaderText = "السعر";



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            P_MAIN.Visible = true;
            P_HOME.Visible = false;
            bunifuThinButton24.Visible = false;

            state = "USER";
            Lb_Title.Text = "المستخدمين";
            DataTable dt = new DataTable();

            try
            {
                dt = BLUSER.Load();
                dataGridView1.DataSource = dt;
                dataGridView1.Columns[0].HeaderText = "التسلسل";
                dataGridView1.Columns[1].HeaderText = "اسم المستخدم";
                dataGridView1.Columns[2].HeaderText = "كلمة السر";
                dataGridView1.Columns[3].HeaderText = "الصلاحية";



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            P_MAIN.Visible = true;
            P_HOME.Visible = false;
            bunifuThinButton24.Visible = false;

            state = "CAT";
            Lb_Title.Text = "الاصناف";
            DataTable dt = new DataTable();

            try
            {
                dt = BLCAT.Load();
                dataGridView1.DataSource = dt;

                dataGridView1.Columns[0].HeaderText = "رقم الصنف";
                dataGridView1.Columns[1].HeaderText = "اسم الصنف";


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void button13_Click(object sender, EventArgs e)
        {

            PL.FRM_REPORT report = new PL. FRM_REPORT();
            report.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.Close();
            PL.FRM_LOGIN Login = new FRM_LOGIN();
            BLUSER.LOGOUT();
            this.Hide();
            Login.Show();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            //ADDCAT
            if (state == "CAT")
            {
                PL.FRM_ADDCAT FCAT = new FRM_ADDCAT();
                FCAT.btnadd.ButtonText = "اضافة";

                FCAT.ID = 0;
                bunifuTransition1.ShowSync(FCAT);

            }
            if (state == "BOOKS")
            {
                PL.FRM_ADDBOOKS fbooks = new FRM_ADDBOOKS();
                fbooks.btnadd.ButtonText = "اضافة";
                fbooks.ID = 0;
                bunifuTransition1.ShowSync(fbooks);

            }
            if (state == "ST")
            {
                PL.FRM_ADDSTUDINT fsell = new FRM_ADDSTUDINT();
                fsell.btnadd.ButtonText = "اضافة";
                fsell.ID = 0;
                bunifuTransition1.ShowSync(fsell);

            }
            if (state == "SELL")
            {
                PL.FRM_MAKESELL fst = new FRM_MAKESELL();
                fst.btnadd.ButtonText = "اضافة";
                fst.ID = 0;
                bunifuTransition1.ShowSync(fst);

            }
            if (state == "BRO")
            {
                PL.FRM_BRO fBR = new FRM_BRO();
                fBR.btnadd.ButtonText = "اضافة";
                fBR.ID = 0;
                bunifuTransition1.ShowSync(fBR);

            }
            if (state == "USER")
            {
                PL.FRM_ADDUSER fuser = new FRM_ADDUSER();
                fuser.btnadd.ButtonText = "اضافة";
                fuser.ID = 0;
                bunifuTransition1.ShowSync(fuser);

            }
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            if (state == "CAT")
            {
                PL.FRM_ADDCAT FCAT = new FRM_ADDCAT();
                FCAT.btnadd.ButtonText = "تعديل";
                FCAT.txt_catname.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value);

                FCAT.ID = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value);
                bunifuTransition1.ShowSync(FCAT);

            }
            else if (state == "BOOKS")
            {
                PL.FRM_ADDBOOKS Fbooks = new FRM_ADDBOOKS();
                Fbooks.btnadd.ButtonText = "تعديل";

                Fbooks.ID = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value);
                DataTable dt = new DataTable();
                dt = BLBOOKS.LOADEDIT(Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value));
                object obj1 = dt.Rows[0]["TITLE"];
                object obj2 = dt.Rows[0]["AUTHER"];
                object obj3 = dt.Rows[0]["CAT"];
                object obj4 = dt.Rows[0]["PRICE"];
                object obj5 = dt.Rows[0]["RATE"];
                object obj6 = dt.Rows[0]["COVER"];
                Fbooks.txt_title.Text = obj1.ToString();
                Fbooks.txt_auther.Text = obj2.ToString();
                Fbooks.comboBox1.Text = obj3.ToString();
                Fbooks.txt_price.Text = obj4.ToString();
                Fbooks.txt_rate.Value = (int)obj5;
                Byte[] ob = (Byte[])obj6;
                MemoryStream ma = new MemoryStream(ob);
                Fbooks.cover.Image = Image.FromStream(ma);
                bunifuTransition1.ShowSync(Fbooks);


            }
            else if (state == "ST")
            {
                PL.FRM_ADDSTUDINT Fst = new FRM_ADDSTUDINT();
                Fst.btnadd.ButtonText = "تعديل";

                Fst.ID = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value);
                DataTable dt = new DataTable();
                dt = BLST.LOADEDIT(Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value));
                object obj1 = dt.Rows[0]["NAME"];
                object obj2 = dt.Rows[0]["TLOCATION"];
                object obj3 = dt.Rows[0]["PHONE"];
                object obj4 = dt.Rows[0]["EMAIL"];
                object obj5 = dt.Rows[0]["SCHOOL"];
                object obj6 = dt.Rows[0]["DEP"];
                object obj7 = dt.Rows[0]["COVER"];
                Fst.txt_name.Text = obj1.ToString();
                Fst.txt_location.Text = obj2.ToString();
                Fst.txt_phone.Text = obj3.ToString();
                Fst.txt_email.Text = obj4.ToString();
                Fst.txt_school.Text = obj5.ToString();
                Fst.txt_dep.Text = obj6.ToString();
                Byte[] ob = (Byte[])obj7;
                MemoryStream ma = new MemoryStream(ob);
                Fst.cover.Image = Image.FromStream(ma);
                bunifuTransition1.ShowSync(Fst);


            }
            else if (state == "SELL")
            {
                PL.FRM_MAKESELL Fsell = new FRM_MAKESELL();
                Fsell.btnadd.ButtonText = "تعديل";

                Fsell.ID = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value);
                DataTable dt = new DataTable();


                bunifuTransition1.ShowSync(Fsell);


            }
            else if (state == "BRO")
            {
                PL.FRM_BRO Fbro = new FRM_BRO();
                Fbro.btnadd.ButtonText = "تعديل";

                Fbro.ID = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value);
                DataTable dt = new DataTable();


                bunifuTransition1.ShowSync(Fbro);


            }
            else if (state == "USER")
            {
                PL.FRM_ADDUSER Fuser = new FRM_ADDUSER();
                Fuser.btnadd.ButtonText = "تعديل";

                Fuser.ID = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value);
                DataTable dt = new DataTable();




                bunifuTransition1.ShowSync(Fuser);


            }
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            //DELETECAT
            if (state == "CAT")
            {
                BLCAT.delete(Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value));
                PL.FRM_DDELETE fdelete = new FRM_DDELETE();
                fdelete.Show();

            }
            else if (state == "BOOKS")
            {

                BLBOOKS.delete(Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value));
                PL.FRM_DDELETE fdelete = new FRM_DDELETE();
                fdelete.Show();

            }
            else if (state == "ST")
            {

                BLST.delete(Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value));
                PL.FRM_DDELETE fdelete = new FRM_DDELETE();
                fdelete.Show();

            }
            else if (state == "SELL")
            {

                BLSELL.delete(Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value));
                PL.FRM_DDELETE fdelete = new FRM_DDELETE();
                fdelete.Show();

            }
            else if (state == "BRO")
            {

                BLBRO.delete(Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value));
                PL.FRM_DDELETE fdelete = new FRM_DDELETE();
                fdelete.Show();

            }
            else if (state == "USER")
            {

                BLUSER.delete(Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value));
                PL.FRM_DDELETE fdelete = new FRM_DDELETE();
                fdelete.Show();

            }
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            if (state == "BOOKS")
            {

                DataTable dt = new DataTable();
                dt = BLBOOKS.LOADEDIT(Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value));
                object obj1 = dt.Rows[0]["TITLE"];
                object obj2 = dt.Rows[0]["AUTHER"];
                object obj3 = dt.Rows[0]["CAT"];
                object obj4 = dt.Rows[0]["PRICE"];
                object obj5 = dt.Rows[0]["RATE"];
                object obj6 = dt.Rows[0]["COVER"];
                PL.FRM_DETBOOKS detbooks = new FRM_DETBOOKS();
                detbooks.txt_title.Text = obj1.ToString();
                detbooks.txt_auther.Text = obj2.ToString();
                detbooks.txt_cat.Text = obj3.ToString();
                detbooks.txt_price.Text = obj4.ToString();
                detbooks.txt_rate.Value = (int)obj5;
                Byte[] ob = (Byte[])obj6;
                MemoryStream ma = new MemoryStream(ob);
                detbooks.cover.Image = Image.FromStream(ma);
                bunifuTransition1.ShowSync(detbooks);


            }
            else if (state == "ST")
            {
                PL.FRM_DETST Fst = new FRM_DETST();



                DataTable dt = new DataTable();
                dt = BLST.LOADEDIT(Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value));
                object obj1 = dt.Rows[0]["NAME"];
                object obj2 = dt.Rows[0]["TLOCATION"];
                object obj3 = dt.Rows[0]["PHONE"];
                object obj4 = dt.Rows[0]["EMAIL"];
                object obj5 = dt.Rows[0]["SCHOOL"];
                object obj6 = dt.Rows[0]["DEP"];
                object obj7 = dt.Rows[0]["COVER"];
                Fst.txt_name.Text = obj1.ToString();
                Fst.txt_location.Text = obj2.ToString();
                Fst.txt_phone.Text = obj3.ToString();
                Fst.txt_email.Text = obj4.ToString();
                Fst.txt_school.Text = obj5.ToString();
                Fst.txt_dep.Text = obj6.ToString();
                Byte[] ob = (Byte[])obj7;
                MemoryStream ma = new MemoryStream(ob);
                Fst.cover.Image = Image.FromStream(ma);
                bunifuTransition1.ShowSync(Fst);


            }
        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {
            if (state == "CAT")
            {
                DataTable dt = new DataTable();
                dt = BLCAT.SERACH(bunifuMaterialTextbox1.Text);

                dataGridView1.DataSource = dt;

            }

            if (state == "BOOKS")
            {
                DataTable dt = new DataTable();
                dt = BLBOOKS.SERACH(bunifuMaterialTextbox1.Text);

                dataGridView1.DataSource = dt;

            }
            if (state == "ST")
            {
                DataTable dt = new DataTable();
                dt = BLST.SERACH(bunifuMaterialTextbox1.Text);

                dataGridView1.DataSource = dt;

            }
            if (state == "SELL")
            {
                DataTable dt = new DataTable();
                dt = BLSELL.SERACH(bunifuMaterialTextbox1.Text);

                dataGridView1.DataSource = dt;

            }
            if (state == "BRO")
            {
                DataTable dt = new DataTable();
                dt = BLBRO.SERACH(bunifuMaterialTextbox1.Text);

                dataGridView1.DataSource = dt;

            }
        }

        private void FRM_MAIN_Load(object sender, EventArgs e)
        {
            P_HOME.Visible = true;
            P_MAIN.Visible = false;
            Lb_Title.Text = "الرئيسية";
        }

        private void FRM_MAIN_Activated(object sender, EventArgs e)
        {
            if (state == "CAT")
            {
                PL.FRM_ADDCAT FCAT = new FRM_ADDCAT();
                FCAT.btnadd.ButtonText = "اضافة";

                FCAT.ID = 0;
                bunifuTransition1.ShowSync(FCAT);

            }






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








            if (lb_prem.Text == "مدير")
            {
                bunifuThinButton22.Enabled = true;
                button6.Enabled = true;
            }
            else
            {
                bunifuThinButton22.Enabled = false;
                button6.Enabled = false;

            }
            if (state == "CAT")
            {
                //Load Data Cat
                try
                {
                    DataTable dt = new DataTable();
                    dt = BLCAT.Load();
                    dataGridView1.DataSource = dt;
                    dataGridView1.Columns[0].HeaderText = "التسلسل";
                    dataGridView1.Columns[1].HeaderText = "اسم الصنف";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (state == "BOOKS")
            {
                P_HOME.Visible = false;
                P_MAIN.Visible = true;
                bunifuThinButton24.Visible = true;
                state = "BOOKS";
                Lb_Title.Text = "الكتب";
                //Load Data

                DataTable dt = new DataTable();
                dt = BLBOOKS.Load();
                dataGridView1.DataSource = dt;
                dataGridView1.Columns[0].HeaderText = "التسلسل";
                dataGridView1.Columns[1].HeaderText = "اسم الكتاب";
                dataGridView1.Columns[2].HeaderText = "المؤلف";
                dataGridView1.Columns[3].HeaderText = "التصنيف";
                dataGridView1.Columns[4].HeaderText = "السعر";



            }
            else if (state == "ST")
            {
                P_MAIN.Visible = true;
                P_HOME.Visible = false;
                state = "ST";
                Lb_Title.Text = "الطلاب";


                try
                {
                    DataTable dt = new DataTable();
                    dt = BLST.Load();
                    dataGridView1.DataSource = dt;
                    dataGridView1.Columns[0].HeaderText = "التسلسل";
                    dataGridView1.Columns[1].HeaderText = "اسم الطالب";
                    dataGridView1.Columns[2].HeaderText = "السكن";
                    dataGridView1.Columns[3].HeaderText = "رقم الهاتف";
                    dataGridView1.Columns[4].HeaderText = "ايميل";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }
            else if (state == "SELL")
            {
                P_MAIN.Visible = true;
                P_HOME.Visible = false;
                state = "SELL";
                Lb_Title.Text = "البيع";


                try
                {
                    DataTable dt = new DataTable();
                    dt = BLSELL.Load();
                    dataGridView1.DataSource = dt;
                    dataGridView1.Columns[0].HeaderText = "التسلسل";
                    dataGridView1.Columns[1].HeaderText = "اسم الكتاب";
                    dataGridView1.Columns[2].HeaderText = "المشتري";

                    dataGridView1.Columns[3].HeaderText = "السعر";

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }
            else if (state == "BRO")
            {

                P_MAIN.Visible = true;
                P_HOME.Visible = false;
                state = "BRO";
                Lb_Title.Text = "الاستعارة";
                DataTable dt = new DataTable();

                try
                {
                    dt = BLBRO.Load();
                    dataGridView1.DataSource = dt;
                    dataGridView1.Columns[0].HeaderText = "التسلسل";
                    dataGridView1.Columns[1].HeaderText = "اسم المشتري";
                    dataGridView1.Columns[2].HeaderText = "اسم الكتاب";
                    dataGridView1.Columns[3].HeaderText = "بداية الاستعارة";
                    dataGridView1.Columns[4].HeaderText = "تهاية الاستعارة";
                    dataGridView1.Columns[5].HeaderText = "السعر";



                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }
            else if (state == "USER")
            {


                P_MAIN.Visible = true;
                P_HOME.Visible = false;
                state = "USER";
                Lb_Title.Text = "المستخدمين";
                DataTable dt = new DataTable();

                try
                {
                    dt = BLUSER.Load();
                    dataGridView1.DataSource = dt;
                    dataGridView1.Columns[0].HeaderText = "التسلسل";
                    dataGridView1.Columns[1].HeaderText = "اسم المستخدم";
                    dataGridView1.Columns[2].HeaderText = "كلمة السر";
                    dataGridView1.Columns[3].HeaderText = "الصلاحية";



                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }

            }
        }
    }
}
