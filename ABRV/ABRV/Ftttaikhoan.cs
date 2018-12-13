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
    public partial class Ftttaikhoan : Form
    {
        public Ftttaikhoan()
        {
            InitializeComponent();
        }
        BUS_KhachHang buskh = new BUS_KhachHang();
        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void loadtttaikhoan()
        {
            DataTable dt = new DataTable();
            dt = buskh.GetOne(FDangnhap.matk);
           if(dt.Rows.Count!=0)
            {
                txthoten.Text = dt.Rows[0][1].ToString();
                txtsdt.Text = dt.Rows[0][2].ToString();
                txtemail.Text = dt.Rows[0][3].ToString();
                txtdc.Text = dt.Rows[0][4].ToString();
            }




        }

        private void Ftttaikhoan_Load(object sender, EventArgs e)
        {
            txtid.Enabled = false;
            txtid.Text = FDangnhap.matk;
            loadtttaikhoan();   
        }

        private void btnluulai_Click(object sender, EventArgs e)
        {
            DataTable dtid = new DataTable();
            dtid = buskh.GetAllID(FDangnhap.matk);
            int dem = dtid.Rows.Count;
           if(dem==0)
            {
                if(txthoten.Text==""||txtsdt.Text=="")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ họ tên và số điện thoại.","Thông báo");
                }
                else
                {
                    DTO_KhachHang dtokh = new DTO_KhachHang(txtid.Text,txthoten.Text,txtsdt.Text,txtemail.Text,txtdc.Text);


                    if(buskh.Them(dtokh))
                    {
                        MessageBox.Show("Thêm thông tin thành công","Thông báo");
                    }
                    else
                    {
                        MessageBox.Show("Không thành công", "Thông báo");
                    }
                }
            }
           else
             {
                if (txthoten.Text == "" || txtsdt.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ họ tên và số điện thoại.", "Thông báo");
                }
                else
                {
                    DTO_KhachHang dtokh = new DTO_KhachHang(txtid.Text, txthoten.Text, txtsdt.Text, txtemail.Text, txtdc.Text);


                    if (buskh.Sua(dtokh))
                    {
                        MessageBox.Show("Sửa thông tin thành công", "Thông báo");
                    }
                    else
                    {
                        MessageBox.Show("Không thành công", "Thông báo");
                    }
                }
            }
        }
    }
}
