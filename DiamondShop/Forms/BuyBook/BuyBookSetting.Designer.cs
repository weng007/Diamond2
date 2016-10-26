namespace DiamondShop
{
    partial class BuyBookSetting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuyBookSetting));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtBuyDate = new System.Windows.Forms.DateTimePicker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtUSDRate = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.btnChooseDate = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbShop = new System.Windows.Forms.ComboBox();
            this.txtPayDate = new System.Windows.Forms.TextBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.cmbBuyer = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.rdoNo = new System.Windows.Forms.RadioButton();
            this.rdoYes = new System.Windows.Forms.RadioButton();
            this.label27 = new System.Windows.Forms.Label();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBuyPrice = new System.Windows.Forms.TextBox();
            this.txtSalePrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gridSetting = new System.Windows.Forms.DataGridView();
            this.RowNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SettingTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaterialName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PricePerGram = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PricePerUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalBaht = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RefID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SettingType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Material = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSeller = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSetting)).BeginInit();
            this.SuspendLayout();
            // 
            // dtBuyDate
            // 
            this.dtBuyDate.CustomFormat = "dd/MM/yyyy";
            this.dtBuyDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtBuyDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtBuyDate.Location = new System.Drawing.Point(127, 17);
            this.dtBuyDate.Name = "dtBuyDate";
            this.dtBuyDate.Size = new System.Drawing.Size(156, 26);
            this.dtBuyDate.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.txtUSDRate);
            this.panel3.Controls.Add(this.label31);
            this.panel3.Controls.Add(this.label30);
            this.panel3.Controls.Add(this.txtCode);
            this.panel3.Controls.Add(this.btnChooseDate);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.cmbShop);
            this.panel3.Controls.Add(this.txtPayDate);
            this.panel3.Controls.Add(this.monthCalendar1);
            this.panel3.Controls.Add(this.cmbBuyer);
            this.panel3.Controls.Add(this.label22);
            this.panel3.Controls.Add(this.label26);
            this.panel3.Controls.Add(this.rdoNo);
            this.panel3.Controls.Add(this.rdoYes);
            this.panel3.Controls.Add(this.label27);
            this.panel3.Controls.Add(this.btnDel);
            this.panel3.Controls.Add(this.btnAdd);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txtBuyPrice);
            this.panel3.Controls.Add(this.txtSalePrice);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.gridSetting);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.txtSeller);
            this.panel3.Controls.Add(this.dtBuyDate);
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(10, 72);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(976, 449);
            this.panel3.TabIndex = 74;
            // 
            // txtUSDRate
            // 
            this.txtUSDRate.Location = new System.Drawing.Point(436, 90);
            this.txtUSDRate.Name = "txtUSDRate";
            this.txtUSDRate.Size = new System.Drawing.Size(61, 26);
            this.txtUSDRate.TabIndex = 258;
            this.txtUSDRate.Text = "0";
            this.txtUSDRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtUSDRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUSDRate_KeyPress);
            this.txtUSDRate.Leave += new System.EventHandler(this.txtUSDRate_Leave);
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(89)))), ((int)(((byte)(52)))));
            this.label31.Location = new System.Drawing.Point(339, 93);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(83, 20);
            this.label31.TabIndex = 259;
            this.label31.Text = "USD Rate";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(89)))), ((int)(((byte)(52)))));
            this.label30.Location = new System.Drawing.Point(376, 22);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(47, 20);
            this.label30.TabIndex = 256;
            this.label30.Text = "Code";
            // 
            // txtCode
            // 
            this.txtCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtCode.Enabled = false;
            this.txtCode.Location = new System.Drawing.Point(436, 19);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(159, 26);
            this.txtCode.TabIndex = 255;
            // 
            // btnChooseDate
            // 
            this.btnChooseDate.BackColor = System.Drawing.Color.Transparent;
            this.btnChooseDate.FlatAppearance.BorderSize = 0;
            this.btnChooseDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChooseDate.Image = ((System.Drawing.Image)(resources.GetObject("btnChooseDate.Image")));
            this.btnChooseDate.Location = new System.Drawing.Point(880, 53);
            this.btnChooseDate.Name = "btnChooseDate";
            this.btnChooseDate.Size = new System.Drawing.Size(34, 28);
            this.btnChooseDate.TabIndex = 254;
            this.btnChooseDate.UseVisualStyleBackColor = false;
            this.btnChooseDate.Click += new System.EventHandler(this.btnChooseDate_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(89)))), ((int)(((byte)(52)))));
            this.label5.Location = new System.Drawing.Point(352, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 20);
            this.label5.TabIndex = 253;
            this.label5.Text = "Location";
            // 
            // cmbShop
            // 
            this.cmbShop.Enabled = false;
            this.cmbShop.FormattingEnabled = true;
            this.cmbShop.Location = new System.Drawing.Point(436, 53);
            this.cmbShop.Name = "cmbShop";
            this.cmbShop.Size = new System.Drawing.Size(157, 28);
            this.cmbShop.TabIndex = 252;
            // 
            // txtPayDate
            // 
            this.txtPayDate.Location = new System.Drawing.Point(751, 54);
            this.txtPayDate.Name = "txtPayDate";
            this.txtPayDate.Size = new System.Drawing.Size(123, 26);
            this.txtPayDate.TabIndex = 250;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(687, 87);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 249;
            this.monthCalendar1.Visible = false;
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            // 
            // cmbBuyer
            // 
            this.cmbBuyer.FormattingEnabled = true;
            this.cmbBuyer.Location = new System.Drawing.Point(127, 88);
            this.cmbBuyer.Name = "cmbBuyer";
            this.cmbBuyer.Size = new System.Drawing.Size(156, 28);
            this.cmbBuyer.TabIndex = 6;
            this.cmbBuyer.SelectedValueChanged += new System.EventHandler(this.cmbBuyer_SelectedValueChanged);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(89)))), ((int)(((byte)(52)))));
            this.label22.Location = new System.Drawing.Point(37, 91);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(50, 20);
            this.label22.TabIndex = 229;
            this.label22.Text = "Buyer";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label26.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(89)))), ((int)(((byte)(52)))));
            this.label26.Location = new System.Drawing.Point(652, 58);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(82, 20);
            this.label26.TabIndex = 210;
            this.label26.Text = "Pay Date";
            // 
            // rdoNo
            // 
            this.rdoNo.AutoSize = true;
            this.rdoNo.Checked = true;
            this.rdoNo.Location = new System.Drawing.Point(817, 17);
            this.rdoNo.Name = "rdoNo";
            this.rdoNo.Size = new System.Drawing.Size(47, 24);
            this.rdoNo.TabIndex = 207;
            this.rdoNo.TabStop = true;
            this.rdoNo.Text = "No";
            this.rdoNo.UseVisualStyleBackColor = true;
            this.rdoNo.CheckedChanged += new System.EventHandler(this.rdoYes_CheckedChanged);
            // 
            // rdoYes
            // 
            this.rdoYes.AutoSize = true;
            this.rdoYes.Location = new System.Drawing.Point(751, 17);
            this.rdoYes.Name = "rdoYes";
            this.rdoYes.Size = new System.Drawing.Size(55, 24);
            this.rdoYes.TabIndex = 206;
            this.rdoYes.Text = "Yes";
            this.rdoYes.UseVisualStyleBackColor = true;
            this.rdoYes.CheckedChanged += new System.EventHandler(this.rdoYes_CheckedChanged);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label27.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(89)))), ((int)(((byte)(52)))));
            this.label27.Location = new System.Drawing.Point(652, 19);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(78, 20);
            this.label27.TabIndex = 208;
            this.label27.Text = "Payment";
            // 
            // btnDel
            // 
            this.btnDel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDel.BackgroundImage")));
            this.btnDel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDel.Enabled = false;
            this.btnDel.FlatAppearance.BorderSize = 0;
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.Image = ((System.Drawing.Image)(resources.GetObject("btnDel.Image")));
            this.btnDel.Location = new System.Drawing.Point(923, 158);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(30, 30);
            this.btnDel.TabIndex = 95;
            this.btnDel.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.BackgroundImage")));
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Enabled = false;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(923, 122);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(30, 30);
            this.btnAdd.TabIndex = 93;
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(89)))), ((int)(((byte)(52)))));
            this.label4.Location = new System.Drawing.Point(670, 383);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 92;
            this.label4.Text = "ขายออก";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(89)))), ((int)(((byte)(52)))));
            this.label3.Location = new System.Drawing.Point(555, 383);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 20);
            this.label3.TabIndex = 91;
            this.label3.Text = "รับซื้อ";
            // 
            // txtBuyPrice
            // 
            this.txtBuyPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuyPrice.Location = new System.Drawing.Point(537, 407);
            this.txtBuyPrice.Name = "txtBuyPrice";
            this.txtBuyPrice.Size = new System.Drawing.Size(81, 26);
            this.txtBuyPrice.TabIndex = 6;
            this.txtBuyPrice.Text = "0";
            this.txtBuyPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBuyPrice.TextChanged += new System.EventHandler(this.txtSeller_TextChanged);
            this.txtBuyPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuyPrice_KeyPress);
            this.txtBuyPrice.Leave += new System.EventHandler(this.txtBuyPrice_Leave);
            // 
            // txtSalePrice
            // 
            this.txtSalePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalePrice.Location = new System.Drawing.Point(663, 407);
            this.txtSalePrice.Name = "txtSalePrice";
            this.txtSalePrice.Size = new System.Drawing.Size(81, 26);
            this.txtSalePrice.TabIndex = 8;
            this.txtSalePrice.Text = "0";
            this.txtSalePrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSalePrice.TextChanged += new System.EventHandler(this.txtSeller_TextChanged);
            this.txtSalePrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuyPrice_KeyPress);
            this.txtSalePrice.Leave += new System.EventHandler(this.txtSalePrice_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(89)))), ((int)(((byte)(52)))));
            this.label2.Location = new System.Drawing.Point(330, 410);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 20);
            this.label2.TabIndex = 88;
            this.label2.Text = "ทองคำแท่ง 96.5% ณ วันที่ซื้อ";
            // 
            // gridSetting
            // 
            this.gridSetting.AllowUserToAddRows = false;
            this.gridSetting.AllowUserToOrderColumns = true;
            this.gridSetting.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gridSetting.ColumnHeadersHeight = 33;
            this.gridSetting.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RowNum,
            this.ID,
            this.SettingTypeName,
            this.MaterialName,
            this.Amount,
            this.Weight,
            this.PricePerGram,
            this.PricePerUnit,
            this.TotalBaht,
            this.RefID,
            this.SettingType,
            this.Material});
            this.gridSetting.Location = new System.Drawing.Point(23, 122);
            this.gridSetting.Name = "gridSetting";
            this.gridSetting.ReadOnly = true;
            this.gridSetting.RowHeadersWidth = 10;
            this.gridSetting.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridSetting.RowTemplate.Height = 25;
            this.gridSetting.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.gridSetting.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridSetting.Size = new System.Drawing.Size(891, 248);
            this.gridSetting.TabIndex = 86;
            this.gridSetting.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.gridSetting_CellFormatting);
            this.gridSetting.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridSetting_CellMouseDoubleClick);
            // 
            // RowNum
            // 
            this.RowNum.DataPropertyName = "RowNum";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.RowNum.DefaultCellStyle = dataGridViewCellStyle7;
            this.RowNum.HeaderText = "No.";
            this.RowNum.Name = "RowNum";
            this.RowNum.ReadOnly = true;
            this.RowNum.Width = 40;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // SettingTypeName
            // 
            this.SettingTypeName.DataPropertyName = "SettingTypeName";
            this.SettingTypeName.HeaderText = "Type";
            this.SettingTypeName.Name = "SettingTypeName";
            this.SettingTypeName.ReadOnly = true;
            this.SettingTypeName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SettingTypeName.Width = 170;
            // 
            // MaterialName
            // 
            this.MaterialName.DataPropertyName = "MaterialName";
            this.MaterialName.HeaderText = "Material";
            this.MaterialName.Name = "MaterialName";
            this.MaterialName.ReadOnly = true;
            this.MaterialName.Width = 150;
            // 
            // Amount
            // 
            this.Amount.DataPropertyName = "Amount";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle8.Format = "N0";
            this.Amount.DefaultCellStyle = dataGridViewCellStyle8;
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            this.Amount.Width = 80;
            // 
            // Weight
            // 
            this.Weight.DataPropertyName = "Weight";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle9.Format = "N2";
            this.Weight.DefaultCellStyle = dataGridViewCellStyle9;
            this.Weight.HeaderText = "Weight";
            this.Weight.Name = "Weight";
            this.Weight.ReadOnly = true;
            this.Weight.Width = 80;
            // 
            // PricePerGram
            // 
            this.PricePerGram.DataPropertyName = "PricePerGram";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle10.Format = "N0";
            this.PricePerGram.DefaultCellStyle = dataGridViewCellStyle10;
            this.PricePerGram.HeaderText = "Price/Gram";
            this.PricePerGram.Name = "PricePerGram";
            this.PricePerGram.ReadOnly = true;
            this.PricePerGram.Width = 110;
            // 
            // PricePerUnit
            // 
            this.PricePerUnit.DataPropertyName = "PricePerUnit";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle11.Format = "N0";
            this.PricePerUnit.DefaultCellStyle = dataGridViewCellStyle11;
            this.PricePerUnit.HeaderText = "Price/Unit";
            this.PricePerUnit.Name = "PricePerUnit";
            this.PricePerUnit.ReadOnly = true;
            // 
            // TotalBaht
            // 
            this.TotalBaht.DataPropertyName = "TotalBaht";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle12.Format = "N0";
            this.TotalBaht.DefaultCellStyle = dataGridViewCellStyle12;
            this.TotalBaht.HeaderText = "TotalBaht";
            this.TotalBaht.Name = "TotalBaht";
            this.TotalBaht.ReadOnly = true;
            this.TotalBaht.Width = 140;
            // 
            // RefID
            // 
            this.RefID.DataPropertyName = "RefID";
            this.RefID.HeaderText = "RefID";
            this.RefID.Name = "RefID";
            this.RefID.ReadOnly = true;
            this.RefID.Visible = false;
            // 
            // SettingType
            // 
            this.SettingType.DataPropertyName = "SettingType";
            this.SettingType.HeaderText = "SettingType";
            this.SettingType.Name = "SettingType";
            this.SettingType.ReadOnly = true;
            this.SettingType.Visible = false;
            // 
            // Material
            // 
            this.Material.DataPropertyName = "Material";
            this.Material.HeaderText = "Material";
            this.Material.Name = "Material";
            this.Material.ReadOnly = true;
            this.Material.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(89)))), ((int)(((byte)(52)))));
            this.label1.Location = new System.Drawing.Point(37, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 85;
            this.label1.Text = "Seller";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(89)))), ((int)(((byte)(52)))));
            this.label6.Location = new System.Drawing.Point(37, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 20);
            this.label6.TabIndex = 84;
            this.label6.Text = "Buy Date";
            // 
            // txtSeller
            // 
            this.txtSeller.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSeller.Location = new System.Drawing.Point(127, 53);
            this.txtSeller.Name = "txtSeller";
            this.txtSeller.Size = new System.Drawing.Size(156, 26);
            this.txtSeller.TabIndex = 4;
            this.txtSeller.TextChanged += new System.EventHandler(this.txtSeller_TextChanged);
            // 
            // btnEdit
            // 
            this.btnEdit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEdit.BackgroundImage")));
            this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(751, 134);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(30, 30);
            this.btnEdit.TabIndex = 94;
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(35)))), ((int)(((byte)(69)))));
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Location = new System.Drawing.Point(3, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(272, 32);
            this.panel1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Location = new System.Drawing.Point(16, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(1089, 352);
            this.button1.TabIndex = 32;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // BuyBookSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(195)))), ((int)(((byte)(157)))));
            this.ClientSize = new System.Drawing.Size(998, 533);
            this.Controls.Add(this.panel3);
            this.Name = "BuyBookSetting";
            this.Text = "DiamondCer";
            this.Controls.SetChildIndex(this.panel3, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSetting)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtBuyDate;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtSeller;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBuyPrice;
        private System.Windows.Forms.TextBox txtSalePrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView gridSetting;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.DataGridViewTextBoxColumn RowNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SettingTypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaterialName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Weight;
        private System.Windows.Forms.DataGridViewTextBoxColumn PricePerGram;
        private System.Windows.Forms.DataGridViewTextBoxColumn PricePerUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalBaht;
        private System.Windows.Forms.DataGridViewTextBoxColumn RefID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SettingType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Material;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.RadioButton rdoNo;
        private System.Windows.Forms.RadioButton rdoYes;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.ComboBox cmbBuyer;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtPayDate;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbShop;
        private System.Windows.Forms.Button btnChooseDate;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.TextBox txtUSDRate;
        private System.Windows.Forms.Label label31;
    }
}