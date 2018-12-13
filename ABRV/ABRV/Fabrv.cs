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
using System.IO;

namespace ABRV
{
    public partial class Fabrv : Form
    {
        public Fabrv()
        {
            InitializeComponent();
        }
        //khai bao 1 so bien khac


        public Int32 NumberPage;
        //khai bao 1 so bien khac




        // khai bao bus

        BUS_Khoanh buska = new BUS_Khoanh();
        BUS_Dangtin busdtin = new BUS_Dangtin();
        //khai bao bus
        private void btntang_Click(object sender, EventArgs e)
        {
           if(NumberPage<demtrang-1)
            {
                NumberPage = Convert.ToInt32(lblnumber.Text);

                NumberPage++;
                lblnumber.Text = NumberPage.ToString();
            }
           else
            {
                MessageBox.Show("Bạn đã ở trang cuối cùng.","Thông báo");
            }

        }

        private void btngiam_Click(object sender, EventArgs e)
        {
            NumberPage = Convert.ToInt32(lblnumber.Text);

            if (NumberPage > 0)
            {
                NumberPage--;
                lblnumber.Text = NumberPage.ToString();
                Fabrv_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Bạn đã ở trang đầu tiên.");
            }
        }

        private void btndangxuat_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private Int32 NumberImage = 1;
        private void LoadNextImage(object sender, EventArgs e)
        {
            if (NumberImage == 8)
            {
                NumberImage = 1;
            }
            slideP.ImageLocation = string.Format(@"Images\{0}.jpg", NumberImage);
            NumberImage++;
            Fabrv_Load(sender, e);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LoadNextImage(sender, e);
        }

        private void btndangtin_Click(object sender, EventArgs e)
        {
            FDangtin fdt = new FDangtin();
            this.Hide();
            fdt.ShowDialog();
            this.Show();

        }

        public Image LoadImage(string maloadanh)
        {
            DataTable dt = new DataTable();
            dt = buska.ViewAnh(maloadanh);
            string paths = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));


            Image imgs = Image.FromFile(paths + dt.Rows[0]["Path"].ToString());


            return imgs;
        }
        private Int32 demtrang;
        private void LoadAnhLenFrm()
        {
            
            int i = NumberPage*9;
            DataTable dtdl = new DataTable();
            dtdl = busdtin.GetAll();
            demtrang = dtdl.Rows.Count/9;
            // anh
            string maloadanh1 = dtdl.Rows[i][0].ToString();
            string maloadanh2 = dtdl.Rows[i + 1][0].ToString();
            string maloadanh3 = dtdl.Rows[i + 2][0].ToString();
            string maloadanh4 = dtdl.Rows[i + 3][0].ToString();
            string maloadanh5 = dtdl.Rows[i + 4][0].ToString();
            string maloadanh6 = dtdl.Rows[i + 5][0].ToString();
            string maloadanh7 = dtdl.Rows[i + 6][0].ToString();
            string maloadanh8 = dtdl.Rows[i + 7][0].ToString();
            string maloadanh9 = dtdl.Rows[i + 8][0].ToString();

            pt1.Image = LoadImage(maloadanh1);
            pt2.Image = LoadImage(maloadanh2);
            pt3.Image = LoadImage(maloadanh3);
            pt4.Image = LoadImage(maloadanh4);
            pt5.Image = LoadImage(maloadanh5);
            pt6.Image = LoadImage(maloadanh6);
            pt7.Image = LoadImage(maloadanh7);
            pt8.Image = LoadImage(maloadanh8);
            pt9.Image = LoadImage(maloadanh9);
            // anh

            //label content
            string maloada1 = dtdl.Rows[i][3].ToString();
            string maloada2 = dtdl.Rows[i + 1][3].ToString();
            string maloada3 = dtdl.Rows[i + 2][3].ToString();
            string maloada4 = dtdl.Rows[i + 3][3].ToString();
            string maloada5 = dtdl.Rows[i + 4][3].ToString();
            string maloada6 = dtdl.Rows[i + 5][3].ToString();
            string maloada7 = dtdl.Rows[i + 6][3].ToString();
            string maloada8 = dtdl.Rows[i + 7][3].ToString();
            string maloada9 = dtdl.Rows[i + 8][3].ToString();


            lbl1c.Text = maloada1;
            lbl2c.Text = maloada2;
            lbl3c.Text = maloada3;
            lbl4c.Text = maloada4;
            lbl5c.Text = maloada5;
            lbl6c.Text = maloada6;
            lbl7c.Text = maloada7;
            lbl8c.Text = maloada8;
            lbl9c.Text = maloada9;
            //label content


            //label gia
            string gia1 = dtdl.Rows[i][4].ToString() + " đ";
            string gia2 = dtdl.Rows[i + 1][4].ToString()+" đ";
            string gia3 = dtdl.Rows[i + 2][4].ToString() + " đ";
            string gia4 = dtdl.Rows[i + 3][4].ToString() + " đ";
            string gia5 = dtdl.Rows[i + 4][4].ToString() + " đ";
            string gia6 = dtdl.Rows[i + 5][4].ToString() + " đ";
            string gia7 = dtdl.Rows[i + 6][4].ToString() + " đ";
            string gia8 = dtdl.Rows[i + 7][4].ToString() + " đ";
            string gia9 = dtdl.Rows[i + 8][4].ToString() + " đ";

            lbl1b.Text = gia1;
            lbl2b.Text = gia2;
            lbl3b.Text = gia3;
            lbl4b.Text = gia4;
            lbl5b.Text = gia5;
            lbl6b.Text = gia6;
            lbl7b.Text = gia7;
            lbl8b.Text = gia8;
            lbl9b.Text = gia9;
            //label gia

            //lay id
            string id1 = dtdl.Rows[i][1].ToString();
            string id2 = dtdl.Rows[i+1][1].ToString();
            string id3 = dtdl.Rows[i+2][1].ToString();
            string id4 = dtdl.Rows[i+3][1].ToString();
            string id5 = dtdl.Rows[i+4][1].ToString();
            string id6 = dtdl.Rows[i+5][1].ToString();
            string id7 = dtdl.Rows[i+6][1].ToString();
            string id8 = dtdl.Rows[i+7][1].ToString();
            string id9 = dtdl.Rows[i+8][1].ToString();
            //layid

        }

        private void Fabrv_Load(object sender, EventArgs e)
        {
            LoadAnhLenFrm();


        }

        private void Fabrv_FormClosed(object sender, FormClosedEventArgs e)
        {
            FDangnhap.matk = "";
        }

        private void btntoiban_Click(object sender, EventArgs e)
        {
            Ftoiban frmtoiban = new Ftoiban();
            frmtoiban.ShowDialog();
        }

        private void btnmesit_Click(object sender, EventArgs e)
        {
            DataTable dtdl = new DataTable();
            dtdl = busdtin.GetAll();
            string maloadanh1 = dtdl.Rows[0][0].ToString();
            MessageBox.Show(demtrang.ToString());
        }

        private void btntttaikhoan_Click(object sender, EventArgs e)
        {
            Ftttaikhoan frmtttk = new Ftttaikhoan();
            frmtttk.ShowDialog();
        }
    }
}
