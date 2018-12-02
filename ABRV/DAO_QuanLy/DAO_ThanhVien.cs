using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAO_QuanLy
{
    public class DAO_ThanhVien:DBconnect
    {
        public SqlConnection Getconnec()
        {
            return new SqlConnection(connec);
        }
        public DataTable GetTable(string sql)
        {
            DataTable dt = new DataTable();

            SqlConnection con = Getconnec();

            con.Open();

            SqlDataAdapter da = new SqlDataAdapter(sql, con);

            da.Fill(dt);
            con.Close();
            return dt;

        }


        public bool Nonquery(string sql)
        {
            SqlConnection con = Getconnec();
            con.Open();

            SqlCommand cmd = new SqlCommand(sql, con);

            if(cmd.ExecuteNonQuery()>0)
            {
                return true;
            }

            cmd.Dispose();
            con.Close();
            return false;

        }
    }
}
