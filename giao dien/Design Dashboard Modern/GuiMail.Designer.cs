namespace Design_Dashboard_Modern
{
    partial class GuiMail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GuiMail));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txtBody = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.Label();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOpenfile = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnsend = new Bunifu.Framework.UI.BunifuThinButton2();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 23;
            this.listBox1.Location = new System.Drawing.Point(227, 335);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(538, 73);
            this.listBox1.TabIndex = 37;
            // 
            // txtBody
            // 
            this.txtBody.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBody.Location = new System.Drawing.Point(227, 218);
            this.txtBody.Name = "txtBody";
            this.txtBody.Size = new System.Drawing.Size(538, 109);
            this.txtBody.TabIndex = 34;
            this.txtBody.Text = "Lời muốn nói";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(125, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 23);
            this.label4.TabIndex = 33;
            this.label4.Text = "Body :";
            // 
            // txtSubject
            // 
            this.txtSubject.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubject.Location = new System.Drawing.Point(227, 163);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(460, 30);
            this.txtSubject.TabIndex = 32;
            this.txtSubject.Text = "Chủ đề";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(125, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 23);
            this.label3.TabIndex = 31;
            this.label3.Text = "Subject :";
            // 
            // txtTo
            // 
            this.txtTo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTo.Location = new System.Drawing.Point(227, 119);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(460, 30);
            this.txtTo.TabIndex = 30;
            this.txtTo.Text = "nknhan01@gmail.com";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(125, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 23);
            this.label2.TabIndex = 29;
            this.label2.Text = "To :";
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(227, 82);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(460, 30);
            this.txtPass.TabIndex = 28;
            this.txtPass.Text = "nguyenthuong";
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.ForeColor = System.Drawing.Color.White;
            this.Password.Location = new System.Drawing.Point(125, 89);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(102, 23);
            this.Password.TabIndex = 27;
            this.Password.Text = "Password :";
            // 
            // txtFrom
            // 
            this.txtFrom.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFrom.Location = new System.Drawing.Point(227, 48);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(460, 30);
            this.txtFrom.TabIndex = 26;
            this.txtFrom.Text = "nguyenthuong100999@gmail.com";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(125, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 23);
            this.label1.TabIndex = 25;
            this.label1.Text = "Sender :";
            // 
            // btnOpenfile
            // 
            this.btnOpenfile.ActiveBorderThickness = 1;
            this.btnOpenfile.ActiveCornerRadius = 20;
            this.btnOpenfile.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnOpenfile.ActiveForecolor = System.Drawing.Color.Blue;
            this.btnOpenfile.ActiveLineColor = System.Drawing.Color.Blue;
            this.btnOpenfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.btnOpenfile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOpenfile.BackgroundImage")));
            this.btnOpenfile.ButtonText = "Thêm Tệp Đính Kèm";
            this.btnOpenfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpenfile.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenfile.ForeColor = System.Drawing.Color.White;
            this.btnOpenfile.IdleBorderThickness = 1;
            this.btnOpenfile.IdleCornerRadius = 20;
            this.btnOpenfile.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnOpenfile.IdleForecolor = System.Drawing.Color.White;
            this.btnOpenfile.IdleLineColor = System.Drawing.Color.White;
            this.btnOpenfile.Location = new System.Drawing.Point(257, 428);
            this.btnOpenfile.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnOpenfile.Name = "btnOpenfile";
            this.btnOpenfile.Size = new System.Drawing.Size(171, 57);
            this.btnOpenfile.TabIndex = 38;
            this.btnOpenfile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnOpenfile.Click += new System.EventHandler(this.btnOpenfile_Click);
            // 
            // btnsend
            // 
            this.btnsend.ActiveBorderThickness = 1;
            this.btnsend.ActiveCornerRadius = 20;
            this.btnsend.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnsend.ActiveForecolor = System.Drawing.Color.Blue;
            this.btnsend.ActiveLineColor = System.Drawing.Color.Blue;
            this.btnsend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.btnsend.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnsend.BackgroundImage")));
            this.btnsend.ButtonText = "Gửi Mail";
            this.btnsend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsend.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsend.ForeColor = System.Drawing.Color.White;
            this.btnsend.IdleBorderThickness = 1;
            this.btnsend.IdleCornerRadius = 20;
            this.btnsend.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnsend.IdleForecolor = System.Drawing.Color.White;
            this.btnsend.IdleLineColor = System.Drawing.Color.White;
            this.btnsend.Location = new System.Drawing.Point(486, 428);
            this.btnsend.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnsend.Name = "btnsend";
            this.btnsend.Size = new System.Drawing.Size(171, 57);
            this.btnsend.TabIndex = 39;
            this.btnsend.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnsend.Click += new System.EventHandler(this.btnsend_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // GuiMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(918, 513);
            this.Controls.Add(this.btnsend);
            this.Controls.Add(this.btnOpenfile);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.txtBody);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.txtFrom);
            this.Controls.Add(this.label1);
            this.Name = "GuiMail";
            this.Text = "GuiMail";
            this.Load += new System.EventHandler(this.GuiMail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.RichTextBox txtBody;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnOpenfile;
        private Bunifu.Framework.UI.BunifuThinButton2 btnsend;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}