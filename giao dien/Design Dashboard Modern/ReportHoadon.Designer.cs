namespace Design_Dashboard_Modern
{
    partial class ReportHoadon
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.CTHDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.QUANLYSIEUTHIDataSet1 = new Design_Dashboard_Modern.QUANLYSIEUTHIDataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btxuat = new Bunifu.Framework.UI.BunifuFlatButton();
            this.CTHDTableAdapter = new Design_Dashboard_Modern.QUANLYSIEUTHIDataSet1TableAdapters.CTHDTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.CTHDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QUANLYSIEUTHIDataSet1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CTHDBindingSource
            // 
            this.CTHDBindingSource.DataMember = "CTHD";
            this.CTHDBindingSource.DataSource = this.QUANLYSIEUTHIDataSet1;
            // 
            // QUANLYSIEUTHIDataSet1
            // 
            this.QUANLYSIEUTHIDataSet1.DataSetName = "QUANLYSIEUTHIDataSet1";
            this.QUANLYSIEUTHIDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.CTHDBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Design_Dashboard_Modern.InHoaDon.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(861, 386);
            this.reportViewer1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.reportViewer1);
            this.panel1.Location = new System.Drawing.Point(18, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(861, 386);
            this.panel1.TabIndex = 1;
            // 
            // btxuat
            // 
            this.btxuat.Activecolor = System.Drawing.Color.White;
            this.btxuat.BackColor = System.Drawing.Color.Transparent;
            this.btxuat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btxuat.BorderRadius = 0;
            this.btxuat.ButtonText = "Xuất Hóa Dơn";
            this.btxuat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btxuat.DisabledColor = System.Drawing.Color.Gray;
            this.btxuat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btxuat.Iconcolor = System.Drawing.Color.Transparent;
            this.btxuat.Iconimage = global::Design_Dashboard_Modern.Properties.Resources.icons8_print1_32;
            this.btxuat.Iconimage_right = null;
            this.btxuat.Iconimage_right_Selected = null;
            this.btxuat.Iconimage_Selected = null;
            this.btxuat.IconMarginLeft = 0;
            this.btxuat.IconMarginRight = 0;
            this.btxuat.IconRightVisible = true;
            this.btxuat.IconRightZoom = 0D;
            this.btxuat.IconVisible = true;
            this.btxuat.IconZoom = 60D;
            this.btxuat.IsTab = false;
            this.btxuat.Location = new System.Drawing.Point(20, 10);
            this.btxuat.Margin = new System.Windows.Forms.Padding(4);
            this.btxuat.Name = "btxuat";
            this.btxuat.Normalcolor = System.Drawing.Color.Transparent;
            this.btxuat.OnHovercolor = System.Drawing.Color.Blue;
            this.btxuat.OnHoverTextColor = System.Drawing.Color.Red;
            this.btxuat.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btxuat.selected = false;
            this.btxuat.Size = new System.Drawing.Size(199, 53);
            this.btxuat.TabIndex = 2;
            this.btxuat.Text = "Xuất Hóa Dơn";
            this.btxuat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btxuat.Textcolor = System.Drawing.Color.Black;
            this.btxuat.TextFont = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btxuat.Click += new System.EventHandler(this.btxuat_Click);
            // 
            // CTHDTableAdapter
            // 
            this.CTHDTableAdapter.ClearBeforeFill = true;
            // 
            // ReportHoadon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 450);
            this.Controls.Add(this.btxuat);
            this.Controls.Add(this.panel1);
            this.Name = "ReportHoadon";
            this.Text = "ReportHoadon";
            this.Load += new System.EventHandler(this.ReportHoadon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CTHDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QUANLYSIEUTHIDataSet1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton btxuat;
        private System.Windows.Forms.BindingSource CTHDBindingSource;
        private QUANLYSIEUTHIDataSet1 QUANLYSIEUTHIDataSet1;
        private QUANLYSIEUTHIDataSet1TableAdapters.CTHDTableAdapter CTHDTableAdapter;
    }
}