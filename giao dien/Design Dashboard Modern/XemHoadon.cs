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
    public partial class XemHoadon : UserControl
    {
        public XemHoadon()
        {
            InitializeComponent();
           
        }

        private void XemHoadon_Load(object sender, EventArgs e)
        {
            datahoadon.DataSource = Hoadondao.Instance.layhoadon();
            setup_DTGV(datahoadon);
            //datahoadon.DataSource = txttimkiem.Text;

        }

        #region Method_setup_DTGV:
        private void setup_DTGV(DataGridView dtgv)
        {
            //CHANGE SIZE DTGV:
            for (int i = 0; i < dtgv.Columns.Count; i++)
            {
                dtgv.AllowUserToResizeColumns = true;
                dtgv.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dtgv.Columns[i].Resizable = DataGridViewTriState.True;
            }
            dtgv.RowsDefaultCellStyle.BackColor = Color.FromArgb(12, 7, 21);
            dtgv.BackgroundColor = Color.FromArgb(30, 30, 46);
            dtgv.ForeColor = Color.Yellow;
        }
        #endregion

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM dbo.HoaDon WHERE Tinhtrang LIKE N'%" + textBox1.Text + "%'";
            datahoadon.DataSource = DataProvider.Instance.ExecuteQuery(sql);
        }
    }
}
