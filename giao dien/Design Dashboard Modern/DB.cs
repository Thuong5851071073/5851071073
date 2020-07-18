using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Design_Dashboard_Modern
{
    class DB
    {
            // tạo một kết nối
         private   SqlConnection conn = new SqlConnection(@"Data Source=ADMIN;Initial Catalog=QUANLYSIEUTHI;Integrated Security=True");
           // tạo hàm kết nối
        public void openconection()
        {
            if (conn.State == System.Data.ConnectionState.Closed)
            {
                conn.Open();
            }
        }
        //tạo hàm tắt kết nối
        public void closeconnection()
        {
            if (conn.State == System.Data.ConnectionState.Open)
            {
                conn.Close();
            }
        }
        //tao ham trả về kết nối
        public SqlConnection GetConnection()
        {
            return conn;
        }


    }
}
