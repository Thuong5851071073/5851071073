using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Design_Dashboard_Modern.DTO;
using System.Data;
namespace Design_Dashboard_Modern.DAO
{
    public class CTPXDAO
    {
        private static CTPXDAO instance;

        public static CTPXDAO Instance
        {
            get { if (instance == null) instance = new CTPXDAO(); return CTPXDAO.instance; }
            private set { CTPXDAO.instance = value; }
        }

        private CTPXDAO() { }

        public List<CTPXDTO> GetCTPXbangmaphieuxuat(string maphieuxuat)
        {
            List<CTPXDTO> list = new List<CTPXDTO>();

            string query = " SELECT PhieuXuat.IDphieuxuat,Sanpham.IDhang, Sanpham.TenHang,SoLuong,Donvitinh,HangHoaTheonam.Gia,Thanhtien=( SoLuong*HangHoaTheonam.Gia) FROM dbo.CTPX INNER JOIN dbo.Sanpham ON Sanpham.IDhang = CTPX.IDhang INNER JOIN dbo.PhieuXuat ON PhieuXuat.IDphieuxuat = CTPX.IDphieuxuat  INNER JOIN dbo.HangHoaTheonam ON HangHoaTheonam.IDhang = Sanpham.IDhang WHERE PhieuXuat.IDphieuxuat='" + maphieuxuat + "'";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                CTPXDTO CTPXBan = new CTPXDTO(item);
                list.Add(CTPXBan);
            }

            return list;
        }

     
    }
    
}
