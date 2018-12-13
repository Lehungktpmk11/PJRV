using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLy
{
    public class DTO_KhachHang
    {
        private string id;
        private string hoten;
        private string sodienthoai;
        private string email;
        private string diachi;

        public string DC
        {
            get { return diachi; }
            set { diachi = value; }
        }

        public string EMAIL
        {
            get { return email; }
            set { email = value; }
        }

        public string SDT
        {
            get { return sodienthoai; }
            set { sodienthoai = value; }
        }

        public string HT
        {
            get { return hoten; }
            set { hoten = value; }
        }

        public string ID
        {
            get { return id; }
            set { id = value; }
        }

        public DTO_KhachHang()
        {

        }
        public DTO_KhachHang(string i, string h,string s,string e,string d)
        {
            this.ID = i;
            this.HT = h;
            this.SDT = s;
            this.EMAIL = e;
            this.DC = d;

        }

    }
}
