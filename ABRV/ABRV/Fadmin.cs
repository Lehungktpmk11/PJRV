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
    public partial class Fadmin : Form
    {
        public Fadmin()
        {
            InitializeComponent();
        }
        BUS_Taikhoan tk = new BUS_Taikhoan();

        private void Fadmin_Load(object sender, EventArgs e)
        {
            txtid.Enabled = false;
            dgvhienthitk.DataSource = tk.GetAll();
        }
        int vitri;

        private void dgvhienthitk_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            vitri = e.RowIndex;


            if (vitri >= 0&&vitri<dgvhienthitk.Rows.Count-1)
            {
                txtid.Text = dgvhienthitk.Rows[vitri].Cells[0].Value.ToString();
                txttaikhoan.Text = dgvhienthitk.Rows[vitri].Cells[1].Value.ToString();
                txtmatkhau.Text = dgvhienthitk.Rows[vitri].Cells[2].Value.ToString();
                bool r = Convert.ToBoolean(dgvhienthitk.Rows[vitri].Cells[3].Value.ToString());
                if (r)
                {
                    rdoadmin.Checked = true;
                }
                else
                {
                    rdonguoidung.Checked = true;
                }

            }
            else
            {
                MessageBox.Show("Chọn lại vị trí");
            }



        }

        private void btnthem_Click(object sender, EventArgs e)
        {
           if(txtmatkhau.Text!=""&&txtmatkhau.Text!=""&&(rdoadmin.Checked==true||rdonguoidung.Checked==true))
            {
                Boolean r;
                if (rdoadmin.Checked)
                {
                    r = true;
                }
                else r = false;
                DTO_Taikhoan ttk = new DTO_Taikhoan(tk.TaoMa(), txttaikhoan.Text, txtmatkhau.Text, r);
                if(tk.Them(ttk))
                {
                    MessageBox.Show("Thêm tài khoản thành công");
                    Fadmin_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Không thành công");
                }


            }
            else
            {
                MessageBox.Show("Nhập đủ thông tin");
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if(vitri>=0&& vitri < dgvhienthitk.Rows.Count - 1)
            {
                if(tk.Xoa(txtid.Text))
                {
                    MessageBox.Show("Xóa tài khoản thành công.");
                    Fadmin_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Xóa không thành công.");
                }
            }
            else
            {
                MessageBox.Show("Chọn lại vị trí");
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (vitri >= 0 && vitri < dgvhienthitk.Rows.Count - 1)
            {
                if (txtmatkhau.Text != "" && txtmatkhau.Text != "" && (rdoadmin.Checked == true || rdonguoidung.Checked == true))
                {
                    Boolean r;
                    if (rdoadmin.Checked)
                    {
                        r = true;
                    }
                    else r = false;
                    DTO_Taikhoan ttk = new DTO_Taikhoan(txtid.Text, txttaikhoan.Text, txtmatkhau.Text, r);
                    if (tk.Sua(ttk))
                    {
                        MessageBox.Show("Sửa khoản thành công");
                        Fadmin_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Không thành công");
                    }


                }
                else
                {
                    MessageBox.Show("Nhập đủ thông tin");
                }
            }
            else
            {
                MessageBox.Show("Chọn lại vị trí");
            }

        }

        private void txttimkiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==(char)13)
            {
                dgvhienthitk.DataSource = tk.Timkiem(txttimkiem.Text);
            }
        }

        private void quảnLýĐăngKýTKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fqldangky fqldk = new Fqldangky();
            this.Hide();
            fqldk.ShowDialog();
            this.Show();
        }
    }
}
