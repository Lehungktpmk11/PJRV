using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAO_QuanLy;
using DTO_QuanLy;

namespace BUS_QuanLy
{
    public class BUS_Taikhoan
    {
        DAO_ThanhVien daotv = new DAO_ThanhVien();
        //lay toan bo
        public DataTable GetAll()
        {
            DataTable dt = new DataTable();

            string sql = "select * from TKDangnhap";
            dt = daotv.Query(sql);
            return dt;
        }
        //lay 1 phan
        public DataTable GetTk(DTO_Taikhoan tk)
        {
            DataTable dt = new DataTable();
            string gsome = "select * from TKDangnhap where [user]='"+tk.TK+"'and pass='"+tk.MK+"'";
            dt = daotv.Query(gsome);


            return dt;
        }
        //them
        public bool Them(DTO_Taikhoan tk)
        {
            string insert =string.Format("insert into TKDangnhap(ID,[user],pass,quyen) values('{0}','{1}','{2}','{3}')",tk.ID,tk.TK,tk.MK,tk.Quyen);
            if(daotv.NonQuery(insert))
            {
                return true;
            }

            return false;
        }
        public bool Xoa(string maxoa)
        {
            string delete = "delete from TKDangnhap where ID='"+maxoa+"'";
            if(daotv.NonQuery(delete))
            {
                return true;
            }

            return false;
        }
        //tim kiem
        public DataTable Timkiem(string matim) 
        {
            DataTable dt = new DataTable();
            string tim = string.Format("select * from TKDangnhap where ID like '%{0}%'",matim);

            dt = daotv.Query(tim);
            return dt;
        }

        //sua
        public bool Sua(DTO_Taikhoan tk)
        {
            string ud = "update TKDangnhap set [user]='"+tk.TK+"',pass='"+tk.MK+"',quyen='"+tk.Quyen+"' where ID='"+tk.ID+"'";
            if(daotv.NonQuery(ud))
            {
                return true;
            }

            return false;
        }

        // de sinh ma tu dong khong can nhap
        public string TaoMa()
        {

            string sql = "select * from TKDangnhap";

            DataTable dt = new DataTable();
            dt = daotv.Query(sql);

            int coso = 0;
            if (dt.Rows.Count == 0)
            {
                coso = 1;
            }
            else
            {
                if (dt.Rows.Count == 1 && int.Parse(dt.Rows[0][0].ToString().Substring(2, 3)) == 1)
                {
                    coso = 2;
                }
                else
                {
                    if (dt.Rows.Count == 1 && int.Parse(dt.Rows[0][0].ToString().Substring(2, 3)) != 1)
                    {
                        coso = 1;
                    }
                    else
                    {
                        if (int.Parse(dt.Rows[0][0].ToString().Substring(2, 3)) > 1)
                        {
                            coso = 1;

                        }
                        else
                        {
                            int flag = 0;
                            for (int i = 0; i < dt.Rows.Count - 1; i++)
                            {

                                if (int.Parse(dt.Rows[i + 1][0].ToString().Substring(2, 3)) - int.Parse(dt.Rows[i][0].ToString().Substring(2, 3)) > 1)
                                {
                                    coso = int.Parse(dt.Rows[i][0].ToString().Substring(2, 3)) + 1;
                                    flag = 1;
                                    break;
                                }
                            }
                            if (flag == 0)
                            {
                                coso = int.Parse(dt.Rows[dt.Rows.Count - 1][0].ToString().Substring(2, 3)) + 1;
                            }
                        }
                    }
                }
            }
            string ma = "";
            if (coso < 10)
                ma = "ID00" + coso;
            else if (coso < 100)
                ma = "ID0" + coso;
            else
                ma = "ID" + coso;

            return ma;
        }

    }
}
