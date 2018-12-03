using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLy
{
    public class DTO_Dangkytaikhoan
    {

        private string dk;
        private string tk;
        private string mk;

        public string Mk
        {
            get { return mk; }
            set { mk = value; }
        }

        public string TK
        {
            get { return tk; }
            set { tk = value; }
        }

        public string DK
        {
            get { return dk; }
            set { dk = value; }
        }
        public DTO_Dangkytaikhoan()
        {

        }
        public DTO_Dangkytaikhoan(string i,string t,string m)
        {
            this.DK = i;
            this.TK = t;
            this.Mk = m;
        }
    }
}
