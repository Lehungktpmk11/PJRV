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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
           Int32 a = Convert.ToInt32(lblnumberPage.Text);
            a++;
            
            lblnumberPage.Text = a.ToString();
            
        }

        private void btnpre_Click(object sender, EventArgs e)
        {
            Int32 a = Convert.ToInt32(lblnumberPage.Text);
            a--;

            lblnumberPage.Text = a.ToString();
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
        Int32 kt;
        private void Form1_Load(object sender, EventArgs e)
        {
           kt = 0;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(kt==0)
            {
                Fdangnhap fdn = new Fdangnhap();
                this.Hide();
                fdn.ShowDialog();
                this.Show();
            }
        }
    }
}
