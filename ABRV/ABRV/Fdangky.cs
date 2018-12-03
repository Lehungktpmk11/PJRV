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
        BUS_QLDK qldk = new BUS_QLDK();
        private void btnhuybo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnxacnhan_Click(object sender, EventArgs e)
        {
            if(txttk.Text!=""&&txtmk.Text!="")
            {
                if(rdodongy.Checked==true)
                {
                    DTO_Dangkytaikhoan dk = new DTO_Dangkytaikhoan(qldk.TaoMa(),txttk.Text,txtmk.Text);
                    if(qldk.Them(dk))
                    {
                        MessageBox.Show("Thành công");
                    }
                    else
                    {
                        MessageBox.Show("Chưa thành công.");
                    }
                }
                else
                {
                    MessageBox.Show("Bạn chưa đồng ý với điều khoản của AB Rao vặt.");
                }
            }
            else
            {
                MessageBox.Show("Nhập đủ thông tin.");
            }
            
        }
    }
}
