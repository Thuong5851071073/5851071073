using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace Design_Dashboard_Modern.DTO
{
   public class nguoidungDTO
    {
        public nguoidungDTO(int iduser,string Matkhau,string tennguoidung, string gmail,string quyenhan,string diachi,string SDT,int Luong ,int sogiolam,int Manhanvien)
        {
            this.Iduser = iduser;
            this.Tennguoidung = tennguoidung;
            this.Gmail = gmail;
            this.Quyenhan = quyenhan;
            this.Diachi = diachi;
            this.SDT1 = SDT;
            this.Luong = luong;
            this.Sogiolam = sogiolam;
            this.Manhanvien = manhanvien;
            this.Matkhau = matkhau;
          }
        public nguoidungDTO(DataRow row)
        {
            this.Iduser = (int)row["IDuser"];
            this.Tennguoidung = row["Tennguoidung"].ToString();
            this.Gmail = row["gmail"].ToString();
            this.Quyenhan = row["gmail"].ToString();
            this.Matkhau= row["Matkhau"].ToString();
            this.Diachi = row["Diachi"].ToString();
            this.Luong = (int)row["Luong"];
            this.Sogiolam = (int)row["Sogiolam"];
            this.Manhanvien = (int)row["Manhanvien"];
            this.SDT1 = row["SDT"].ToString();



        }
        private string matkhau;
        private int iduser;
        private string tennguoidung;
        private string gmail;
        private string quyenhan;
        private string diachi;
        private int luong;
        private int sogiolam;
        private int manhanvien;
        private string SDT;

        public int Iduser { get => iduser; set => iduser = value; }
        public string Tennguoidung { get => tennguoidung; set => tennguoidung = value; }
        public string Gmail { get => gmail; set => gmail = value; }
        public string Quyenhan { get => quyenhan; set => quyenhan = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public int Luong { get => luong; set => luong = value; }
        public int Sogiolam { get => sogiolam; set => sogiolam = value; }
        public int Manhanvien { get => manhanvien; set => manhanvien = value; }
       
        public string Matkhau { get => matkhau; set => matkhau = value; }
        public string SDT1 { get => SDT; set => SDT = value; }
    }
}
