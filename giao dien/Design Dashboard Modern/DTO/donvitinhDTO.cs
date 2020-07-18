using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace Design_Dashboard_Modern.DTO
{
  public  class donvitinhDTO
    {
        public donvitinhDTO(int sothutu, string tengoidonvi, int soluongdonvi)
        {
            this.Sothutu = sothutu;
            this.Tengoidonvi = tengoidonvi;
            this.Soluongdonvi = soluongdonvi;
        }
        public donvitinhDTO(DataRow row)
        {
            this.Sothutu = (int)row["Sothutu"];
           
            this.Tengoidonvi = row["Tengoidonvi"].ToString();
            this.Soluongdonvi = (int)row["soluongdonvi"];
           
        }
        private int sothutu;
        private string tengoidonvi;
        private int soluongdonvi;

        public int Sothutu { get => sothutu; set => sothutu = value; }
        public string Tengoidonvi { get => tengoidonvi; set => tengoidonvi = value; }
        public int Soluongdonvi { get => soluongdonvi; set => soluongdonvi = value; }
    }
}
