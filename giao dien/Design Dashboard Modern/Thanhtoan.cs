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
using System.IO;
using System.Data.SqlClient;
using DevExpress.XtraReports.UI;

namespace Design_Dashboard_Modern
{
    public partial class Thanhtoan : UserControl
    {
        public Thanhtoan()
        {
            InitializeComponent();
            load();



        }
        #region METHOD:

        #region METHOD-THANH-TOAN:

        void thanhToanHoaDon(int tongTien, int idBill)
        {
            Hoadondao.Instance.DAO_updateBill(tongTien, idBill);
        }

        #endregion


        #region METHOD-LOAD-VAO-CHI-TIET-HOA-DON:

        DataTable loadhangvaochitiethoadon(int idHangg, int idBill, int soLuong, int thanhTien, int Pricee, int STTT)
        {
            DataTable result = CTHDDAO.Instance.InsertChiTietBill(idHangg, idBill, soLuong, Pricee, thanhTien, STTT);
            return result;
        }

        #endregion

        #region METHOD LOAD-NUMBER-BILL:
        void loadBillAdd()
        {
            string queryseletIDHD = "SELECT MAX(IDhoadon) FROM dbo.HoaDon ";
            int dataIDHD = (int)DataProvider.Instance.ExecuteScalar(queryseletIDHD);
            tbxIDbill.Text = dataIDHD.ToString();
        }
        #endregion

        #region METHOD-LOAD-DATA:

        public void load()
        {
            cbTinhTrang.Items.Add("Đã Thanh Toán");
            cbTinhTrang.Items.Add("Chưa Thanh Toán");
            cbTinhTrang.Items.Add("Đang Nợ Nên Ghi Vào Sổ");

            string queryselectIDkhach = "SELECT IDkhach FROM dbo.KhachHang";
            DataTable dataIDkhach = DataProvider.Instance.ExecuteQuery(queryselectIDkhach);

            cbIDcustomer.DataSource = dataIDkhach;
            cbIDcustomer.DisplayMember = "IDkhach";

            //LOAD ID NGUOI DUNG:
            tbxNguoiDung.Text = DangNhap.showname;

        }

        #endregion

        #endregion

        #region EVENT:

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
        #region EVENT-LOAD-GIAODIEN:

        private void Thanhtoan_Load(object sender, EventArgs e)
        {
            dataSP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataSP.RowTemplate.Height = 50;
            dataSP.AllowUserToAddRows = false;
            dataSP.DataSource = sanphamDAO.Instance.GetlistSP();
            setup_DTGV(dataSP);
            setup_DTGV(dtgvCTHD);
        }

        #endregion

        #region EVENT-ADD-BILL:
        private void btnAddBill_Click(object sender, EventArgs e)
        {
            //Bắt lỗi tình trạng và  mã nhân viên:
            if (cbTinhTrang.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn tình trạng!");
            }
            else if (cbIDcustomer.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn ID nhân viên!");
            }
            else
            {
                //try
                {
                    int idUser = DangNhap.showIDuser;
                    string tinhTrang = cbTinhTrang.Text;
                    int idCustomer = Convert.ToInt32(cbIDcustomer.Text);
                    Hoadondao.Instance.insertHoaDon(idCustomer, tinhTrang, idUser);
                    MessageBox.Show("Thêm hóa đơn thành công!");
                    loadBillAdd();
                }
                /* catch(Exception)
                 {
                     MessageBox.Show("Thêm hóa đơn thất bại!");
                 }*/
            }
        }
        #endregion

