using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace Book.BL
{
    class CLS_SELL
    {
        DAL.CLS_DAL DAL = new Book.DAL.CLS_DAL();
        public DataTable Load()
        {
            SqlParameter[] Pr = null;
            DataTable dt = new DataTable();
            dt = DAL.read("PR_LOADSELL", Pr);
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
        public void Insert(string STUDENT, string BTITLE, int PRICE)
        {
            SqlParameter[] Pr = new SqlParameter[3];
            Pr[0] = new SqlParameter("STUDENT", STUDENT);
            Pr[1] = new SqlParameter("BTITLE", BTITLE);
            Pr[2] = new SqlParameter("PRICE", PRICE);
            DAL.open();
            DAL.Excute("PR_INSERTSELL", Pr);
            DAL.close();

        }
        public void Update(string STUDENT, string BTITLE, int PRICE, int ID)
        {
            SqlParameter[] Pr = new SqlParameter[4];
            Pr[0] = new SqlParameter("STUDENT", STUDENT);
            Pr[1] = new SqlParameter("BTITLE", BTITLE);
            Pr[2] = new SqlParameter("PRICE", PRICE);
            Pr[3] = new SqlParameter("ID", ID);
            DAL.open();
            DAL.Excute("PR_UPDATESELL", Pr);
            DAL.close();

        }
        public void delete(int ID)
        {
            SqlParameter[] Pr = new SqlParameter[1];

            Pr[0] = new SqlParameter("ID", ID);
            DAL.open();
            DAL.Excute("PR_SELLDELETE", Pr);
            DAL.close();

        }
        public DataTable SERACH(string serach)
        {
            SqlParameter[] Pr = new SqlParameter[1];
            Pr[0] = new SqlParameter("SERACH", serach);
            DataTable dt = new DataTable();
            dt = DAL.read("P_SERACHSELL", Pr);
            return (dt);
        }
    }
}
