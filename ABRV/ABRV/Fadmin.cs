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
    public partial class Fadmin : Form
    {
        public Fadmin()
        {
            InitializeComponent();
        }
        BUS_Dangnhap dn = new BUS_Dangnhap();
        private void button1_Click(object sender, EventArgs e)
        {
            dgvhienthi.DataSource = dn.GetAllTk();
            
        }
    }
}