        #region EVENT-TINHTIEN-NUMBERIC-UP-DOWN:

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                int result = 0;
                int giaTien = Convert.ToInt32(txtGiaBan.Text);
                int soluong = Convert.ToInt32(nbSoLuong.Value.ToString());
                result = giaTien * soluong;
                tbxTongTien.Text = result.ToString();
            }
            catch (Exception)
            { }
        }

        #endregion

        #region EVENT-LOAD-CTHD:

        void loadCTHD()
        {
            dtgvCTHD.DataSource = CTHDDAO.Instance.LISTSPCHON();

        }

        #endregion

        #region EVENT-LOAD-CHI-TIET-BILL:

        private void btnAddChiTietBill_Click(object sender, EventArgs e)
        {
            //THEM DU LIEU:
            try {
                if (tbxMaHang.Text == "Mã Hàng" && tbxMaHang.Text == "")
                {
                    MessageBox.Show("Vui lòng chọn sản phẩm!");
                }
                else {
                    int idHang = Convert.ToInt32(tbxMaHang.Text);
                    int idBill = Convert.ToInt32(tbxIDbill.Text);
                    int soLuong = Convert.ToInt32(nbSoLuong.Value.ToString());
                    int thanhTien = Convert.ToInt32(tbxTongTien.Text);
                    int Pricee = Convert.ToInt32(txtGiaBan.Text);
                    int STTT = Convert.ToInt32(tbxDVT.Text);

                    if (nbSoLuong.Value == 0)
                    {
                        MessageBox.Show("Vui lòng nhập số lượng!");
                    }
                    else if (txtGiaBan.Text == "" && tbxTenHang.Text == "Tên Hàng" && tbxMaHang.Text == "Mã Hàng" && tbxDVT.Text == "" && xemhang.Image == null)
                    {
                        MessageBox.Show("Vui lòng chọn hàng hóa!");
                    }




                    else
                    {
                        try
                        {

                            if (sanphamDAO.Instance.GetSoLuongSP(idHang) >= nbSoLuong.Value)
                            {
                                dtgvCTHD.DataSource = loadhangvaochitiethoadon(idHang, idBill, soLuong, thanhTien, Pricee, STTT);
                            }
                            else
                            {
                                MessageBox.Show("Số lượng tồn kho không đủ!");
                            }
                            if (CTHDDAO.Instance.checkHangTrongCTHD(idHang, idBill) == 2)
                            {
                                int soluongcapnhat = CTHDDAO.Instance.UpdateSoLuongCapNhat(idHang, idBill);
                                CTHDDAO.Instance.deleteDuLieuThua(idHang, idBill);
                                dtgvCTHD.DataSource = loadhangvaochitiethoadon(idHang, idBill, soluongcapnhat, thanhTien, Pricee, STTT);

                            }


                            tbxTongTienThanhToan.Text = CTHDDAO.Instance.tinhtongtien(Convert.ToInt32(tbxIDbill.Text)).ToString();
                            loadCTHD();
                        }
                        catch (Exception)
                        { }
                    }
                }
            } catch (Exception)
            {
                MessageBox.Show("Vui lòng chọn dũ liệu!");
            }
        }

        #endregion

        #region EVENT-XOA-CTHD:

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            dtgvCTHD.DataSource = CTHDDAO.Instance.XoaCTHD();
        }

        #endregion

        #region EVENT-CELL-CLICK:

        private void dataSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Byte[] img = (Byte[])dataSP.CurrentRow.Cells[4].Value;
            MemoryStream ms = new MemoryStream(img);
            xemhang.Image = Image.FromStream(ms);
            tbxMaHang.Text = dataSP.CurrentRow.Cells[0].Value.ToString();
            tbxTenHang.Text = dataSP.CurrentRow.Cells[1].Value.ToString();
            txtGiaBan.Text = dataSP.CurrentRow.Cells[9].Value.ToString();
            tbxDVT.Text = dataSP.CurrentRow.Cells[8].Value.ToString();
            //TINH TONG TIEN KHI CICK
            int result = 0;
            int giaTien = Convert.ToInt32(txtGiaBan.Text);
            int soluong = Convert.ToInt32(nbSoLuong.Value.ToString());
            result = giaTien * soluong;
            tbxTongTien.Text = result.ToString();
        }




        #endregion

        #endregion
        #region Thanh toán
        private void btnThanhToan_Click(object sender, EventArgs e)
        {

            int idBill = Convert.ToInt32(tbxIDbill.Text);
            int idHang = Convert.ToInt32(tbxMaHang.Text);
            int tonggTien = Convert.ToInt32(tbxTongTienThanhToan.Text);
            int idHoaDon = Convert.ToInt32(tbxIDbill.Text);
            int soluongcapnhat = CTHDDAO.Instance.UpdateSoLuongCapNhat(idHang, idBill);

            try
            {
                if (sanphamDAO.Instance.GetSoLuongSP(idHang) >= CTHDDAO.Instance.UpdateSoLuongCapNhat(idHang, idBill))
                {

                    //thanh toan
                    thanhToanHoaDon(tonggTien, idHoaDon);
                    //UPDATE:
                    //UPDATE SO LUONG
                    int soluongtonKhoCapNhat = sanphamDAO.Instance.GetSoLuongSP(idHang) - soluongcapnhat;
                    sanphamDAO.Instance.upDateSoLuong(soluongtonKhoCapNhat, idHang);
                    //LOAD LIST SP
                    dataSP.DataSource = sanphamDAO.Instance.GetlistSP();
                    MessageBox.Show("Thanh toán thành công!");
                }
                else
                {
                    MessageBox.Show("Số lượng tồn kho không đủ!");
                }


            }
            catch (Exception)
            {
                MessageBox.Show("Thanh toán không thành công");
            }

        }



        private void btinhoadon_Click(object sender, EventArgs e)
        {


            ReportHoadon hd = new ReportHoadon();
            hd.ShowDialog();
        }

        private void btnGuiMai_Click(object sender, EventArgs e)
        {

            GuiMail n = new GuiMail();
            n.Show();
        }
    
   

    }

}
#endregion;
#endregion;