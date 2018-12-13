using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO_QuanLy;
using BUS_QuanLy;

namespace ABRV
{
    public partial class FDangnhap : Form
    {
        public FDangnhap()
        {
            InitializeComponent();
        }
        BUS_Taikhoan dn = new BUS_Taikhoan();
        public static string matk;
        private void btndangnhap_Click(object sender, EventArgs e)
        {
            if(txttk.Text!=""&&txtmk.Text!="")
            {
                DTO_Taikhoan tk = new DTO_Taikhoan(txttk.Text, txtmk.Text);
                DataTable dt = new DataTable();
                dt = dn.GetTk(tk);
                if(dt.Rows.Count>0)
                {
                    Boolean qq = Convert.ToBoolean(dt.Rows[0][3].ToString());
                    if(qq)
                    {
                        Fquantrivien fqtv = new Fquantrivien();
                        this.Hide();
                        fqtv.ShowDialog();
                        this.Show();
                        matk = dt.Rows[0][0].ToString();

                    }
                    else
                    {
                        matk = dt.Rows[0][0].ToString();
                        Fabrv fab = new Fabrv();
                        this.Hide();
                        fab.ShowDialog();
                        this.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu.");
                }



            }
            else
            {
                MessageBox.Show("Hãy nhập đủ thông tin.");
            }
        }

        private void btndangky_Click(object sender, EventArgs e)
        {
            Fdangky fdk = new Fdangky();
            this.Hide();
            fdk.ShowDialog();
            this.Show();
           
        }
    }
}
