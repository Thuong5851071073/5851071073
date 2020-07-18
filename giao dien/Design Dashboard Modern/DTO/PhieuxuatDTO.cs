using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace Design_Dashboard_Modern.DTO
{
   public class PhieuxuatDTO
    {
        public PhieuxuatDTO(int Phieuxuat , int TongTien ,int IDkhach ,DateTime? Ngaylap ,string Tinhtrang , int manguoidung)
        {
            this.Phieuxuat = Phieuxuat;
            this.Tongtien = Tongtien;
            this.Idkhach = IDkhach;
            this.Ngaylap = Ngaylap;
            this.Tinhtrang = Tinhtrang;
            this.Manguoidung = manguoidung;
        }
        public PhieuxuatDTO(DataRow row ) {
            this.Phieuxuat = (int)row["IDphieuxuat"];
            this.Tongtien = (int)row["Tongtien"];
            this.Idkhach = (int)row["IDKhach"];
            this.Ngaylap = (DateTime?)row["NgayLap"];
            this.Tinhtrang = row["Tinhtrang"].ToString();
            this.Manguoidung = (int)row["manguoidung"];
               }
        private int phieuxuat;
        private int tongtien;
        private int idkhach;
        private DateTime? ngaylap;
        private string tinhtrang;
        private int manguoidung;


        public int Phieuxuat { get => phieuxuat; set => phieuxuat = value; }
        public int Tongtien { get => tongtien; set => tongtien = value; }
        public int Idkhach { get => idkhach; set => idkhach = value; }
        public DateTime? Ngaylap { get => ngaylap; set => ngaylap = value; }
        public string Tinhtrang { get => tinhtrang; set => tinhtrang = value; }
        public int Manguoidung { get => manguoidung; set => manguoidung = value; }
    }
}
