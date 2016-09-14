namespace DiamondShop
{
    partial class PaymentList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentList));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panal = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.txtEPayDate = new System.Windows.Forms.TextBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.btnChooseDate = new System.Windows.Forms.Button();
            this.txtSPayDate = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dtEBuyDate = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dtSBuyDate = new System.Windows.Forms.DateTimePicker();
            this.txtSeller = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbIsPaid = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cmbBuyBookType = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gridBuyBookPayment = new System.Windows.Forms.DataGridView();
            this.Payment1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsPaid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Payment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BuybookType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seller = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BuyDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PayDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalBaht = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LabName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColorTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShapeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OriginName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            this.panal.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridBuyBookPayment)).BeginInit();
            this.SuspendLayout();
            // 
            // panal
            // 
            this.panal.BackColor = System.Drawing.Color.DarkKhaki;
            this.panal.Controls.Add(this.monthCalendar1);
            this.panal.Controls.Add(this.button1);
            this.panal.Controls.Add(this.txtEPayDate);
            this.panal.Controls.Add(this.btnChooseDate);
            this.panal.Controls.Add(this.txtSPayDate);
            this.panal.Controls.Add(this.label9);
            this.panal.Controls.Add(this.dtEBuyDate);
            this.panal.Controls.Add(this.label8);
            this.panal.Controls.Add(this.label10);
            this.panal.Controls.Add(this.dtSBuyDate);
            this.panal.Controls.Add(this.txtSeller);
            this.panal.Controls.Add(this.label4);
            this.panal.Controls.Add(this.label7);
            this.panal.Controls.Add(this.label3);
            this.panal.Controls.Add(this.cmbIsPaid);
            this.panal.Controls.Add(this.label1);
            this.panal.Controls.Add(this.label2);
            this.panal.Controls.Add(this.btnSearch);
            this.panal.Controls.Add(this.btnAdd);
            this.panal.Controls.Add(this.cmbBuyBookType);
            this.panal.Controls.Add(this.label6);
            this.panal.Controls.Add(this.label5);
            this.panal.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.panal.Location = new System.Drawing.Point(0, 0);
            this.panal.Name = "panal";
            this.panal.Size = new System.Drawing.Size(1329, 183);
            this.panal.TabIndex = 40;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(854, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 28);
            this.button1.TabIndex = 257;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtEPayDate
            // 
            this.txtEPayDate.Location = new System.Drawing.Point(725, 60);
            this.txtEPayDate.Name = "txtEPayDate";
            this.txtEPayDate.Size = new System.Drawing.Size(123, 27);
            this.txtEPayDate.TabIndex = 256;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(469, 92);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 255;
            this.monthCalendar1.Visible = false;
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            // 
            // btnChooseDate
            // 
            this.btnChooseDate.Location = new System.Drawing.Point(663, 61);
            this.btnChooseDate.Name = "btnChooseDate";
            this.btnChooseDate.Size = new System.Drawing.Size(34, 28);
            this.btnChooseDate.TabIndex = 254;
            this.btnChooseDate.UseVisualStyleBackColor = true;
            this.btnChooseDate.Click += new System.EventHandler(this.btnChooseDate_Click);
            // 
            // txtSPayDate
            // 
            this.txtSPayDate.Location = new System.Drawing.Point(534, 62);
            this.txtSPayDate.Name = "txtSPayDate";
            this.txtSPayDate.Size = new System.Drawing.Size(123, 27);
            this.txtSPayDate.TabIndex = 253;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(703, 63);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(16, 25);
            this.label9.TabIndex = 93;
            this.label9.Text = "-";
            // 
            // dtEBuyDate
            // 
            this.dtEBuyDate.CustomFormat = "dd/MM/yyyy";
            this.dtEBuyDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtEBuyDate.Location = new System.Drawing.Point(690, 25);
            this.dtEBuyDate.Name = "dtEBuyDate";
            this.dtEBuyDate.Size = new System.Drawing.Size(131, 27);
            this.dtEBuyDate.TabIndex = 88;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(671, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 25);
            this.label8.TabIndex = 89;
            this.label8.Text = "-";
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(796, 63);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(12, 26);
            this.label10.TabIndex = 90;
            this.label10.Text = "-";
            // 
            // dtSBuyDate
            // 
            this.dtSBuyDate.CustomFormat = "dd/MM/yyyy";
            this.dtSBuyDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtSBuyDate.Location = new System.Drawing.Point(534, 25);
            this.dtSBuyDate.Name = "dtSBuyDate";
            this.dtSBuyDate.Size = new System.Drawing.Size(131, 27);
            this.dtSBuyDate.TabIndex = 87;
            // 
            // txtSeller
            // 
            this.txtSeller.Location = new System.Drawing.Point(253, 24);
            this.txtSeller.Name = "txtSeller";
            this.txtSeller.Size = new System.Drawing.Size(168, 27);
            this.txtSeller.TabIndex = 86;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(796, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(12, 26);
            this.label4.TabIndex = 85;
            this.label4.Text = "-";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(439, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 26);
            this.label7.TabIndex = 83;
            this.label7.Text = "Buy Date";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(165, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 26);
            this.label3.TabIndex = 81;
            this.label3.Text = "Payment";
            // 
            // cmbIsPaid
            // 
            this.cmbIsPaid.FormattingEnabled = true;
            this.cmbIsPaid.Location = new System.Drawing.Point(253, 99);
            this.cmbIsPaid.Name = "cmbIsPaid";
            this.cmbIsPaid.Size = new System.Drawing.Size(168, 29);
            this.cmbIsPaid.TabIndex = 80;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(796, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 26);
            this.label1.TabIndex = 79;
            this.label1.Text = "-";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(440, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 26);
            this.label2.TabIndex = 77;
            this.label2.Text = "Pay Date";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Gainsboro;
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.Linen;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(254, 140);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(105, 32);
            this.btnSearch.TabIndex = 52;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.BackgroundImage")));
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.Linen;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(20, 21);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(70, 90);
            this.btnAdd.TabIndex = 68;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cmbBuyBookType
            // 
            this.cmbBuyBookType.FormattingEnabled = true;
            this.cmbBuyBookType.Location = new System.Drawing.Point(253, 61);
            this.cmbBuyBookType.Name = "cmbBuyBookType";
            this.cmbBuyBookType.Size = new System.Drawing.Size(168, 29);
            this.cmbBuyBookType.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(122, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 26);
            this.label6.TabIndex = 53;
            this.label6.Text = "Buybook Type";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(187, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 26);
            this.label5.TabIndex = 51;
            this.label5.Text = "Seller";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.gridBuyBookPayment);
            this.panel2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(1, 187);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1335, 388);
            this.panel2.TabIndex = 34;
            // 
            // gridBuyBookPayment
            // 
            this.gridBuyBookPayment.AllowUserToAddRows = false;
            this.gridBuyBookPayment.AllowUserToDeleteRows = false;
            this.gridBuyBookPayment.AllowUserToOrderColumns = true;
            this.gridBuyBookPayment.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gridBuyBookPayment.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.gridBuyBookPayment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridBuyBookPayment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Payment1,
            this.ID,
            this.IsPaid,
            this.Payment,
            this.Code,
            this.BuybookType,
            this.Seller,
            this.BuyDate,
            this.PayDate,
            this.Weight,
            this.TotalBaht,
            this.LabName,
            this.ColorTypeName,
            this.ColorName,
            this.ShapeName,
            this.OriginName,
            this.Detail,
            this.Remark});
            this.gridBuyBookPayment.Location = new System.Drawing.Point(19, 0);
            this.gridBuyBookPayment.Name = "gridBuyBookPayment";
            this.gridBuyBookPayment.ReadOnly = true;
            this.gridBuyBookPayment.RowHeadersWidth = 10;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridBuyBookPayment.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.gridBuyBookPayment.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridBuyBookPayment.RowTemplate.Height = 30;
            this.gridBuyBookPayment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridBuyBookPayment.Size = new System.Drawing.Size(1313, 388);
            this.gridBuyBookPayment.TabIndex = 2;
            this.gridBuyBookPayment.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridBuyBookPayment_CellClick);
            this.gridBuyBookPayment.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gridDiamondCer_MouseDoubleClick);
            // 
            // Payment1
            // 
            this.Payment1.HeaderText = "Select";
            this.Payment1.Name = "Payment1";
            this.Payment1.ReadOnly = true;
            this.Payment1.Width = 80;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // IsPaid
            // 
            this.IsPaid.DataPropertyName = "IsPaid";
            this.IsPaid.HeaderText = "IsPaid";
            this.IsPaid.Name = "IsPaid";
            this.IsPaid.ReadOnly = true;
            this.IsPaid.Visible = false;
            // 
            // Payment
            // 
            this.Payment.DataPropertyName = "Payment";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.Payment.DefaultCellStyle = dataGridViewCellStyle7;
            this.Payment.HeaderText = "Status";
            this.Payment.Name = "Payment";
            this.Payment.ReadOnly = true;
            this.Payment.Width = 80;
            // 
            // Code
            // 
            this.Code.DataPropertyName = "Code";
            this.Code.HeaderText = "Code";
            this.Code.Name = "Code";
            this.Code.ReadOnly = true;
            this.Code.Width = 150;
            // 
            // BuybookType
            // 
            this.BuybookType.DataPropertyName = "BuybookType";
            this.BuybookType.HeaderText = "BuybookType";
            this.BuybookType.Name = "BuybookType";
            this.BuybookType.ReadOnly = true;
            this.BuybookType.Width = 200;
            // 
            // Seller
            // 
            this.Seller.DataPropertyName = "Seller";
            this.Seller.HeaderText = "Seller";
            this.Seller.Name = "Seller";
            this.Seller.ReadOnly = true;
            this.Seller.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Seller.Width = 150;
            // 
            // BuyDate
            // 
            this.BuyDate.DataPropertyName = "BuyDate";
            dataGridViewCellStyle8.Format = "dd/MM/yyyy";
            this.BuyDate.DefaultCellStyle = dataGridViewCellStyle8;
            this.BuyDate.HeaderText = "Buy Date";
            this.BuyDate.Name = "BuyDate";
            this.BuyDate.ReadOnly = true;
            this.BuyDate.Width = 110;
            // 
            // PayDate
            // 
            this.PayDate.DataPropertyName = "PayDate";
            dataGridViewCellStyle9.NullValue = "-";
            this.PayDate.DefaultCellStyle = dataGridViewCellStyle9;
            this.PayDate.HeaderText = "PayDate";
            this.PayDate.Name = "PayDate";
            this.PayDate.ReadOnly = true;
            this.PayDate.Width = 90;
            // 
            // Weight
            // 
            this.Weight.DataPropertyName = "Weight";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle10.Format = "N2";
            this.Weight.DefaultCellStyle = dataGridViewCellStyle10;
            this.Weight.HeaderText = "Weight";
            this.Weight.Name = "Weight";
            this.Weight.ReadOnly = true;
            this.Weight.Width = 70;
            // 
            // TotalBaht
            // 
            this.TotalBaht.DataPropertyName = "TotalBaht";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle11.Format = "N0";
            this.TotalBaht.DefaultCellStyle = dataGridViewCellStyle11;
            this.TotalBaht.HeaderText = "TotalBaht";
            this.TotalBaht.Name = "TotalBaht";
            this.TotalBaht.ReadOnly = true;
            this.TotalBaht.Width = 120;
            // 
            // LabName
            // 
            this.LabName.DataPropertyName = "LabName";
            this.LabName.HeaderText = "Lab";
            this.LabName.Name = "LabName";
            this.LabName.ReadOnly = true;
            this.LabName.Width = 60;
            // 
            // ColorTypeName
            // 
            this.ColorTypeName.DataPropertyName = "ColorTypeName";
            this.ColorTypeName.HeaderText = "ColorType";
            this.ColorTypeName.Name = "ColorTypeName";
            this.ColorTypeName.ReadOnly = true;
            this.ColorTypeName.Width = 150;
            // 
            // ColorName
            // 
            this.ColorName.DataPropertyName = "ColorName";
            this.ColorName.HeaderText = "Color";
            this.ColorName.Name = "ColorName";
            this.ColorName.ReadOnly = true;
            // 
            // ShapeName
            // 
            this.ShapeName.DataPropertyName = "ShapeName";
            this.ShapeName.HeaderText = "Shape";
            this.ShapeName.Name = "ShapeName";
            this.ShapeName.ReadOnly = true;
            // 
            // OriginName
            // 
            this.OriginName.DataPropertyName = "OriginName";
            this.OriginName.HeaderText = "OriginName";
            this.OriginName.Name = "OriginName";
            this.OriginName.ReadOnly = true;
            this.OriginName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.OriginName.Width = 160;
            // 
            // Detail
            // 
            this.Detail.DataPropertyName = "Detail";
            this.Detail.HeaderText = "Detail";
            this.Detail.Name = "Detail";
            this.Detail.ReadOnly = true;
            this.Detail.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Detail.Width = 110;
            // 
            // Remark
            // 
            this.Remark.DataPropertyName = "Remark";
            this.Remark.HeaderText = "Remark";
            this.Remark.Name = "Remark";
            this.Remark.ReadOnly = true;
            this.Remark.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Remark.Width = 120;
            // 
            // PaymentList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(1335, 577);
            this.Controls.Add(this.panal);
            this.Controls.Add(this.panel2);
            this.Name = "PaymentList";
            this.Text = "DiamondCerList";
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            this.panal.ResumeLayout(false);
            this.panal.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridBuyBookPayment)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView gridBuyBookPayment;
        private System.Windows.Forms.Panel panal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbBuyBookType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbIsPaid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSeller;
        private System.Windows.Forms.DateTimePicker dtEBuyDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtSBuyDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button btnChooseDate;
        private System.Windows.Forms.TextBox txtSPayDate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtEPayDate;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Payment1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsPaid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Payment;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn BuybookType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Seller;
        private System.Windows.Forms.DataGridViewTextBoxColumn BuyDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn PayDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Weight;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalBaht;
        private System.Windows.Forms.DataGridViewTextBoxColumn LabName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColorTypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShapeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn OriginName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Detail;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remark;
    }
}