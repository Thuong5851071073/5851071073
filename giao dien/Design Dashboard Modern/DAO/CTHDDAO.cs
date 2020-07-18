using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Dashboard_Modern.DAO
{
    public class CTHDDAO
    {

        private static CTHDDAO instance;

        public static CTHDDAO Instance
        {
            get { if (instance == null) instance = new CTHDDAO(); return CTHDDAO.instance; }
            private set { CTHDDAO.instance = value; }
        }
        public CTHDDAO()
        {

        }
        public DataTable InsertChiTietBill(int idHang, int idBill, int soLuong, int Price, int thanhTien, int STT)
        {
            string query = string.Format("INSERT dbo.CTHD(IDhang,IDhoadon,SoLuong,Gia,Thanhtien,sothutu)VALUES({0},{1},{2},{3},{4},{5})", idHang, idBill, soLuong, Price, thanhTien, STT);
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            return result;
        }
        public DataTable LISTSPCHON()
        {
            string sql = string.Format("SELECT * FROM dbo.CTHD");
            DataTable resuft = DataProvider.Instance.ExecuteQuery(sql);
            return resuft;

        }
        public DataTable XoaCTHD()
        {
            string sql = string.Format("DELETE FROM dbo.CTHD");
            DataTable resuft = DataProvider.Instance.ExecuteQuery(sql);
            return resuft;
        }
        public int tinhtongtien(int idhaodon)
        {
            string sql = string.Format("SELECT SUM( Thanhtien) AS N'Tổng Tiền' FROM dbo.CTHD  WHERE IDhoadon='" + idhaodon + "'");
            int result = (int)  DataProvider.Instance.ExecuteScalar(sql);
            return result;
        }
        public DataTable Xoasp(int idhang)
        {
            string sql = string.Format("DELETE FROM dbo.CTHD WHERE IDhang='"+idhang+"'");
            DataTable resuft = DataProvider.Instance.ExecuteQuery(sql);
            return resuft;
        }

        public int upDateSoLuong(int soLuong, int idHang)
        {
            string query = string.Format(" UPDATE dbo.CTHD SET SoLuong = {0} WHERE IDhang = {1}", soLuong, idHang);
            int result = (int)DataProvider.Instance.ExecuteScalar(query);
            return result;
        }
        public int checkHangTrongCTHD(int idhang,int idhd)
        {
            string query = string.Format("SELECT COUNT(*) FROM dbo.CTHD WHERE IDhang={0} AND IDhoadon ={1} ", idhang,idhd);
            int result = (int)DataProvider.Instance.ExecuteScalar(query);
            return result;
        }
        public int UpdateSoLuongCapNhat(int idhang,int idhd)
        {
            string query1 = string.Format("SELECT SUM(SoLuong) FROM dbo.CTHD WHERE IDhang = {0} AND IDhoadon={1}", idhang,idhd);
            int result = (int)DataProvider.Instance.ExecuteScalar(query1);
            return result;
        }
        public void deleteDuLieuThua(int idhang, int idhoadon)
        {
            string query = string.Format("DELETE FROM dbo.CTHD WHERE IDhang={0} AND IDhoadon ={1}", idhang, idhoadon);
            DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
   
