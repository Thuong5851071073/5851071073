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

namespace Design_Dashboard_Modern
{
    public partial class usersanpham : UserControl
    {
        public usersanpham()
        {
            InitializeComponent();
            loadDATA();
        }
        #region METHOD:

        #region MEDTHOD-Change-Imgae-->Byte:

        public byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            
            MemoryStream ms = new MemoryStream();
            try
            {
                imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            }catch(Exception)
            {
                MessageBox.Show("Hình ảnh không hợp lệ hoặc chưa thêm");
            }
            return ms.ToArray();
        }

        #endregion

        #region METHOD-LOAD-PRODUCT:

        public void addSP(string tenHang, string theTich, byte Picture, int soluongtrongkho, int idncc, int giavon, int sodonvitinh, int giaban, string loaihang, string Ngaysx,string ngayhethansudung)
        {
           sanphamDAO.Instance.ThemDuLieu(tenHang,theTich,Picture,soluongtrongkho,idncc,giavon,sodonvitinh,giaban,loaihang,Ngaysx,ngayhethansudung);
        }

        #endregion

        #region METHOD-LOAD-DATA:
        #region Loaddcomboboxnhacungcap;
        void loadDATA()
        {
            string queryselectNCC ="SELECT IDnhacc FROM dbo.NhaCungCap";
            string queryselectIDDVT = "SELECT Sothutu FROM dbo.Donvitinh";
            string queryselectLOAIHANG = "SELECT tenLoaiHang FROM loaihang";



            DataTable datancc = DataProvider.Instance.ExecuteQuery(queryselectNCC);
            DataTable dataIDDVT = DataProvider.Instance.ExecuteQuery(queryselectIDDVT);
            DataTable dataLOAIHANG = DataProvider.Instance.ExecuteQuery(queryselectLOAIHANG);

            cbmanhacc.DataSource = datancc;
            cbmadvt.DataSource = dataIDDVT;
            cbloaihang.DataSource = dataLOAIHANG;

            cbmanhacc.DisplayMember= "IDnhacc";
            cbmadvt.DisplayMember = "Sothutu";
            cbloaihang.DisplayMember = "tenLoaiHang";

            

        }
        #endregion;
        #endregion

        #endregion

        #region EVENT:

        #region EVENT-OPEN-FILE:

