namespace Design_Dashboard_Modern
{
    partial class DVT
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.soLuongDVT = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbxNameDVT = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.dtdvt = new System.Windows.Forms.DataGridView();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtdvt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.panel1.Controls.Add(this.bunifuFlatButton2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.bunifuFlatButton1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.soLuongDVT);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.tbxNameDVT);
            this.panel1.Location = new System.Drawing.Point(34, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(433, 297);
            this.panel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(36, 143);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(351, 1);
            this.panel3.TabIndex = 3;
            // 
            // soLuongDVT
            // 
            this.soLuongDVT.BackColor = System.Drawing.Color.White;
            this.soLuongDVT.BorderColorFocused = System.Drawing.Color.White;
            this.soLuongDVT.BorderColorIdle = System.Drawing.Color.White;
            this.soLuongDVT.BorderColorMouseHover = System.Drawing.Color.White;
            this.soLuongDVT.BorderThickness = 3;
            this.soLuongDVT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.soLuongDVT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soLuongDVT.ForeColor = System.Drawing.Color.Black;
            this.soLuongDVT.isPassword = false;
            this.soLuongDVT.Location = new System.Drawing.Point(36, 96);
            this.soLuongDVT.Margin = new System.Windows.Forms.Padding(4);
            this.soLuongDVT.Name = "soLuongDVT";
            this.soLuongDVT.Size = new System.Drawing.Size(343, 44);
            this.soLuongDVT.TabIndex = 2;
            this.soLuongDVT.Text = "Số lượng đơn vị tính";
            this.soLuongDVT.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.soLuongDVT.Enter += new System.EventHandler(this.soLuongDVT_Enter);
            this.soLuongDVT.Leave += new System.EventHandler(this.soLuongDVT_Leave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(36, 81);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(351, 1);
            this.panel2.TabIndex = 1;
            // 
            // tbxNameDVT
            // 
            this.tbxNameDVT.BackColor = System.Drawing.Color.White;
            this.tbxNameDVT.BorderColorFocused = System.Drawing.Color.White;
            this.tbxNameDVT.BorderColorIdle = System.Drawing.Color.White;
            this.tbxNameDVT.BorderColorMouseHover = System.Drawing.Color.White;
            this.tbxNameDVT.BorderThickness = 3;
            this.tbxNameDVT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxNameDVT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxNameDVT.ForeColor = System.Drawing.Color.Black;
            this.tbxNameDVT.isPassword = false;
            this.tbxNameDVT.Location = new System.Drawing.Point(36, 34);
            this.tbxNameDVT.Margin = new System.Windows.Forms.Padding(4);
            this.tbxNameDVT.Name = "tbxNameDVT";
            this.tbxNameDVT.Size = new System.Drawing.Size(343, 44);
            this.tbxNameDVT.TabIndex = 0;
            this.tbxNameDVT.Text = "Tên gói đơn vị tính";
            this.tbxNameDVT.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbxNameDVT.Enter += new System.EventHandler(this.tbxNameDVT_Enter);
            this.tbxNameDVT.Leave += new System.EventHandler(this.tbxNameDVT_Leave);
            // 
            // dtdvt
            // 
            this.dtdvt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtdvt.Location = new System.Drawing.Point(473, 18);
            this.dtdvt.Name = "dtdvt";
            this.dtdvt.RowTemplate.Height = 24;
            this.dtdvt.Size = new System.Drawing.Size(336, 297);
            this.dtdvt.TabIndex = 2;
            this.dtdvt.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtdvt_CellClick);
            this.dtdvt.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtdvt_CellContentClick);
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "Xóa";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton2.ForeColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = global::Design_Dashboard_Modern.Properties.Resources.icons8_waste_32;
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 90D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(228, 181);
            this.bunifuFlatButton2.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(165, 84);
            this.bunifuFlatButton2.TabIndex = 5;
            this.bunifuFlatButton2.Text = "Xóa";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton2.Click += new System.EventHandler(this.bunifuFlatButton2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Design_Dashboard_Modern.Properties.Resources.icons8_close_window_32;
            this.pictureBox1.Location = new System.Drawing.Point(386, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Thêm";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.ForeColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = global::Design_Dashboard_Modern.Properties.Resources.icons8_checked_checkbox_32;
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(36, 181);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(169, 84);
            this.bunifuFlatButton1.TabIndex = 4;
            this.bunifuFlatButton1.Text = "Thêm";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // DVT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.Controls.Add(this.dtdvt);
            this.Controls.Add(this.panel1);
            this.Name = "DVT";
            this.Size = new System.Drawing.Size(826, 357);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtdvt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuMetroTextbox soLuongDVT;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuMetroTextbox tbxNameDVT;
        private System.Windows.Forms.DataGridView dtdvt;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
    }
}
