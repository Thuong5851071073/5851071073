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

namespace Design_Dashboard_Modern
{
    public partial class NhaphangtunhaCC : UserControl
    {
        public NhaphangtunhaCC()
        {
            InitializeComponent();
        }

        #region METHOD:

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
        #endregion
        #region LOAD-DU-LIEU-PHIEU-VUA-NHAP:

        void loadIdMaxPN()
        {
            string queryseletIDPN = "SELECT MAX(IDphieunhap) FROM dbo.PhieuNhap ";
            int dataIDPN = (int)DataProvider.Instance.ExecuteScalar(queryseletIDPN);
            tbxIDPhieuNhap.Text = dataIDPN.ToString();
        }

        #endregion

        #region METHOD-NHAP-HANG-CTPN:

        void addCTPN(int idHang, int idPhieuNhap, int soLuong, int gia, int thanhTien, int soDVT)
        {
            if(phieunhapDAO.Instance.insertCTPN(idHang,idPhieuNhap,soLuong,gia,thanhTien,soDVT)==false)
            {
              MessageBox.Show("Thêm vào giỏ thất bại!");
            }

        }

        #endregion

        #region METHOD-LOADHANG:

        DataTable loadCTPN(int idPhieuNhap)
        {
            return phieunhapDAO.Instance.getDataCTPN(idPhieuNhap);
        }

        #endregion

        #endregion

        #region EVENT:

        #region EVENT-DATA-GRID-VIEW-CHỌN SP:

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Byte[] img = (Byte[])dataGridView1.CurrentRow.Cells[4].Value;
            MemoryStream ms = new MemoryStream(img);
            xemhang.Image = Image.FromStream(ms);
            txtmahang.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txttenhang.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtGiaVon.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            tbxDVT.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
        }

        #endregion

        #region EVENT_LOAD:

        private void NhaphangtunhaCC_Load(object sender, EventArgs e)
        {
            //LOAD dữ liệu:
            tbxnguoidung.Text = DangNhap.showname;
            cbTinhTrang.Items.Add("Đã Thanh Toán");
            cbTinhTrang.Items.Add("Chưa Thanh Toán");
            cbTinhTrang.Items.Add("Đang Nợ Nên Ghi Vào Sổ");

            string querySelectNCC = "SELECT IDnhacc FROM dbo.NhaCungCap";

            DataTable dataIDNCC = DataProvider.Instance.ExecuteQuery(querySelectNCC);

            cbMaNCC.DataSource = dataIDNCC;
            cbMaNCC.DisplayMember = "IDnhacc";

            //load DTGV:
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataGridView1.RowTemplate.Height = 50;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.DataSource = sanphamDAO.Instance.GetlistSP();
            setup_DTGV(dataGridView1);
            setup_DTGV(dtgvCTPN);
        }


        #endregion

        #region EVENT-ADD-PN:

        private void btnAddBill_Click(object sender, EventArgs e)
        {
            //getDuLieu
            int idNCC = Convert.ToInt32(cbMaNCC.Text);
            string tinhTrang = cbTinhTrang.Text;
            int idUser = DangNhap.showIDuser;
            //Bắt lỗi tình trạng và  mã nhân viên:
            if (cbTinhTrang.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn tình trạng!");
            }
            else if (cbMaNCC.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn mã nhà cung cấp!");
            }
            else if (phieunhapDAO.Instance.insertPhieuNhap(idNCC, tinhTrang, idUser))
            {
                    MessageBox.Show("Thêm hóa đơn thành công!");
                    loadIdMaxPN();
            }
            else
            {
                MessageBox.Show("Thêm hóa đơn thất bại!");
            }
        }

        #endregion

        #region EVENT-ADD-CHI-TIET-PHIEU-NHAP:

