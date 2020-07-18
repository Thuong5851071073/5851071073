using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Design_Dashboard_Modern.DAO;


namespace Design_Dashboard_Modern
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }
        #region Biến tĩnh:

        public static string showname;
        public static int showIDuser;

        #endregion

        #region METHOD:

        #region METHOD CHECK USER+PASSWORD:
        public bool Login(string username, string pass)
        {
            return AccountDAO.Instance.DAODangNhap(username, pass);
        }
        #endregion

        #endregion

        #region EVENT:

        #region EVENT CLOSE FORM:
        private void btthoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btxExit_Click_1(object sender, EventArgs e)
        {

            Application.Exit();

        }
        private void DangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
        #endregion

        #region EVENT- HIDE-TEXT:

        private void txtgmail_Enter(object sender, EventArgs e)
        {
            if (txtgmail.Text== "username")
            {
                txtgmail.Text = "";
            }
        }
        private void txtgmail_Leave(object sender, EventArgs e)
        {
            if(txtgmail.Text=="")
            {
                txtgmail.Text = "username";
            }
        }
        private void txtpass_Enter(object sender, EventArgs e)
        {
            if(txtpass.Text== "passwork")
            {
                txtpass.Text = "";
            }
            txtpass.UseSystemPasswordChar = false;

        }
        private void txtpass_Leave(object sender, EventArgs e)
        {
            if(txtpass.Text=="")
            {
                txtpass.Text = "passwork";
                txtpass.UseSystemPasswordChar = true;
            }
        }

        #endregion

        #endregion
        #region Event_Panner_ Trông suốt;
        private void DangNhap_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }
        #endregion;
        #region EVENT-Đăng nhập:
        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            string userName = txtgmail.Text;
            string passWord = txtpass.Text;
            if (Login(userName, passWord))
            {
                showname = txtgmail.Text;
                showIDuser = AccountDAO.Instance.Dao_showIDuser(userName);
                Menu fmenu = new Menu(userName);
                this.Hide();
                fmenu.ShowDialog();
                this.Show();
              
                txtpass.Text = "";
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!");
            }

        }
        #endregion
        #region EVENT- Mở FORM CHANGE-PASSWORD:
        private void button1_Click_1(object sender, EventArgs e)
        {
            DOIMK d = new DOIMK();
            this.Hide();
            d.ShowDialog();
            this.Show();
        }
        #endregion
        #region EVENT- Mở FORM CREATE-PASSWORD:
        private void btnCreatePassWord_Click_1(object sender, EventArgs e)
        {
            fcreateAccount createAccount = new fcreateAccount();
            this.Hide();
            createAccount.ShowDialog();
            this.Show();
            txtgmail.Text = "";
            txtpass.Text = "";
           
        }
        #endregion

       
    }
}
