using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLy
{
    public class DTO_Taikhoan
    {
        private string iD;
        private string user;
        private string pass;
        private Boolean quyen;

        public Boolean Quyen
        {
            get { return quyen; }
            set { quyen = value; }
        }

        public string MK
        {
            get { return pass; }
            set { pass = value; }
        }

        public string TK
        {
            get { return user; }
            set { user = value; }
        }

        public string ID
        {
            get { return iD; }
            set { iD = value; }
        }


        public DTO_Taikhoan()
        {

        }
        public DTO_Taikhoan(string tk, string mk)  
        {
            this.TK = tk;
            this.MK = mk;
        }
        public DTO_Taikhoan(string id, string tk, string mk, Boolean qq)
        {
            this.iD = id;
            this.TK = tk;
            this.MK = mk;
            this.Quyen = qq;

        }
    }
}
