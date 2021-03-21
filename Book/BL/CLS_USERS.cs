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
    class CLS_USERS
    {
        DAL.CLS_DAL DAL = new Book.DAL.CLS_DAL();
        public DataTable Load()
        {
            SqlParameter[] Pr = null;
            DataTable dt = new DataTable();
            dt = DAL.read("PR_LOADUS", Pr);
            return (dt);
        }
        public void Insert(string CNAME, string CPASSWORD, string CPREM, string CSTATE)
        {
            SqlParameter[] Pr = new SqlParameter[4];
            Pr[0] = new SqlParameter("CNAME", CNAME);
            Pr[1] = new SqlParameter("CPASSWORD", CPASSWORD);
            Pr[2] = new SqlParameter("CPREM", CPREM);
            Pr[3] = new SqlParameter("CSTATE", CSTATE);


            DAL.open();
            DAL.Excute("PR_INSERTUS", Pr);
            DAL.close();

        }
        public void update(string CNAME, string CPASSWORD, string CPREM, int ID)
        {
            SqlParameter[] Pr = new SqlParameter[4];
            Pr[0] = new SqlParameter("CNAME", CNAME);
            Pr[1] = new SqlParameter("CPASSWORD", CPASSWORD);
            Pr[2] = new SqlParameter("CPREM", CPREM);
            Pr[3] = new SqlParameter("ID", ID);
            DAL.open();
            DAL.Excute("PR_EDITUSER", Pr);
            DAL.close();

        }

        public void delete(int ID)
        {
            SqlParameter[] Pr = new SqlParameter[1];

            Pr[0] = new SqlParameter("ID", ID);
            DAL.open();
            DAL.Excute("PR_DELETEUSER", Pr);
            DAL.close();

        }
        public void LOGOUT()
        {
            SqlParameter[] Pr = null;

            DAL.open();
            DAL.Excute("PR_LOGOUT", Pr);
            DAL.close();

        }
        public DataTable Login(string CNAME, string CPASSWORD)
        {
            SqlParameter[] Pr = new SqlParameter[2];
            Pr[0] = new SqlParameter("CNAME", CNAME);
            Pr[1] = new SqlParameter("CPASSWORD", CPASSWORD);
            DataTable dt = new DataTable();
            dt = DAL.read("PR_LOGIN", Pr);
            return (dt);
        }
        public void updatelogin(string CNAME, string CPASSWORD)
        {
            SqlParameter[] Pr = new SqlParameter[2];
            Pr[0] = new SqlParameter("CNAME", CNAME);
            Pr[1] = new SqlParameter("CPASSWORD", CPASSWORD);

            DAL.open();
            DAL.Excute("PR_UPDATELOGIN", Pr);
            DAL.close();

        }
        public DataTable startload()
        {
            SqlParameter[] Pr = null;
            DataTable dt = new DataTable();
            dt = DAL.read("PR_START", Pr);
            return (dt);
        }
    }
}
