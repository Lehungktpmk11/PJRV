using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABRV
{
    public partial class Fabrv : Form
    {
        public Fabrv()
        {
            InitializeComponent();
        }
        public Int32 NumberPage;
        private void btntang_Click(object sender, EventArgs e)
        {
            NumberPage = Convert.ToInt32(lblnumber.Text);

            NumberPage++;
            lblnumber.Text = NumberPage.ToString();

        }

        private void btngiam_Click(object sender, EventArgs e)
        {
            NumberPage = Convert.ToInt32(lblnumber.Text);

           if(NumberPage>0)
            {
                NumberPage--;
                lblnumber.Text = NumberPage.ToString();
            }
            else
            {
                MessageBox.Show("Bạn đã ở trang đầu tiên.");
            }
        }

        private void btndangxuat_Click(object sender, EventArgs e)
        {
            this.Close();
            FDangnhap.matk = "";
        }
    }
}
