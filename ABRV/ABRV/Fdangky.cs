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
    public partial class Fdangky : Form
    {
        public Fdangky()
        {
            InitializeComponent();
        }
        BUS_QLDK busqldk = new BUS_QLDK();
      

        private void btndangky_Click(object sender, EventArgs e)
        {
            if(txtxnmk.Text==""||txtdktk.Text==""||txtdkmk.Text=="")
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!");
            }
            else
            {
              if(Kiemtra())
                {
                    MessageBox.Show("Xác nhận mật khẩu không trùng khớp", "Thông báo");
                }
                else
                {
                    DTO_Dangkytaikhoan dktk = new DTO_Dangkytaikhoan(busqldk.TaoMa(), txtdktk.Text, txtxnmk.Text);
                   if(busqldk.Them(dktk))
                    {
                        MessageBox.Show("Đăng ký thành công. Vui lòng chờ xác nhận từ người quản trị","Thông báo");
                    }
                    else
                    {
                        MessageBox.Show("Đăng ký thất bại");
                    }
                }

            }
        }
        private bool Kiemtra()
        {
            if(txtdkmk.Text!=txtxnmk.Text)
            {
                return true;
            }


            return false;
        }
        private void btnhuybo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
