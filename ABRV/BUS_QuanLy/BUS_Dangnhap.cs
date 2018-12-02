using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_QuanLy;
using DAO_QuanLy;
using System.Data;
namespace BUS_QuanLy
{

    public class BUS_Dangnhap
    {
        DAO_ThanhVien daotv = new DAO_ThanhVien();

        public DataTable GetTk(DTO_Taikhoan tk)
        {
            DataTable dt = new DataTable();
            string sql = "select * from TKDangnhap where [user]='"+tk.User+"' and pass='"+tk.Pass+"'";

            dt = daotv.GetTable(sql);

           


            return dt;
        }
        public DataTable GetAllTk()
        {
            DataTable dt = new DataTable();
            string sql = "select * from TKDangnhap";

            dt = daotv.GetTable(sql);




            return dt;
        }

    }
}
