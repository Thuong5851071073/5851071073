using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Design_Dashboard_Modern.DTO;
namespace Design_Dashboard_Modern.DAO
{
   public class PhieuxuatDAO
    {
        private static PhieuxuatDAO insinstance;
        public static PhieuxuatDAO Instance
        {
            get { if (insinstance == null) insinstance = new PhieuxuatDAO();

              return PhieuxuatDAO.insinstance; }

            private set { PhieuxuatDAO.insinstance = value; }

        }
        public static int TableWidth = 90;
        public static int TableHeight = 90;
      

        private PhieuxuatDAO() { }

       public bool InsertPX(int Tongtien,int IDKhach, string Tinhtrang, int manguoidung)
        {

            string queryInsertPX = string.Format("INSERT INTO dbo.PhieuXuat(Tongtien, IDKhach, NgayLap,Tinhtrang, manguoidung) " +
                                                     "VALUES({0} , {1}, GETDATE(), N'{2}',{3})", Tongtien,IDKhach,Tinhtrang,manguoidung);

            int result = DataProvider.Instance.ExecuteNonQuery(queryInsertPX);
            return result > 0;
        }

        
       
    }
}
