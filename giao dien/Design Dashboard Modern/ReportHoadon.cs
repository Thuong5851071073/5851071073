using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Design_Dashboard_Modern
{
    public partial class ReportHoadon : Form
    {
        public ReportHoadon()
        {
            InitializeComponent();
        }

        private void ReportHoadon_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QUANLYSIEUTHIDataSet1.CTHD' table. You can move, or remove it, as needed.
            this.CTHDTableAdapter.Fill(this.QUANLYSIEUTHIDataSet1.CTHD);

            this.reportViewer1.RefreshReport();
        }

        private void btxuat_Click(object sender, EventArgs e)
        {
            //Khai báo câu lệnh SQL
            string sql = string.Format("SELECT  IDhang , IDhoadon,SoLuong ,Gia,Thanhtien FROM dbo.CTHD ");
            SqlConnection con = new SqlConnection();
            //Truyền vào chuỗi kết nối tới cơ sở dữ liệu
            //Gọi Application.StartupPath để lấy đường dẫn tới thư mục chứa file chạy chương trình 
            con.ConnectionString = @"Data Source=DESKTOP-3T56K1L;Initial Catalog=FAHASA;Integrated Security=True";

            SqlDataAdapter adp = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            try
            {
                adp.Fill(ds);
            
          
            //  ds.Tables.Add.
            //Khai báo chế độ xử lý báo cáo, trong trường hợp này lấy báo cáo ở local
            reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            //Đường dẫn báo cáo
            reportViewer1.LocalReport.ReportPath = "ReportHoadon.rdlc";
            //Nếu có dữ liệu
            if (ds.Tables[0].Rows.Count > 0)
            {
                //Tạo nguồn dữ liệu cho báo cáo
                ReportDataSource rds = new ReportDataSource();
                rds.Name = "datachitiethoadon";
                rds.Value = ds.Tables[0];
                //Xóa dữ liệu của báo cáo cũ trong trường hợp người dùng thực hiện câu truy vấn khác
                // rpvBaoCao.LocalReport.DataSources.Clear();
                //Add dữ liệu vào báo cáo
                reportViewer1.LocalReport.DataSources.Add(rds);
                //Refresh lại báo cáo
                reportViewer1.RefreshReport();
            }
            }
            catch (Exception)
            {
                MessageBox.Show(" Vui lòng xuất file excel");
            }
        }
    }
}
