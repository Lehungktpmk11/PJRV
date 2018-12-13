using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLy
{
    public class DTO_Khoanh
    {
        private string im;
        private string id;
        private string anh;

        public string Anh
        {
            get { return anh; }
            set { anh = value; }
        }

        public string ID
        {
            get { return id; }
            set { id = value; }
        }

        public string IM
        {
            get { return im; }
            set { im = value; }
        }
        public DTO_Khoanh()
        {

        }
        public DTO_Khoanh(string m, string d, string a)
        {
            this.IM = m;
            this.ID = d;
            this.Anh = a;

        }
    }
}
