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
    class CLS_ST
    {
        DAL.CLS_DAL DAL = new Book.DAL.CLS_DAL();
        public DataTable Load()
        {
            SqlParameter[] Pr = null;
            DataTable dt = new DataTable();
            dt = DAL.read("PR_LOADST", Pr);
            return (dt);
        }
        public void Insert(string NAME, string TLOCATION, string PHONE, string EMAIL, string SCHOOL, string DEP, MemoryStream COVER)
        {
            SqlParameter[] Pr = new SqlParameter[7];
            Pr[0] = new SqlParameter("NAME", NAME);
            Pr[1] = new SqlParameter("TLOCATION", TLOCATION);
            Pr[2] = new SqlParameter("PHONE", PHONE);
            Pr[3] = new SqlParameter("EMAIL", EMAIL);
            Pr[4] = new SqlParameter("SCHOOL", SCHOOL);
            Pr[5] = new SqlParameter("DEP", DEP);
            Pr[6] = new SqlParameter("COVER", COVER.ToArray());
            DAL.open();
            DAL.Excute("PR_INSERTST", Pr);
            DAL.close();

        }
        public DataTable LOADEDIT(int ID)
        {
            SqlParameter[] Pr = new SqlParameter[1];
            Pr[0] = new SqlParameter("ID", ID);
            DataTable dt = new DataTable();
            dt = DAL.read("PR_SELECTEDITST", Pr);
            return (dt);
        }
        public void Update(string NAME, string TLOCATION, string PHONE, string EMAIL, string SCHOOL, string DEP, MemoryStream COVER, int ID)
        {
            SqlParameter[] Pr = new SqlParameter[8];
            Pr[0] = new SqlParameter("NAME", NAME);
            Pr[1] = new SqlParameter("TLOCATION", TLOCATION);
            Pr[2] = new SqlParameter("PHONE", PHONE);
            Pr[3] = new SqlParameter("EMAIL", EMAIL);
            Pr[4] = new SqlParameter("SCHOOL", SCHOOL);
            Pr[5] = new SqlParameter("DEP", DEP);
            Pr[6] = new SqlParameter("COVER", COVER.ToArray());
            Pr[7] = new SqlParameter("ID", ID);
            DAL.open();
            DAL.Excute("PR_EDITST", Pr);
            DAL.close();

        }
        public void delete(int ID)
        {
            SqlParameter[] Pr = new SqlParameter[1];

            Pr[0] = new SqlParameter("ID", ID);
            DAL.open();
            DAL.Excute("P_DELETEST", Pr);
            DAL.close();

        }
        public DataTable SERACH(string serach)
        {
            SqlParameter[] Pr = new SqlParameter[1];
            Pr[0] = new SqlParameter("SERACH", serach);
            DataTable dt = new DataTable();
            dt = DAL.read("P_STSERACH", Pr);
            return (dt);
        }
    }
}
