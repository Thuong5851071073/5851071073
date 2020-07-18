using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace Design_Dashboard_Modern.DTO
{
   public class CTHDDTO
    {
        public CTHDDTO(int mahang, int mahoadon, int soluong, int gia, int STT,  int thanhtien)
        {
            this.Mahang = mahang;
            this.Mahoadon = mahoadon;
            this.Soluong = soluong;
            this.Gia = gia;
            this.STT1 = STT;
           
            this.Thanhtien = thanhtien;

        }
        public CTHDDTO(DataRow row)
        {
            this.Mahang = (int)row["IDhang"];
            this.Mahoadon = (int)row["IDhoadon"];
            this.Soluong = (int)row["SoLuong"];
            this.Gia = (int)row["Gia"];
            this.STT1 = (int)row["sothutu"];
          
            this.Thanhtien = (int)row["Thanhtien"];
        }
        private int mahang;
        private int mahoadon;
        private int soluong;
        private int gia;
        private int STT;
       
        private int thanhtien;

        public int Mahang { get => mahang; set => mahang = value; }
        public int Mahoadon { get => mahoadon; set => mahoadon = value; }
        public int Soluong { get => soluong; set => soluong = value; }
        public int Gia { get => gia; set => gia = value; }
       
      
        public int Thanhtien { get => thanhtien; set => thanhtien = value; }
        public int STT1 { get => STT; set => STT = value; }
    }
}
