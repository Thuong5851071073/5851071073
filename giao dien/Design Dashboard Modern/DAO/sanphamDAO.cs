using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Design_Dashboard_Modern.DTO;

namespace Design_Dashboard_Modern.DAO
{
    public class sanphamDAO
    {
        private static sanphamDAO instance;

        public static sanphamDAO Instance
        {
            get { if (instance == null) instance = new sanphamDAO(); return sanphamDAO.instance; }
            private set { sanphamDAO.instance = value; }


        }
        public sanphamDAO()
        {

        }
      
        //SHOW ALL:
            public DataTable GetlistSP()
            {
                string mahang = "Mã hàng";
                string tenhang = "Tên hàng hóa";
                string loaihang = "Loại hàng";
                string thetich = "Thể tích";
                string hinhanh = "Hình ảnh hàng hóa";
                string soluongtrongkho = "Số lượng tồn kho";
                string idnhacccc = "Mã nhà cung cấp";
                string giavons = "Giá Vốn";
                string madvt = "Mã đơn vị tính";
                string giaban = "Giá bán";
                string ngaysx="Ngày Sản Xuất ";
                string NgayHetHan = "Ngày Hết Hạn";
                string query = string.Format("SELECT IDhang AS [{0}],TenHang AS [{1}], Loaihang AS [{2}], TheTich AS [{3}],PICTURE as [{4}], Soluongthungtrongkho as [{5}], IDnhacc AS [{6}],GiaVon AS [{7}], sothutu AS [{8}], Giaban AS [{9}] , NgaySX AS[{10}] , NgayHetHan AS[{11}] FROM  dbo.Sanpham", mahang, tenhang, loaihang, thetich, hinhanh, soluongtrongkho, idnhacccc, giavons, madvt, giaban,ngaysx,NgayHetHan);
                DataTable data = DataProvider.Instance.ExecuteQuery(query);   
                return data;
        }
        public DataTable Laydanhsachsanpham()
        {
            string mahang = "Mã hàng";
            string tenhang = "Tên hàng hóa";
            string loaihang = "Loại hàng";
            string thetich = "Thể tích";
            string hinhanh = "Hình ảnh hàng hóa";
            string soluongtrongkho = "Số lượng tồn kho";
            string idnhacccc = "Mã nhà cung cấp";
            string giavons = "Giá Vốn";
            string madvt = "Mã đơn vị tính";
            string giaban = "Giá bán";
         
            string query = string.Format("SELECT IDhang AS [{0}],TenHang AS [{1}], Loaihang AS [{2}], TheTich AS [{3}],PICTURE as [{4}], Soluongthungtrongkho as [{5}], IDnhacc AS [{6}],GiaVon AS [{7}], sothutu AS [{8}], Giaban AS [{9}] FROM  dbo.Sanpham", mahang, tenhang, loaihang, thetich, hinhanh, soluongtrongkho, idnhacccc, giavons, madvt, giaban);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }
        public void ThemDuLieu(string tenHang,string theTich,byte Picture, int soluongtrongkho,int idncc,int giavon,int sodonvitinh,int giaban,string loaihang ,string ngaysx, string ngayhethan)
        {
            string query = string.Format("INSERT INTO  dbo.Sanpham(TenHang,TheTich, PICTURE,Soluongthungtrongkho, IDnhacc, GiaVon, sothutu, Giaban, Loaihang, NgaySX,NgayHetHan)VALUES(   N'{0}', N'{1}', {2},  {3}, {4}, {5},  {6},  {7}, N'{8}', '{9}', '{10}' )",
                tenHang, theTich, Picture, soluongtrongkho, idncc, giavon, sodonvitinh, giaban, loaihang, ngaysx, ngayhethan);
            DataProvider.Instance.ExecuteQuery(query);
            
        }
        public void xoaSp(int id)
        {
            string query = string.Format("DELETE dbo.Sanpham  WHERE IDhang='{0}'", id);
            DataProvider.Instance.ExecuteNonQuery(query);
        }
      
        public DataTable thongbaosplay()
        {
            string sql = string.Format(" SELECT * FROM dbo.Sanpham WHERE Soluongthungtrongkho<5");
            DataTable data= DataProvider.Instance.ExecuteQuery(sql);
            return data;
        }
       
        public void upDateSoLuong(int soluongTrongBangSanPham, int idhang)
        { 
            string queryUpDate = string.Format("UPDATE dbo.Sanpham SET Soluongthungtrongkho={0} WHERE IDhang={1}",soluongTrongBangSanPham,idhang);
            DataProvider.Instance.ExecuteQuery(queryUpDate);
        }
        public int GetSoLuongSP(int idhang)
        {
            string query = string.Format("SELECT Sum(Soluongthungtrongkho) FROM dbo.Sanpham WHERE IDhang ={0}", idhang);
            int result = (int)DataProvider.Instance.ExecuteScalar(query);
            return result;
        }
        public DataTable ThongbaoSanPhamHetHan()
        {
            string sql = string.Format("SELECT  *  FROM dbo.Sanpham WHERE   (GETDATE()>=(NgayHetHan))");
            DataTable data=DataProvider.Instance.ExecuteQuery(sql);
            return data;
        }

    }
}
