using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Design_Dashboard_Modern.DTO
{
   public class khachhangDTO
    {
        public khachhangDTO(int IDkhach,string tenkhach ,int SDT,string diachi )
        {
            this.Idkhach = IDkhach;
            this.Tenkhach = tenkhach;
            this.Sdt = SDT;
            this.Diachi = diachi;
          //  this.Makhachhang = makhachhang;
        }
        public khachhangDTO(DataRow row)
        {
            this.Idkhach = (int)row["IDkhach"];
            this.Sdt = (int)row["SDT"];
            this.Tenkhach = row["TenKhach"].ToString();
            this.Diachi = row["DiaChi"].ToString();
           // this.Makhachhang = row["Makhachhang"].ToString();


        }
        private int idkhach;
        private string tenkhach;
        private int sdt;
        private string diachi;
       // private string makhachhang;

        public int Idkhach { get => idkhach; set => idkhach = value; }
        public string Tenkhach { get => tenkhach; set => tenkhach = value; }
        public int Sdt { get => sdt; set => sdt = value; }
        public string Diachi { get => diachi; set => diachi = value; }
    //    public string Makhachhang { get => makhachhang; set => makhachhang = value; }
    }
}
