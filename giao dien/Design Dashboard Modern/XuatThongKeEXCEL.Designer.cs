namespace Design_Dashboard_Modern
{
    partial class XuatThongKeEXCEL
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btxuat = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btxuatchitra = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dtDoanhthu = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataXuatTientra = new System.Windows.Forms.DataGridView();
            this.btguimail = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtDoanhthu)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataXuatTientra)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btguimail);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.btxuat);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1234, 336);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.btxuatchitra);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 342);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1234, 299);
            this.panel2.TabIndex = 1;
            // 
            // btxuat
            // 
            this.btxuat.Activecolor = System.Drawing.Color.Transparent;
            this.btxuat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.btxuat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btxuat.BorderRadius = 0;
            this.btxuat.ButtonText = "Xuất  Doanh Thu ";
            this.btxuat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btxuat.DisabledColor = System.Drawing.Color.Gray;
            this.btxuat.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btxuat.ForeColor = System.Drawing.Color.White;
            this.btxuat.Iconcolor = System.Drawing.Color.Transparent;
            this.btxuat.Iconimage = global::Design_Dashboard_Modern.Properties.Resources.icons8_microsoft_excel_2019_322;
            this.btxuat.Iconimage_right = null;
            this.btxuat.Iconimage_right_Selected = null;
            this.btxuat.Iconimage_Selected = null;
            this.btxuat.IconMarginLeft = 0;
            this.btxuat.IconMarginRight = 0;
            this.btxuat.IconRightVisible = true;
            this.btxuat.IconRightZoom = 0D;
            this.btxuat.IconVisible = true;
            this.btxuat.IconZoom = 90D;
            this.btxuat.IsTab = false;
            this.btxuat.Location = new System.Drawing.Point(4, 4);
            this.btxuat.Margin = new System.Windows.Forms.Padding(4);
            this.btxuat.Name = "btxuat";
            this.btxuat.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.btxuat.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.btxuat.OnHoverTextColor = System.Drawing.Color.Red;
            this.btxuat.selected = false;
            this.btxuat.Size = new System.Drawing.Size(296, 72);
            this.btxuat.TabIndex = 53;
            this.btxuat.Text = "Xuất  Doanh Thu ";
            this.btxuat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btxuat.Textcolor = System.Drawing.Color.White;
            this.btxuat.TextFont = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btxuat.Click += new System.EventHandler(this.btxuat_Click);
            // 
            // btxuatchitra
            // 
            this.btxuatchitra.Activecolor = System.Drawing.Color.Transparent;
            this.btxuatchitra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.btxuatchitra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btxuatchitra.BorderRadius = 0;
            this.btxuatchitra.ButtonText = "Xuất Tiền Trả";
            this.btxuatchitra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btxuatchitra.DisabledColor = System.Drawing.Color.Gray;
            this.btxuatchitra.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btxuatchitra.ForeColor = System.Drawing.Color.White;
            this.btxuatchitra.Iconcolor = System.Drawing.Color.Transparent;
            this.btxuatchitra.Iconimage = global::Design_Dashboard_Modern.Properties.Resources.icons8_microsoft_excel_2019_322;
            this.btxuatchitra.Iconimage_right = null;
            this.btxuatchitra.Iconimage_right_Selected = null;
            this.btxuatchitra.Iconimage_Selected = null;
            this.btxuatchitra.IconMarginLeft = 0;
            this.btxuatchitra.IconMarginRight = 0;
            this.btxuatchitra.IconRightVisible = true;
            this.btxuatchitra.IconRightZoom = 0D;
            this.btxuatchitra.IconVisible = true;
            this.btxuatchitra.IconZoom = 90D;
            this.btxuatchitra.IsTab = false;
            this.btxuatchitra.Location = new System.Drawing.Point(0, 4);
            this.btxuatchitra.Margin = new System.Windows.Forms.Padding(4);
            this.btxuatchitra.Name = "btxuatchitra";
            this.btxuatchitra.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.btxuatchitra.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.btxuatchitra.OnHoverTextColor = System.Drawing.Color.Red;
            this.btxuatchitra.selected = false;
            this.btxuatchitra.Size = new System.Drawing.Size(287, 72);
            this.btxuatchitra.TabIndex = 54;
            this.btxuatchitra.Text = "Xuất Tiền Trả";
            this.btxuatchitra.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btxuatchitra.Textcolor = System.Drawing.Color.White;
            this.btxuatchitra.TextFont = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btxuatchitra.Click += new System.EventHandler(this.btxuatchitra_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dtDoanhthu);
            this.panel3.Location = new System.Drawing.Point(0, 83);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1234, 252);
            this.panel3.TabIndex = 54;
            // 
            // dtDoanhthu
            // 
            this.dtDoanhthu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtDoanhthu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtDoanhthu.Location = new System.Drawing.Point(0, 0);
            this.dtDoanhthu.Name = "dtDoanhthu";
            this.dtDoanhthu.RowTemplate.Height = 24;
            this.dtDoanhthu.Size = new System.Drawing.Size(1234, 252);
            this.dtDoanhthu.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dataXuatTientra);
            this.panel4.Location = new System.Drawing.Point(3, 74);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1228, 224);
            this.panel4.TabIndex = 55;
            // 
            // dataXuatTientra
            // 
            this.dataXuatTientra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataXuatTientra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataXuatTientra.Location = new System.Drawing.Point(0, 0);
            this.dataXuatTientra.Name = "dataXuatTientra";
            this.dataXuatTientra.RowTemplate.Height = 24;
            this.dataXuatTientra.Size = new System.Drawing.Size(1228, 224);
            this.dataXuatTientra.TabIndex = 0;
            // 
            // btguimail
            // 
            this.btguimail.Activecolor = System.Drawing.Color.Transparent;
            this.btguimail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.btguimail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btguimail.BorderRadius = 0;
            this.btguimail.ButtonText = "Gửi Mail Cho Chủ";
            this.btguimail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btguimail.DisabledColor = System.Drawing.Color.Gray;
            this.btguimail.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btguimail.ForeColor = System.Drawing.Color.White;
            this.btguimail.Iconcolor = System.Drawing.Color.Transparent;
            this.btguimail.Iconimage = global::Design_Dashboard_Modern.Properties.Resources.icons8_gmail_321;
            this.btguimail.Iconimage_right = null;
            this.btguimail.Iconimage_right_Selected = null;
            this.btguimail.Iconimage_Selected = null;
            this.btguimail.IconMarginLeft = 0;
            this.btguimail.IconMarginRight = 0;
            this.btguimail.IconRightVisible = true;
            this.btguimail.IconRightZoom = 0D;
            this.btguimail.IconVisible = true;
            this.btguimail.IconZoom = 90D;
            this.btguimail.IsTab = false;
            this.btguimail.Location = new System.Drawing.Point(934, 4);
            this.btguimail.Margin = new System.Windows.Forms.Padding(4);
            this.btguimail.Name = "btguimail";
            this.btguimail.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.btguimail.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.btguimail.OnHoverTextColor = System.Drawing.Color.Red;
            this.btguimail.selected = false;
            this.btguimail.Size = new System.Drawing.Size(296, 72);
            this.btguimail.TabIndex = 55;
            this.btguimail.Text = "Gửi Mail Cho Chủ";
            this.btguimail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btguimail.Textcolor = System.Drawing.Color.White;
            this.btguimail.TextFont = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btguimail.Click += new System.EventHandler(this.btguimail_Click);
            // 
            // XuatThongKeEXCEL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(1234, 641);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "XuatThongKeEXCEL";
            this.Text = "Xuất Thống Kê ";
            this.Load += new System.EventHandler(this.XuatThongKeEXCEL_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtDoanhthu)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataXuatTientra)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuFlatButton btxuat;
        private Bunifu.Framework.UI.BunifuFlatButton btxuatchitra;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dtDoanhthu;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dataXuatTientra;
        private Bunifu.Framework.UI.BunifuFlatButton btguimail;
    }
}