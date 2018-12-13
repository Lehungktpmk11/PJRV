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
    public class BUS_Dangtin
    {
        DAO_ThanhVien daotv = new DAO_ThanhVien();
        
        //lay theo id tk
        public DataTable GetTinByID(string id)
        {
            DataTable dt = new DataTable();
            string sql = "select * from Dangtin where ID='" + id + "'";
            dt = daotv.Query(sql);


            return dt;
        }
        //lay toan bo
        public DataTable GetAll()
        {
            DataTable dt = new DataTable();

            string sql = "select * from Dangtin";
            dt = daotv.Query(sql);
            return dt;
        }
        public bool Xoa(string maxoa)
        {
            string delete = "delete from Dangtin where DT='" + maxoa + "'";
            if (daotv.NonQuery(delete))
            {
                return true;
            }

            return false;
        }
        public DataTable Getloai()
        {

            DataTable dt = new DataTable();

            string sql = "select * from LOAI";
            dt = daotv.Query(sql);
            return dt;

        }
        public bool Them(DTO_Dangtin dtin)
        {
            string insert = string.Format("INSERT INTO Dangtin([DT], [ID], [Loai], [Mota], [Gia], [Motachitiet], [Dientich], [Loaicanho], [Sotang], [Sophongngu], [Vs], [Diachi]) VALUES('{0}','{1}','{2}',N'{3}','{4}',N'{5}','{6}',N'{7}','{8}','{9}','{10}',N'{11}')", dtin.DT, dtin.ID, dtin.Loai, dtin.Mota, dtin.Gia, dtin.MTCT, dtin.Dientich, dtin.Lch, dtin.Tang, dtin.Phongngu, dtin.VS, dtin.DC);
            if (daotv.NonQuery(insert))
            {
                return true;
            }

            return false;
        }
        //sua
        public bool Sua(DTO_Dangtin dt)
        {
            string ud = "update Dangtin set ID='" + dt.ID + "',Loai='" + dt.Loai + "',Mota=N'" + dt.Mota + "',Gia='" + dt.Gia + "',Motachitiet=N'" + dt.MTCT + "',Dientich='" + dt.Dientich + "',Loaicanho=N'"+dt.Lch+"',Sotang='" + dt.Tang + "',Sophongngu='" + dt.Phongngu + "',Vs='" + dt.VS + "',Diachi='" + dt.DC + "' where DT='" + dt.DT + "'";
            if (daotv.NonQuery(ud))
            {
                return true;
            }

            return false;
        }
        public DataTable Timkiem(string matim)
        {
            DataTable dt = new DataTable();
            string tim = string.Format("select * from Dangtin where DT like '%{0}%'", matim);

            dt = daotv.Query(tim);
            return dt;
        }

        public string TaoMa()
        {

            string sql = "select * from Dangtin";

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
                ma = "DT00" + coso;
            else if (coso < 100)
                ma = "DT0" + coso;
            else
                ma = "DT" + coso;

            return ma;
        }


    }
}
