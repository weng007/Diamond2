namespace DiamondShop
{
    partial class BuyBookDiamond
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuyBookDiamond));
            this.dtBuyDate = new System.Windows.Forms.DateTimePicker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label19 = new System.Windows.Forms.Label();
            this.txtMarketPrice = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.grid1 = new System.Windows.Forms.DataGridView();
            this.ActionDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actionDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.refIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isDeletedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tds2 = new DiamondDS.DS.dsBBDiamondStock();
            this.cmbShop = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.chkPayByUSD = new System.Windows.Forms.CheckBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtPriceCarat = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtTotalUSD = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTotalBaht = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.txtUSDRate = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.dtDueDate = new System.Windows.Forms.DateTimePicker();
            this.rdoPayment2 = new System.Windows.Forms.RadioButton();
            this.rdoPayment1 = new System.Windows.Forms.RadioButton();
            this.label12 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPriceCaratUSD = new System.Windows.Forms.TextBox();
            this.cmbClearity = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbColor = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtESize = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSSize = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtSeller = new System.Windows.Forms.TextBox();
            this.cmbShape = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tds2)).BeginInit();
            this.SuspendLayout();
            // 
            // dtBuyDate
            // 
            this.dtBuyDate.CustomFormat = "dd/MM/yyyy";
            this.dtBuyDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtBuyDate.Location = new System.Drawing.Point(137, 17);
            this.dtBuyDate.Name = "dtBuyDate";
            this.dtBuyDate.Size = new System.Drawing.Size(131, 26);
            this.dtBuyDate.TabIndex = 2;
            this.dtBuyDate.ValueChanged += new System.EventHandler(this.dtBuyDate_ValueChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label19);
            this.panel3.Controls.Add(this.txtMarketPrice);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.txtNote);
            this.panel3.Controls.Add(this.label26);
            this.panel3.Controls.Add(this.grid1);
            this.panel3.Controls.Add(this.cmbShop);
            this.panel3.Controls.Add(this.label20);
            this.panel3.Controls.Add(this.chkPayByUSD);
            this.panel3.Controls.Add(this.label17);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.txtPriceCarat);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.txtTotalUSD);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.txtTotalBaht);
            this.panel3.Controls.Add(this.label24);
            this.panel3.Controls.Add(this.txtUSDRate);
            this.panel3.Controls.Add(this.label23);
            this.panel3.Controls.Add(this.label21);
            this.panel3.Controls.Add(this.dtDueDate);
            this.panel3.Controls.Add(this.rdoPayment2);
            this.panel3.Controls.Add(this.rdoPayment1);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txtPriceCaratUSD);
            this.panel3.Controls.Add(this.cmbClearity);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.cmbColor);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.txtWeight);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.txtAmount);
            this.panel3.Controls.Add(this.txtESize);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.txtSSize);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label18);
            this.panel3.Controls.Add(this.txtSeller);
            this.panel3.Controls.Add(this.cmbShape);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.txtCode);
            this.panel3.Controls.Add(this.dtBuyDate);
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.panel3.Location = new System.Drawing.Point(12, 72);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(945, 484);
            this.panel3.TabIndex = 74;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.ForeColor = System.Drawing.Color.Red;
            this.label19.Location = new System.Drawing.Point(61, 171);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(158, 20);
            this.label19.TabIndex = 177;
            this.label19.Text = "*Work only mode edit";
            // 
            // txtMarketPrice
            // 
            this.txtMarketPrice.Location = new System.Drawing.Point(439, 405);
            this.txtMarketPrice.Name = "txtMarketPrice";
            this.txtMarketPrice.Size = new System.Drawing.Size(131, 26);
            this.txtMarketPrice.TabIndex = 30;
            this.txtMarketPrice.Text = "0";
            this.txtMarketPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtMarketPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtWeight_KeyPress);
            this.txtMarketPrice.Leave += new System.EventHandler(this.txtMarketPrice_Leave);
            // 
            // label16
            // 
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(89)))), ((int)(((byte)(52)))));
            this.label16.Location = new System.Drawing.Point(337, 407);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(106, 48);
            this.label16.TabIndex = 176;
            this.label16.Text = "Market Price (Baht)";
            // 
            // txtNote
            // 
            this.txtNote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtNote.Location = new System.Drawing.Point(654, 348);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(270, 84);
            this.txtNote.TabIndex = 32;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label26.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(89)))), ((int)(((byte)(52)))));
            this.label26.Location = new System.Drawing.Point(650, 322);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(47, 20);
            this.label26.TabIndex = 171;
            this.label26.Text = "Note";
            // 
            // grid1
            // 
            this.grid1.AutoGenerateColumns = false;
            this.grid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ActionDate,
            this.Amount,
            this.iDDataGridViewTextBoxColumn,
            this.actionDateDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.refIDDataGridViewTextBoxColumn,
            this.isDeletedDataGridViewTextBoxColumn});
            this.grid1.DataMember = "BBDiamondStock";
            this.grid1.DataSource = this.tds2;
            this.grid1.Enabled = false;
            this.grid1.Location = new System.Drawing.Point(33, 199);
            this.grid1.Name = "grid1";
            this.grid1.RowHeadersWidth = 10;
            this.grid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid1.Size = new System.Drawing.Size(235, 266);
            this.grid1.TabIndex = 76;
            this.grid1.Validated += new System.EventHandler(this.grid1_Validated);
            // 
            // ActionDate
            // 
            this.ActionDate.DataPropertyName = "ActionDate";
            this.ActionDate.HeaderText = "วันที่";
            this.ActionDate.Name = "ActionDate";
            // 
            // Amount
            // 
            this.Amount.DataPropertyName = "Amount";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle1.NullValue = "0";
            this.Amount.DefaultCellStyle = dataGridViewCellStyle1;
            this.Amount.HeaderText = "คงเหลือ (ct)";
            this.Amount.Name = "Amount";
            this.Amount.Width = 120;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // actionDateDataGridViewTextBoxColumn
            // 
            this.actionDateDataGridViewTextBoxColumn.DataPropertyName = "ActionDate";
            this.actionDateDataGridViewTextBoxColumn.HeaderText = "ActionDate";
            this.actionDateDataGridViewTextBoxColumn.Name = "actionDateDataGridViewTextBoxColumn";
            this.actionDateDataGridViewTextBoxColumn.Visible = false;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.Visible = false;
            // 
            // refIDDataGridViewTextBoxColumn
            // 
            this.refIDDataGridViewTextBoxColumn.DataPropertyName = "RefID";
            this.refIDDataGridViewTextBoxColumn.HeaderText = "RefID";
            this.refIDDataGridViewTextBoxColumn.Name = "refIDDataGridViewTextBoxColumn";
            this.refIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // isDeletedDataGridViewTextBoxColumn
            // 
            this.isDeletedDataGridViewTextBoxColumn.DataPropertyName = "IsDeleted";
            this.isDeletedDataGridViewTextBoxColumn.HeaderText = "IsDeleted";
            this.isDeletedDataGridViewTextBoxColumn.Name = "isDeletedDataGridViewTextBoxColumn";
            this.isDeletedDataGridViewTextBoxColumn.Visible = false;
            // 
            // tds2
            // 
            this.tds2.DataSetName = "dsBBDiamondStock";
            this.tds2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbShop
            // 
            this.cmbShop.FormattingEnabled = true;
            this.cmbShop.Location = new System.Drawing.Point(137, 122);
            this.cmbShop.Name = "cmbShop";
            this.cmbShop.Size = new System.Drawing.Size(131, 28);
            this.cmbShop.TabIndex = 6;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(89)))), ((int)(((byte)(52)))));
            this.label20.Location = new System.Drawing.Point(29, 125);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(47, 20);
            this.label20.TabIndex = 165;
            this.label20.Text = "Shop";
            // 
            // chkPayByUSD
            // 
            this.chkPayByUSD.AutoSize = true;
            this.chkPayByUSD.Checked = true;
            this.chkPayByUSD.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPayByUSD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.chkPayByUSD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(89)))), ((int)(((byte)(52)))));
            this.chkPayByUSD.Location = new System.Drawing.Point(440, 209);
            this.chkPayByUSD.Name = "chkPayByUSD";
            this.chkPayByUSD.Size = new System.Drawing.Size(125, 24);
            this.chkPayByUSD.TabIndex = 52;
            this.chkPayByUSD.Text = "Pay By USD";
            this.chkPayByUSD.UseVisualStyleBackColor = true;
            this.chkPayByUSD.CheckedChanged += new System.EventHandler(this.chkPayByUSD_CheckedChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(89)))), ((int)(((byte)(52)))));
            this.label17.Location = new System.Drawing.Point(638, 247);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(95, 20);
            this.label17.TabIndex = 161;
            this.label17.Text = "Price / Carat";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(89)))), ((int)(((byte)(52)))));
            this.label15.Location = new System.Drawing.Point(888, 247);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(43, 20);
            this.label15.TabIndex = 160;
            this.label15.Text = "Baht";
            // 
            // txtPriceCarat
            // 
            this.txtPriceCarat.Enabled = false;
            this.txtPriceCarat.Location = new System.Drawing.Point(750, 244);
            this.txtPriceCarat.Name = "txtPriceCarat";
            this.txtPriceCarat.Size = new System.Drawing.Size(131, 26);
            this.txtPriceCarat.TabIndex = 28;
            this.txtPriceCarat.Text = "0";
            this.txtPriceCarat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPriceCarat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtWeight_KeyPress);
            this.txtPriceCarat.Leave += new System.EventHandler(this.txtPriceCarat_Leave);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(89)))), ((int)(((byte)(52)))));
            this.label13.Location = new System.Drawing.Point(572, 282);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 20);
            this.label13.TabIndex = 157;
            this.label13.Text = "USD";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(89)))), ((int)(((byte)(52)))));
            this.label14.Location = new System.Drawing.Point(344, 282);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(83, 20);
            this.label14.TabIndex = 156;
            this.label14.Text = "Total USD";
            // 
            // txtTotalUSD
            // 
            this.txtTotalUSD.Enabled = false;
            this.txtTotalUSD.Location = new System.Drawing.Point(439, 279);
            this.txtTotalUSD.Name = "txtTotalUSD";
            this.txtTotalUSD.Size = new System.Drawing.Size(130, 26);
            this.txtTotalUSD.TabIndex = 104;
            this.txtTotalUSD.Text = "0";
            this.txtTotalUSD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(89)))), ((int)(((byte)(52)))));
            this.label5.Location = new System.Drawing.Point(573, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 20);
            this.label5.TabIndex = 154;
            this.label5.Text = "USD";
            // 
            // txtTotalBaht
            // 
            this.txtTotalBaht.Enabled = false;
            this.txtTotalBaht.Location = new System.Drawing.Point(439, 370);
            this.txtTotalBaht.Name = "txtTotalBaht";
            this.txtTotalBaht.Size = new System.Drawing.Size(131, 26);
            this.txtTotalBaht.TabIndex = 112;
            this.txtTotalBaht.Text = "0";
            this.txtTotalBaht.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTotalBaht.TextChanged += new System.EventHandler(this.txtTotalBaht_TextChanged);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(89)))), ((int)(((byte)(52)))));
            this.label24.Location = new System.Drawing.Point(338, 373);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(82, 20);
            this.label24.TabIndex = 152;
            this.label24.Text = "Total Baht";
            // 
            // txtUSDRate
            // 
            this.txtUSDRate.Location = new System.Drawing.Point(439, 314);
            this.txtUSDRate.Name = "txtUSDRate";
            this.txtUSDRate.Size = new System.Drawing.Size(61, 26);
            this.txtUSDRate.TabIndex = 26;
            this.txtUSDRate.Text = "0";
            this.txtUSDRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtUSDRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtWeight_KeyPress);
            this.txtUSDRate.Leave += new System.EventHandler(this.txtUSDRate_Leave);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(89)))), ((int)(((byte)(52)))));
            this.label23.Location = new System.Drawing.Point(345, 317);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(83, 20);
            this.label23.TabIndex = 150;
            this.label23.Text = "USD Rate";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(89)))), ((int)(((byte)(52)))));
            this.label21.Location = new System.Drawing.Point(649, 141);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(86, 20);
            this.label21.TabIndex = 149;
            this.label21.Text = "Due Date";
            // 
            // dtDueDate
            // 
            this.dtDueDate.CustomFormat = "dd/MM/yyyy";
            this.dtDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDueDate.Location = new System.Drawing.Point(738, 139);
            this.dtDueDate.Name = "dtDueDate";
            this.dtDueDate.Size = new System.Drawing.Size(131, 26);
            this.dtDueDate.TabIndex = 22;
            // 
            // rdoPayment2
            // 
            this.rdoPayment2.AutoSize = true;
            this.rdoPayment2.Checked = true;
            this.rdoPayment2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(89)))), ((int)(((byte)(52)))));
            this.rdoPayment2.Location = new System.Drawing.Point(803, 100);
            this.rdoPayment2.Name = "rdoPayment2";
            this.rdoPayment2.Size = new System.Drawing.Size(47, 24);
            this.rdoPayment2.TabIndex = 44;
            this.rdoPayment2.TabStop = true;
            this.rdoPayment2.Text = "No";
            this.rdoPayment2.UseVisualStyleBackColor = true;
            // 
            // rdoPayment1
            // 
            this.rdoPayment1.AutoSize = true;
            this.rdoPayment1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(89)))), ((int)(((byte)(52)))));
            this.rdoPayment1.Location = new System.Drawing.Point(737, 100);
            this.rdoPayment1.Name = "rdoPayment1";
            this.rdoPayment1.Size = new System.Drawing.Size(55, 24);
            this.rdoPayment1.TabIndex = 40;
            this.rdoPayment1.Text = "Yes";
            this.rdoPayment1.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(89)))), ((int)(((byte)(52)))));
            this.label12.Location = new System.Drawing.Point(650, 102);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 20);
            this.label12.TabIndex = 145;
            this.label12.Text = "Payment";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(89)))), ((int)(((byte)(52)))));
            this.label4.Location = new System.Drawing.Point(320, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 20);
            this.label4.TabIndex = 126;
            this.label4.Text = "Price / Carat";
            // 
            // txtPriceCaratUSD
            // 
            this.txtPriceCaratUSD.Location = new System.Drawing.Point(440, 244);
            this.txtPriceCaratUSD.Name = "txtPriceCaratUSD";
            this.txtPriceCaratUSD.Size = new System.Drawing.Size(130, 26);
            this.txtPriceCaratUSD.TabIndex = 24;
            this.txtPriceCaratUSD.Text = "0";
            this.txtPriceCaratUSD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPriceCaratUSD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtWeight_KeyPress);
            this.txtPriceCaratUSD.Leave += new System.EventHandler(this.txtPriceCaratUSD_Leave);
            // 
            // cmbClearity
            // 
            this.cmbClearity.FormattingEnabled = true;
            this.cmbClearity.Location = new System.Drawing.Point(737, 52);
            this.cmbClearity.Name = "cmbClearity";
            this.cmbClearity.Size = new System.Drawing.Size(179, 28);
            this.cmbClearity.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(89)))), ((int)(((byte)(52)))));
            this.label11.Location = new System.Drawing.Point(652, 55);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 20);
            this.label11.TabIndex = 123;
            this.label11.Text = "Clearity";
            // 
            // cmbColor
            // 
            this.cmbColor.FormattingEnabled = true;
            this.cmbColor.Location = new System.Drawing.Point(737, 14);
            this.cmbColor.Name = "cmbColor";
            this.cmbColor.Size = new System.Drawing.Size(146, 28);
            this.cmbColor.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(89)))), ((int)(((byte)(52)))));
            this.label2.Location = new System.Drawing.Point(652, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 121;
            this.label2.Text = "Color";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(89)))), ((int)(((byte)(52)))));
            this.label10.Location = new System.Drawing.Point(347, 125);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 20);
            this.label10.TabIndex = 120;
            this.label10.Text = "Weight";
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(447, 122);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(53, 26);
            this.txtWeight.TabIndex = 16;
            this.txtWeight.Text = "0";
            this.txtWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtWeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtWeight_KeyPress);
            this.txtWeight.Leave += new System.EventHandler(this.txtWeight_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(89)))), ((int)(((byte)(52)))));
            this.label9.Location = new System.Drawing.Point(347, 90);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 20);
            this.label9.TabIndex = 118;
            this.label9.Text = "Amount";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(447, 87);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(79, 26);
            this.txtAmount.TabIndex = 14;
            this.txtAmount.Text = "0";
            this.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtWeight_KeyPress);
            // 
            // txtESize
            // 
            this.txtESize.Location = new System.Drawing.Point(525, 52);
            this.txtESize.Name = "txtESize";
            this.txtESize.Size = new System.Drawing.Size(53, 26);
            this.txtESize.TabIndex = 12;
            this.txtESize.Text = "0";
            this.txtESize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtESize.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtWeight_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(89)))), ((int)(((byte)(52)))));
            this.label8.Location = new System.Drawing.Point(506, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 20);
            this.label8.TabIndex = 115;
            this.label8.Text = "-";
            // 
            // txtSSize
            // 
            this.txtSSize.Location = new System.Drawing.Point(447, 52);
            this.txtSSize.Name = "txtSSize";
            this.txtSSize.Size = new System.Drawing.Size(53, 26);
            this.txtSSize.TabIndex = 10;
            this.txtSSize.Text = "0";
            this.txtSSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSSize.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtWeight_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(89)))), ((int)(((byte)(52)))));
            this.label7.Location = new System.Drawing.Point(347, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 20);
            this.label7.TabIndex = 113;
            this.label7.Text = "Size";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(89)))), ((int)(((byte)(52)))));
            this.label18.Location = new System.Drawing.Point(29, 55);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(49, 20);
            this.label18.TabIndex = 112;
            this.label18.Text = "Seller";
            // 
            // txtSeller
            // 
            this.txtSeller.Location = new System.Drawing.Point(137, 52);
            this.txtSeller.Name = "txtSeller";
            this.txtSeller.Size = new System.Drawing.Size(131, 26);
            this.txtSeller.TabIndex = 4;
            // 
            // cmbShape
            // 
            this.cmbShape.FormattingEnabled = true;
            this.cmbShape.Location = new System.Drawing.Point(447, 15);
            this.cmbShape.Name = "cmbShape";
            this.cmbShape.Size = new System.Drawing.Size(174, 28);
            this.cmbShape.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(89)))), ((int)(((byte)(52)))));
            this.label3.Location = new System.Drawing.Point(347, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 88;
            this.label3.Text = "Shape";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(89)))), ((int)(((byte)(52)))));
            this.label1.Location = new System.Drawing.Point(29, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 85;
            this.label1.Text = "Code";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(89)))), ((int)(((byte)(52)))));
            this.label6.Location = new System.Drawing.Point(29, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 20);
            this.label6.TabIndex = 84;
            this.label6.Text = "Buy Date";
            // 
            // txtCode
            // 
            this.txtCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtCode.Location = new System.Drawing.Point(137, 87);
            this.txtCode.Name = "txtCode";
            this.txtCode.ReadOnly = true;
            this.txtCode.Size = new System.Drawing.Size(157, 26);
            this.txtCode.TabIndex = 100;
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
            // BuyBookDiamond
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(195)))), ((int)(((byte)(157)))));
            this.ClientSize = new System.Drawing.Size(969, 572);
            this.Controls.Add(this.panel3);
            this.Name = "BuyBookDiamond";
            this.Text = "DiamondCer";
            this.Controls.SetChildIndex(this.panel3, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tds2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtBuyDate;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbShape;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtSeller;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtESize;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSSize;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbClearity;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbColor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPriceCaratUSD;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtPriceCarat;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtTotalUSD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTotalBaht;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txtUSDRate;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.DateTimePicker dtDueDate;
        private System.Windows.Forms.RadioButton rdoPayment2;
        private System.Windows.Forms.RadioButton rdoPayment1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.CheckBox chkPayByUSD;
        private System.Windows.Forms.TextBox txtMarketPrice;
        private System.Windows.Forms.ComboBox cmbShop;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.DataGridView grid1;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label16;
        private DiamondDS.DS.dsBBDiamondStock tds2;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActionDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn actionDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn refIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isDeletedDataGridViewTextBoxColumn;
    }
}