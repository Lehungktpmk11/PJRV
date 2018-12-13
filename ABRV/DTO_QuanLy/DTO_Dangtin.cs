using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLy
{
    public class DTO_Dangtin
    {
        private string dt;

        private string id;
       
        private string dientich;
        private string loaicanho;
        private Int32 tang;
        private string mota;
        private Int32 phongngu;
        private Boolean loai;
        private string mtct;
        private Int32 vesinh;
        private string dc;
        private Single gia;

        public string DT
        {
            get { return dt; }
            set { dt = value; }
        }
        public string DC
        {
            get { return dc; }
            set { dc = value; }
        }
        public Int32 VS
        {
            get { return vesinh; }
            set { vesinh = value; }
        }
        public Int32 Phongngu
        {
            get { return phongngu; }
            set { phongngu = value; }
        }
        public Int32 Tang
        {
            get { return tang; }
            set { tang = value; }
        }
        public string Lch
        {
            get { return loaicanho; }
            set { loaicanho = value; }
        }
        public string Dientich
        {
            get { return dientich; }
            set { dientich = value; }
        }
        public string ID
        {
            get { return id; }
            set { id = value; }
        }
        public Boolean Loai
        {
            get { return loai; }
            set { loai = value; }
        }
        public string Mota
        {
            get { return mota; }
            set { mota = value; }
        }
        public Single Gia
        {
            get { return gia; }
            set { gia = value; }
        }      
             
        public string MTCT
        {
            get { return mtct; }
            set { mtct = value; }
        }
        public DTO_Dangtin()
        {

        }
        public DTO_Dangtin(string adt, string aid,Boolean aloai, string amt, Single agia,string amtct,string adtich, string alch, Int32 atang, Int32 apngu, Int32 awc, string adc)
        {
            this.DT = adt;
            this.ID = aid;
            this.Loai = aloai;
            this.Mota = amt;
            this.Gia = agia;
            this.MTCT = amtct;
            this.Dientich = adtich;
            this.Lch = alch;
            this.Tang = atang;
            this.Phongngu = apngu;
            this.VS = awc;
            this.DC = adc;


        }
    }
}
