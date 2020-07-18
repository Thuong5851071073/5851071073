using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Dashboard_Modern.DAO
{
  public  class DVTDAO
    {
        private static DVTDAO instance;
        public static DVTDAO Instance
        {
            get { if (instance == null) instance = new DVTDAO(); return DVTDAO.instance; }
            private set { DVTDAO.instance = value; }
        }
        private DVTDAO()
        {

        }
        public DataTable laytendonvi()
        {
            string query = "SELECT Tengoidonvi FROM  dbo.Donvitinh ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }
        public void insertDataDVT(string tengoiDVT,int soluong )
        {
            string sql = string.Format("INSERT INTO dbo.Donvitinh(Tengoidonvi,soluongdonvi)VALUES(N'{0}',{1})", tengoiDVT, soluong);
            DataProvider.Instance.ExecuteQuery(sql);
        }
        public DataTable laydvt()
        {
            string query = "	SELECT * FROM dbo.Donvitinh ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }
        public void deleteDVT(string tengoidonvi, int soluong)
        {
            string SQL = string.Format("DELETE FROM dbo.Donvitinh WHERE Tengoidonvi=N'{0}' and soluongdonvi={1} ",tengoidonvi,soluong);
            DataProvider.Instance.ExecuteQuery(SQL);
        }
        public int checkTrungLap(string ten,int soluong)
        { 
            string sql= string.Format("SELECT COUNT(*) FROM dbo.Donvitinh WHERE Tengoidonvi=N'{0}' AND soluongdonvi = {1}",ten,soluong);
            int result = (int)DataProvider.Instance.ExecuteScalar(sql);
            return result;
        }
    }
}
