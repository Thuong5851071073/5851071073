namespace Design_Dashboard_Modern
{
    partial class Menu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            BunifuAnimatorNS.Animation animation4 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation3 = new BunifuAnimatorNS.Animation();
            this.SidebarWrapper = new System.Windows.Forms.Panel();
            this.Sidebar = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnhaphnag = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panelnguoidung = new System.Windows.Forms.Panel();
            this.bunifuFlatButton8 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btthongbao = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btkhachhang = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnnguoidung = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btbanhang = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bthoadon = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bthanghoa = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btthongke = new Bunifu.Framework.UI.BunifuFlatButton();
            this.LineaSidebar = new Bunifu.Framework.UI.BunifuSeparator();
            this.Wrapper = new System.Windows.Forms.Panel();
            this.layoutPicture1 = new Design_Dashboard_Modern.LayoutPicture();
            this.khachhang1 = new Design_Dashboard_Modern.khachhang();
            this.fmbaocao1 = new Design_Dashboard_Modern.fmbaocao();
            this.thongbao1 = new Design_Dashboard_Modern.Thongbao();
            this.xemHoadon2 = new Design_Dashboard_Modern.XemHoadon();
            this.nhaphangtunhaCC1 = new Design_Dashboard_Modern.NhaphangtunhaCC();
            this.usersanpham1 = new Design_Dashboard_Modern.usersanpham();
            this.thanhtoan1 = new Design_Dashboard_Modern.Thanhtoan();
            this.xemHoadon1 = new Design_Dashboard_Modern.XemHoadon();
            this.nhanvien1 = new Design_Dashboard_Modern.DVT();
            this.banhang1 = new Design_Dashboard_Modern.banhang();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labeldate = new System.Windows.Forms.Label();
            this.labeltime = new System.Windows.Forms.Label();
            this.CurvaSidebar = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.AnimacionSidebar = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.labelChuChay = new System.Windows.Forms.Label();
            this.MenuTop = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MenuSidebar = new System.Windows.Forms.PictureBox();
            this.Maximizar = new System.Windows.Forms.PictureBox();
            this.Restaurar = new System.Windows.Forms.PictureBox();
            this.Salir = new System.Windows.Forms.PictureBox();
            this.Minimizar = new System.Windows.Forms.PictureBox();
            this.AnimacionSidebarBack = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.RadioPanelChart = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Temporizador = new System.Windows.Forms.Timer(this.components);
            this.MoverDashboard = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timnerChaychu = new System.Windows.Forms.Timer(this.components);
            this.SidebarWrapper.SuspendLayout();
            this.Sidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelnguoidung.SuspendLayout();
            this.Wrapper.SuspendLayout();
            this.panel2.SuspendLayout();
            this.MenuTop.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MenuSidebar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Restaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Salir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).BeginInit();
            this.SuspendLayout();
            // 
            // SidebarWrapper
            // 
            this.SidebarWrapper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.SidebarWrapper.Controls.Add(this.Sidebar);
            this.AnimacionSidebarBack.SetDecoration(this.SidebarWrapper, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.SidebarWrapper, BunifuAnimatorNS.DecorationType.None);
            this.SidebarWrapper.Dock = System.Windows.Forms.DockStyle.Left;
            this.SidebarWrapper.Location = new System.Drawing.Point(0, 98);
            this.SidebarWrapper.Margin = new System.Windows.Forms.Padding(4);
            this.SidebarWrapper.Name = "SidebarWrapper";
            this.SidebarWrapper.Size = new System.Drawing.Size(400, 1004);
            this.SidebarWrapper.TabIndex = 1;
            // 
            // Sidebar
            // 
            this.Sidebar.AutoScroll = true;
            this.Sidebar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Sidebar.BackgroundImage")));
            this.Sidebar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Sidebar.Controls.Add(this.pictureBox1);
            this.Sidebar.Controls.Add(this.btnhaphnag);
            this.Sidebar.Controls.Add(this.panelnguoidung);
            this.Sidebar.Controls.Add(this.btthongbao);
            this.Sidebar.Controls.Add(this.btkhachhang);
            this.Sidebar.Controls.Add(this.btnnguoidung);
            this.Sidebar.Controls.Add(this.btbanhang);
            this.Sidebar.Controls.Add(this.bthoadon);
            this.Sidebar.Controls.Add(this.bthanghoa);
            this.Sidebar.Controls.Add(this.btthongke);
            this.Sidebar.Controls.Add(this.LineaSidebar);
            this.AnimacionSidebarBack.SetDecoration(this.Sidebar, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.Sidebar, BunifuAnimatorNS.DecorationType.None);
            this.Sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.Sidebar.GradientBottomLeft = System.Drawing.Color.White;
            this.Sidebar.GradientBottomRight = System.Drawing.Color.White;
            this.Sidebar.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.Sidebar.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.Sidebar.Location = new System.Drawing.Point(0, 0);
            this.Sidebar.Margin = new System.Windows.Forms.Padding(4);
            this.Sidebar.Name = "Sidebar";
            this.Sidebar.Quality = 10;
            this.Sidebar.Size = new System.Drawing.Size(393, 1004);
            this.Sidebar.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebar.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Image = global::Design_Dashboard_Modern.Properties.Resources.Artboard_1mdpi1;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(387, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // btnhaphnag
            // 
            this.btnhaphnag.Activecolor = System.Drawing.Color.Transparent;
            this.btnhaphnag.BackColor = System.Drawing.Color.Transparent;
            this.btnhaphnag.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnhaphnag.BorderRadius = 0;
            this.btnhaphnag.ButtonText = "NHẬP HÀNG";
            this.btnhaphnag.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebarBack.SetDecoration(this.btnhaphnag, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.btnhaphnag, BunifuAnimatorNS.DecorationType.None);
            this.btnhaphnag.DisabledColor = System.Drawing.Color.Gray;
            this.btnhaphnag.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhaphnag.Iconcolor = System.Drawing.Color.Transparent;
            this.btnhaphnag.Iconimage = global::Design_Dashboard_Modern.Properties.Resources.icons8_product_321;
            this.btnhaphnag.Iconimage_right = null;
            this.btnhaphnag.Iconimage_right_Selected = null;
            this.btnhaphnag.Iconimage_Selected = null;
            this.btnhaphnag.IconMarginLeft = 0;
            this.btnhaphnag.IconMarginRight = 0;
            this.btnhaphnag.IconRightVisible = true;
            this.btnhaphnag.IconRightZoom = 0D;
            this.btnhaphnag.IconVisible = true;
            this.btnhaphnag.IconZoom = 50D;
            this.btnhaphnag.IsTab = false;
            this.btnhaphnag.Location = new System.Drawing.Point(25, 97);
            this.btnhaphnag.Margin = new System.Windows.Forms.Padding(5);
            this.btnhaphnag.Name = "btnhaphnag";
            this.btnhaphnag.Normalcolor = System.Drawing.Color.Transparent;
            this.btnhaphnag.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnhaphnag.OnHoverTextColor = System.Drawing.Color.Red;
            this.btnhaphnag.selected = false;
            this.btnhaphnag.Size = new System.Drawing.Size(336, 63);
            this.btnhaphnag.TabIndex = 18;
            this.btnhaphnag.Text = "NHẬP HÀNG";
            this.btnhaphnag.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnhaphnag.Textcolor = System.Drawing.Color.Black;
            this.btnhaphnag.TextFont = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhaphnag.Click += new System.EventHandler(this.bunifuFlatButton9_Click_1);
            // 
            // panelnguoidung
            // 
            this.panelnguoidung.BackColor = System.Drawing.Color.Transparent;
            this.panelnguoidung.Controls.Add(this.bunifuFlatButton8);
            this.AnimacionSidebarBack.SetDecoration(this.panelnguoidung, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.panelnguoidung, BunifuAnimatorNS.DecorationType.None);
            this.panelnguoidung.Location = new System.Drawing.Point(25, 679);
            this.panelnguoidung.Name = "panelnguoidung";
            this.panelnguoidung.Size = new System.Drawing.Size(345, 123);
            this.panelnguoidung.TabIndex = 15;
            // 
            // bunifuFlatButton8
            // 
            this.bunifuFlatButton8.Activecolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton8.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton8.BorderRadius = 0;
            this.bunifuFlatButton8.ButtonText = "ĐĂNG XUẤT";
            this.bunifuFlatButton8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebarBack.SetDecoration(this.bunifuFlatButton8, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.bunifuFlatButton8, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton8.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton8.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton8.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton8.Iconimage = global::Design_Dashboard_Modern.Properties.Resources.icons8_logout_rounded_down_32;
            this.bunifuFlatButton8.Iconimage_right = null;
            this.bunifuFlatButton8.Iconimage_right_Selected = null;
            this.bunifuFlatButton8.Iconimage_Selected = null;
            this.bunifuFlatButton8.IconMarginLeft = 0;
            this.bunifuFlatButton8.IconMarginRight = 0;
            this.bunifuFlatButton8.IconRightVisible = true;
            this.bunifuFlatButton8.IconRightZoom = 0D;
            this.bunifuFlatButton8.IconVisible = true;
            this.bunifuFlatButton8.IconZoom = 50D;
            this.bunifuFlatButton8.IsTab = false;
            this.bunifuFlatButton8.Location = new System.Drawing.Point(5, 5);
            this.bunifuFlatButton8.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuFlatButton8.Name = "bunifuFlatButton8";
            this.bunifuFlatButton8.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton8.OnHovercolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton8.OnHoverTextColor = System.Drawing.Color.Red;
            this.bunifuFlatButton8.selected = false;
            this.bunifuFlatButton8.Size = new System.Drawing.Size(335, 63);
            this.bunifuFlatButton8.TabIndex = 14;
            this.bunifuFlatButton8.Text = "ĐĂNG XUẤT";
            this.bunifuFlatButton8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton8.Textcolor = System.Drawing.Color.Black;
            this.bunifuFlatButton8.TextFont = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton8.Click += new System.EventHandler(this.bunifuFlatButton8_Click);
            // 
            // btthongbao
            // 
            this.btthongbao.Activecolor = System.Drawing.Color.Transparent;
            this.btthongbao.BackColor = System.Drawing.Color.Transparent;
            this.btthongbao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btthongbao.BorderRadius = 0;
            this.btthongbao.ButtonText = "THÔNG BÁO";
            this.btthongbao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebarBack.SetDecoration(this.btthongbao, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.btthongbao, BunifuAnimatorNS.DecorationType.None);
            this.btthongbao.DisabledColor = System.Drawing.Color.Gray;
            this.btthongbao.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btthongbao.Iconcolor = System.Drawing.Color.Transparent;
            this.btthongbao.Iconimage = global::Design_Dashboard_Modern.Properties.Resources.icons8_megaphone_32;
            this.btthongbao.Iconimage_right = null;
            this.btthongbao.Iconimage_right_Selected = null;
            this.btthongbao.Iconimage_Selected = null;
            this.btthongbao.IconMarginLeft = 0;
            this.btthongbao.IconMarginRight = 0;
            this.btthongbao.IconRightVisible = true;
            this.btthongbao.IconRightZoom = 0D;
            this.btthongbao.IconVisible = true;
            this.btthongbao.IconZoom = 50D;
            this.btthongbao.IsTab = false;
            this.btthongbao.Location = new System.Drawing.Point(25, 535);
            this.btthongbao.Margin = new System.Windows.Forms.Padding(5);
            this.btthongbao.Name = "btthongbao";
            this.btthongbao.Normalcolor = System.Drawing.Color.Transparent;
            this.btthongbao.OnHovercolor = System.Drawing.Color.Transparent;
            this.btthongbao.OnHoverTextColor = System.Drawing.Color.Red;
            this.btthongbao.selected = false;
            this.btthongbao.Size = new System.Drawing.Size(336, 63);
            this.btthongbao.TabIndex = 14;
            this.btthongbao.Text = "THÔNG BÁO";
            this.btthongbao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btthongbao.Textcolor = System.Drawing.Color.Black;
            this.btthongbao.TextFont = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btthongbao.Click += new System.EventHandler(this.bunifuFlatButton7_Click);
            // 
            // btkhachhang
            // 
            this.btkhachhang.Activecolor = System.Drawing.Color.Transparent;
            this.btkhachhang.BackColor = System.Drawing.Color.Transparent;
            this.btkhachhang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btkhachhang.BorderRadius = 0;
            this.btkhachhang.ButtonText = "      KHÁCH HÀNG";
            this.btkhachhang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebarBack.SetDecoration(this.btkhachhang, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.btkhachhang, BunifuAnimatorNS.DecorationType.None);
            this.btkhachhang.DisabledColor = System.Drawing.Color.Gray;
            this.btkhachhang.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btkhachhang.Iconcolor = System.Drawing.Color.Transparent;
            this.btkhachhang.Iconimage = global::Design_Dashboard_Modern.Properties.Resources.icons8_customs_officer_32;
            this.btkhachhang.Iconimage_right = null;
            this.btkhachhang.Iconimage_right_Selected = null;
            this.btkhachhang.Iconimage_Selected = null;
            this.btkhachhang.IconMarginLeft = 0;
            this.btkhachhang.IconMarginRight = 0;
            this.btkhachhang.IconRightVisible = true;
            this.btkhachhang.IconRightZoom = 0D;
            this.btkhachhang.IconVisible = true;
            this.btkhachhang.IconZoom = 50D;
            this.btkhachhang.IsTab = false;
            this.btkhachhang.Location = new System.Drawing.Point(25, 389);
            this.btkhachhang.Margin = new System.Windows.Forms.Padding(5);
            this.btkhachhang.Name = "btkhachhang";
            this.btkhachhang.Normalcolor = System.Drawing.Color.Transparent;
            this.btkhachhang.OnHovercolor = System.Drawing.Color.Transparent;
            this.btkhachhang.OnHoverTextColor = System.Drawing.Color.Red;
            this.btkhachhang.selected = false;
            this.btkhachhang.Size = new System.Drawing.Size(336, 63);
            this.btkhachhang.TabIndex = 12;
            this.btkhachhang.Text = "      KHÁCH HÀNG";
            this.btkhachhang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btkhachhang.Textcolor = System.Drawing.Color.Black;
            this.btkhachhang.TextFont = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btkhachhang.Click += new System.EventHandler(this.bunifuFlatButton5_Click);
            // 
            // btnnguoidung
            // 
            this.btnnguoidung.Activecolor = System.Drawing.Color.Transparent;
            this.btnnguoidung.BackColor = System.Drawing.Color.Transparent;
            this.btnnguoidung.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnnguoidung.BorderRadius = 0;
            this.btnnguoidung.ButtonText = "      NGƯỜI DÙNG";
            this.btnnguoidung.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebarBack.SetDecoration(this.btnnguoidung, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.btnnguoidung, BunifuAnimatorNS.DecorationType.None);
            this.btnnguoidung.DisabledColor = System.Drawing.Color.Gray;
            this.btnnguoidung.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnguoidung.Iconcolor = System.Drawing.Color.Transparent;
            this.btnnguoidung.Iconimage = global::Design_Dashboard_Modern.Properties.Resources.icons8_male_user_32;
            this.btnnguoidung.Iconimage_right = null;
            this.btnnguoidung.Iconimage_right_Selected = null;
            this.btnnguoidung.Iconimage_Selected = null;
            this.btnnguoidung.IconMarginLeft = 0;
            this.btnnguoidung.IconMarginRight = 0;
            this.btnnguoidung.IconRightVisible = true;
            this.btnnguoidung.IconRightZoom = 0D;
            this.btnnguoidung.IconVisible = true;
            this.btnnguoidung.IconZoom = 50D;
            this.btnnguoidung.IsTab = false;
            this.btnnguoidung.Location = new System.Drawing.Point(25, 608);
            this.btnnguoidung.Margin = new System.Windows.Forms.Padding(5);
            this.btnnguoidung.Name = "btnnguoidung";
            this.btnnguoidung.Normalcolor = System.Drawing.Color.Transparent;
            this.btnnguoidung.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnnguoidung.OnHoverTextColor = System.Drawing.Color.Red;
            this.btnnguoidung.selected = false;
            this.btnnguoidung.Size = new System.Drawing.Size(336, 63);
            this.btnnguoidung.TabIndex = 13;
            this.btnnguoidung.Text = "      NGƯỜI DÙNG";
            this.btnnguoidung.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnnguoidung.Textcolor = System.Drawing.Color.Black;
            this.btnnguoidung.TextFont = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnguoidung.Click += new System.EventHandler(this.btnnguoidung_Click);
            // 
            // btbanhang
            // 
            this.btbanhang.Activecolor = System.Drawing.Color.Transparent;
            this.btbanhang.BackColor = System.Drawing.Color.Transparent;
            this.btbanhang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btbanhang.BorderRadius = 0;
            this.btbanhang.ButtonText = "BÁN HÀNG";
            this.btbanhang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebarBack.SetDecoration(this.btbanhang, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.btbanhang, BunifuAnimatorNS.DecorationType.None);
            this.btbanhang.DisabledColor = System.Drawing.Color.Gray;
            this.btbanhang.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbanhang.Iconcolor = System.Drawing.Color.Transparent;
            this.btbanhang.Iconimage = global::Design_Dashboard_Modern.Properties.Resources.icons8_shopping_cart_32;
            this.btbanhang.Iconimage_right = null;
            this.btbanhang.Iconimage_right_Selected = null;
            this.btbanhang.Iconimage_Selected = null;
            this.btbanhang.IconMarginLeft = 0;
            this.btbanhang.IconMarginRight = 0;
            this.btbanhang.IconRightVisible = true;
            this.btbanhang.IconRightZoom = 0D;
            this.btbanhang.IconVisible = true;
            this.btbanhang.IconZoom = 50D;
            this.btbanhang.IsTab = false;
            this.btbanhang.Location = new System.Drawing.Point(25, 170);
            this.btbanhang.Margin = new System.Windows.Forms.Padding(5);
            this.btbanhang.Name = "btbanhang";
            this.btbanhang.Normalcolor = System.Drawing.Color.Transparent;
            this.btbanhang.OnHovercolor = System.Drawing.Color.Transparent;
            this.btbanhang.OnHoverTextColor = System.Drawing.Color.Red;
            this.btbanhang.selected = false;
            this.btbanhang.Size = new System.Drawing.Size(336, 63);
            this.btbanhang.TabIndex = 11;
            this.btbanhang.Text = "BÁN HÀNG";
            this.btbanhang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btbanhang.Textcolor = System.Drawing.Color.Black;
            this.btbanhang.TextFont = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbanhang.Click += new System.EventHandler(this.bunifuFlatButton4_Click);
            // 
            // bthoadon
            // 
            this.bthoadon.Activecolor = System.Drawing.Color.Transparent;
            this.bthoadon.BackColor = System.Drawing.Color.Transparent;
            this.bthoadon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bthoadon.BorderRadius = 0;
            this.bthoadon.ButtonText = "HÓA ĐƠN";
            this.bthoadon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebarBack.SetDecoration(this.bthoadon, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.bthoadon, BunifuAnimatorNS.DecorationType.None);
            this.bthoadon.DisabledColor = System.Drawing.Color.Gray;
            this.bthoadon.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bthoadon.Iconcolor = System.Drawing.Color.Transparent;
            this.bthoadon.Iconimage = global::Design_Dashboard_Modern.Properties.Resources.icons8_stack_of_money_32;
            this.bthoadon.Iconimage_right = null;
            this.bthoadon.Iconimage_right_Selected = null;
            this.bthoadon.Iconimage_Selected = null;
            this.bthoadon.IconMarginLeft = 0;
            this.bthoadon.IconMarginRight = 0;
            this.bthoadon.IconRightVisible = true;
            this.bthoadon.IconRightZoom = 0D;
            this.bthoadon.IconVisible = true;
            this.bthoadon.IconZoom = 50D;
            this.bthoadon.IsTab = false;
            this.bthoadon.Location = new System.Drawing.Point(25, 316);
            this.bthoadon.Margin = new System.Windows.Forms.Padding(5);
            this.bthoadon.Name = "bthoadon";
            this.bthoadon.Normalcolor = System.Drawing.Color.Transparent;
            this.bthoadon.OnHovercolor = System.Drawing.Color.Transparent;
            this.bthoadon.OnHoverTextColor = System.Drawing.Color.Red;
            this.bthoadon.selected = false;
            this.bthoadon.Size = new System.Drawing.Size(336, 63);
            this.bthoadon.TabIndex = 10;
            this.bthoadon.Text = "HÓA ĐƠN";
            this.bthoadon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bthoadon.Textcolor = System.Drawing.Color.Black;
            this.bthoadon.TextFont = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bthoadon.Click += new System.EventHandler(this.bunifuFlatButton3_Click);
            // 
            // bthanghoa
            // 
            this.bthanghoa.Activecolor = System.Drawing.Color.Transparent;
            this.bthanghoa.BackColor = System.Drawing.Color.Transparent;
            this.bthanghoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bthanghoa.BorderRadius = 0;
            this.bthanghoa.ButtonText = "     HÀNG HÓA";
            this.bthanghoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebarBack.SetDecoration(this.bthanghoa, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.bthanghoa, BunifuAnimatorNS.DecorationType.None);
            this.bthanghoa.DisabledColor = System.Drawing.Color.Gray;
            this.bthanghoa.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bthanghoa.Iconcolor = System.Drawing.Color.Transparent;
            this.bthanghoa.Iconimage = global::Design_Dashboard_Modern.Properties.Resources.icons8_add_shopping_cart_32;
            this.bthanghoa.Iconimage_right = null;
            this.bthanghoa.Iconimage_right_Selected = null;
            this.bthanghoa.Iconimage_Selected = null;
            this.bthanghoa.IconMarginLeft = 0;
            this.bthanghoa.IconMarginRight = 0;
            this.bthanghoa.IconRightVisible = true;
            this.bthanghoa.IconRightZoom = 0D;
            this.bthanghoa.IconVisible = true;
            this.bthanghoa.IconZoom = 50D;
            this.bthanghoa.IsTab = false;
            this.bthanghoa.Location = new System.Drawing.Point(25, 243);
            this.bthanghoa.Margin = new System.Windows.Forms.Padding(5);
            this.bthanghoa.Name = "bthanghoa";
            this.bthanghoa.Normalcolor = System.Drawing.Color.Transparent;
            this.bthanghoa.OnHovercolor = System.Drawing.Color.Transparent;
            this.bthanghoa.OnHoverTextColor = System.Drawing.Color.Red;
            this.bthanghoa.selected = false;
            this.bthanghoa.Size = new System.Drawing.Size(336, 63);
            this.bthanghoa.TabIndex = 9;
            this.bthanghoa.Text = "     HÀNG HÓA";
            this.bthanghoa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bthanghoa.Textcolor = System.Drawing.Color.Black;
            this.bthanghoa.TextFont = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bthanghoa.Click += new System.EventHandler(this.bunifuFlatButton2_Click);
            // 
            // btthongke
            // 
            this.btthongke.Activecolor = System.Drawing.Color.Transparent;
            this.btthongke.BackColor = System.Drawing.Color.Transparent;
            this.btthongke.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btthongke.BorderRadius = 0;
            this.btthongke.ButtonText = "THỐNG KÊ";
            this.btthongke.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebarBack.SetDecoration(this.btthongke, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.btthongke, BunifuAnimatorNS.DecorationType.None);
            this.btthongke.DisabledColor = System.Drawing.Color.Silver;
            this.btthongke.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btthongke.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btthongke.Iconcolor = System.Drawing.Color.Transparent;
            this.btthongke.Iconimage = global::Design_Dashboard_Modern.Properties.Resources.icons8_doughnut_chart_32;
            this.btthongke.Iconimage_right = null;
            this.btthongke.Iconimage_right_Selected = null;
            this.btthongke.Iconimage_Selected = null;
            this.btthongke.IconMarginLeft = 0;
            this.btthongke.IconMarginRight = 0;
            this.btthongke.IconRightVisible = true;
            this.btthongke.IconRightZoom = 0D;
            this.btthongke.IconVisible = true;
            this.btthongke.IconZoom = 50D;
            this.btthongke.IsTab = false;
            this.btthongke.Location = new System.Drawing.Point(25, 462);
            this.btthongke.Margin = new System.Windows.Forms.Padding(5);
            this.btthongke.Name = "btthongke";
            this.btthongke.Normalcolor = System.Drawing.Color.Transparent;
            this.btthongke.OnHovercolor = System.Drawing.Color.Transparent;
            this.btthongke.OnHoverTextColor = System.Drawing.Color.Red;
            this.btthongke.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btthongke.selected = true;
            this.btthongke.Size = new System.Drawing.Size(336, 63);
            this.btthongke.TabIndex = 8;
            this.btthongke.Text = "THỐNG KÊ";
            this.btthongke.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btthongke.Textcolor = System.Drawing.Color.Black;
            this.btthongke.TextFont = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btthongke.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // LineaSidebar
            // 
            this.LineaSidebar.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebarBack.SetDecoration(this.LineaSidebar, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.LineaSidebar, BunifuAnimatorNS.DecorationType.None);
            this.LineaSidebar.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LineaSidebar.LineThickness = 1;
            this.LineaSidebar.Location = new System.Drawing.Point(9, 84);
            this.LineaSidebar.Margin = new System.Windows.Forms.Padding(5);
            this.LineaSidebar.Name = "LineaSidebar";
            this.LineaSidebar.Size = new System.Drawing.Size(336, 1);
            this.LineaSidebar.TabIndex = 7;
            this.LineaSidebar.Transparency = 255;
            this.LineaSidebar.Vertical = false;
            // 
            // Wrapper
            // 
            this.Wrapper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.Wrapper.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Wrapper.Controls.Add(this.layoutPicture1);
            this.Wrapper.Controls.Add(this.khachhang1);
            this.Wrapper.Controls.Add(this.fmbaocao1);
            this.Wrapper.Controls.Add(this.thongbao1);
            this.Wrapper.Controls.Add(this.xemHoadon2);
            this.Wrapper.Controls.Add(this.nhaphangtunhaCC1);
            this.Wrapper.Controls.Add(this.usersanpham1);
            this.Wrapper.Controls.Add(this.thanhtoan1);
            this.Wrapper.Controls.Add(this.xemHoadon1);
            this.Wrapper.Controls.Add(this.nhanvien1);
            this.Wrapper.Controls.Add(this.banhang1);
            this.AnimacionSidebarBack.SetDecoration(this.Wrapper, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.Wrapper, BunifuAnimatorNS.DecorationType.None);
            this.Wrapper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Wrapper.Location = new System.Drawing.Point(400, 98);
            this.Wrapper.Margin = new System.Windows.Forms.Padding(4);
            this.Wrapper.Name = "Wrapper";
            this.Wrapper.Size = new System.Drawing.Size(1467, 1004);
            this.Wrapper.TabIndex = 2;
            // 
            // layoutPicture1
            // 
            this.layoutPicture1.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebar.SetDecoration(this.layoutPicture1, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.layoutPicture1, BunifuAnimatorNS.DecorationType.None);
            this.layoutPicture1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutPicture1.Location = new System.Drawing.Point(0, 0);
            this.layoutPicture1.Name = "layoutPicture1";
            this.layoutPicture1.Size = new System.Drawing.Size(1467, 1004);
            this.layoutPicture1.TabIndex = 16;
            // 
            // khachhang1
            // 
            this.khachhang1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.AnimacionSidebar.SetDecoration(this.khachhang1, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.khachhang1, BunifuAnimatorNS.DecorationType.None);
            this.khachhang1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.khachhang1.Location = new System.Drawing.Point(0, 0);
            this.khachhang1.Name = "khachhang1";
            this.khachhang1.Size = new System.Drawing.Size(1467, 1004);
            this.khachhang1.TabIndex = 15;
            this.khachhang1.Visible = false;
            // 
            // fmbaocao1
            // 
            this.fmbaocao1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.AnimacionSidebar.SetDecoration(this.fmbaocao1, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.fmbaocao1, BunifuAnimatorNS.DecorationType.None);
            this.fmbaocao1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fmbaocao1.Location = new System.Drawing.Point(0, 0);
            this.fmbaocao1.Name = "fmbaocao1";
            this.fmbaocao1.Size = new System.Drawing.Size(1467, 1004);
            this.fmbaocao1.TabIndex = 14;
            this.fmbaocao1.Visible = false;
            // 
            // thongbao1
            // 
            this.thongbao1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.AnimacionSidebar.SetDecoration(this.thongbao1, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.thongbao1, BunifuAnimatorNS.DecorationType.None);
            this.thongbao1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.thongbao1.Location = new System.Drawing.Point(0, 0);
            this.thongbao1.Name = "thongbao1";
            this.thongbao1.Size = new System.Drawing.Size(1467, 1004);
            this.thongbao1.TabIndex = 13;
            this.thongbao1.Visible = false;
            // 
            // xemHoadon2
            // 
            this.xemHoadon2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.AnimacionSidebar.SetDecoration(this.xemHoadon2, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.xemHoadon2, BunifuAnimatorNS.DecorationType.None);
            this.xemHoadon2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xemHoadon2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xemHoadon2.Location = new System.Drawing.Point(0, 0);
            this.xemHoadon2.Name = "xemHoadon2";
            this.xemHoadon2.Size = new System.Drawing.Size(1467, 1004);
            this.xemHoadon2.TabIndex = 12;
            this.xemHoadon2.Visible = false;
            // 
            // nhaphangtunhaCC1
            // 
            this.nhaphangtunhaCC1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.AnimacionSidebar.SetDecoration(this.nhaphangtunhaCC1, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.nhaphangtunhaCC1, BunifuAnimatorNS.DecorationType.None);
            this.nhaphangtunhaCC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nhaphangtunhaCC1.Location = new System.Drawing.Point(0, 0);
            this.nhaphangtunhaCC1.Name = "nhaphangtunhaCC1";
            this.nhaphangtunhaCC1.Size = new System.Drawing.Size(1467, 1004);
            this.nhaphangtunhaCC1.TabIndex = 11;
            this.nhaphangtunhaCC1.Visible = false;
            // 
            // usersanpham1
            // 
            this.usersanpham1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.AnimacionSidebar.SetDecoration(this.usersanpham1, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.usersanpham1, BunifuAnimatorNS.DecorationType.None);
            this.usersanpham1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usersanpham1.Location = new System.Drawing.Point(0, 0);
            this.usersanpham1.Name = "usersanpham1";
            this.usersanpham1.Size = new System.Drawing.Size(1467, 1004);
            this.usersanpham1.TabIndex = 10;
            this.usersanpham1.Visible = false;
            // 
            // thanhtoan1
            // 
            this.thanhtoan1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.AnimacionSidebar.SetDecoration(this.thanhtoan1, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.thanhtoan1, BunifuAnimatorNS.DecorationType.None);
            this.thanhtoan1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.thanhtoan1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.thanhtoan1.Location = new System.Drawing.Point(0, 0);
            this.thanhtoan1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.thanhtoan1.Name = "thanhtoan1";
            this.thanhtoan1.Size = new System.Drawing.Size(1467, 1004);
            this.thanhtoan1.TabIndex = 7;
            this.thanhtoan1.Visible = false;
            // 
            // xemHoadon1
            // 
            this.xemHoadon1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.AnimacionSidebar.SetDecoration(this.xemHoadon1, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.xemHoadon1, BunifuAnimatorNS.DecorationType.None);
            this.xemHoadon1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xemHoadon1.Location = new System.Drawing.Point(0, 0);
            this.xemHoadon1.Name = "xemHoadon1";
            this.xemHoadon1.Size = new System.Drawing.Size(1467, 1004);
            this.xemHoadon1.TabIndex = 6;
            this.xemHoadon1.Visible = false;
            // 
            // nhanvien1
            // 
            this.nhanvien1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.AnimacionSidebar.SetDecoration(this.nhanvien1, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.nhanvien1, BunifuAnimatorNS.DecorationType.None);
            this.nhanvien1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nhanvien1.Location = new System.Drawing.Point(0, 0);
            this.nhanvien1.Name = "nhanvien1";
            this.nhanvien1.Size = new System.Drawing.Size(1467, 1004);
            this.nhanvien1.TabIndex = 3;
            this.nhanvien1.Visible = false;
            // 
            // banhang1
            // 
            this.banhang1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.AnimacionSidebar.SetDecoration(this.banhang1, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.banhang1, BunifuAnimatorNS.DecorationType.None);
            this.banhang1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.banhang1.Location = new System.Drawing.Point(0, 0);
            this.banhang1.Name = "banhang1";
            this.banhang1.Size = new System.Drawing.Size(1467, 1004);
            this.banhang1.TabIndex = 2;
            this.banhang1.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labeldate);
            this.panel2.Controls.Add(this.labeltime);
            this.AnimacionSidebarBack.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.panel2.Location = new System.Drawing.Point(616, 12);
            this.panel2.Name = "panel2";
            this.panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel2.Size = new System.Drawing.Size(523, 73);
            this.panel2.TabIndex = 4;
            // 
            // labeldate
            // 
            this.labeldate.AutoSize = true;
            this.AnimacionSidebar.SetDecoration(this.labeldate, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.labeldate, BunifuAnimatorNS.DecorationType.None);
            this.labeldate.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeldate.ForeColor = System.Drawing.Color.White;
            this.labeldate.Location = new System.Drawing.Point(223, 27);
            this.labeldate.Name = "labeldate";
            this.labeldate.Size = new System.Drawing.Size(151, 32);
            this.labeldate.TabIndex = 1;
            this.labeldate.Text = "dd-mm-yyy";
            // 
            // labeltime
            // 
            this.labeltime.AutoSize = true;
            this.AnimacionSidebar.SetDecoration(this.labeltime, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.labeltime, BunifuAnimatorNS.DecorationType.None);
            this.labeltime.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltime.ForeColor = System.Drawing.Color.White;
            this.labeltime.Location = new System.Drawing.Point(54, 27);
            this.labeltime.Name = "labeltime";
            this.labeltime.Size = new System.Drawing.Size(117, 32);
            this.labeltime.TabIndex = 0;
            this.labeltime.Text = "00:00:00";
            // 
            // CurvaSidebar
            // 
            this.CurvaSidebar.ElipseRadius = 7;
            this.CurvaSidebar.TargetControl = this.Sidebar;
            // 
            // AnimacionSidebar
            // 
            this.AnimacionSidebar.AnimationType = BunifuAnimatorNS.AnimationType.Particles;
            this.AnimacionSidebar.Cursor = null;
            animation4.AnimateOnlyDifferences = true;
            animation4.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.BlindCoeff")));
            animation4.LeafCoeff = 0F;
            animation4.MaxTime = 1F;
            animation4.MinTime = 0F;
            animation4.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicCoeff")));
            animation4.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicShift")));
            animation4.MosaicSize = 1;
            animation4.Padding = new System.Windows.Forms.Padding(100, 50, 100, 150);
            animation4.RotateCoeff = 0F;
            animation4.RotateLimit = 0F;
            animation4.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.ScaleCoeff")));
            animation4.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.SlideCoeff")));
            animation4.TimeCoeff = 2F;
            animation4.TransparencyCoeff = 0F;
            this.AnimacionSidebar.DefaultAnimation = animation4;
            // 
            // labelChuChay
            // 
            this.labelChuChay.AutoSize = true;
            this.AnimacionSidebar.SetDecoration(this.labelChuChay, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.labelChuChay, BunifuAnimatorNS.DecorationType.None);
            this.labelChuChay.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChuChay.ForeColor = System.Drawing.Color.White;
            this.labelChuChay.Location = new System.Drawing.Point(4, 20);
            this.labelChuChay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelChuChay.Name = "labelChuChay";
            this.labelChuChay.Size = new System.Drawing.Size(264, 35);
            this.labelChuChay.TabIndex = 1;
            this.labelChuChay.Text = "Cửa Hàng Tạp Hóa";
            // 
            // MenuTop
            // 
            this.MenuTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.MenuTop.Controls.Add(this.panel1);
            this.MenuTop.Controls.Add(this.MenuSidebar);
            this.MenuTop.Controls.Add(this.Maximizar);
            this.MenuTop.Controls.Add(this.Restaurar);
            this.MenuTop.Controls.Add(this.Salir);
            this.MenuTop.Controls.Add(this.panel2);
            this.MenuTop.Controls.Add(this.Minimizar);
            this.AnimacionSidebarBack.SetDecoration(this.MenuTop, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.MenuTop, BunifuAnimatorNS.DecorationType.None);
            this.MenuTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuTop.Location = new System.Drawing.Point(0, 0);
            this.MenuTop.Margin = new System.Windows.Forms.Padding(4);
            this.MenuTop.Name = "MenuTop";
            this.MenuTop.Size = new System.Drawing.Size(1867, 98);
            this.MenuTop.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelChuChay);
            this.AnimacionSidebarBack.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(109, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(501, 73);
            this.panel1.TabIndex = 6;
            // 
            // MenuSidebar
            // 
            this.AnimacionSidebar.SetDecoration(this.MenuSidebar, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.MenuSidebar, BunifuAnimatorNS.DecorationType.None);
            this.MenuSidebar.Image = global::Design_Dashboard_Modern.Properties.Resources.icons8_menu_32;
            this.MenuSidebar.Location = new System.Drawing.Point(30, 28);
            this.MenuSidebar.Margin = new System.Windows.Forms.Padding(4);
            this.MenuSidebar.Name = "MenuSidebar";
            this.MenuSidebar.Size = new System.Drawing.Size(40, 37);
            this.MenuSidebar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MenuSidebar.TabIndex = 0;
            this.MenuSidebar.TabStop = false;
            this.MenuSidebar.Click += new System.EventHandler(this.MenuSidebar_Click);
            // 
            // Maximizar
            // 
            this.Maximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AnimacionSidebar.SetDecoration(this.Maximizar, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.Maximizar, BunifuAnimatorNS.DecorationType.None);
            this.Maximizar.Image = ((System.Drawing.Image)(resources.GetObject("Maximizar.Image")));
            this.Maximizar.Location = new System.Drawing.Point(1763, 28);
            this.Maximizar.Margin = new System.Windows.Forms.Padding(4);
            this.Maximizar.Name = "Maximizar";
            this.Maximizar.Size = new System.Drawing.Size(40, 37);
            this.Maximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Maximizar.TabIndex = 3;
            this.Maximizar.TabStop = false;
            this.Maximizar.Click += new System.EventHandler(this.Maximizar_Click);
            // 
            // Restaurar
            // 
            this.Restaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AnimacionSidebar.SetDecoration(this.Restaurar, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.Restaurar, BunifuAnimatorNS.DecorationType.None);
            this.Restaurar.Image = ((System.Drawing.Image)(resources.GetObject("Restaurar.Image")));
            this.Restaurar.Location = new System.Drawing.Point(1763, 28);
            this.Restaurar.Margin = new System.Windows.Forms.Padding(4);
            this.Restaurar.Name = "Restaurar";
            this.Restaurar.Size = new System.Drawing.Size(40, 37);
            this.Restaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Restaurar.TabIndex = 5;
            this.Restaurar.TabStop = false;
            this.Restaurar.Visible = false;
            this.Restaurar.Click += new System.EventHandler(this.Restaurar_Click);
            // 
            // Salir
            // 
            this.Salir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AnimacionSidebar.SetDecoration(this.Salir, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.Salir, BunifuAnimatorNS.DecorationType.None);
            this.Salir.Image = ((System.Drawing.Image)(resources.GetObject("Salir.Image")));
            this.Salir.Location = new System.Drawing.Point(1811, 28);
            this.Salir.Margin = new System.Windows.Forms.Padding(4);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(40, 37);
            this.Salir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Salir.TabIndex = 2;
            this.Salir.TabStop = false;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // Minimizar
            // 
            this.Minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AnimacionSidebar.SetDecoration(this.Minimizar, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.Minimizar, BunifuAnimatorNS.DecorationType.None);
            this.Minimizar.Image = ((System.Drawing.Image)(resources.GetObject("Minimizar.Image")));
            this.Minimizar.Location = new System.Drawing.Point(1715, 28);
            this.Minimizar.Margin = new System.Windows.Forms.Padding(4);
            this.Minimizar.Name = "Minimizar";
            this.Minimizar.Size = new System.Drawing.Size(40, 37);
            this.Minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Minimizar.TabIndex = 4;
            this.Minimizar.TabStop = false;
            this.Minimizar.Click += new System.EventHandler(this.Minimizar_Click);
            // 
            // AnimacionSidebarBack
            // 
            this.AnimacionSidebarBack.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.AnimacionSidebarBack.Cursor = null;
            animation3.AnimateOnlyDifferences = true;
            animation3.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.BlindCoeff")));
            animation3.LeafCoeff = 0F;
            animation3.MaxTime = 1F;
            animation3.MinTime = 0F;
            animation3.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicCoeff")));
            animation3.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicShift")));
            animation3.MosaicSize = 0;
            animation3.Padding = new System.Windows.Forms.Padding(0);
            animation3.RotateCoeff = 0F;
            animation3.RotateLimit = 0F;
            animation3.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.ScaleCoeff")));
            animation3.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.SlideCoeff")));
            animation3.TimeCoeff = 0F;
            animation3.TransparencyCoeff = 0F;
            this.AnimacionSidebarBack.DefaultAnimation = animation3;
            // 
            // RadioPanelChart
            // 
            this.RadioPanelChart.ElipseRadius = 7;
            this.RadioPanelChart.TargetControl = this;
            // 
            // Temporizador
            // 
            this.Temporizador.Enabled = true;
            this.Temporizador.Tick += new System.EventHandler(this.Temporizador_Tick);
            // 
            // MoverDashboard
            // 
            this.MoverDashboard.Fixed = true;
            this.MoverDashboard.Horizontal = true;
            this.MoverDashboard.TargetControl = this.MenuTop;
            this.MoverDashboard.Vertical = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timnerChaychu
            // 
            this.timnerChaychu.Enabled = true;
            this.timnerChaychu.Interval = 200;
            this.timnerChaychu.Tick += new System.EventHandler(this.timnerChaychu_Tick);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1867, 1102);
            this.Controls.Add(this.Wrapper);
            this.Controls.Add(this.SidebarWrapper);
            this.Controls.Add(this.MenuTop);
            this.AnimacionSidebar.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Menu_FormClosing);
            this.Load += new System.EventHandler(this.Menu_Load);
            this.SidebarWrapper.ResumeLayout(false);
            this.Sidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelnguoidung.ResumeLayout(false);
            this.Wrapper.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.MenuTop.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MenuSidebar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Restaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Salir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel SidebarWrapper;
        private System.Windows.Forms.Panel Wrapper;
        private Bunifu.Framework.UI.BunifuGradientPanel Sidebar;
        private Bunifu.Framework.UI.BunifuFlatButton btthongbao;
        private Bunifu.Framework.UI.BunifuFlatButton btkhachhang;
        private Bunifu.Framework.UI.BunifuFlatButton btbanhang;
        private Bunifu.Framework.UI.BunifuFlatButton bthoadon;
        private Bunifu.Framework.UI.BunifuFlatButton bthanghoa;
        private Bunifu.Framework.UI.BunifuFlatButton btthongke;
        private Bunifu.Framework.UI.BunifuSeparator LineaSidebar;
        private Bunifu.Framework.UI.BunifuElipse CurvaSidebar;
        private BunifuAnimatorNS.BunifuTransition AnimacionSidebar;
        private BunifuAnimatorNS.BunifuTransition AnimacionSidebarBack;
        private Bunifu.Framework.UI.BunifuElipse RadioPanelChart;
        private System.Windows.Forms.Timer Temporizador;
        private Bunifu.Framework.UI.BunifuDragControl MoverDashboard;
        private System.Windows.Forms.Panel MenuTop;
        private System.Windows.Forms.PictureBox Restaurar;
        private System.Windows.Forms.PictureBox Minimizar;
        private System.Windows.Forms.PictureBox Maximizar;
        private System.Windows.Forms.PictureBox Salir;
        private System.Windows.Forms.Label labelChuChay;
        private System.Windows.Forms.PictureBox MenuSidebar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labeldate;
        private System.Windows.Forms.Label labeltime;
        private System.Windows.Forms.Timer timer1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton8;
        private Thanhtoan thanhtoan1;
        private XemHoadon xemHoadon1;
        private DVT nhanvien1;
        private banhang banhang1;
       
       // private khachhang xemkhachhang1;
        private usersanpham usersanpham1;
        private Bunifu.Framework.UI.BunifuFlatButton btnhaphnag;
        private NhaphangtunhaCC nhaphangtunhaCC1;
        private XemHoadon xemHoadon2;
        private System.Windows.Forms.Panel panelnguoidung;
        private Bunifu.Framework.UI.BunifuFlatButton btnnguoidung;
        private Thongbao thongbao1;
        private fmbaocao fmbaocao1;
        private khachhang khachhang1;
        private LayoutPicture layoutPicture1;
        private System.Windows.Forms.Timer timnerChaychu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

