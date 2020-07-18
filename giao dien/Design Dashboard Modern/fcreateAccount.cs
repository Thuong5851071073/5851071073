using Design_Dashboard_Modern.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Design_Dashboard_Modern
{
    public partial class fcreateAccount : Form
    {
        public fcreateAccount()
        {
            InitializeComponent();
        }
        #region Method:

        #region medthodAddAccount:

        void addAcount(string gmail, string userName, string haspass, string Position, string Address, string phoneNumber)
        {
            try {
                #region addAccount:
                if (AccountDAO.Instance.DAO_LayIdUser(gmail) == 1)
                {
                    MessageBox.Show("Tài Khoản đã tồn tại , vui lòng nhập tên gmail khác ");
                }
                else if (AccountDAO.Instance.DAO_LayIdUser(gmail) == 0 && gmail != "" && userName != "" && haspass != "" && Position != "" && Address != "" && phoneNumber != "" && AccountDAO.Instance.DAO_insertAccount(gmail, userName, haspass, Position, Address, phoneNumber))
                {


                    MessageBox.Show("Thêm tài khoản thành công");
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Tài Khoản đã tồn tại , vui lòng nhập tên gmail khác ");
            }
            
          
            #endregion
        }

        #endregion

        #endregion

        #region EVENT:

        #region EVENT CLOSE FORM:

        private void fcreateAccount_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn rời khỏi đây", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
        private void btnCancle_Click_1(object sender, EventArgs e)
        {
            this.Close();

        }
        #endregion

        private static bool IsNumber(string val)
        {
            if (val != "")
                return Regex.IsMatch(val, @"^[0-9]\d*\.?[0]*$");
            else return true;
        }
        #region EVENT CREATE ACCOUNT:
        private void btnCreateAccount_Click_1(object sender, EventArgs e)
        {

            //Dữ Liệu Truyền Vào:
            string haspass = "";
            //CHECK LỖI:
         


                if (tbxGmail.Text != "" )
                {
                    string gmail = tbxGmail.Text;
                   

                    if (tbxPassWord.Text != "")
                    {
                        string passWork = tbxPassWord.Text;
                        try
                        {
                            if (passWork != null)
                            {
                                byte[] temp = ASCIIEncoding.ASCII.GetBytes(passWork);
                                byte[] hasdata = new MD5CryptoServiceProvider().ComputeHash(temp);
                                foreach (byte item in hasdata)
                                {
                                    haspass += item;
                                }
                            }
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Lỗi mã hóa");
                        }

                        if (tbxUserName.Text != "")
                        {
                            string userName = tbxUserName.Text;

                            if (tbxPosition.Text != "")
                            {
                                string Position = tbxPosition.Text;

                                if(tbxAddress.Text != "")
                                {
                                    string Address = tbxAddress.Text;
                                    if (tbxPhoneNumber.Text != "")
                                    {
                                        string phoneNumber = tbxPhoneNumber.Text;
                                        //ADD ACCOUNT:
                                        addAcount(gmail, userName, haspass, Position, Address, phoneNumber);
                                    }
                                    else
                                    {
                                        MessageBox.Show("bạn chưa nhập số điện thoại");
                                    }
                                  
                                }
                                else
                                {
                                    MessageBox.Show("bạn chưa nhập địa chỉ");
                                }

                            }
                            else
                            {
                                MessageBox.Show("bạn chưa nhập Quyền");
                            }
                        }
                        else
                        {
                            MessageBox.Show("bạn chưa nhập tên người dùng");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Bạn chưa nhập Mật Khẩu");


                    }
                }
                else
                {
                    MessageBox.Show("Bạn chưa nhập Gmail");


                }

        }
      
        #endregion

        #region EVENT HIDE TEXT:
        private void tbxGmail_Enter_1(object sender, EventArgs e)
        {
            
                tbxGmail.Text = "";
            
        }
        private void tbxGmail_Leave_1(object sender, EventArgs e)
        {

            if (tbxGmail.Text == "")
            {
                tbxGmail.Text = "TÊN ĐĂNG NHẬP (GMAIL)";
            }
        }
        private void tbxUserName_Enter_1(object sender, EventArgs e)
        {

           
            {
                tbxUserName.Text = "";
            }
        }
        private void tbxUserName_Leave_1(object sender, EventArgs e)
        {
            if (tbxUserName.Text == "")
            {
                tbxUserName.Text = "TÊN NGƯỜI DÙNG";
            }
        }
        private void tbxPassWord_Enter_1(object sender, EventArgs e)
        {
           
            {
                tbxPassWord.Text = "";
            }
            tbxPassWord.UseSystemPasswordChar = true;
        }
        private void tbxPassWord_Leave_1(object sender, EventArgs e)
        {

            if (tbxPassWord.Text == "")
            {
                tbxPassWord.UseSystemPasswordChar = false;
                tbxPassWord.Text = "MẬT KHẨU";
            }
        }
        private void tbxPosition_Enter_1(object sender, EventArgs e)
        {
        
            {
                tbxPosition.Text = "";
            }
        }

        private void tbxPosition_Leave(object sender, EventArgs e)
        {
            if (tbxPosition.Text == "")
            {
                tbxPosition.Text = "QUYỀN HẠN";
            }
        }


        private void tbxAddress_Enter(object sender, EventArgs e)
        {
         
            {
                tbxAddress.Text = "";
            }
        }
        private void tbxAddress_Leave(object sender, EventArgs e)
        {
            if (tbxAddress.Text == "")
            {
                tbxAddress.Text = "ĐỊA CHỈ";
            }
        }
        private void tbxPhoneNumber_Enter_1(object sender, EventArgs e)
        {
          
            {
                tbxPhoneNumber.Text = "";
            }
        }

        private void tbxPhoneNumber_Leave(object sender, EventArgs e)
        {
            if (tbxPhoneNumber.Text == "")
            {
                tbxPhoneNumber.Text = "SỐ ĐIỆN THOẠI";
            }
        }
        private void tbxPhoneNumber_TextChanged(object sender, EventArgs e)
        { 
              if (IsNumber(tbxPhoneNumber.Text) != true)
            {
                MessageBox.Show("Dữ liệu nhập không hợp lệ, không được nhập ký tự", "Thông báo");
                tbxPhoneNumber.Text = "";
            }
        }

        #endregion

        #endregion




    }
}
