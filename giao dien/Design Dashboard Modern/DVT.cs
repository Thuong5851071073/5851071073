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
    public partial class DVT : UserControl
    {
        public DVT()
        {
            InitializeComponent();
            loadData();
        }

        void loadData()
        {

            dtdvt.DataSource = DVTDAO.Instance.laydvt();

        }
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

            try
            {
                string name = tbxNameDVT.Text;
              int soluong = Convert.ToInt32(soLuongDVT.Text);
           
                if (tbxNameDVT.Text != "Tên gói đơn vị tính" && DVTDAO.Instance.checkTrungLap(name,soluong)==0)
                {
                    DVTDAO.Instance.insertDataDVT(name, soluong);
                    MessageBox.Show("Thêm đơn vị tính thành công");
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập tên đơn vị tính,hoặc bị trùng dữ liệu!");
                }
            }catch(Exception)
            {
                MessageBox.Show("Vui lòng nhập số lượng và số lượng phải là số");
            }
            loadData();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void soLuongDVT_Enter(object sender, EventArgs e)
        {
            if(soLuongDVT.Text== "Số lượng đơn vị tính")
            {
                soLuongDVT.Text ="";
            }
        }

        private void soLuongDVT_Leave(object sender, EventArgs e)
        {
            if (soLuongDVT.Text == "")
            {
                soLuongDVT.Text = "Số lượng đơn vị tính";
            }
        }

        private void tbxNameDVT_Enter(object sender, EventArgs e)
        {
            if (tbxNameDVT.Text == "Tên gói đơn vị tính")
            {
                tbxNameDVT.Text ="";
            }

        }

        private void tbxNameDVT_Leave(object sender, EventArgs e)
        {
            if (tbxNameDVT.Text == "")
            {
                tbxNameDVT.Text = "Tên gói đơn vị tính";
            }
        }

        private void dtdvt_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxNameDVT.Text = dtdvt.CurrentRow.Cells[1].Value.ToString();
            soLuongDVT.Text = dtdvt.CurrentRow.Cells[2].Value.ToString();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            string name = tbxNameDVT.Text;
            int soluong = Convert.ToInt32(soLuongDVT.Text);
            try
            { 
                DVTDAO.Instance.deleteDVT(name, soluong);
                MessageBox.Show("Xóa đơn vị tính thành công!");
            }
            catch (Exception)
            {
                MessageBox.Show("Xóa đơn vị tính thất bại!");
            }
            loadData();
        }

        private void dtdvt_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
