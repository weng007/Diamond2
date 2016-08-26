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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportBuyingList));
            this.panel2 = new System.Windows.Forms.Panel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbShape = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEWeight = new System.Windows.Forms.TextBox();
            this.txtSWeight = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dtEDueDate = new System.Windows.Forms.DateTimePicker();
            this.dtSDueDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dtEBuyDate = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.dtSBuyDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tds = new DiamondDS.DS.dsSell();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            //this.ReportBuying = new DiamondShop.ReportBuying();
            //this.SP_Rpt_BuyingBindingSource = new System.Windows.Forms.BindingSource(this.components);

            //this.SP_Rpt_BuyingTableAdapter = new DiamondShop.ReportBuyingTableAdapters.SP_Rpt_BuyingTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tds)).BeginInit();
            this.panel1.SuspendLayout();
            //((System.ComponentModel.ISupportInitialize)(this.ReportBuying)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_Rpt_BuyingBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.reportViewer1);
            this.panel2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(2, 141);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1340, 443);
            this.panel2.TabIndex = 45;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.SP_Rpt_BuyingBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "DiamondShop.Report.ReportBuying.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(10, 8);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1323, 435);
            this.reportViewer1.TabIndex = 121;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(161)))), ((int)(((byte)(118)))));
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.comboBox4);
            this.panel4.Controls.Add(this.cmbStatus);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.cmbShape);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.txtEWeight);
            this.panel4.Controls.Add(this.txtSWeight);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.dtEDueDate);
            this.panel4.Controls.Add(this.dtSDueDate);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.dtEBuyDate);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.dtSBuyDate);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.cmbType);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.btnSearch);
            this.panel4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(12, 39);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1323, 99);
            this.panel4.TabIndex = 44;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(942, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 26);
            this.label2.TabIndex = 136;
            this.label2.Text = "Payment";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(245, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 25);
            this.label1.TabIndex = 135;
            this.label1.Text = "-";
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(1029, 9);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(172, 29);
            this.comboBox4.TabIndex = 134;
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(750, 57);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(172, 29);
            this.cmbStatus.TabIndex = 132;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(679, 60);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 26);
            this.label11.TabIndex = 133;
            this.label11.Text = "Status";
            // 
            // cmbShape
            // 
            this.cmbShape.FormattingEnabled = true;
            this.cmbShape.Location = new System.Drawing.Point(750, 9);
            this.cmbShape.Name = "cmbShape";
            this.cmbShape.Size = new System.Drawing.Size(172, 29);
            this.cmbShape.TabIndex = 130;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(679, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 26);
            this.label10.TabIndex = 131;
            this.label10.Text = "Shape";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(567, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 25);
            this.label6.TabIndex = 129;
            this.label6.Text = "-";
            // 
            // txtEWeight
            // 
            this.txtEWeight.Location = new System.Drawing.Point(585, 60);
            this.txtEWeight.Name = "txtEWeight";
            this.txtEWeight.Size = new System.Drawing.Size(74, 27);
            this.txtEWeight.TabIndex = 128;
            // 
            // txtSWeight
            // 
            this.txtSWeight.Location = new System.Drawing.Point(487, 61);
            this.txtSWeight.Name = "txtSWeight";
            this.txtSWeight.Size = new System.Drawing.Size(74, 27);
            this.txtSWeight.TabIndex = 127;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(416, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 26);
            this.label9.TabIndex = 126;
            this.label9.Text = "Weight";
            // 
            // dtEDueDate
            // 
            this.dtEDueDate.CustomFormat = "dd/MM/yyyy";
            this.dtEDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtEDueDate.Location = new System.Drawing.Point(265, 62);
            this.dtEDueDate.Name = "dtEDueDate";
            this.dtEDueDate.Size = new System.Drawing.Size(131, 27);
            this.dtEDueDate.TabIndex = 125;
            // 
            // dtSDueDate
            // 
            this.dtSDueDate.CustomFormat = "dd/MM/yyyy";
            this.dtSDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtSDueDate.Location = new System.Drawing.Point(109, 62);
            this.dtSDueDate.Name = "dtSDueDate";
            this.dtSDueDate.Size = new System.Drawing.Size(131, 27);
            this.dtSDueDate.TabIndex = 124;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(14, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 26);
            this.label5.TabIndex = 123;
            this.label5.Text = "Due Date";
            // 
            // dtEBuyDate
            // 
            this.dtEBuyDate.CustomFormat = "dd/MM/yyyy";
            this.dtEBuyDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtEBuyDate.Location = new System.Drawing.Point(265, 13);
            this.dtEBuyDate.Name = "dtEBuyDate";
            this.dtEBuyDate.Size = new System.Drawing.Size(131, 27);
            this.dtEBuyDate.TabIndex = 121;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(246, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 25);
            this.label8.TabIndex = 122;
            this.label8.Text = "-";
            // 
            // dtSBuyDate
            // 
            this.dtSBuyDate.CustomFormat = "dd/MM/yyyy";
            this.dtSBuyDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtSBuyDate.Location = new System.Drawing.Point(109, 13);
            this.dtSBuyDate.Name = "dtSBuyDate";
            this.dtSBuyDate.Size = new System.Drawing.Size(131, 27);
            this.dtSBuyDate.TabIndex = 120;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(14, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 26);
            this.label7.TabIndex = 119;
            this.label7.Text = "Buy Date";
            // 
            // cmbType
            // 
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Location = new System.Drawing.Point(487, 10);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(172, 29);
            this.cmbType.TabIndex = 116;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(416, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 26);
            this.label4.TabIndex = 118;
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
            this.btnSearch.Location = new System.Drawing.Point(1029, 54);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(105, 32);
            this.btnSearch.TabIndex = 117;
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // tds
            // 
            this.tds.DataSetName = "dsSell";
            this.tds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1347, 32);
            this.panel1.TabIndex = 52;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(1311, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(38, 32);
            this.btnClose.TabIndex = 35;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ReportBuying
            // 
            //this.ReportBuying.DataSetName = "ReportBuying";
            //this.ReportBuying.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SP_Rpt_BuyingBindingSource
            // 
            this.SP_Rpt_BuyingBindingSource.DataMember = "SP_Rpt_Buying";
            //this.SP_Rpt_BuyingBindingSource.DataSource = this.ReportBuying;
            // 
            // SP_Rpt_BuyingTableAdapter
            // 
            //this.SP_Rpt_BuyingTableAdapter.ClearBeforeFill = true;
            // 
            // ReportBuyingList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1347, 596);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Name = "ReportBuyingList";
            this.Text = "SaleList";
            this.Load += new System.EventHandler(this.ReportBuyingList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tds)).EndInit();
            this.panel1.ResumeLayout(false);
            //((System.ComponentModel.ISupportInitialize)(this.ReportBuying)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_Rpt_BuyingBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private DiamondDS.DS.dsSell tds;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbShape;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEWeight;
        private System.Windows.Forms.TextBox txtSWeight;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtEDueDate;
        private System.Windows.Forms.DateTimePicker dtSDueDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtEBuyDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtSBuyDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.BindingSource SP_Rpt_BuyingBindingSource;
        //private ReportBuying ReportBuying;
        //private ReportBuyingTableAdapters.SP_Rpt_BuyingTableAdapter SP_Rpt_BuyingTableAdapter;
    }
}