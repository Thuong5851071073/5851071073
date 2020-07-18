using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Dashboard_Modern.DAO
{
   public class Hoadondao
    {
        private static Hoadondao insinstance;
        public static Hoadondao Instance
        {
            get
            {
                if (insinstance == null) insinstance = new Hoadondao();

                return Hoadondao.insinstance;
            }

            private set { Hoadondao.insinstance = value; }
              
    }
        private Hoadondao() { }

        public void GetIDHD()
        {
            string sql = string.Format("SELECT IDhoadon FROM dbo.HoaDon");
            DataProvider.Instance.ExecuteQuery(sql);
        }

        //INSERT HOA DON:
        public void insertHoaDon(int idKhach, string tinhTrang, int idUser)
        {
            string query = string.Format("INSERT dbo.HoaDon(NgayLap,IDkhach,TongTien,Tinhtrang,manguidung)VALUES(GETDATE(),{0},0,N'{1}',{2})", idKhach, tinhTrang, idUser);
              DataProvider.Instance.ExecuteNonQuery(query);
        }
        //Update BILL:
        public void DAO_updateBill(int tongTien,int idBill)
        {
            string queryUpdateBill = string.Format("UPDATE dbo.HoaDon SET TongTien ={0} WHERE IDhoadon ={1}", tongTien, idBill);
            DataProvider.Instance.ExecuteQuery(queryUpdateBill);
        }
        public DataTable layhoadon()
        {
            string sql = "SELECT * FROM dbo.HoaDon";
            DataTable data = DataProvider.Instance.ExecuteQuery(sql);
            return data;
        }
        public void tinhtongdanhthu(DateTime ngay1 ,DateTime ngay2)
        {
            string sql = "SELECT  SUM(TongTien)FROM   dbo.HoaDon WHERE   NgayLap BETWEEN '" + ngay1 + "' AND '" + ngay2 + "'";
            DataProvider.Instance.ExecuteQuery(sql);
        }
        public DataTable layngay(DateTime ngay1,DateTime ngay2,int manguoidung)
        {
            string sql = "SELECT* FROM dbo.HoaDon WHERE NgayLap BETWEEN '" + ngay1 + "' AND '" + ngay2 + "'AND manguidung='"+manguoidung+"'";
            DataTable data= DataProvider.Instance.ExecuteQuery(sql);
            return data;
        }
         public DataTable inhadon(int ma)
        {
            string sql = string.Format("SELECT TongTien,Tinhtrang FROM dbo.HoaDon WHERE IDhoadon = "+ma+" ");
            DataTable data = DataProvider.Instance.ExecuteQuery(sql);

            return data;
        }
        public DataTable loadThongKe(int NgayLap)
        {
            string sql = string.Format("SELECT MONTH(NgayLap) AS NgayLap,SUM(TongTien) AS Tongtien FROM dbo.HoaDon  WHERE (YEAR(NgayLap))='"+NgayLap+"'  GROUP  BY NgayLap");
            DataTable data = DataProvider.Instance.ExecuteQuery(sql);
            return data;
        }
        public DataTable LoadThongkeTheoNam()
        {
            string sql = string.Format("SELECT YEAR(NgayLap) AS NgayLap,SUM(TongTien) AS Tongtien FROM dbo.HoaDon   GROUP  BY NgayLap");
            DataTable data = DataProvider.Instance.ExecuteQuery(sql);
            return data; 
        }
        public DataTable ShowHoadon()
        {
            string sql = "SELECT * FROM dbo.HoaDon";
            DataTable data = DataProvider.Instance.ExecuteQuery(sql);
            return data;
        }

    }
}


