using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_QuanLy;
using DTO_QuanLy;
namespace ABRV
{
    public partial class Fdangnhap : Form
    {
        public Fdangnhap()
        {
            InitializeComponent();
        }
        BUS_Dangnhap busDN = new BUS_Dangnhap();
        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Fdangnhap_Load(object sender, EventArgs e)
        {

        }

        private void btndangnhap_Click(object sender, EventArgs e)
        {
            if(txtmk.Text!=""&&txttk.Text!="")
            {
                DataTable dt = new DataTable();
                DTO_Taikhoan tk = new DTO_Taikhoan(txttk.Text, txtmk.Text);
                dt = busDN.GetTk(tk);
                if (dt.Rows.Count>0)
                {
                    string qq = dt.Rows[0][3].ToString();
                    if(qq=="False")
                    {
                        
                    }
                    else
                    {
                        Fadmin fad = new Fadmin();
                        this.Hide();
                        fad.ShowDialog();
                        this.Show();
                    
                    }
                }
                else
                {
                    MessageBox.Show("Đăng nhập không thành công!!!");
                }


            }
            else
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!!");
            }
        }
    }
}
