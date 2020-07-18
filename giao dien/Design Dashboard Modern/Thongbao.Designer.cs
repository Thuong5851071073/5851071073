namespace Design_Dashboard_Modern
{
    partial class Thongbao
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
            this.dtsp = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtsl = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.idhang = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txttenhang = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.Dtsanphamhethan = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtsp)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dtsanphamhethan)).BeginInit();
            this.SuspendLayout();
            // 
            // dtsp
            // 
            this.dtsp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtsp.Location = new System.Drawing.Point(151, 221);
            this.dtsp.Name = "dtsp";
            this.dtsp.RowTemplate.Height = 24;
            this.dtsp.Size = new System.Drawing.Size(1133, 265);
            this.dtsp.TabIndex = 0;
            this.dtsp.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtsp_CellClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.txtsl);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel11);
            this.panel1.Controls.Add(this.idhang);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.txttenhang);
            this.panel1.Location = new System.Drawing.Point(41, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1398, 147);
            this.panel1.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1118, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(159, 22);
            this.textBox1.TabIndex = 52;
            // 
            // txtsl
            // 
            this.txtsl.Location = new System.Drawing.Point(723, 44);
            this.txtsl.Name = "txtsl";
            this.txtsl.Size = new System.Drawing.Size(159, 22);
            this.txtsl.TabIndex = 51;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(588, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 19);
            this.label2.TabIndex = 50;
            this.label2.Text = " Lượng  Còn: ";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(578, 71);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(317, 1);
            this.panel5.TabIndex = 48;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(978, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 19);
            this.label3.TabIndex = 46;
            this.label3.Text = "Tại Nhà CC";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Location = new System.Drawing.Point(978, 71);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(317, 1);
            this.panel6.TabIndex = 45;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.White;
            this.panel11.Location = new System.Drawing.Point(78, 71);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(112, 1);
            this.panel11.TabIndex = 44;
            // 
            // idhang
            // 
            this.idhang.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.idhang.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.idhang.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.idhang.BorderThickness = 3;
            this.idhang.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.idhang.Enabled = false;
            this.idhang.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idhang.ForeColor = System.Drawing.Color.White;
            this.idhang.isPassword = false;
            this.idhang.Location = new System.Drawing.Point(78, 25);
            this.idhang.Margin = new System.Windows.Forms.Padding(4);
            this.idhang.Name = "idhang";
            this.idhang.Size = new System.Drawing.Size(92, 47);
            this.idhang.TabIndex = 43;
            this.idhang.Text = "IDhang";
            this.idhang.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(221, 71);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(317, 1);
            this.panel3.TabIndex = 42;
            // 
            // txttenhang
            // 
            this.txttenhang.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.txttenhang.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.txttenhang.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.txttenhang.BorderThickness = 3;
            this.txttenhang.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txttenhang.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttenhang.ForeColor = System.Drawing.Color.White;
            this.txttenhang.isPassword = false;
            this.txttenhang.Location = new System.Drawing.Point(225, 20);
            this.txttenhang.Margin = new System.Windows.Forms.Padding(4);
            this.txttenhang.Name = "txttenhang";
            this.txttenhang.Size = new System.Drawing.Size(299, 47);
            this.txttenhang.TabIndex = 41;
            this.txttenhang.Text = "Tên Hàng";
            this.txttenhang.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Dtsanphamhethan
            // 
            this.Dtsanphamhethan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dtsanphamhethan.Location = new System.Drawing.Point(151, 544);
            this.Dtsanphamhethan.Name = "Dtsanphamhethan";
            this.Dtsanphamhethan.RowTemplate.Height = 24;
            this.Dtsanphamhethan.Size = new System.Drawing.Size(1133, 265);
            this.Dtsanphamhethan.TabIndex = 3;
            this.Dtsanphamhethan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dtsanphamhethan_CellClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(147, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(366, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Bảng Thông Báo Sản Phẩm Cần Nhập Về :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(147, 503);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Bảng Thông Báo Sản Phẩm Hết Hạn :";
            // 
            // Thongbao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Dtsanphamhethan);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtsp);
            this.Name = "Thongbao";
            this.Size = new System.Drawing.Size(1467, 918);
            this.Load += new System.EventHandler(this.Thongbao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtsp)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dtsanphamhethan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtsp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel11;
        private Bunifu.Framework.UI.BunifuMetroTextbox idhang;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuMetroTextbox txttenhang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtsl;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView Dtsanphamhethan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
    }
}
