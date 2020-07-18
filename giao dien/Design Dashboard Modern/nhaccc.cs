using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Design_Dashboard_Modern.DAO;

namespace Design_Dashboard_Modern
{
    public partial class nhaccc : UserControl
    {
        public nhaccc()
        {
            InitializeComponent();
            load();
        }

        #region METHOD:
        #region METHOD-LOAD-DATA:

        void load()
        {
            datanhacc.DataSource = nhaccDAO.Instance.lanhacc();
        }

        #endregion

        #endregion

        #region EVENT:

        #region EVENT-HIDE:

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        #endregion

        #region EVENT-ADD-DATA:

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (txttennhacc.Text!=""&&txtsdt.Text!="")
            {
            string sql = string.Format("INSERT INTO dbo.NhaCungCap(TenNCC, SDT)VALUES(   N'"+txttennhacc.Text+"',"+txtsdt.Text+"  ) ");
            DataProvider.Instance.ExecuteQuery(sql);
            MessageBox.Show("Thêm Thành Công");
            load();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập dữ liệu!");
            }          
        }

        #endregion

        #region EVENT-HIDE-TEXT:

        private void txttennhacc_Enter(object sender, EventArgs e)
        {
            if (txttennhacc.Text== "Tên Nhà Cung Cấp")
            {
                txttennhacc.Text = "";
            }
        }

        private void txttennhacc_Leave(object sender, EventArgs e)
        {
            if (txttennhacc.Text == "")
            {
                txttennhacc.Text = "Tên Nhà Cung Cấp";
            }
        }

        private void txtsdt_Enter(object sender, EventArgs e)
        {
            if (txtsdt.Text == "Số Điện Thoại")
            {
                txtsdt.Text = "";
            }
        }

        private void txtsdt_Leave(object sender, EventArgs e)
        {
            if (txtsdt.Text == "")
            {
                txtsdt.Text = "Số Điện Thoại";
            }
        }

        #endregion

        #endregion
    }
}
