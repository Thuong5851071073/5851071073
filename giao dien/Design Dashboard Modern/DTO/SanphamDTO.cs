using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Dashboard_Modern.DTO
{
   public  class SanphamDTO
    {
        public SanphamDTO(int  IDhang,string Tenhang ,string  Loaihang,int SoLuongthungtonkho,string Thetich , byte[] Picture,int manhacc,int giaban,int giavon, int sothutu)
        {
            this.IDhang1 = IDhang;
            this.Tenhang1 = Tenhang;
          
            this.SoLuongthungtonkho1 = SoLuongthungtonkho;
            this.Loaihang1 = Loaihang;
            this.Thetich1 = Thetich;
            this.Picture1 = Picture;
            this.Manhacc = manhacc;
            this.Giaban = giaban;
            this.Giavon = giavon;
            this.Sott = sothutu;

        }
        public SanphamDTO(DataRow row)
        {
            this.IDhang1 = (int)row["IDhang"];
            this.Tenhang1 = row["TenHang"].ToString();
            this.Loaihang1 = row["Loaihang"].ToString();
            this.SoLuongthungtonkho1 = (int)row["Soluongthungtrongkho"];
            this.Thetich1=row["TheTich"].ToString();
            this.Picture1 = (byte[])row["PICTURE"];
            this.Manhacc = (int)row["IDnhacc"];
            this.Giaban = (int)row["Giaban"];
            this.Giavon = (int)row["GiaVon"];
            this.Sott = (int)row["sothutu"];


        }
        private int IDhang;
        private string Tenhang;
        private string Loaihang;
        private int SoLuongthungtonkho;
        private int manhacc;
        private int giaban;
        private int giavon;
        private int sott;
       
        private string Thetich;
        private byte[] Picture;

        public int IDhang1 { get => IDhang; set => IDhang = value; }
        public string Tenhang1 { get => Tenhang; set => Tenhang = value; }
       
       
        public string Thetich1 { get => Thetich; set => Thetich = value; }
        public byte[] Picture1 { get => Picture; set => Picture = value; }
        public int SoLuongthungtonkho1 { get => SoLuongthungtonkho; set => SoLuongthungtonkho = value; }
        public int Manhacc { get => manhacc; set => manhacc = value; }
        public int Giaban { get => giaban; set => giaban = value; }
        public int Giavon { get => giavon; set => giavon = value; }
        public int Sott { get => sott; set => sott = value; }
        public string Loaihang1 { get => Loaihang; set => Loaihang = value; }
    }
}
