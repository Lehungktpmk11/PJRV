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
    public class BUS_QLDK
    {

        DAO_ThanhVien daotv = new DAO_ThanhVien();
        public DataTable GetAll()
        {
            DataTable dt = new DataTable();
            string sql = "select * from QLDK";
            dt = daotv.Query(sql);
            return dt;
        }
        public bool Them(DTO_Dangkytaikhoan dktk)
        {
            string insert = string.Format("insert into QLDK(DK,TK,MK) values('{0}','{1}','{2}')",dktk.DK,dktk.TK,dktk.Mk);
            if (daotv.NonQuery(insert))
            {
                return true;
            }

            return false;
        }
        public bool Xoa(string maxoa)
        {
            string delete = "delete from QLDK where DK='" + maxoa + "'";
            if (daotv.NonQuery(delete))
            {
                return true;
            }

            return false;
        }
        //tim kiem
        public DataTable Timkiem(string matim)
        {
            DataTable dt = new DataTable();
            string tim = string.Format("select * from QLDK where DK like '%{0}%'", matim);

            dt = daotv.Query(tim);
            return dt;
        }
        // de sinh ma tu dong khong can nhap
        public string TaoMa()
        {

            string sql = "select * from QLDK";

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
                ma = "DK00" + coso;
            else if (coso < 100)
                ma = "DK0" + coso;
            else
                ma = "DK" + coso;

            return ma;
        }
    }
}
