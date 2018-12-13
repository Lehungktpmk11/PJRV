using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAO_QuanLy;
namespace BUS_QuanLy
{
    public class BUS_Khuvuc
    {

        DAO_ThanhVien daotv = new DAO_ThanhVien();

        //lay huyen
        public DataTable GetDistrict(string matim)
        {
            DataTable dt = new DataTable();

            string sql = "select * from District where [Mã Tỉnh/Tp]='"+matim+"'";
            dt = daotv.Query(sql);
            return dt;
        }
        // lay tinh
        public DataTable GetProvince()
        {
            DataTable dt = new DataTable();

            string sql = "select * from Province";
            dt = daotv.Query(sql);
            return dt;
        }
        //lay xa
        public DataTable GetWard(string matim)
        {
            DataTable dt = new DataTable();

            string sql = "select * from Ward where [Mã Huyện]='"+matim+"'";
            dt = daotv.Query(sql);
            return dt;
        }


    }
}
