using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Design_Dashboard_Modern.DAO;
namespace Design_Dashboard_Modern
{
    public partial class XuatThongKeEXCEL : Form
    {
        public XuatThongKeEXCEL()
        {
            InitializeComponent();
        }
        #region Method
        #region LaodPhieuNhap;
      void   LoadhieuNhap()
        {
            dataXuatTientra.DataSource = phieunhapDAO.Instance.showPhieuNhap();
            setup_DTGV(dataXuatTientra);
        }
        #endregion;
        #region LoadHoadon;
        void LoadHoadon()
        {
            dtDoanhthu.DataSource = Hoadondao.Instance.ShowHoadon();
            setup_DTGV(dtDoanhthu);
        }
        #endregion;

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
        #endregion;
        #region Xuất Excel Thống kê trả tiền cho nhà cung cấp , và doanh thu;
        private void XuatThongKeEXCEL_Load(object sender, EventArgs e)
        {
            LoadhieuNhap();
            LoadHoadon();
        }

        private void btxuat_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application oExcel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbooks oBooks;
            Microsoft.Office.Interop.Excel.Sheets oSheets;
            Microsoft.Office.Interop.Excel.Workbook oBook;
            Microsoft.Office.Interop.Excel.Worksheet oSheet;
            // Tạo mới một Excel WorkBook
            oExcel.DisplayAlerts = false;
            oExcel.Application.SheetsInNewWorkbook = 1;
            oBooks = oExcel.Workbooks;
            oBook = (Microsoft.Office.Interop.Excel.Workbook)(oExcel.Workbooks.Add(Type.Missing));
            oSheets = oBook.Worksheets;
            oSheet = (Microsoft.Office.Interop.Excel.Worksheet)oSheets.get_Item(1);
            oSheet.Name = "Danh Sách";
            // Tạo phần đầu nếu muốn
            Microsoft.Office.Interop.Excel.Range head = oSheet.get_Range("A1", "G1");
            head.MergeCells = true;
            head.Value2 = "Danh Sách Thống Kê Doanh Thu ";
            head.Font.Bold = true;
            head.MergeCells = true;
            head.Font.Name = "Tahoma";
            head.Font.Size = "18";
            head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("A3", "C3");


            // rowHead.Font.Bold = true;
            // Kẻ viền
            // rowHead.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;
            /*(tạo font chữ và cỡ chữ
              head.Font.Name = "Tahoma";
            head.Font.Size = "18";)*/
            oSheet.Cells[3, 1] = "STT";
            oSheet.Cells[2, 4] = " Họ Tên Người Lập";
            oSheet.Cells[2, 5] = " Nguyễn Văn Thương";
            // căn tiêu đề ra giữa
            //  head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            // Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("A3", "C3");

            //  rowHead.Font.Bold = true;
            // Kẻ viền

            //rowHead.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

            // Thiết lập màu nền

            // rowHead.Interior.ColorIndex = 15;

            //  rowHead.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            // Tạo tiêu đề cột
            for (int i = 0; i < dtDoanhthu.ColumnCount; i++)
            {
                oSheet.Cells[3, i + 2] = dtDoanhthu.Columns[i].HeaderText;
            }
            // Tạo mẳng đối tượng để lưu dữ toàn bồ dữ liệu trong DataTable,
            //  vì dữ liệu được được gán vào các Cell trong Excel phải thông qua object thuần.
            for (int i = 0; i < dtDoanhthu.RowCount - 1; i++)
            {
                oSheet.Cells[i + 4, 1] = i + 1;
                for (int j = 0; j < dtDoanhthu.ColumnCount; j++)
                {
                    oSheet.Cells[i + 4, j + 2] = dtDoanhthu.Rows[i].Cells[j].Value;
                }
            }

            // Căn giữa cột STT
            // oSheet.get_Range("A4", "G4").HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            oSheet.Columns.AutoFit();

            oExcel.Visible = true;
        }

        private void btxuatchitra_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application oExcel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbooks oBooks;
            Microsoft.Office.Interop.Excel.Sheets oSheets;
            Microsoft.Office.Interop.Excel.Workbook oBook;
            Microsoft.Office.Interop.Excel.Worksheet oSheet;
            // Tạo mới một Excel WorkBook
            oExcel.DisplayAlerts = false;
            oExcel.Application.SheetsInNewWorkbook = 1;
            oBooks = oExcel.Workbooks;
            oBook = (Microsoft.Office.Interop.Excel.Workbook)(oExcel.Workbooks.Add(Type.Missing));
            oSheets = oBook.Worksheets;
            oSheet = (Microsoft.Office.Interop.Excel.Worksheet)oSheets.get_Item(1);
            oSheet.Name = "Danh Sách";
            // Tạo phần đầu nếu muốn
            Microsoft.Office.Interop.Excel.Range head = oSheet.get_Range("A1", "G1");
            head.MergeCells = true;
            head.Value2 = "Danh Sách Thống Kê Chi Trả Nhà Cung Cấp ";
            head.Font.Bold = true;
            head.MergeCells = true;
            head.Font.Name = "Tahoma";
            head.Font.Size = "18";
            head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("A3", "C3");


            // rowHead.Font.Bold = true;
            // Kẻ viền
            // rowHead.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;
            /*(tạo font chữ và cỡ chữ
              head.Font.Name = "Tahoma";
            head.Font.Size = "18";)*/
            oSheet.Cells[3, 1] = "STT";
            oSheet.Cells[2, 4] = " Họ Tên Người Lập";
            oSheet.Cells[2, 5] = " Nguyễn Văn Thương";
            // căn tiêu đề ra giữa
            //  head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            // Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("A3", "C3");

            //  rowHead.Font.Bold = true;
            // Kẻ viền

            //rowHead.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

            // Thiết lập màu nền

            // rowHead.Interior.ColorIndex = 15;

            //  rowHead.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            // Tạo tiêu đề cột
            for (int i = 0; i < dataXuatTientra.ColumnCount; i++)
            {
                oSheet.Cells[3, i + 2] = dataXuatTientra.Columns[i].HeaderText;
            }
            // Tạo mẳng đối tượng để lưu dữ toàn bồ dữ liệu trong DataTable,
            //  vì dữ liệu được được gán vào các Cell trong Excel phải thông qua object thuần.
            for (int i = 0; i < dataXuatTientra.RowCount - 1; i++)
            {
                oSheet.Cells[i + 4, 1] = i + 1;
                for (int j = 0; j < dataXuatTientra.ColumnCount; j++)
                {
                    oSheet.Cells[i + 4, j + 2] = dataXuatTientra.Rows[i].Cells[j].Value;
                }
            }

            // Căn giữa cột STT
            // oSheet.get_Range("A4", "G4").HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            oSheet.Columns.AutoFit();

            oExcel.Visible = true;
        }
        #endregion;

        private void btguimail_Click(object sender, EventArgs e)
        {
            
            GuiMail mail = new GuiMail();
            mail.ShowDialog();
        }
    }
}
