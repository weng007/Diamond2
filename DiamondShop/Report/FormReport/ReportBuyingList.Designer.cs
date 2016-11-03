namespace DiamondShop
{
    partial class ReportBuyingList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportBuyingList));
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
            this.cmbShape = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbPayment = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtEWeight = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSWeight = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dtEDueDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtSDueDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtEBuyDate = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.dtSBuyDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
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
            this.button1.FlatAppearance.BorderSize = 0;
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
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.panel4.Controls.Add(this.cmbShape);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.cmbPayment);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.txtEWeight);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.txtSWeight);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.dtEDueDate);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.dtSDueDate);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.cmbStatus);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.dtEBuyDate);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.dtSBuyDate);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.cmbType);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.btnSearch);
            this.panel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(16, 34);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1318, 107);
            this.panel4.TabIndex = 44;
            // 
            // cmbShape
            // 
            this.cmbShape.FormattingEnabled = true;
            this.cmbShape.Location = new System.Drawing.Point(1054, 13);
            this.cmbShape.Name = "cmbShape";
            this.cmbShape.Size = new System.Drawing.Size(172, 28);
            this.cmbShape.TabIndex = 128;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(986, 18);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 26);
            this.label12.TabIndex = 127;
            this.label12.Text = "Shape";
            // 
            // cmbPayment
            // 
            this.cmbPayment.FormattingEnabled = true;
            this.cmbPayment.Location = new System.Drawing.Point(793, 61);
            this.cmbPayment.Name = "cmbPayment";
            this.cmbPayment.Size = new System.Drawing.Size(172, 28);
            this.cmbPayment.TabIndex = 126;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(703, 66);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 26);
            this.label11.TabIndex = 125;
            this.label11.Text = "Payment";
            // 
            // txtEWeight
            // 
            this.txtEWeight.Location = new System.Drawing.Point(892, 17);
            this.txtEWeight.Name = "txtEWeight";
            this.txtEWeight.Size = new System.Drawing.Size(73, 26);
            this.txtEWeight.TabIndex = 124;
            this.txtEWeight.Text = "50";
            this.txtEWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(872, 17);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(16, 25);
            this.label10.TabIndex = 123;
            this.label10.Text = "-";
            // 
            // txtSWeight
            // 
            this.txtSWeight.Location = new System.Drawing.Point(793, 17);
            this.txtSWeight.Name = "txtSWeight";
            this.txtSWeight.Size = new System.Drawing.Size(73, 26);
            this.txtSWeight.TabIndex = 122;
            this.txtSWeight.Text = "0";
            this.txtSWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(717, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 26);
            this.label9.TabIndex = 121;
            this.label9.Text = "Weight";
            // 
            // dtEDueDate
            // 
            this.dtEDueDate.CustomFormat = "dd/MM/yyyy";
            this.dtEDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtEDueDate.Location = new System.Drawing.Point(546, 65);
            this.dtEDueDate.Name = "dtEDueDate";
            this.dtEDueDate.Size = new System.Drawing.Size(131, 26);
            this.dtEDueDate.TabIndex = 118;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(527, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 25);
            this.label3.TabIndex = 119;
            this.label3.Text = "-";
            // 
            // dtSDueDate
            // 
            this.dtSDueDate.CustomFormat = "dd/MM/yyyy";
            this.dtSDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtSDueDate.Location = new System.Drawing.Point(390, 65);
            this.dtSDueDate.Name = "dtSDueDate";
            this.dtSDueDate.Size = new System.Drawing.Size(131, 26);
            this.dtSDueDate.TabIndex = 117;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(652, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(12, 26);
            this.label5.TabIndex = 116;
            this.label5.Text = "-";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(295, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 26);
            this.label6.TabIndex = 115;
            this.label6.Text = "Due Date";
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(97, 65);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(172, 28);
            this.cmbStatus.TabIndex = 114;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(29, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 26);
            this.label2.TabIndex = 113;
            this.label2.Text = "Status";
            // 
            // dtEBuyDate
            // 
            this.dtEBuyDate.CustomFormat = "dd/MM/yyyy";
            this.dtEBuyDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtEBuyDate.Location = new System.Drawing.Point(546, 18);
            this.dtEBuyDate.Name = "dtEBuyDate";
            this.dtEBuyDate.Size = new System.Drawing.Size(131, 26);
            this.dtEBuyDate.TabIndex = 93;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(527, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 25);
            this.label8.TabIndex = 94;
            this.label8.Text = "-";
            // 
            // dtSBuyDate
            // 
            this.dtSBuyDate.CustomFormat = "dd/MM/yyyy";
            this.dtSBuyDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtSBuyDate.Location = new System.Drawing.Point(390, 18);
            this.dtSBuyDate.Name = "dtSBuyDate";
            this.dtSBuyDate.Size = new System.Drawing.Size(131, 26);
            this.dtSBuyDate.TabIndex = 92;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(652, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 26);
            this.label1.TabIndex = 91;
            this.label1.Text = "-";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(295, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 26);
            this.label7.TabIndex = 90;
            this.label7.Text = "Buy Date";
            // 
            // cmbType
            // 
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Location = new System.Drawing.Point(97, 18);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(172, 28);
            this.cmbType.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(29, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 26);
            this.label4.TabIndex = 46;
            this.label4.Text = "Type";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.Linen;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(1054, 59);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(105, 32);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // ReportBuyingList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(161)))), ((int)(((byte)(118)))));
            this.ClientSize = new System.Drawing.Size(1351, 758);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Name = "ReportBuyingList";
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cmbType;
        private DiamondDS.DS.dsSell tds;
        private System.Windows.Forms.DateTimePicker dtEBuyDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtSBuyDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource dsReportSellingBindingSource;
        private System.Windows.Forms.BindingSource reportSellingBindingSource;
        private Report.DS.dsReportSelling dsReportSelling;
        private System.Windows.Forms.BindingSource dsReportSellingBindingSource1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.DateTimePicker dtEDueDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtSDueDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSWeight;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbShape;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbPayment;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtEWeight;
        private System.Windows.Forms.Label label10;
    }
}