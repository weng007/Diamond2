namespace DiamondShop
{
    partial class ReportOrderList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportOrderList));
            this.reportSellingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsReportSelling = new DiamondShop.Report.DS.dsReportSelling();
            this.dsReportSellingBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dsReportSellingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tds = new DiamondDS.DS.dsSell();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportSellingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReportSelling)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReportSellingBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReportSellingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tds)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportSellingBindingSource
            // 
            this.reportSellingBindingSource.DataMember = "ReportSelling";
            this.reportSellingBindingSource.DataSource = this.dsReportSellingBindingSource;
            // 
            // dsReportSelling
            // 
            this.dsReportSelling.DataSetName = "dsReportSelling";
            this.dsReportSelling.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsReportSellingBindingSource1
            // 
            this.dsReportSellingBindingSource1.DataSource = this.dsReportSelling;
            this.dsReportSellingBindingSource1.Position = 0;
            // 
            // dsReportSellingBindingSource
            // 
            this.dsReportSellingBindingSource.DataSource = typeof(DiamondDS.DS.dsReportSelling);
            this.dsReportSellingBindingSource.Position = 0;
            // 
            // tds
            // 
            this.tds.DataSetName = "dsSell";
            this.tds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1351, 32);
            this.panel1.TabIndex = 52;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(1315, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(38, 32);
            this.button1.TabIndex = 35;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.reportViewer1);
            this.panel2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(5, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1329, 711);
            this.panel2.TabIndex = 45;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(7, 3);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1327, 705);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // ReportOrderList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(161)))), ((int)(((byte)(118)))));
            this.ClientSize = new System.Drawing.Size(1351, 758);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "ReportOrderList";
            this.Text = "SaleList";
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportSellingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReportSelling)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReportSellingBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReportSellingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tds)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private DiamondDS.DS.dsSell tds;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource dsReportSellingBindingSource;
        private System.Windows.Forms.BindingSource reportSellingBindingSource;
        private Report.DS.dsReportSelling dsReportSelling;
        private System.Windows.Forms.BindingSource dsReportSellingBindingSource1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}