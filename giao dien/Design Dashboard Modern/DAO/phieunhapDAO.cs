using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Dashboard_Modern.DAO
{
    public class phieunhapDAO
    {
        private static phieunhapDAO instance;

        public static phieunhapDAO Instance
        {
            get { if (instance == null) instance = new phieunhapDAO(); return phieunhapDAO.instance; }
            private set { phieunhapDAO.instance = value; }
        }
        public phieunhapDAO()
        {

        }

        public bool insertPhieuNhap(int idNCC,string tinhTrang,int idUser)
        {
           string ngayLap = "GETDATE()";
           int tongTien = 0;
            string SQL = string.Format("INSERT dbo.PhieuNhap(IDnhacc,Ngaylap,Tongtien,Tinhtrang,manguidung)VALUES({0},{1},{2},N'{3}',{4})", idNCC,ngayLap,tongTien,tinhTrang,idUser);
             int result =DataProvider.Instance.ExecuteNonQuery(SQL);
            return result > 0;
        }
        
        //Chi tiet phieu nhập:
        //thêm vào bảng CTPN:
        public bool insertCTPN(int idHang,int idPhieuNhap,int soLuong,int gia,int thanhTien,int soDVT)
        {
            string query = string.Format("INSERT dbo.CTPN(IDhang,IDphieunhap, SoLuong, Gia, ThanhTien, sothutu)VALUES({0},{1},{2},{3},{4},{5})", idHang, idPhieuNhap, soLuong, gia, thanhTien, soDVT);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result>0;
        }
        //Lấy dữ liệu chi tiết phiếu nhập:
        public DataTable getDataCTPN(int idPhieuNhap)
        {
            string query = string.Format("SELECT * FROM dbo.CTPN WHERE IDphieunhap ={0}",idPhieuNhap);
            return DataProvider.Instance.ExecuteQuery(query);
        }
        //Kiem tra hàng nhập có trùng không
        public int checkSoluongNhap(int idHang,int idPhieuNhap)
        {
            string query = string.Format("SELECT COUNT(*) FROM dbo.CTPN WHERE IDhang ={0} AND IDphieunhap ={1}",idHang,idPhieuNhap);
            int result = (int)DataProvider.Instance.ExecuteScalar(query);
            return result;
        }
        //Tinh tong so lượng trùng IDHANG:
        public int soLuongCapNhat(int idHang,int idPhieuNhap)
        {
            string query = string.Format("SELECT SUM(SoLuong) FROM dbo.CTPN  WHERE IDhang ={0} AND IDphieunhap = {1}", idHang, idPhieuNhap);
            int result =(int) DataProvider.Instance.ExecuteScalar(query);
            return result;
        }
        //Xóa dữ liệu thừa
        public void deleteDuLieuThua(int idhang, int idPhieuNhap)
        {
            string query = string.Format("DELETE FROM dbo.CTPN WHERE IDhang ={0} AND IDphieunhap = {1}", idhang, idPhieuNhap);
            DataProvider.Instance.ExecuteQuery(query);
        }
        //Xóa dữ liệu trong CTPN:
        public void deleteAll()
        {
            string query = string.Format("DELETE FROM dbo.CTPN ");
            DataProvider.Instance.ExecuteQuery(query);
        }
        public int tinhTongTienPhieuNhap(int idPhieuNhap)
        {
            string query = string.Format("SELECT SUM(ThanhTien) FROM dbo.CTPN WHERE IDphieunhap={0}", idPhieuNhap);
            int result=(int) DataProvider.Instance.ExecuteScalar(query);
            return result;
        }
        public int UpdateTongTienPhieuNhap(int idphieunhap,int tongtien)
        {
            string sql = string.Format("UPDATE  dbo.PhieuNhap SET Tongtien="+tongtien+" WHERE IDphieunhap='"+idphieunhap+"'");
            int result = (int)DataProvider.Instance.ExecuteScalar(sql);
            return result;
        }
        public DataTable loadThongKePhieuNhapTheoThang(int NgayLap)
        {
            string sql = string.Format("SELECT MONTH( Ngaylap) AS NgayLap,SUM(TongTien) AS Tongtien FROM dbo.PhieuNhap   WHERE YEAR(( Ngaylap))='"+NgayLap+"'GROUP BY Ngaylap");
            DataTable data = DataProvider.Instance.ExecuteQuery(sql);
            return data;
        }
        public DataTable LoadThongkePhieuNhapTheoNam()
        {
            string sql = string.Format("SELECT YEAR( Ngaylap) AS NgayLap,SUM(TongTien) AS Tongtien FROM dbo.PhieuNhap  GROUP BY Ngaylap");
            DataTable data = DataProvider.Instance.ExecuteQuery(sql);
            return data;
        }
        public DataTable showPhieuNhap()
        {
            string sql = ("SELECT * FROM dbo.PhieuNhap");
            DataTable data = DataProvider.Instance.ExecuteQuery(sql);
            return data;
        }
    }


}
