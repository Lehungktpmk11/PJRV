using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using DTO_QuanLy;
using BUS_QuanLy;
using System.Data.SqlClient;
namespace ABRV
{
    public partial class FDangtin : Form
    {
        public FDangtin()
        {
            InitializeComponent();
        }
        
        public string imgLocation = "";
        public string imgLocation1= "";
        public string imgLocation2 = "";
        BUS_Khoanh buska = new BUS_Khoanh();
        BUS_Khuvuc buskv = new BUS_Khuvuc();
        BUS_Dangtin busdtin = new BUS_Dangtin();
        private string FileName = "";
        private string FileName1 = "";
        private string FileName2 = "";

        private void btndangngay_Click(object sender, EventArgs e)
        {

            if (Kiemtranhapfrm(sender, e))
            {
                Boolean li;
                if (rdoban.Checked == true)
                {
                    li = true;
                }
                else
                {
                    li = false;
                }
                string diachi = txtdcnha.Text + "/" + cboxa.Text + "/" + cbohuyen.Text + "/" + cbotinh.Text;
                string madt = busdtin.TaoMa();
                DTO_Dangtin dtodt = new DTO_Dangtin(madt, FDangnhap.matk, li, txtmota.Text, Convert.ToSingle(txtgia.Text), txtgioithieu.Text, txtdientich.Text, cbolch.Text, Convert.ToInt32(txtsotang.Text), Convert.ToInt32(txtphongngu.Text), Convert.ToInt32(txtwc.Text), diachi);

                if (busdtin.Them(dtodt))
                {
                    Xulyanh(madt);
                    MessageBox.Show("Thành công", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Không thành công.", "Thông báo");
                }

            }
            else
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin.");
            }
            // MessageBox.Show(txtgioithieu.Text);
            //MessageBox.Show(diachi);

        }
        
        // xu ly anh
        private void Xulyanh(string maluuanh)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            string CorrectFileName = Path.GetFileName(FileName);
            string CorrectFileName1 = Path.GetFileName(FileName1);
            string CorrectFileName2 = Path.GetFileName(FileName2);

            string link = "\\Picture\\" + CorrectFileName;
            string link1 = "\\Picture\\" + CorrectFileName1;
            string link2 = "\\Picture\\" + CorrectFileName2;
            DTO_Khoanh ka = new DTO_Khoanh(buska.TaoMa(), maluuanh, link);
            string paths = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));

            File.Copy(FileName, paths + "\\Picture\\" + CorrectFileName);
            File.Copy(FileName1, paths + "\\Picture\\" + CorrectFileName1);
            File.Copy(FileName2, paths + "\\Picture\\" + CorrectFileName2);

            buska.InsertDB(ka);
            DTO_Khoanh ka1 = new DTO_Khoanh(buska.TaoMa(), maluuanh, link1);
            buska.InsertDB(ka1);
            DTO_Khoanh ka2 = new DTO_Khoanh(buska.TaoMa(), maluuanh, link2);
            buska.InsertDB(ka2);

        }

        // xu ly anh

        private void ptdt_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.InitialDirectory = "C:\\";
            dialog.Filter = "Image File (*jpg)|*.jpg";
            dialog.FilterIndex = 1;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imgLocation = dialog.FileName.ToString();
                ptdt.ImageLocation = imgLocation;
                FileName = dialog.FileName;
            }
        }

        private void FDangtin_Load(object sender, EventArgs e)
        {
            Tinh(sender, e);
            LoadLoai(sender, e);
        }
        private void LoadLoai(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = busdtin.Getloai();
            cbolch.DataSource = dt;
            cbolch.DisplayMember = "Loai";
            cbolch.ValueMember = "IL";

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.InitialDirectory = "C:\\";
            dialog.Filter = "Image File (*jpg)|*.jpg";
            dialog.FilterIndex = 1;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imgLocation1 = dialog.FileName.ToString();
                pictureBox1.ImageLocation = imgLocation1;
                FileName1 = dialog.FileName;
            }
        }
        private void Tinh(object sender, EventArgs e)
        {
            DataTable tinh = new DataTable();
            tinh = buskv.GetProvince();
            cbotinh.DataSource = tinh;
            cbotinh.DisplayMember = "Tên";
            cbotinh.ValueMember = "Mã tỉnh";

           
        }
        private void Huyen(object sender, EventArgs e)
        {
            DataTable huyen = new DataTable();
            string ma=cbotinh.SelectedValue.ToString();
            huyen = buskv.GetDistrict(ma);
            cbohuyen.DataSource = huyen;
            cbohuyen.DisplayMember = "Tên";
            cbohuyen.ValueMember = "Mã Huyện/Tp/Thị xã";


        }
        private void Xa(object sender, EventArgs e)
        {
            DataTable xa = new DataTable();
            string matim = cbohuyen.SelectedValue.ToString();
            xa= buskv.GetWard(matim);
            cboxa.DataSource = xa;
            cboxa.DisplayMember = "Tên";
            cboxa.ValueMember = "Mã Xã/Phường/Thị Trấn";


        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.InitialDirectory = "C:\\";
            dialog.Filter = "Image File (*jpg)|*.jpg";
            dialog.FilterIndex = 1;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imgLocation2 = dialog.FileName.ToString();
                pictureBox2.ImageLocation = imgLocation2;
                FileName2 = dialog.FileName;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbotinh_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Huyen(sender, e);
        }

        private void cbohuyen_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Xa(sender, e);
        }




        // bat loi
        private bool Kiemtranhapfrm(object sender, EventArgs e)
        {
            

            if(txtmota.Text==""||txtgioithieu.Text==""||txtgia.Text==""||txtdientich.Text==""||(rdoban.Checked==false&&rdomua.Checked==false)|| txtphongngu.Text == "" || txtsotang.Text == "" || txtwc.Text == "" || txtdcnha.Text == "" || cboxa.Text == ""||cbolch.Text=="")
            {
                return false;
            }
           

            return true;
        }

        private void txtgia_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtsotang_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtphongngu_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtwc_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        //bat loi
    }
}
