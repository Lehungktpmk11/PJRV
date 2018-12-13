using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;
using DAO_QuanLy;
using DTO_QuanLy;


namespace BUS_QuanLy
{
    public class BUS_Khoanh
    {
        DAO_ThanhVien daotv = new DAO_ThanhVien();

        public bool InsertDB(DTO_Khoanh ka)
        {
            string sql = string.Format("insert into DBimage(IM,ID,Path) values('{0}','{1}','{2}')",ka.IM,ka.ID,ka.Anh);

            if (daotv.NonQuery(sql))
                return true;

            return false;
        }
        public bool XoaAnh(string maxoa)
        {

            string sql = "delete from DBimage where ID='"+maxoa+"' ";
            if (daotv.NonQuery(sql))
                return true;


            return false;
        }
        public DataTable ViewAnh(string maid)
        {
            DataTable dt = new DataTable();
           
            string sql = "select * from DBimage where ID='"+maid+"'";

            dt = daotv.Query(sql);


            return dt;

        }
        public string TaoMa()
        {

            string sql = "select * from DBimage";

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
                ma = "IM00" + coso;
            else if (coso < 100)
                ma = "IM0" + coso;
            else
                ma = "IM" + coso;

            return ma;
        }
    }
}
