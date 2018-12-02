using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLy
{
    public class DTO_Taikhoan
    {
        private string user;
        private string pass;
        private string iD;
        private bool quyen;

        public bool Quyen
        {
            get { return quyen; }
            set { quyen = value; }
        }

        public string Id
        {
            get { return iD; }
            set { iD = value; }
        }

        public string Pass
        {
            get { return pass; }
            set { pass = value; }
        }

        public string User
        {
            get { return user; }
            set { user = value; }
        }

        public DTO_Taikhoan()
        {

        }
        public DTO_Taikhoan(string tk,string mk)
        {
            
            this.User = tk;
            this.Pass = mk;
            
        }
        public DTO_Taikhoan(string i, string tk, string mk,bool q)
        {
            this.Id = i;
            this.User = tk;
            this.Pass = mk;
            this.Quyen = q;
        }

    }
}
