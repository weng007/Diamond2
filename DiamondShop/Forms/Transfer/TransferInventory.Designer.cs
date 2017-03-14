namespace DiamondShop
{
    partial class TransferInventory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransferInventory));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtSendDate = new System.Windows.Forms.DateTimePicker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTransferNo = new System.Windows.Forms.TextBox();
            this.cmbReceiver = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnReceive = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.txtSShop = new System.Windows.Forms.TextBox();
            this.txtReceivedDate = new System.Windows.Forms.TextBox();
            this.txtTransferStatus = new System.Windows.Forms.TextBox();
            this.cmbEShop = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.gridTransfer = new System.Windows.Forms.DataGridView();
            this.RowNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JewelryTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Weight1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Weight2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceTag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EShop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RefID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RefID1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BuyBookType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSender = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTransfer)).BeginInit();
            this.SuspendLayout();
            // 
            // dtSendDate
            // 
            this.dtSendDate.CustomFormat = "dd/MM/yyyy";
            this.dtSendDate.Enabled = false;
            this.dtSendDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtSendDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtSendDate.Location = new System.Drawing.Point(127, 17);
            this.dtSendDate.Name = "dtSendDate";
            this.dtSendDate.Size = new System.Drawing.Size(145, 26);
            this.dtSendDate.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.txtTransferNo);
            this.panel3.Controls.Add(this.cmbReceiver);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.btnReceive);
            this.panel3.Controls.Add(this.btnPrint);
            this.panel3.Controls.Add(this.txtSShop);
            this.panel3.Controls.Add(this.txtReceivedDate);
            this.panel3.Controls.Add(this.txtTransferStatus);
            this.panel3.Controls.Add(this.cmbEShop);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txtNote);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.btnDel);
            this.panel3.Controls.Add(this.btnAdd);
            this.panel3.Controls.Add(this.gridTransfer);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.txtSender);
            this.panel3.Controls.Add(this.dtSendDate);
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(10, 72);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(989, 461);
            this.panel3.TabIndex = 74;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(652, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 20);
            this.label8.TabIndex = 253;
            this.label8.Text = "Transfer No.";
            // 
            // txtTransferNo
            // 
            this.txtTransferNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtTransferNo.Enabled = false;
            this.txtTransferNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTransferNo.Location = new System.Drawing.Point(772, 60);
            this.txtTransferNo.Name = "txtTransferNo";
            this.txtTransferNo.Size = new System.Drawing.Size(156, 26);
            this.txtTransferNo.TabIndex = 252;
            // 
            // cmbReceiver
            // 
            this.cmbReceiver.FormattingEnabled = true;
            this.cmbReceiver.Location = new System.Drawing.Point(447, 55);
            this.cmbReceiver.Name = "cmbReceiver";
            this.cmbReceiver.Size = new System.Drawing.Size(157, 28);
            this.cmbReceiver.TabIndex = 251;
            this.cmbReceiver.SelectedIndexChanged += new System.EventHandler(this.cmbReceiver_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(322, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 28);
            this.label7.TabIndex = 250;
            this.label7.Text = "Receiver";
            // 
            // btnReceive
            // 
            this.btnReceive.BackColor = System.Drawing.Color.Thistle;
            this.btnReceive.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReceive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReceive.Image = ((System.Drawing.Image)(resources.GetObject("btnReceive.Image")));
            this.btnReceive.Location = new System.Drawing.Point(23, 343);
            this.btnReceive.Name = "btnReceive";
            this.btnReceive.Size = new System.Drawing.Size(77, 100);
            this.btnReceive.TabIndex = 249;
            this.btnReceive.UseVisualStyleBackColor = false;
            this.btnReceive.Visible = false;
            this.btnReceive.Click += new System.EventHandler(this.btnReceive_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.Enabled = false;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.Location = new System.Drawing.Point(116, 343);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(77, 100);
            this.btnPrint.TabIndex = 248;
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // txtSShop
            // 
            this.txtSShop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtSShop.Enabled = false;
            this.txtSShop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSShop.Location = new System.Drawing.Point(127, 92);
            this.txtSShop.Name = "txtSShop";
            this.txtSShop.Size = new System.Drawing.Size(145, 26);
            this.txtSShop.TabIndex = 242;
            // 
            // txtReceivedDate
            // 
            this.txtReceivedDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtReceivedDate.Enabled = false;
            this.txtReceivedDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReceivedDate.Location = new System.Drawing.Point(447, 19);
            this.txtReceivedDate.Name = "txtReceivedDate";
            this.txtReceivedDate.Size = new System.Drawing.Size(156, 26);
            this.txtReceivedDate.TabIndex = 241;
            // 
            // txtTransferStatus
            // 
            this.txtTransferStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtTransferStatus.Enabled = false;
            this.txtTransferStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTransferStatus.Location = new System.Drawing.Point(772, 23);
            this.txtTransferStatus.Name = "txtTransferStatus";
            this.txtTransferStatus.Size = new System.Drawing.Size(156, 26);
            this.txtTransferStatus.TabIndex = 240;
            // 
            // cmbEShop
            // 
            this.cmbEShop.Enabled = false;
            this.cmbEShop.FormattingEnabled = true;
            this.cmbEShop.Location = new System.Drawing.Point(447, 92);
            this.cmbEShop.Name = "cmbEShop";
            this.cmbEShop.Size = new System.Drawing.Size(156, 28);
            this.cmbEShop.TabIndex = 238;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(322, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 28);
            this.label3.TabIndex = 239;
            this.label3.Text = "End Location";
            // 
            // txtNote
            // 
            this.txtNote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtNote.Location = new System.Drawing.Point(608, 343);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(320, 87);
            this.txtNote.TabIndex = 6;
            this.txtNote.TextChanged += new System.EventHandler(this.txtNote_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(89)))), ((int)(((byte)(52)))));
            this.label16.Location = new System.Drawing.Point(557, 343);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(47, 20);
            this.label16.TabIndex = 237;
            this.label16.Text = "Note";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(19, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 42);
            this.label4.TabIndex = 235;
            this.label4.Text = "Start Location";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(647, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 233;
            this.label2.Text = "Transfer Status";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(320, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 20);
            this.label5.TabIndex = 231;
            this.label5.Text = "Received Date";
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
            this.btnDel.Location = new System.Drawing.Point(934, 179);
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
            this.btnAdd.Location = new System.Drawing.Point(934, 143);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(30, 30);
            this.btnAdd.TabIndex = 93;
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // gridTransfer
            // 
            this.gridTransfer.AllowUserToAddRows = false;
            this.gridTransfer.AllowUserToDeleteRows = false;
            this.gridTransfer.AllowUserToOrderColumns = true;
            this.gridTransfer.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gridTransfer.ColumnHeadersHeight = 33;
            this.gridTransfer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RowNum,
            this.ID,
            this.Code,
            this.JewelryTypeName,
            this.Size,
            this.Amount1,
            this.Weight1,
            this.Amount2,
            this.Weight2,
            this.PriceTag,
            this.EShop,
            this.Status,
            this.RefID,
            this.RefID1,
            this.BuyBookType});
            this.gridTransfer.Location = new System.Drawing.Point(23, 143);
            this.gridTransfer.Name = "gridTransfer";
            this.gridTransfer.ReadOnly = true;
            this.gridTransfer.RowHeadersWidth = 10;
            this.gridTransfer.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridTransfer.RowTemplate.Height = 25;
            this.gridTransfer.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.gridTransfer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridTransfer.Size = new System.Drawing.Size(905, 187);
            this.gridTransfer.TabIndex = 86;
            this.gridTransfer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridTransfer_CellClick);
            // 
            // RowNum
            // 
            this.RowNum.DataPropertyName = "RowNum";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.RowNum.DefaultCellStyle = dataGridViewCellStyle1;
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
            // Code
            // 
            this.Code.DataPropertyName = "Code";
            this.Code.HeaderText = "Code";
            this.Code.Name = "Code";
            this.Code.ReadOnly = true;
            this.Code.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Code.Width = 150;
            // 
            // JewelryTypeName
            // 
            this.JewelryTypeName.DataPropertyName = "JewelryTypeName";
            this.JewelryTypeName.HeaderText = "JewelryType";
            this.JewelryTypeName.Name = "JewelryTypeName";
            this.JewelryTypeName.ReadOnly = true;
            this.JewelryTypeName.Width = 140;
            // 
            // Size
            // 
            this.Size.DataPropertyName = "Size";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            this.Size.DefaultCellStyle = dataGridViewCellStyle2;
            this.Size.HeaderText = "Size";
            this.Size.Name = "Size";
            this.Size.ReadOnly = true;
            this.Size.Width = 70;
            // 
            // Amount1
            // 
            this.Amount1.DataPropertyName = "Amount1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            this.Amount1.DefaultCellStyle = dataGridViewCellStyle3;
            this.Amount1.HeaderText = "Amt. DC.";
            this.Amount1.Name = "Amount1";
            this.Amount1.ReadOnly = true;
            this.Amount1.Width = 90;
            // 
            // Weight1
            // 
            this.Weight1.DataPropertyName = "Weight1";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N2";
            this.Weight1.DefaultCellStyle = dataGridViewCellStyle4;
            this.Weight1.HeaderText = "นน. DC.";
            this.Weight1.Name = "Weight1";
            this.Weight1.ReadOnly = true;
            this.Weight1.Width = 90;
            // 
            // Amount2
            // 
            this.Amount2.DataPropertyName = "Amount2";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N0";
            this.Amount2.DefaultCellStyle = dataGridViewCellStyle5;
            this.Amount2.HeaderText = "Amt. GC.";
            this.Amount2.Name = "Amount2";
            this.Amount2.ReadOnly = true;
            this.Amount2.Width = 90;
            // 
            // Weight2
            // 
            this.Weight2.DataPropertyName = "Weight2";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "N2";
            this.Weight2.DefaultCellStyle = dataGridViewCellStyle6;
            this.Weight2.HeaderText = "นน. GC.";
            this.Weight2.Name = "Weight2";
            this.Weight2.ReadOnly = true;
            this.Weight2.Width = 90;
            // 
            // PriceTag
            // 
            this.PriceTag.DataPropertyName = "PriceTag";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "N0";
            this.PriceTag.DefaultCellStyle = dataGridViewCellStyle7;
            this.PriceTag.HeaderText = "PriceTag";
            this.PriceTag.Name = "PriceTag";
            this.PriceTag.ReadOnly = true;
            this.PriceTag.Width = 120;
            // 
            // EShop
            // 
            this.EShop.DataPropertyName = "EShop";
            this.EShop.HeaderText = "EShop";
            this.EShop.Name = "EShop";
            this.EShop.ReadOnly = true;
            this.EShop.Visible = false;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Visible = false;
            // 
            // RefID
            // 
            this.RefID.DataPropertyName = "RefID";
            this.RefID.HeaderText = "RefID";
            this.RefID.Name = "RefID";
            this.RefID.ReadOnly = true;
            this.RefID.Visible = false;
            // 
            // RefID1
            // 
            this.RefID1.DataPropertyName = "RefID1";
            this.RefID1.HeaderText = "RefID1";
            this.RefID1.Name = "RefID1";
            this.RefID1.ReadOnly = true;
            this.RefID1.Visible = false;
            // 
            // BuyBookType
            // 
            this.BuyBookType.DataPropertyName = "BuyBookType";
            this.BuyBookType.HeaderText = "BuyBookType";
            this.BuyBookType.Name = "BuyBookType";
            this.BuyBookType.ReadOnly = true;
            this.BuyBookType.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(19, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 85;
            this.label1.Text = "Sender";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(19, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 20);
            this.label6.TabIndex = 84;
            this.label6.Text = "Send Date";
            // 
            // txtSender
            // 
            this.txtSender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtSender.Enabled = false;
            this.txtSender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSender.Location = new System.Drawing.Point(127, 55);
            this.txtSender.Name = "txtSender";
            this.txtSender.Size = new System.Drawing.Size(145, 26);
            this.txtSender.TabIndex = 4;
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
            // TransferInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(195)))), ((int)(((byte)(157)))));
            this.ClientSize = new System.Drawing.Size(1007, 542);
            this.Controls.Add(this.panel3);
            this.Name = "TransferInventory";
            this.Text = "DiamondCer";
            this.Controls.SetChildIndex(this.panel3, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTransfer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtSendDate;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtSender;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridTransfer;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cmbEShop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtReceivedDate;
        private System.Windows.Forms.TextBox txtTransferStatus;
        private System.Windows.Forms.TextBox txtSShop;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnReceive;
        private System.Windows.Forms.ComboBox cmbReceiver;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTransferNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn RowNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn JewelryTypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Size;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Weight1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Weight2;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceTag;
        private System.Windows.Forms.DataGridViewTextBoxColumn EShop;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn RefID;
        private System.Windows.Forms.DataGridViewTextBoxColumn RefID1;
        private System.Windows.Forms.DataGridViewTextBoxColumn BuyBookType;
    }
}