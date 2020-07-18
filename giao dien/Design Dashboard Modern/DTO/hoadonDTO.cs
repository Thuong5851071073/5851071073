using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace Design_Dashboard_Modern.DTO
{
   public class hoadonDTO
    {
        public hoadonDTO(int IDhoadon, int TongTien, int manhanvien, DateTime? Ngaylap, string Tinhtrang ,int makhach,int manguoidug)
        {
            this.Idhoadon = IDhoadon;
            this.Tongtien = Tongtien;
            this.Idnhanvien = manhanvien;
            this.Ngaylap = Ngaylap;
            this.Tinhtrang = Tinhtrang;
            this.Makhach = makhach;
            this.Manguoidung = manguoidug;

        }
        public hoadonDTO(DataRow row)
        {
            this.Idhoadon = (int)row["IDhoadon"];
            this.Tongtien = (int)row["Tongtien"];
            this.Idnhanvien = (int)row["IDnhanvien"];
            this.Ngaylap = (DateTime?)row["NgayLap"];
            this.Tinhtrang = row["Tinhtrang"].ToString();
            this.Makhach = (int)row["IDkhach"];
            this.Manguoidung = (int)row["manguidung"];
        }
        private int idhoadon;
        private int tongtien;
        private int idnhanvien;
        private DateTime? ngaylap;
        private string tinhtrang;
        private int makhach;
        private int manguoidung;

        public int Idhoadon { get => idhoadon; set => idhoadon = value; }
        public int Tongtien { get => tongtien; set => tongtien = value; }
        public int Idnhanvien { get => idnhanvien; set => idnhanvien = value; }
        public DateTime? Ngaylap { get => ngaylap; set => ngaylap = value; }
        public string Tinhtrang { get => tinhtrang; set => tinhtrang = value; }
        public int Makhach { get => makhach; set => makhach = value; }
        public int Manguoidung { get => manguoidung; set => manguoidung = value; }
    }
}