        private void btnAddChiTietBill_Click(object sender, EventArgs e)
        {
            //lấy dữ liệu:
            if (txttenhang.Text!= "Tên Hàng" && txtmahang.Text != "Mã Hàng" && tbxDVT.Text!="" &&xemhang.Image!=null)
            {
               if(numericUpDown1.Value!=0)
                {
                    try { 
                    int idHangg = Convert.ToInt32(txtmahang.Text);
                    int idPhieuNhapp = Convert.ToInt32(tbxIDPhieuNhap.Text);
                    int soLuongg = Convert.ToInt32(numericUpDown1.Value.ToString());
                    int giaVonn = Convert.ToInt32(txtGiaVon.Text);
                    int thanhTienn = Convert.ToInt32(tbxTongTien.Text);
                    int soDVTT = Convert.ToInt32(tbxDVT.Text);
                    addCTPN(idHangg, idPhieuNhapp, soLuongg, giaVonn, thanhTienn, soDVTT);
                    if(phieunhapDAO.Instance.checkSoluongNhap(idHangg, idPhieuNhapp)==2)
                    {
                        int soluongcapnhat = phieunhapDAO.Instance.soLuongCapNhat(idHangg, idPhieuNhapp);
                        phieunhapDAO.Instance.deleteDuLieuThua(idHangg, idPhieuNhapp);
                        addCTPN(idHangg, idPhieuNhapp, soluongcapnhat, giaVonn, thanhTienn, soDVTT);
                    }

                        MessageBox.Show("Thêm vào giỏ thành công!");
                        txttongtien.Text = phieunhapDAO.Instance.tinhTongTienPhieuNhap(Convert.ToInt32(tbxIDPhieuNhap.Text)).ToString();
                        dtgvCTPN.DataSource = loadCTPN(idPhieuNhapp);


                    }catch(Exception)
                    {
                        MessageBox.Show("Bạn vui lòng tạo phiếu nhập!");
                    }

                    
                }
               else
                {
                    MessageBox.Show("Bạn vui lòng nhập số lượng!");
                }
                    
            }
            else
            {
                MessageBox.Show("Vui lòng chọn hàng hóa nhập vào!");
            }
          
        }

        #endregion
       
        #region;

        #region EVENT-TINH-TONG-TIEN:

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            try
            {
               string  idPhieuNhap = tbxIDPhieuNhap.Text;
                int tongtien = Convert.ToInt32(txttongtien.Text);
                int result = 0;
                int giaTien = Convert.ToInt32(txtGiaVon.Text);
                int soluong = Convert.ToInt32(numericUpDown1.Value.ToString());
                result = giaTien * soluong;
                tbxTongTien.Text = result.ToString();
              
            }
            catch (Exception)
            {
            }
        }

        private void txtGiaVon_OnValueChanged(object sender, EventArgs e)
        {
            try
            {
                int result = 0;
                int giaTien = Convert.ToInt32(txtGiaVon.Text);
                int soluong = Convert.ToInt32(numericUpDown1.Value.ToString());
                result = giaTien * soluong;
                tbxTongTien.Text = result.ToString();
            }
            catch (Exception)
            { }
        }


        #endregion

        #region UpdateTongTienPhieuNhap
        void Update()
        {
            int idPhieuNhap = Convert.ToInt32(tbxIDPhieuNhap.Text);
            int tongtien = Convert.ToInt32(txttongtien.Text);
            phieunhapDAO.Instance.UpdateTongTienPhieuNhap(idPhieuNhap, tongtien);
        }
        #endregion;
        #region EVENT-THANH-TOAN:

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            try { 
            int idHangg = Convert.ToInt32(txtmahang.Text);
            int idPhieuNhapp = Convert.ToInt32(tbxIDPhieuNhap.Text);

            int soLuongHangSeThem = phieunhapDAO.Instance.soLuongCapNhat(idHangg, idPhieuNhapp);
            int soluongtonKhoCapNhat = sanphamDAO.Instance.GetSoLuongSP(idHangg) + soLuongHangSeThem;
            sanphamDAO.Instance.upDateSoLuong(soluongtonKhoCapNhat, idHangg);
            MessageBox.Show("Thanh Toán thành công");
                Update();
                phieunhapDAO.Instance.deleteAll();
            dtgvCTPN.DataSource = loadCTPN(idPhieuNhapp);
            dataGridView1.DataSource = sanphamDAO.Instance.GetlistSP();
            }
            catch (Exception)
            {
                
            }
        }

        #endregion

        #region EVENT-XOA-HANG-TRONG-CTPN:

        private void btnResetData_Click(object sender, EventArgs e)
        {
            if (tbxIDPhieuNhap.Text != "")
            {
                int idPhieuNhapp = Convert.ToInt32(tbxIDPhieuNhap.Text);
                phieunhapDAO.Instance.deleteAll();
                dtgvCTPN.DataSource = loadCTPN(idPhieuNhapp);
            }
            else
            {
                MessageBox.Show("Chưa thêm vào rỏ hàng");
            }
        }

        #endregion
    }
    #endregion
    #endregion

}

