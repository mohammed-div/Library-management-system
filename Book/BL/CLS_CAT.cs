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
    class CLS_CAT
    {

        DAL.CLS_DAL DAL = new Book.DAL.CLS_DAL();
        public DataTable Load()
        {
            SqlParameter[] Pr = null;
            DataTable dt = new DataTable();
            dt = DAL.read("PR_LOADCAT", Pr);
            return (dt);
        }
        public DataTable SERACH(string serach)
        {
            SqlParameter[] Pr = new SqlParameter[1];
            Pr[0] = new SqlParameter("SERACH", serach);
            DataTable dt = new DataTable();
            dt = DAL.read("P_CATSERACH", Pr);
            return (dt);
        }
        public void Insert(string CAT_NAME)
        {
            SqlParameter[] Pr = new SqlParameter[1];
            Pr[0] = new SqlParameter("CAT_NAME", CAT_NAME);
            DAL.open();
            DAL.Excute("P_ADDCAT", Pr);
            DAL.close();

        }
        public void Update(string CAT_NAME, int ID)
        {
            SqlParameter[] Pr = new SqlParameter[2];
            Pr[0] = new SqlParameter("CAT_NAME", CAT_NAME);
            Pr[1] = new SqlParameter("ID", ID);
            DAL.open();
            DAL.Excute("P_EDITCAT", Pr);
            DAL.close();

        }

        public void delete(int ID)
        {
            SqlParameter[] Pr = new SqlParameter[1];

            Pr[0] = new SqlParameter("ID", ID);
            DAL.open();
            DAL.Excute("P_DELETECAT", Pr);
            DAL.close();

        }
    }
}
