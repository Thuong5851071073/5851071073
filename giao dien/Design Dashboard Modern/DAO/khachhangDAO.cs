using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Design_Dashboard_Modern.DTO;

namespace Design_Dashboard_Modern.DAO
{
   public class khachhangDAO
    {
        private static khachhangDAO insinstance;
        public static khachhangDAO Instance
        {
            get
            {
                if (insinstance == null) insinstance = new khachhangDAO();

                return khachhangDAO.insinstance;
            }

            private set { khachhangDAO.insinstance = value; }

        }
        private khachhangDAO() { }
        public List<khachhangDTO>getlistkhachhang()
        {
            List<khachhangDTO> list = new List<khachhangDTO>();

            string query = "   SELECT  IDkhach,TenKhach,SDT,DiaChi FROM dbo.KhachHang ";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                khachhangDTO khachhang = new khachhangDTO(item);
                list.Add(khachhang);
            }

            return list;
        }
        public void ThemKhach(string ten,string diachi,int sdt)
        {
            DataProvider.Instance.ExecuteQuery("EXECUTE dbo.usp_themkhach @tenkhach = N'" + ten + "'," +
                       " @sdt = " + sdt + ",@diachi = N'" + diachi + "'");
        }
        public DataTable laydanhsachkhach()
        {
            string sql = string.Format("SELECT * FROM dbo.KhachHang ");
            DataTable data = DataProvider.Instance.ExecuteQuery(sql);
            return data;
        }
        public DataTable updatesdt(int sdt,int id)
        {
            string sql = string.Format("UPDATE dbo.KhachHang SET SDT='"+sdt+"' WHERE IDkhach='"+id+"'");
            DataTable data = DataProvider.Instance.ExecuteQuery(sql);
            return data;
        }
        public DataTable updateDC(string dc, int id)
        {
            string sql = string.Format("UPDATE dbo.KhachHang SET DiaChi='" +dc+ "' WHERE IDkhach='"+id+"'");
            DataTable data= DataProvider.Instance.ExecuteQuery(sql);
            return data;
        }

    }
}
