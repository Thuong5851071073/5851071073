using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Design_Dashboard_Modern.DTO
{
   public class PhieunhapDTO
    {
        public PhieunhapDTO(int Phieunhap, int TongTien, int IDncc, DateTime? Ngaylap, string Tinhtrang, int manguoidung)
        {
            this.Phieunhap = Phieunhap;
            this.Tongtien = Tongtien;
            this.Idncc = IDncc;
            this.Ngaylap = Ngaylap;
            this.Tinhtrang = Tinhtrang;
            this.Manguoiung = manguoidung;

        }
        public PhieunhapDTO(DataRow row)
        {
            this.Phieunhap = (int)row["IDphieunhap"];
            this.Tongtien = (int)row["Tongtien"];
            this.Idncc = (int)row["IDnhacc"];
            this.Ngaylap = (DateTime?)row["NgayLap"];
            this.Tinhtrang = row["Tinhtrang"].ToString();
            this.Manguoiung = (int)row["manguidung"];

        }
        private int phieunhap;
        private int tongtien;
        private int idncc;
        private DateTime? ngaylap;
        private string tinhtrang;
        private int  manguoiung;


        public int Phieunhap { get => phieunhap; set => phieunhap = value; }
        public int Tongtien { get => tongtien; set => tongtien = value; }
        public int Idncc { get => idncc; set => idncc = value; }
        public DateTime? Ngaylap { get => ngaylap; set => ngaylap = value; }
        public string Tinhtrang { get => tinhtrang; set => tinhtrang = value; }
        public int Manguoiung { get => manguoiung; set => manguoiung = value; }
    }
}
