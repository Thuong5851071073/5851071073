using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Design_Dashboard_Modern.DAO
{
    class AccountDAO
    {
        private static AccountDAO instance;
        public static AccountDAO Instance
        {
            get
            {
                if (instance == null) instance = new AccountDAO();
                return instance;
            }
            private set
            {
                instance = value;
            }

        }
        private AccountDAO() { }
        public bool DAODangNhap(String Name, String pass)
        {
            byte[] temp = ASCIIEncoding.ASCII.GetBytes(pass);
            byte[] hasdata = new MD5CryptoServiceProvider().ComputeHash(temp);
            string haspass = "";
            foreach (byte item in hasdata)
            {
                haspass += item;
            }
            string querydangnhap = "EXEC dbo.proc_dangnhap @userGmail , @passWork ";
            DataTable resulf = DataProvider.Instance.ExecuteQuery(querydangnhap, new object[] { Name, haspass });
            return resulf.Rows.Count > 0;
        }
        public bool DAO_insertAccount(string gmail, string userName, string haspass, string Position, string Address, string phoneNumber)
        {
            string queryInsertAccount = string.Format("INSERT INTO dbo.nguoidung(gmail , Tennguoidung , Matkhau , Quyenhan , Diachi , SDT) " +
                                                    "VALUES(N'{0}' , N'{1}' , '{2}' , N'{3}' , N'{4}', {5})", gmail, userName, haspass, Position, Address, phoneNumber);

            int result = DataProvider.Instance.ExecuteNonQuery(queryInsertAccount);
            return result > 0;

        }

        public bool DAO_updateAccount(string newPassWord, string gmail)
        {

            string queryUpdateAccount = string.Format("UPDATE dbo.nguoidung SET Matkhau='{0}' WHERE gmail = '{1}'", newPassWord, gmail);
            int result = DataProvider.Instance.ExecuteNonQuery(queryUpdateAccount);
            return result > 0;
        }
        public bool  DAO_CHECKMK( string gmail, string oldpass)
        {
            byte[] temp = ASCIIEncoding.ASCII.GetBytes(oldpass);
            byte[] hasdata = new MD5CryptoServiceProvider().ComputeHash(temp);
            string haspass = "";
            foreach (byte item in hasdata)
            {
                haspass += item;
            }

            string query = string.Format("SELECT  COUNT(gmail) FROM dbo.nguoidung WHERE gmail= '"+gmail+"' AND Matkhau ='"+haspass+"'");//EXEC dbo.USP_CHECKMK @gmailnhap = N'{0}' ,@oldpass = '{1}'
            object resuft = DataProvider.Instance.ExecuteScalar(query);
            if ((int)resuft == 1)
                return true;
            else
                return false;
        }

        public void DAo_laytegmail(string gmail, string mk)
        {
            string qureygetgmail = string.Format("SELECT  gmail,Matkhau FROM dbo.nguoidung WHERE gmail='{0}' AND Matkhau='{1}'", gmail, mk);
            DataProvider.Instance.ExecuteQuery(qureygetgmail);

        }
        public int DAO_LayIdUser(string gmail)

        {
            string qureyGetIdUser = string.Format("SELECT COUNT(gmail) FROM dbo.nguoidung WHERE gmail='{0}'", gmail);
            int result = (int)DataProvider.Instance.ExecuteScalar(qureyGetIdUser);
            return result;

        }
        public int Dao_showIDuser(string gmail)
        {
            string qureyGetIdUser = string.Format("SELECT IDuser FROM dbo.nguoidung WHERE gmail='{0}'", gmail);
            int result = (int)DataProvider.Instance.ExecuteScalar(qureyGetIdUser);
            return result;
        }
        public string getquyen(string tennguoidung)
        {
            string sql = string.Format("SELECT quyenhan FROM dbo.nguoidung WHERE gmail like N'" + tennguoidung + "'");
            string quyen = (string)DataProvider.Instance.ExecuteScalar(sql);
            return quyen;

        }
    }

}
