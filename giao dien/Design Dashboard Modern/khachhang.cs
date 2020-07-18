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
using Microsoft.Office.Interop.Excel;
using Excel = Microsoft.Office.Interop.Excel;
using System.Text.RegularExpressions;


namespace Design_Dashboard_Modern
{
    public partial class khachhang : UserControl
    {
        public khachhang()
        {
            InitializeComponent();
        }

        #region thêm và update khách hàng;
        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
         if(  txtmakhch.Text != ""|| txtmakhch.Text == "Mã Khách")
            {
                dtkhach.DataSource = khachhangDAO.Instance.updatesdt(Convert.ToInt32(txtsdt.Text), Convert.ToInt32(txtmakhch.Text));
                dtkhach.DataSource = khachhangDAO.Instance.updateDC(txtdc.Text, Convert.ToInt32(txtmakhch.Text));
                MessageBox.Show(" Update thanh công ");
                load();
            }
            else
            {
                MessageBox.Show("Vui Lòng Nhập Mã Khách Hàng");
            }
        }
       
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
            
        {
            if (txttenkhach.Text == "") {
                MessageBox.Show("Mời bạn nhập tên khách");
            }
            else if ( txtsdt.Text == "")
            {
                MessageBox.Show("Mời bạn nhập SĐT:");

            }
            else if (txtdc.Text == "")
            {
                MessageBox.Show("Mời bạn nhập Địa chỉ:");
            }
            else
            {
                khachhangDAO.Instance.ThemKhach(txttenkhach.Text,txtdc.Text,  Convert.ToInt32(txtsdt.Text));
                MessageBox.Show("Nhập thành công");
                load();

            }
           
        }
        #endregion;
        #region Load datagiview Kháchhang
        void load()
        {
            dtkhach.DataSource = khachhangDAO.Instance.laydanhsachkhach();

        }
        private void khachhang_Load(object sender, EventArgs e)
        {
            load();
        }
        #endregion;
        #region LoaD từ datagiview lên textbox
        private void dtkhach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            txttenkhach.Text = dtkhach.CurrentRow.Cells[1].Value.ToString();
            txtmakhch.Text = dtkhach.CurrentRow.Cells[0].Value.ToString();
            txtsdt.Text = dtkhach.CurrentRow.Cells[2].Value.ToString();
            txtdc.Text = dtkhach.CurrentRow.Cells[3].Value.ToString();
            dtkhach.DataSource = khachhangDAO.Instance.laydanhsachkhach();
        }
        #endregion;
        #region bắt lỗi nhập chữ ;
        private static bool IsNumber(string val)
        {
            if (val != "")
                return Regex.IsMatch(val, @"^[0-9]\d*\.?[0]*$");
            else return true;
        }
        private void txtsdt_OnValueChanged(object sender, EventArgs e)
        {
            if (IsNumber(txtsdt.Text) != true)
            {
                MessageBox.Show("Dữ liệu nhập không hợp lệ, không được nhập ký tự", "Thông báo");
                txtsdt.Text = "";
            }
        }
        #endregion;

        private void btnXuatExcel_Click(object sender, EventArgs e)
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
            head.Value2 = "Danh Sách Khách Hàng ";
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
            oSheet.Cells[2,4] = " Họ Tên Người Lập";
            oSheet.Cells[2,5] = " Nguyễn Văn Thương";
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
            for (int i = 0; i < dtkhach.ColumnCount; i++)
            {
                oSheet.Cells[3, i + 2] = dtkhach.Columns[i].HeaderText;
            }
            // Tạo mẳng đối tượng để lưu dữ toàn bồ dữ liệu trong DataTable,
            //  vì dữ liệu được được gán vào các Cell trong Excel phải thông qua object thuần.
            for (int i = 0; i < dtkhach.RowCount - 1; i++)
            {
                oSheet.Cells[i + 4, 1] = i + 1;
                for (int j = 0; j < dtkhach.ColumnCount; j++)
                {
                    oSheet.Cells[i + 4, j + 2] = dtkhach.Rows[i].Cells[j].Value;
                }
            }

            // Căn giữa cột STT
           // oSheet.get_Range("A4", "G4").HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            oSheet.Columns.AutoFit();
       
            oExcel.Visible = true;

        }
    }
}
