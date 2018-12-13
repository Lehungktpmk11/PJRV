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
namespace ABRV
{
    public partial class Ftoiban : Form
    {
        public Ftoiban()
        {
            InitializeComponent();
        }
        BUS_Dangtin busdtin = new BUS_Dangtin();
        private void Ftoiban_Load(object sender, EventArgs e)
        {
            dgvtoiban.DataSource = busdtin.GetTinByID(FDangnhap.matk);
        }
    }
}
