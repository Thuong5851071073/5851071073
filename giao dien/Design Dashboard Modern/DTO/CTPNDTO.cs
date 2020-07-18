using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace Design_Dashboard_Modern.DTO
{
   public class CTPNDTO
    {
        public CTPNDTO(int mahang, int maphieunhap, int soluong, int gia, int  STT, string tenhang,int thanhtien)
        {
            this.Mahang = mahang;
            this.Maphieunhap = maphieunhap;
            this.Soluong = soluong;
            this.Gia = gia;
            this.STT1 = STT;
            this.Tenhang = tenhang;
            this.Thanhtien = thanhtien;

        }
        public CTPNDTO(DataRow row)
        {
            this.Mahang = (int)row["IDhang"];
            this.Maphieunhap = (int)row["IDphieunhap"];
            this.Soluong = (int)row["SoLuong"];
            this.Gia = (int)row["Gia"];
            this.STT1 = (int)row["sothutu"];
            this.Tenhang = row["Tenhang"].ToString();
            this.Thanhtien = (int)row["ThanhTien"];
        }
        private int mahang;
        private int maphieunhap;
        private int soluong;
        private int gia;
        private int STT;
        private String tenhang;
        private int thanhtien;

        public int Mahang { get => mahang; set => mahang = value; }
        public int Maphieunhap { get => maphieunhap; set => maphieunhap = value; }
        public int Soluong { get => soluong; set => soluong = value; }
        public int Gia { get => gia; set => gia = value; }
       
        public string Tenhang { get => tenhang; set => tenhang = value; }
        public int Thanhtien { get => thanhtien; set => thanhtien = value; }
        public int STT1 { get => STT; set => STT = value; }
    }
}
