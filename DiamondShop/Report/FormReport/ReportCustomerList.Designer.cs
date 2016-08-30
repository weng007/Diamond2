namespace DiamondShop
{
    partial class ReportCustomerList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportCustomerList));
            this.dsReportSellingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportSellingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tds = new DiamondDS.DS.dsSell();
            this.dsReportSelling = new DiamondShop.Report.DS.dsReportSelling();
            this.dsReportSellingBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtDisplayName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dtEBirthDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtSBirthDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtEAnniDate = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.dtSAnniDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReportSellingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportSellingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReportSelling)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReportSellingBindingSource1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dsReportSellingBindingSource
            // 
            this.dsReportSellingBindingSource.DataSource = typeof(DiamondDS.DS.dsReportSelling);
            this.dsReportSellingBindingSource.Position = 0;
            // 
            // reportSellingBindingSource
            // 
            this.reportSellingBindingSource.DataMember = "ReportSelling";
            this.reportSellingBindingSource.DataSource = this.dsReportSellingBindingSource;
            // 
            // tds
            // 
            this.tds.DataSetName = "dsSell";
            this.tds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.panel2.Location = new System.Drawing.Point(5, 147);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1329, 599);
            this.panel2.TabIndex = 45;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(7, 3);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1327, 593);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(161)))), ((int)(((byte)(118)))));
            this.panel4.Controls.Add(this.txtDisplayName);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.btnSearch);
            this.panel4.Controls.Add(this.dtEBirthDate);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.dtSBirthDate);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.dtEAnniDate);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.dtSAnniDate);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(16, 34);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1318, 107);
            this.panel4.TabIndex = 44;
            // 
            // txtDisplayName
            // 
            this.txtDisplayName.Location = new System.Drawing.Point(608, 20);
            this.txtDisplayName.Name = "txtDisplayName";
            this.txtDisplayName.Size = new System.Drawing.Size(168, 27);
            this.txtDisplayName.TabIndex = 159;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(485, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 26);
            this.label9.TabIndex = 158;
            this.label9.Text = "DisplayName";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.Linen;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(608, 62);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(105, 32);
            this.btnSearch.TabIndex = 157;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dtEBirthDate
            // 
            this.dtEBirthDate.CustomFormat = "dd/MM/yyyy";
            this.dtEBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtEBirthDate.Location = new System.Drawing.Point(337, 66);
            this.dtEBirthDate.Name = "dtEBirthDate";
            this.dtEBirthDate.Size = new System.Drawing.Size(131, 27);
            this.dtEBirthDate.TabIndex = 155;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(318, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 25);
            this.label3.TabIndex = 156;
            this.label3.Text = "-";
            // 
            // dtSBirthDate
            // 
            this.dtSBirthDate.CustomFormat = "dd/MM/yyyy";
            this.dtSBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtSBirthDate.Location = new System.Drawing.Point(181, 66);
            this.dtSBirthDate.Name = "dtSBirthDate";
            this.dtSBirthDate.Size = new System.Drawing.Size(131, 27);
            this.dtSBirthDate.TabIndex = 154;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(443, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(12, 26);
            this.label5.TabIndex = 153;
            this.label5.Text = "-";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(86, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 26);
            this.label6.TabIndex = 152;
            this.label6.Text = "Birth Date";
            // 
            // dtEAnniDate
            // 
            this.dtEAnniDate.CustomFormat = "dd/MM/yyyy";
            this.dtEAnniDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtEAnniDate.Location = new System.Drawing.Point(337, 19);
            this.dtEAnniDate.Name = "dtEAnniDate";
            this.dtEAnniDate.Size = new System.Drawing.Size(131, 27);
            this.dtEAnniDate.TabIndex = 150;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(318, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 25);
            this.label8.TabIndex = 151;
            this.label8.Text = "-";
            // 
            // dtSAnniDate
            // 
            this.dtSAnniDate.CustomFormat = "dd/MM/yyyy";
            this.dtSAnniDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtSAnniDate.Location = new System.Drawing.Point(181, 19);
            this.dtSAnniDate.Name = "dtSAnniDate";
            this.dtSAnniDate.Size = new System.Drawing.Size(131, 27);
            this.dtSAnniDate.TabIndex = 149;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(443, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 26);
            this.label2.TabIndex = 148;
            this.label2.Text = "-";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(34, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 26);
            this.label7.TabIndex = 147;
            this.label7.Text = "Annivesary Date";
            // 
            // ReportCustomerList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(161)))), ((int)(((byte)(118)))));
            this.ClientSize = new System.Drawing.Size(1351, 758);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Name = "ReportCustomerList";
            this.Text = "SaleList";
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReportSellingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportSellingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReportSelling)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReportSellingBindingSource1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private DiamondDS.DS.dsSell tds;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource dsReportSellingBindingSource;
        private System.Windows.Forms.BindingSource reportSellingBindingSource;
        private Report.DS.dsReportSelling dsReportSelling;
        private System.Windows.Forms.BindingSource dsReportSellingBindingSource1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.DateTimePicker dtEBirthDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtSBirthDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtEAnniDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtSAnniDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDisplayName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSearch;
    }
}