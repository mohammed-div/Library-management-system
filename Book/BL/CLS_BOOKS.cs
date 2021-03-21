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
    class CLS_BOOKS
    {
        DAL.CLS_DAL DAL = new Book.DAL.CLS_DAL();
        public DataTable Load()
        {
            SqlParameter[] Pr = null;
            DataTable dt = new DataTable();
            dt = DAL.read("PR_LOADBOOKS", Pr);
            return (dt);
        }
        public DataTable LOADCAT()
        {
            SqlParameter[] Pr = null;

            DataTable dt = new DataTable();
            dt = DAL.read("PR_LOADCATCOMBOBOX", Pr);
            return (dt);
        }
        public void Insert(string TITLE, string AUTHER, string CAT, string PRICE, int RATE, MemoryStream COVER)
        {
            SqlParameter[] Pr = new SqlParameter[6];
            Pr[0] = new SqlParameter("TITLE", TITLE);
            Pr[1] = new SqlParameter("AUTHER", AUTHER);
            Pr[2] = new SqlParameter("CAT", CAT);
            Pr[3] = new SqlParameter("PRICE", PRICE);
            Pr[4] = new SqlParameter("RATE", RATE);
            Pr[5] = new SqlParameter("COVER", COVER.ToArray());
            DAL.open();
            DAL.Excute("PR_INSERTBOOKS", Pr);
            DAL.close();

        }
        public DataTable LOADEDIT(int ID)
        {
            SqlParameter[] Pr = new SqlParameter[1];
            Pr[0] = new SqlParameter("ID", ID);
            DataTable dt = new DataTable();
            dt = DAL.read("PR_SELECTEDIT", Pr);
            return (dt);
        }
        public void Update(string TITLE, string AUTHER, string CAT, string PRICE, int RATE, MemoryStream COVER, int ID)
        {
            SqlParameter[] Pr = new SqlParameter[7];
            Pr[0] = new SqlParameter("TITLE", TITLE);
            Pr[1] = new SqlParameter("AUTHER", AUTHER);
            Pr[2] = new SqlParameter("CAT", CAT);
            Pr[3] = new SqlParameter("PRICE", PRICE);
            Pr[4] = new SqlParameter("RATE", RATE);
            Pr[5] = new SqlParameter("COVER", COVER.ToArray());
            Pr[6] = new SqlParameter("ID", ID);
            DAL.open();
            DAL.Excute("PR_EDITBOOKS", Pr);
            DAL.close();

        }
        public void delete(int ID)
        {
            SqlParameter[] Pr = new SqlParameter[1];

            Pr[0] = new SqlParameter("ID", ID);
            DAL.open();
            DAL.Excute("P_DELETEBOOKS", Pr);
            DAL.close();

        }
        public DataTable SERACH(string serach)
        {
            SqlParameter[] Pr = new SqlParameter[1];
            Pr[0] = new SqlParameter("SERACH", serach);
            DataTable dt = new DataTable();
            dt = DAL.read("P_BOOKSSERACH", Pr);
            return (dt);
        }
    }
}
