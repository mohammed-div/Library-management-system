using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace Book.DAL
{
    class CLS_DAL
    {
        SqlConnection con = new SqlConnection();
        public CLS_DAL()
        {
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dell\source\repos\Book\Book\DB.mdf;Integrated Security=True");
        }
        public void open()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }
        public void close()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }



        }

        public DataTable read(string store, SqlParameter[] Pr)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = store;
            if (Pr != null)
            {
                cmd.Parameters.AddRange(Pr);
            }
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public void Excute(string store, SqlParameter[] Pr)
        {

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = store;
            if (Pr != null)
            {
                cmd.Parameters.AddRange(Pr);
            }
            cmd.ExecuteNonQuery();


        }
    }
}
