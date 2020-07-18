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
using System.Data.SqlClient;

namespace Design_Dashboard_Modern
 
{
    public partial class fmbaocao : UserControl
    {
        public fmbaocao()
        {
            InitializeComponent();
        }
        #region Load Thống Kê theo Năm
        void LoadThongkeTheoNam()
        {
            DoanhThuTheoNgay.Titles.Add(" Biểu Đồ Doanh Thu Theo Năm");
            DoanhThuTheoNgay.DataSource = Hoadondao.Instance.LoadThongkeTheoNam();
            charttheongaythang.ChartAreas["ChartArea1"].AxisX.Title = "Năm";
            charttheongaythang.ChartAreas["ChartArea1"].AxisY.Title = "Tổng Tiền";
            DoanhThuTheoNgay.Series["Doanh Thu Theo Nam"].XValueMember = "NgayLap";
            DoanhThuTheoNgay.Series["Doanh Thu Theo Nam"].YValueMembers = "TongTien";
          
        }
        #endregion;
        #region Load Thống Kê theo NămNhàCC
        void LoadThongkeTheoNamPhieuNhap()
        {
            chart2.Titles.Add("Biểu Đồ Thống Kê Trả Cho Nhà Cung Cấp Theo Năm");
            chart2.DataSource = phieunhapDAO.Instance.LoadThongkePhieuNhapTheoNam();
            chart2.ChartAreas["ChartArea1"].AxisX.Title = "Năm";
            chart2.ChartAreas["ChartArea1"].AxisY.Title = "Tổng Tiền";
            chart2.Series["Trả Nhà Cung Cấp Theo Năm"].XValueMember = "Ngaylap";
            chart2.Series["Trả Nhà Cung Cấp Theo Năm"].YValueMembers = "Tongtien";

        }
        #endregion;
        #region loadThongkeTheoThangCuaNam
        void LoadCharTheoThang()
        {
            int nam;
           nam = dateTimePicker1.Value.Year;
            charttheongaythang.DataSource = Hoadondao.Instance.loadThongKe(nam);
           // charttheongaythang.Titles.Add("Doanh Thu Theo Tháng");
            charttheongaythang.ChartAreas["ChartArea1"].AxisX.Title = "Tháng";
            charttheongaythang.ChartAreas["ChartArea1"].AxisY.Title = "Tổng Tiền";
            charttheongaythang.Series["Doanh Thu Theo Thang"].XValueMember = "NgayLap";
            charttheongaythang.Series["Doanh Thu Theo Thang"].YValueMembers = "TongTien";
            charttheongaythang.Series["Doanh Thu Theo Thang"].Points.AddY("Thang 1");
            charttheongaythang.Series["Doanh Thu Theo Thang"].Points.AddY("Thang 2");
            charttheongaythang.Series["Doanh Thu Theo Thang"].Points.AddY("Thang 3");
            charttheongaythang.Series["Doanh Thu Theo Thang"].Points.AddY("Thang 4");
            charttheongaythang.Series["Doanh Thu Theo Thang"].Points.AddY("Thang 5");
            charttheongaythang.Series["Doanh Thu Theo Thang"].Points.AddY("Thang 6");
            charttheongaythang.Series["Doanh Thu Theo Thang"].Points.AddY("Thang 7");
            charttheongaythang.Series["Doanh Thu Theo Thang"].Points.AddY("Thang 8");
            charttheongaythang.Series["Doanh Thu Theo Thang"].Points.AddY("Thang 9");
            charttheongaythang.Series["Doanh Thu Theo Thang"].Points.AddY("Thang 10");
            charttheongaythang.Series["Doanh Thu Theo Thang"].Points.AddY("Thang 11");
            charttheongaythang.Series["Doanh Thu Theo Thang"].Points.AddY("Thang 12");
        }

        #endregion;
        #region Tiền Trả Cho Nhà Cung Cấp
        void ThongKeTheoThangPhieuNhap()
        {
            
                int nam;
            nam = dateTimePicker1.Value.Year;
            ThongKePhieuTra.DataSource = phieunhapDAO.Instance.loadThongKePhieuNhapTheoThang(nam);
            // charttheongaythang.Titles.Add("Doanh Thu Theo Tháng");
            ThongKePhieuTra.ChartAreas["ChartArea1"].AxisX.Title = "Tháng";
            ThongKePhieuTra.ChartAreas["ChartArea1"].AxisY.Title = "Tổng Tiền";
            ThongKePhieuTra.Series["Tiền trả Khi Lấy Hàng Theo Tháng"].XValueMember = "Ngaylap";
            ThongKePhieuTra.Series["Tiền trả Khi Lấy Hàng Theo Tháng"].YValueMembers = "Tongtien";
            
            ThongKePhieuTra.Series["Tiền trả Khi Lấy Hàng Theo Tháng"].Points.AddY("Thang 1");
            ThongKePhieuTra.Series["Tiền trả Khi Lấy Hàng Theo Tháng"].Points.AddY("Thang 2");
            ThongKePhieuTra.Series["Tiền trả Khi Lấy Hàng Theo Tháng"].Points.AddY("Thang 3");
            ThongKePhieuTra.Series["Tiền trả Khi Lấy Hàng Theo Tháng"].Points.AddY("Thang 4");
            ThongKePhieuTra.Series["Tiền trả Khi Lấy Hàng Theo Tháng"].Points.AddY("Thang 5");
            ThongKePhieuTra.Series["Tiền trả Khi Lấy Hàng Theo Tháng"].Points.AddY("Thang 6");
            ThongKePhieuTra.Series["Tiền trả Khi Lấy Hàng Theo Tháng"].Points.AddY("Thang 7");
            ThongKePhieuTra.Series["Tiền trả Khi Lấy Hàng Theo Tháng"].Points.AddY("Thang 8");
            ThongKePhieuTra.Series["Tiền trả Khi Lấy Hàng Theo Tháng"].Points.AddY("Thang 9");
            ThongKePhieuTra.Series["Tiền trả Khi Lấy Hàng Theo Tháng"].Points.AddY("Thang 10");
            ThongKePhieuTra.Series["Tiền trả Khi Lấy Hàng Theo Tháng"].Points.AddY("Thang 11");
            ThongKePhieuTra.Series["Tiền trả Khi Lấy Hàng Theo Tháng"].Points.AddY("Thang 12");
        }
        #endregion;


        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
            LoadCharTheoThang();
            ThongKeTheoThangPhieuNhap();


        }
        
        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            LoadThongkeTheoNam();
            LoadThongkeTheoNamPhieuNhap();
        }

        private void btxuat_Click(object sender, EventArgs e)
        {
            XuatThongKeEXCEL xuatThongKe = new XuatThongKeEXCEL();
            xuatThongKe.Show();
        }
    }
}
