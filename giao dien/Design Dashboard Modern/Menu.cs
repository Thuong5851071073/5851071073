
using Design_Dashboard_Modern.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Design_Dashboard_Modern
{
    public partial class Menu : Form
    {
        private string tendn;

        public string Tendn { get => tendn; set => tendn = value; }
        public Menu(string ten)
        {
            tendn = ten;
            InitializeComponent();
            Xofile();
            MessageBox.Show("Đăng nhập thành công");
        }
        public Menu()
        {
            InitializeComponent();
            Xofile();
            MessageBox.Show("Đăng nhập thành công");
        }
        private void Xofile()
        {
          panelnguoidung.Visible = false;
        }
        private void hidepannelnguoidung()
        {
            if (panelnguoidung.Visible == true)
                panelnguoidung.Visible = false;

        }
        private void showpannelnguoidung()
        {
            if (panelnguoidung.Visible == false)
            {
                hidepannelnguoidung();
                panelnguoidung.Visible = true;
            }
            else
            {
                panelnguoidung.Visible = false;
            }

        }

        private void Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Minimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Maximizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            Maximizar.Visible = false;
            Restaurar.Visible = true;
        }

        private void Restaurar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            Restaurar.Visible = false;
            Maximizar.Visible = true;
        }

        private void MenuSidebar_Click(object sender, EventArgs e)
        {
            if (Sidebar.Width == 270)
            {
                Sidebar.Visible = false;
                Sidebar.Width = 68;
                SidebarWrapper.Width = 90;
                LineaSidebar.Width = 52;
                AnimacionSidebar.Show(Sidebar);
            }
            else
            {
                Sidebar.Visible = false;
                Sidebar.Width = 270;
                SidebarWrapper.Width = 300;
                LineaSidebar.Width = 252;
                AnimacionSidebarBack.Show(Sidebar);
            }
        }

        private void Temporizador_Tick(object sender, EventArgs e)
        {
            Temporizador.Stop();

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            labeltime.Text = (DateTime.Now.Hour < 10 ? "0" + DateTime.Now.Hour.ToString() : DateTime.Now.Hour.ToString()) + ":" + (DateTime.Now.Minute < 10 ? "0" + DateTime.Now.Minute.ToString() : DateTime.Now.Minute.ToString()) + ":" + (DateTime.Now.Second < 10 ? "0" + DateTime.Now.Second.ToString() : DateTime.Now.Second.ToString());
            labeldate.Text = DateTime.Now.DayOfWeek.ToString() + ", " + (DateTime.Now.Day < 10 ? "0" + DateTime.Now.Day.ToString() : DateTime.Now.Day.ToString()) + "/" + (DateTime.Now.Month < 10 ? "0" + DateTime.Now.Month.ToString() : DateTime.Now.Month.ToString()) + "/" + DateTime.Now.Year;
        }
        private void btnnguoidung_Click(object sender, EventArgs e)
        {
            showpannelnguoidung();
        }
        private void bunifuFlatButton8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //SHOW:
        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            xemHoadon1.Visible = true;
            banhang1.Visible = false;
            nhanvien1.Visible = false;
            thanhtoan1.Visible = false;
            usersanpham1.Visible = false;
            nhaphangtunhaCC1.Visible = false;
            thongbao1.Visible = false;
            fmbaocao1.Visible = false;
            khachhang1.Visible = false;
            xemHoadon2.Visible = false;
            layoutPicture1.Visible = false;

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            banhang1.Visible = true;
            khachhang1.Visible = false;
            nhanvien1.Visible = false;
            xemHoadon1.Visible = false;
            thanhtoan1.Visible = false;
            usersanpham1.Visible = false;
            nhaphangtunhaCC1.Visible = false;
            xemHoadon2.Visible = false;
            thongbao1.Visible = false;
            fmbaocao1.Visible = false;
            khachhang1.Visible = false;
            layoutPicture1.Visible = false;
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
         
            banhang1.Visible = false;
            nhanvien1.Visible = false;   
            thanhtoan1.Visible = false;
            usersanpham1.Visible = false;
            nhaphangtunhaCC1.Visible = false;
            xemHoadon2.Visible = false;
            thongbao1.Visible = false;
            fmbaocao1.Visible = false;
            khachhang1.Visible = false;
            layoutPicture1.Visible = false;
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            nhanvien1.Visible = true;
            banhang1.Visible = false;
            xemHoadon2.Visible = false;
            thanhtoan1.Visible = false;
            usersanpham1.Visible = false;
            nhaphangtunhaCC1.Visible = false;
            thongbao1.Visible = false;
            fmbaocao1.Visible = false;
            khachhang1.Visible = false;
            layoutPicture1.Visible = false;
        }
        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            thanhtoan1.Visible = true;
           
            banhang1.Visible = false;
            nhanvien1.Visible = false;

            xemHoadon2.Visible = false;
            xemHoadon1.Visible = false;
        
            usersanpham1.Visible = false;
            nhaphangtunhaCC1.Visible = false;
            thongbao1.Visible = false;
            fmbaocao1.Visible = false;
            khachhang1.Visible = false;
            layoutPicture1.Visible = false;
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            khachhang1.Visible = true;
            banhang1.Visible = false;
            nhanvien1.Visible = false;
            xemHoadon1.Visible = false;
            thanhtoan1.Visible = false; 
            usersanpham1.Visible = false;
            xemHoadon2.Visible = false;
            nhaphangtunhaCC1.Visible = false;
            thongbao1.Visible = false;
            fmbaocao1.Visible = false;
            layoutPicture1.Visible = false;
        }

        private void bunifuFlatButton9_Click(object sender, EventArgs e)
        {
           
            banhang1.Visible = false;
            nhanvien1.Visible = false;
            xemHoadon1.Visible = false;
            khachhang1.Visible = false;
            thanhtoan1.Visible = false;
            nhaphangtunhaCC1.Visible = false;
            xemHoadon2.Visible = false;
            usersanpham1.Visible = false;
            nhaphangtunhaCC1.Visible = false;
            thongbao1.Visible = false;
            fmbaocao1.Visible = false;
            layoutPicture1.Visible = false;

        }
        private void Menu_Load(object sender, EventArgs e)
        {
            string quyen = AccountDAO.Instance.getquyen(tendn);
            Console.WriteLine(quyen);
            if(quyen.ToUpper()=="KHO")
            {
                this.bthoadon.Visible = false;
                this.btthongke.Visible = false;
                this.btkhachhang.Visible = false;
            }
            if(quyen.ToUpper()=="THỐNG KÊ")
            {
                this.btthongbao.Visible = false;
                this.btkhachhang.Visible = false;
            }
            if (quyen.ToUpper() == "KHACHHANG") {
                {
                  
                    this.bthanghoa.Visible = true;
                   this. btthongbao.Visible = true;
                    this.bthoadon.Visible = false;
                    this.btkhachhang.Visible = false;
                    this.btnnguoidung.Visible = true;
                    this.btbanhang.Visible = false;
                    this.btnhaphnag.Visible = false;
                    this.btthongke.Visible = false;
                    this.bthanghoa.Dock.ToString();

                } }
            if (quyen.ToUpper() == "BANHANG") {
                {
                    this.bthanghoa.Visible = true;
                    this.btthongbao.Visible = true;
                    this.bthoadon.Visible = false;
                    this.btkhachhang.Visible = true;
                    this.btnnguoidung.Visible = true;
                    this.btbanhang.Visible = true;
                    this.btnhaphnag.Visible = false;

                } }
           
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            xemHoadon2.Visible = true;
            banhang1.Visible = false;
            nhanvien1.Visible = false;
            xemHoadon1.Visible = false;
            thanhtoan1.Visible = false;
            khachhang1.Visible = false;
            usersanpham1.Visible = false;
            nhaphangtunhaCC1.Visible = false;
            thongbao1.Visible = false;
            fmbaocao1.Visible = false;
            layoutPicture1.Visible = false;

        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
           
         
            banhang1.Visible = false;
            nhanvien1.Visible = false;
            khachhang1.Visible = false;

            xemHoadon2.Visible = false;
            thanhtoan1.Visible = false;
            usersanpham1.Visible = false;
            nhaphangtunhaCC1.Visible = false;
            thongbao1.Visible = false;
            fmbaocao1.Visible = false;
            layoutPicture1.Visible = false;
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            usersanpham1.Visible = true;
            banhang1.Visible = false;
            nhanvien1.Visible = false;
            xemHoadon2.Visible = false;
            thanhtoan1.Visible = false;
            nhaphangtunhaCC1.Visible = false;
            thongbao1.Visible = false;
            khachhang1.Visible = false;
            fmbaocao1.Visible = false;
            layoutPicture1.Visible = false;
        }

        private void bunifuFlatButton9_Click_1(object sender, EventArgs e)
        {
            nhaphangtunhaCC1.Visible = true;
            usersanpham1.Visible = false;  
            banhang1.Visible = false;
            nhanvien1.Visible = false;
            xemHoadon2.Visible = false;
            thanhtoan1.Visible = false;
            thongbao1.Visible = false;
            fmbaocao1.Visible = false;
            khachhang1.Visible = false;
            layoutPicture1.Visible = false;

        }


        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn rời khỏi đây", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void bunifuFlatButton7_Click(object sender, EventArgs e)
        {
            thongbao1.Visible = true;
            nhaphangtunhaCC1.Visible = false;
            usersanpham1.Visible = false;
            khachhang1.Visible = false;  
            banhang1.Visible = false;
            nhanvien1.Visible = false;
            xemHoadon2.Visible = false;
            thanhtoan1.Visible = false;
            fmbaocao1.Visible = false;
             layoutPicture1.Visible = false;

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            fmbaocao1.Visible = true;
            thongbao1.Visible = false;
            nhaphangtunhaCC1.Visible = false;
            usersanpham1.Visible = false; 
            banhang1.Visible = false;
            nhanvien1.Visible = false;
            xemHoadon2.Visible = false;
            thanhtoan1.Visible = false;
            khachhang1.Visible = false;
            layoutPicture1.Visible = false;

        }
        public int i = 10;
        private void timnerChaychu_Tick(object sender, EventArgs e)
        {
            labelChuChay.Left += i;
            if (labelChuChay.Left >= this.Width - labelChuChay.Width || labelChuChay.Left <= 0)
                i = -i;
        }
    }
}
