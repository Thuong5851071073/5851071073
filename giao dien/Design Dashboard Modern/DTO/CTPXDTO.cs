using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace Design_Dashboard_Modern.DTO
{
   public class CTPXDTO
    {
        public CTPXDTO(int mahang, int maphieuxuat,int soluong,int gia,int STT,string tenhang ,int thanhtien)
        {
            this.Mahang = mahang;
            this.Maphieuxuat = maphieuxuat;
            this.Soluong = soluong;
            this.Gia = gia;
            this.STT1 = STT;
            this.Tenhang = tenhang;
            this.Thanhtien = thanhtien;
            
        }
        public CTPXDTO(DataRow row)
        {
            this.Mahang = (int)row["IDhang"];
            this.Maphieuxuat = (int)row["IDphieuxuat"];
            this.Soluong = (int)row["SoLuong"];
            this.Gia = (int)row["Gia"];
            this.STT1 = (int)row["sothutu"];
            this.Tenhang = row["Tenhang"].ToString();
            this.Thanhtien = (int)row["Thanhtien"];
           // this.Tongtien = (int)row["Tongtien"];

        }
        private int tongtien;
        private int thanhtien;
        private int mahang;
        private int maphieuxuat;
        private int soluong;
        private int gia;
        private  int STT;
        private String tenhang;

        public int Mahang { get => mahang; set => mahang = value; }
        public int Maphieuxuat { get => maphieuxuat; set => maphieuxuat = value; }
        public int Soluong { get => soluong; set => soluong = value; }
        public int Gia { get => gia; set => gia = value; }
       
        public string Tenhang { get => tenhang; set => tenhang = value; }
        public int Thanhtien { get => thanhtien; set => thanhtien = value; }
        public int Tongtien { get => tongtien; set => tongtien = value; }
        public int STT1 { get => STT; set => STT = value; }
    }
}
