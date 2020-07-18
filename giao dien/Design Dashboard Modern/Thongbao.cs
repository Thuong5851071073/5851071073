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
    public partial class Thongbao : UserControl
    {
        public Thongbao()
        {
            InitializeComponent();
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {

        }

        void loadsanphamhethan()
        {
            Dtsanphamhethan.DataSource = sanphamDAO.Instance.ThongbaoSanPhamHetHan();
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
            dtgv.RowsDefaultCellStyle.BackColor = Color.White;
            dtgv.BackgroundColor = Color.White;
            dtgv.ForeColor = Color.Black;
        }
        #endregion EVENT-LOAD-GIAODIEN:
        private void Thongbao_Load(object sender, EventArgs e)
        {
            dtsp.DataSource = sanphamDAO.Instance.thongbaosplay();
            loadsanphamhethan();
            setup_DTGV(dtsp);
            setup_DTGV(Dtsanphamhethan);
        }

        private void dtsp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idhang.Text=dtsp.CurrentRow.Cells[0].Value.ToString();
            txttenhang.Text = dtsp.CurrentRow.Cells[1].Value.ToString();
            txtsl.Text = dtsp.CurrentRow.Cells[4].Value.ToString();
            textBox1.Text= dtsp.CurrentRow.Cells[5].Value.ToString();
            MessageBox.Show("Bạn cần lấy hàng này về !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Dtsanphamhethan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idhang.Text = dtsp.CurrentRow.Cells[0].Value.ToString();
            txttenhang.Text = dtsp.CurrentRow.Cells[1].Value.ToString();
            txtsl.Text = dtsp.CurrentRow.Cells[4].Value.ToString();
            textBox1.Text = dtsp.CurrentRow.Cells[5].Value.ToString();
            MessageBox.Show("hàng đã hết hạn !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
