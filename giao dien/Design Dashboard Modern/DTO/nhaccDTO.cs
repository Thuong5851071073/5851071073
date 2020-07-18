using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Design_Dashboard_Modern.DTO
{
    public class nhaccDTO
    {
        public nhaccDTO(int manhacc, string tennhacc, int sdt)
        {
            this.Manhacc = manhacc;
            this.Tennhacc = tennhacc;
            this.Sdt = sdt;
        }
        public nhaccDTO(DataRow row) 
            {
            this.Manhacc = (int)row["IDnhacc"];
            this.Sdt = (int)row["SDT"];
            this.Tennhacc = row["TenNCC"].ToString();

        } 
        private int manhacc;
        private string tennhacc;
        private int sdt;

        public int Manhacc { get => manhacc; set => manhacc = value; }
        public string Tennhacc { get => tennhacc; set => tennhacc = value; }
        public int Sdt { get => sdt; set => sdt = value; }
    }

}
