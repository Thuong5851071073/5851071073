using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Dashboard_Modern.DAO
{
   public class nhaccDAO

    {
        private static nhaccDAO instance;

        public static nhaccDAO Instance
        {
            get { if (instance == null) instance = new nhaccDAO(); return nhaccDAO.instance; }
            private set { nhaccDAO.instance = value; }
        }

        private nhaccDAO() { }

        public DataTable lanhacc()
        {
            string query = "		SELECT * FROM dbo.NhaCungCap ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }
    }
}
