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
    public partial class Fqldangky : Form
    {
        public Fqldangky()
        {
            InitializeComponent();
        }
        BUS_QLDK qldk = new BUS_QLDK();
        BUS_Taikhoan qltk = new BUS_Taikhoan();
        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Fqldangky_Load(object sender, EventArgs e)
        {
            dgvdktk.DataSource = qldk.GetAll();
        }

        private void btnhuybo_Click(object sender, EventArgs e)
        {
            if(vitri>=0&&vitri<dgvdktk.Rows.Count-1)
            {
                string ma = dgvdktk.Rows[vitri].Cells[0].Value.ToString();
                if(qldk.Xoa(ma))
                {
                    MessageBox.Show("Hủy bỏ thành công.");
                    Fqldangky_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Không thành công.");
                }
            }
        }
        int vitri;
        private void dgvdktk_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           vitri= e.RowIndex;
            MessageBox.Show(vitri.ToString());
        }

        private void txttimkiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==(char)13)
            {
                dgvdktk.DataSource = qldk.Timkiem(txttimkiem.Text);
            }
        }

        private void btnxacnhan_Click(object sender, EventArgs e)
        {
            if (vitri >= 0 && vitri < dgvdktk.Rows.Count - 1)
            {
                string sdt = dgvdktk.Rows[vitri].Cells[1].Value.ToString();
                string mk = dgvdktk.Rows[vitri].Cells[2].Value.ToString();
                string ma = dgvdktk.Rows[vitri].Cells[0].Value.ToString();
                bool q = false;
                DTO_Taikhoan tk = new DTO_Taikhoan(qltk.TaoMa(), sdt, mk, q);
                if (qldk.Xoa(ma)==true &&qltk.Them(tk)==true)
                {
                    MessageBox.Show("Xác nhận thành công.");
                    Fqldangky_Load(sender, e);
                    

                }
                else
                {
                    MessageBox.Show("Không thành công.");
                }
            }
        }

        private void Fqldangky_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
