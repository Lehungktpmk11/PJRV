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
    public class BUS_KhachHang
    {
        DAO_ThanhVien daotv = new DAO_ThanhVien();

        public DataTable GetAll()
        {
            DataTable dt = new DataTable();

            string sql = "select * from KhachHang";
            dt = daotv.Query(sql);
            return dt;
        }
        public DataTable GetAllID(string ma)
        {
            DataTable dt = new DataTable();
            string sql = "select ID from KhachHang where ID='"+ma+"'";

            dt = daotv.Query(sql);

            return dt;
        }
        public DataTable GetOne(string ma)
        {
            DataTable dt = new DataTable();
            string sql = "select * from KhachHang where ID='" + ma + "'";
            dt = daotv.Query(sql);
            return dt;
        }



        public bool Them(DTO_KhachHang kh)
        {
            string ins = string.Format("insert into KhachHang(ID,Hoten,Sdt,Email,Diachi) values('{0}',N'{1}','{2}','{3}',N'{4}')",kh.ID,kh.HT,kh.SDT,kh.EMAIL,kh.DC);

            if(daotv.NonQuery(ins))
            {
                return true;
            }
            return false;
        }
        public bool Sua(DTO_KhachHang kh)
        {
            string ud = string.Format("update KhachHang set Hoten=N'{1}',Sdt='{2}',Email='{3}',Diachi=N'{4}' where ID='{0}'", kh.ID, kh.HT, kh.SDT, kh.EMAIL, kh.DC);

            if (daotv.NonQuery(ud))
            {
                return true;
            }
            return false;
        }
        public bool Xoa(string ma)
        {
            string maxoa = "delete from KhachHang where ID='"+ma+"'";
            if (daotv.NonQuery(maxoa))
            {
                return true;
            }
            return false;
        }
    }
}