        private void btchon_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image files(*.jpg;*.gif;*.png)|*.jpg;*.gif;*.png";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                image1.Image = new Bitmap(ofd.FileName);
            }
        }

        #endregion

        #region EVENT-LOAD-PRODUCT:

        private void usersanpham_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataGridView1.RowTemplate.Height = 100;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.DataSource = sanphamDAO.Instance.GetlistSP();
        }

        #endregion

        #region EVENT-GET-CLICK-DATAGIRDVIEW:

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            Byte[] img = (Byte[])dataGridView1.CurrentRow.Cells[4].Value;
            MemoryStream ms = new MemoryStream(img);
            image1.Image = Image.FromStream(ms);
            idhang.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txttenhang.Text= dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtthetich.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtgiaban.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            txtgiavon.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            cbmadvt.Text=  dataGridView1.CurrentRow.Cells[8].Value.ToString();
            cbmanhacc.Text= dataGridView1.CurrentRow.Cells[6].Value.ToString();
            cbloaihang.Text= dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtNgaysanxuat.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            txtHansudung.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();

        }

        #endregion

        #region EVENT-ADD-PRODUCT:

        private void btthem_Click(object sender, EventArgs e)
        {         

          
            byte[] Picture1 = imageToByteArray(image1.Image);
            DB db = new DB();
            string query = ("INSERT INTO dbo.Sanpham(TenHang,TheTich,PICTURE,Soluongthungtrongkho,IDnhacc,GiaVon,sothutu,Giaban,Loaihang, NgaySX,NgayHetHan)VALUES(@tenHang1,@theTich1,@Picture1, @soluongtrongkho1, @idncc1, @giavon1,@sodonvitinh1, @giaban1,@loaihang1,@ngaysx1 ,@ngayhethan1)");
            db.openconection();
            try
            {
                SqlCommand command = new SqlCommand(query, db.GetConnection());
                //Tên hàng:
                if(txttenhang.Text!= "Tên Hàng" && txttenhang.Text != "")
                { 
                command.Parameters.Add("@tenHang1", SqlDbType.NVarChar).Value = txttenhang.Text;
                }
                else
                {
                    MessageBox.Show("Vui Lòng nhập tên hàng!");
                }
                //Thể tích:
                if (txtthetich.Text != "Thể Tích" && txtthetich.Text != "")
                {
                    command.Parameters.Add("@theTich1", SqlDbType.NVarChar).Value = txtthetich.Text;
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập thể tích!");
                }
                //Hình ảnh:
                if (image1.Image != null)
                { 
                  command.Parameters.Add("@Picture1", SqlDbType.VarBinary).Value = Picture1;
                }
               

                //Số lượng:
            if (nbSoLuong.Text != "0" && txttenhang.Text != "")
                {
                    command.Parameters.Add("@soluongtrongkho1", SqlDbType.Int).Value = nbSoLuong.Value;
                }
                else
                {
                    MessageBox.Show("Vui lòng số lượng!");
                }
                //Nhà cung cấp:
                command.Parameters.Add("@idncc1", SqlDbType.Int).Value = cbmanhacc.Text;
                //Số đơn vị tính:
                command.Parameters.Add("@sodonvitinh1", SqlDbType.Int).Value = cbmadvt.Text;
                //Giá bán:
                if (txtNgaysanxuat.Text != "")
                {
                    command.Parameters.Add("@ngaysx1", SqlDbType.Date).Value = txtNgaysanxuat.Text;
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập ngày sản xuất , lưu ý nhập Năm/Tháng/Ngày  Ví Dụ : '2020/07/10'");
                }
                if (txtHansudung.Text != "")
                {
                    command.Parameters.Add("@ngayhethan1", SqlDbType.Date).Value = txtHansudung.Text;
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập Ngày hết hạn , lưu ý nhập Năm/Tháng/Ngày  Ví Dụ : '2020/07/10'");
                }

                
                try
                {
                    command.Parameters.Add("@giaban1", SqlDbType.Int).Value = txtgiaban.Text;
                }catch(Exception)
                {
                    MessageBox.Show("Vui lòng nhập số!");
                }
                //Loại hàng:
                command.Parameters.Add("@loaihang1", SqlDbType.NVarChar).Value = cbloaihang.Text;
                //Giá Vốn:
                try
                {
                    command.Parameters.Add("@giavon1", SqlDbType.Int).Value = txtgiavon.Text;
                }
                catch (Exception)
                {
                    MessageBox.Show("Vui lòng nhập số!");
                }

                if (command.ExecuteNonQuery() == 1)
                {
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
                    dataGridView1.RowTemplate.Height = 100;
                    dataGridView1.AllowUserToAddRows = false;
                    dataGridView1.DataSource = sanphamDAO.Instance.GetlistSP();
                    db.closeconnection();
                    MessageBox.Show(" Thêm sản phẩm thành công");
                }
                
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi vui lòng kiểm tra lại dữ liệu,Lưu ý Ngày sản xuất và hạn sử dụng chỉ có thể nhập năm/tháng/ngay ví dụ : '2020/01/01'");
            }
        }

        #endregion

        #region EVENT-RESET-DATA:

        private void Btlammoi_Click(object sender, EventArgs e)
        {
            txttenhang.Text = "Tên Hàng";
            txtgiaban.Text = "Giá Bán";
            txtgiavon.Text = "Giá Vốn";
            txtthetich.Text = "Thể Tích";
            txtHansudung.Text = "2020/01/01";
            txtNgaysanxuat.Text = "2020/01/01";
            nbSoLuong.Value=1;
        }

        #endregion

        #region EVENT-DELETE-PRODUCT:

        private void btxoa_Click(object sender, EventArgs e)
        {
            if (idhang.Text != "")
            {
                int i = Convert.ToInt32(idhang.Text);
                sanphamDAO.Instance.xoaSp(i);
                dataGridView1.DataSource = sanphamDAO.Instance.GetlistSP();
                MessageBox.Show("Xóa thành công!");
            }
           
            else
            {
                MessageBox.Show("Xóa hàng hóa thất bại,vui lòng kiểm tra lại!");
            }
        }

        #endregion

        #region EVENT-LOAD-DATAGIRDVIEW:

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
           
            
            dataGridView1.DataSource = sanphamDAO.Instance.GetlistSP();
            byte[] Picture1 = imageToByteArray(image1.Image);
            DB db = new DB();
            string query = ("UPDATE dbo.Sanpham SET PICTURE = @picture1, Soluongthungtrongkho = @soluongtrongkho1,sothutu =@sodonvitinh1 ,IDnhacc = @idncc1,GiaVon = @giavon1,Giaban = @giaban1,NgaySX=@ngaysanxuat,NgayHetHan=@ngayhethan WHERE IDhang ='" + idhang.Text + "' ");
            db.openconection();
            try
            {


                {
                    SqlCommand command = new SqlCommand(query, db.GetConnection());
                    command.Parameters.AddWithValue("@Picture1", SqlDbType.VarBinary).Value = Picture1;
                    command.Parameters.AddWithValue("@soluongtrongkho1", SqlDbType.Int).Value = nbSoLuong.Value;
                    command.Parameters.AddWithValue("@idncc1", SqlDbType.Int).Value = cbmanhacc.Text;
                    command.Parameters.AddWithValue("@sodonvitinh1", SqlDbType.Int).Value = cbmadvt.Text;
                    command.Parameters.AddWithValue("@giaban1", SqlDbType.Int).Value = txtgiaban.Text;
                    command.Parameters.AddWithValue("@loaihang1", SqlDbType.NVarChar).Value = cbloaihang.Text;
                    command.Parameters.AddWithValue("@giavon1", SqlDbType.Int).Value = txtgiavon.Text;
                    command.Parameters.AddWithValue("@ngaysanxuat", SqlDbType.Date).Value = txtNgaysanxuat.Text;
                    command.Parameters.AddWithValue("@ngayhethan", SqlDbType.Date).Value = txtHansudung.Text;

                    if (command.ExecuteNonQuery() == 1)
                        MessageBox.Show("thành công");
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
                    dataGridView1.RowTemplate.Height = 100;
                    dataGridView1.AllowUserToAddRows = false;
                    dataGridView1.DataSource = sanphamDAO.Instance.GetlistSP();
                    db.closeconnection();
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Thất bại ! bạn hãy nhập lại ngày sản xuất và ngày hết hạn  Lưu ý: Ngày nhập vào phải là năm/tháng/ngày Ví dụ : 2020/01/12");

            }


        }

        #endregion

        #region EVENT-SHOW-TABLE-DONVITINH:

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            dvt1.Visible = true;
        }

        #endregion

        #region EVENT-SHOW-TABLE-NHACC: 

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            nhaccc1.Visible = true;
        }


        #endregion

        #region EVENT-HIDE-TEXT:

        private void txttenhang_Enter(object sender, EventArgs e)
        {
            if(txttenhang.Text== "Tên Hàng")
            {
                txttenhang.Text = "";
            }
        }
        private void txttenhang_Leave(object sender, EventArgs e)
        {
            if (txttenhang.Text == "")
            {
                txttenhang.Text = "Tên Hàng";
            }
        }
        private void txtthetich_Enter(object sender, EventArgs e)
        {
            if (txtthetich.Text == "Thể Tích")
            {
                txtthetich.Text = "";
            }
        }
        private void txtthetich_Leave(object sender, EventArgs e)
        {
            if (txtthetich.Text == "")
            {
                txtthetich.Text = "Thể Tích";
            }
        }
        private void txtgiaban_Enter(object sender, EventArgs e)
        {
            if (txtgiaban.Text == "Giá Bán")
            {
                txtgiaban.Text = "";
            }
        }
        private void txtgiaban_Leave(object sender, EventArgs e)
        {
            if (txtgiaban.Text == "")
            {
                txtgiaban.Text = "Giá Bán";
            }
        }
        private void txtgiavon_Enter(object sender, EventArgs e)
        {
            if (txtgiavon.Text == "Giá Vốn")
            {
                txtgiavon.Text = "";
            }
        }
        private void txtgiavon_Leave(object sender, EventArgs e)
        {
            if (txtgiavon.Text == "")
            {
                txtgiavon.Text = "Giá Vốn";
            }
        }


    

        private void txtNgaysanxuat_Enter(object sender, EventArgs e)
        {
            txtNgaysanxuat.Text = "";
        }

        private void txtNgaysanxuat_Leave(object sender, EventArgs e)
        {
           
        }

        private void txtHansudung_Enter(object sender, EventArgs e)
        {
            txtHansudung.Text = "";
        }

        private void txtHansudung_Leave(object sender, EventArgs e)
        {
           
        }
    }
    #endregion
    #endregion
}
