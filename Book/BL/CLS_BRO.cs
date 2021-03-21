using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace Book.BL
{
    class CLS_BRO
    {
        DAL.CLS_DAL DAL = new Book.DAL.CLS_DAL();
        public DataTable Load()
        {
            SqlParameter[] Pr = null;
            DataTable dt = new DataTable();
            dt = DAL.read("PR_LOADBRO", Pr);
            return (dt);
        }
        public DataTable LoadBOOKS()
        {
            SqlParameter[] Pr = null;
            DataTable dt = new DataTable();
            dt = DAL.read("PR_LOADBOOKSFORSELL", Pr);
            return (dt);
        }
        public DataTable LoadST()
        {
            SqlParameter[] Pr = null;
            DataTable dt = new DataTable();
            dt = DAL.read("PR_LOADSTFORSELL", Pr);
            return (dt);
        }
        public void Insert(string BNAME, string BTITE, string BDATE1, string BDATE2, int PRICE)
        {
            SqlParameter[] Pr = new SqlParameter[5];
            Pr[0] = new SqlParameter("BNAME", BNAME);
            Pr[1] = new SqlParameter("BTITE", BTITE);
            Pr[2] = new SqlParameter("BDATE1", BDATE1);
            Pr[3] = new SqlParameter("BDATE2", BDATE2);
            Pr[4] = new SqlParameter("PRICE", PRICE);
            DAL.open();
            DAL.Excute("PR_INSERTBRO", Pr);
            DAL.close();

        }
        public void update(string BNAME, string BTITE, string BDATE1, string BDATE2, int PRICE, int ID)
        {
            SqlParameter[] Pr = new SqlParameter[6];
            Pr[0] = new SqlParameter("BNAME", BNAME);
            Pr[1] = new SqlParameter("BTITE", BTITE);
            Pr[2] = new SqlParameter("BDATE1", BDATE1);
            Pr[3] = new SqlParameter("BDATE2", BDATE2);
            Pr[4] = new SqlParameter("PRICE", PRICE);
            Pr[5] = new SqlParameter("ID", ID);
            DAL.open();
            DAL.Excute("PR_EDITBRO", Pr);
            DAL.close();

        }
        public void delete(int ID)
        {
            SqlParameter[] Pr = new SqlParameter[1];

            Pr[0] = new SqlParameter("ID", ID);
            DAL.open();
            DAL.Excute("P_DELETEBRO", Pr);
            DAL.close();

        }
        public DataTable SERACH(string serach)
        {
            SqlParameter[] Pr = new SqlParameter[1];
            Pr[0] = new SqlParameter("SERACH", serach);
            DataTable dt = new DataTable();
            dt = DAL.read("P_SERACHBRO", Pr);
            return (dt);
        }
    }
}
