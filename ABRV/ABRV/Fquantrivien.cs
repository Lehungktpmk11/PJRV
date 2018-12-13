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
    public partial class Fquantrivien : Form
    {
        public Fquantrivien()
        {
            InitializeComponent();
        }
        //
        //khaibao bus
        //
        BUS_Taikhoan tk = new BUS_Taikhoan();
        BUS_Dangtin busdtin = new BUS_Dangtin();
        BUS_Khoanh buska = new BUS_Khoanh();

        BUS_KhachHang buskh = new BUS_KhachHang();
        //
        //khai bao bus
        //
        private void Fquantrivien_Load(object sender, EventArgs e)
        {
            txtid.Enabled = false;
            dgvhienthitk.DataSource = tk.GetAll();
        }
        int vitri;
        private void dgvhienthi_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            vitri = e.RowIndex;


            if (vitri >= 0 && vitri < dgvhienthitk.Rows.Count - 1)
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
                        Fquantrivien_Load(sender, e);
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

        private void btnthem_Click(object sender, EventArgs e)
        {
            if (txtmatkhau.Text != "" && txtmatkhau.Text != "" && (rdoadmin.Checked == true || rdonguoidung.Checked == true))
            {
                Boolean r;
                if (rdoadmin.Checked)
                {
                    r = true;
                }
                else r = false;
                DTO_Taikhoan ttk = new DTO_Taikhoan(tk.TaoMa(), txttaikhoan.Text, txtmatkhau.Text, r);
                if (tk.Them(ttk))
                {
                    MessageBox.Show("Thêm tài khoản thành công");
                    Fquantrivien_Load(sender, e);
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
            if (vitri >= 0 && vitri < dgvhienthitk.Rows.Count - 1)
            {
                if (tk.Xoa(txtid.Text))
                {
                    MessageBox.Show("Xóa tài khoản thành công.");
                    Fquantrivien_Load(sender, e);
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

        private void txttimkiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                dgvhienthitk.DataSource = tk.Timkiem(txttimkiem.Text);
            }
        }

        private void Fquantrivien_FormClosed(object sender, FormClosedEventArgs e)
        {
            FDangnhap.matk = "";
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        PaintEventArgs ex;
        private void tptindang_Paint(object sender, PaintEventArgs ex)
        {
            dgvtindang.DataSource = busdtin.GetAll();
        }
        int vitritb2;
        string maanh;
        int maxvt2;
        private void dgvtindang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            maxvt2 = dgvtindang.Rows.Count;
            vitritb2 = e.RowIndex;
            maanh = dgvtindang.Rows[vitritb2].Cells[0].Value.ToString();
            Boolean loai = Convert.ToBoolean(dgvtindang.Rows[vitritb2].Cells[2].Value);
            if (loai)
            {
                rdoban.Checked = true;
            }
            else rdomua.Checked = true;
            txtmota.Text = dgvtindang.Rows[vitritb2].Cells[3].Value.ToString();
            txtgia.Text = dgvtindang.Rows[vitritb2].Cells[4].Value.ToString();
            txtmtct.Text= dgvtindang.Rows[vitritb2].Cells[5].Value.ToString();
            txtdientich.Text= dgvtindang.Rows[vitritb2].Cells[6].Value.ToString();
            txtlch.Text= dgvtindang.Rows[vitritb2].Cells[7].Value.ToString();
            txtsotang.Text= dgvtindang.Rows[vitritb2].Cells[8].Value.ToString();
            txtphongngu.Text= dgvtindang.Rows[vitritb2].Cells[9].Value.ToString();
            txtwc.Text= dgvtindang.Rows[vitritb2].Cells[10].Value.ToString();
            txtdiachi.Text= dgvtindang.Rows[vitritb2].Cells[11].Value.ToString();
        }
        public Image LoadImage(int dong)
        {
            DataTable dt = new DataTable();
            dt = buska.ViewAnh(maanh);
            string paths = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));


            Image imgs = Image.FromFile(paths + dt.Rows[dong]["Path"].ToString());


            return imgs;
        }
        private void btnxemanh_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = LoadImage(0);
            pictureBox2.Image = LoadImage(1);
            pictureBox3.Image = LoadImage(2);
            tptindang_Paint(sender,ex);
        }

        private void btndsdangky_Click(object sender, EventArgs e)
        {
            Fqldangky frmqldk = new Fqldangky();
            frmqldk.ShowDialog();
        }

        private void btnxoatin_Click(object sender, EventArgs e)
        {
            DialogResult hoi;
            hoi = MessageBox.Show("Bạn chắc chắn muốn xóa tin đăng không?","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(hoi==DialogResult.Yes)
            {
                if (vitritb2 >= 0 && vitritb2 < (maxvt2 - 1))
                {
                    if (buska.XoaAnh(maanh) == true && busdtin.Xoa(maanh))
                    {
                        MessageBox.Show("Xóa tin thành công", "Thông báo");
                        tptindang_Paint(sender, ex);
                    }
                    else
                    {
                        MessageBox.Show("Xóa tin thất bại.!!!", "Thông báo");
                    }
                }
            }
        }

        private void dgvkhachhang_Paint(object sender, PaintEventArgs e)
        {
            dgvkhachhang.DataSource = buskh.GetAll();
        }
    }
}
