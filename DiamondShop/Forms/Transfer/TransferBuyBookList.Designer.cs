﻿namespace DiamondShop
{
    partial class TransferBuyBookList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransferBuyBookList));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cmbSender = new System.Windows.Forms.ComboBox();
            this.cmbEShop = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbShop = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtESendDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtSSendDate = new System.Windows.Forms.DateTimePicker();
            this.cmbTransferStatus = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gridTransfer = new System.Windows.Forms.DataGridView();
            this.RowNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SenderName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransferNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SendDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReceiveDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EShopName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransferStatusName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTransfer)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(91)))), ((int)(((byte)(59)))));
            this.panel4.Controls.Add(this.cmbSender);
            this.panel4.Controls.Add(this.cmbEShop);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.cmbShop);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.dtESendDate);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.dtSSendDate);
            this.panel4.Controls.Add(this.cmbTransferStatus);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.btnAdd);
            this.panel4.Controls.Add(this.btnSearch);
            this.panel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.panel4.Location = new System.Drawing.Point(0, 1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(965, 144);
            this.panel4.TabIndex = 42;
            // 
            // cmbSender
            // 
            this.cmbSender.FormattingEnabled = true;
            this.cmbSender.Location = new System.Drawing.Point(228, 16);
            this.cmbSender.Name = "cmbSender";
            this.cmbSender.Size = new System.Drawing.Size(172, 28);
            this.cmbSender.TabIndex = 91;
            // 
            // cmbEShop
            // 
            this.cmbEShop.FormattingEnabled = true;
            this.cmbEShop.Location = new System.Drawing.Point(541, 60);
            this.cmbEShop.Name = "cmbEShop";
            this.cmbEShop.Size = new System.Drawing.Size(172, 28);
            this.cmbEShop.TabIndex = 89;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(421, 63);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 26);
            this.label9.TabIndex = 90;
            this.label9.Text = "EndLocation";
            // 
            // cmbShop
            // 
            this.cmbShop.FormattingEnabled = true;
            this.cmbShop.Location = new System.Drawing.Point(228, 60);
            this.cmbShop.Name = "cmbShop";
            this.cmbShop.Size = new System.Drawing.Size(172, 28);
            this.cmbShop.TabIndex = 87;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(108, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 26);
            this.label8.TabIndex = 88;
            this.label8.Text = "StartLocation";
            // 
            // dtESendDate
            // 
            this.dtESendDate.CustomFormat = "dd/MM/yyyy";
            this.dtESendDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtESendDate.Location = new System.Drawing.Point(383, 106);
            this.dtESendDate.Name = "dtESendDate";
            this.dtESendDate.Size = new System.Drawing.Size(131, 26);
            this.dtESendDate.TabIndex = 80;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(364, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 25);
            this.label6.TabIndex = 82;
            this.label6.Text = "-";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(108, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 25);
            this.label7.TabIndex = 81;
            this.label7.Text = "Send Date";
            // 
            // dtSSendDate
            // 
            this.dtSSendDate.CustomFormat = "dd/MM/yyyy";
            this.dtSSendDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtSSendDate.Location = new System.Drawing.Point(227, 106);
            this.dtSSendDate.Name = "dtSSendDate";
            this.dtSSendDate.Size = new System.Drawing.Size(131, 26);
            this.dtSSendDate.TabIndex = 79;
            // 
            // cmbTransferStatus
            // 
            this.cmbTransferStatus.FormattingEnabled = true;
            this.cmbTransferStatus.Location = new System.Drawing.Point(542, 16);
            this.cmbTransferStatus.Name = "cmbTransferStatus";
            this.cmbTransferStatus.Size = new System.Drawing.Size(172, 28);
            this.cmbTransferStatus.TabIndex = 77;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(412, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 26);
            this.label3.TabIndex = 78;
            this.label3.Text = "Transfer Status";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(108, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 26);
            this.label5.TabIndex = 75;
            this.label5.Text = "Sender";
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
            this.btnAdd.TabIndex = 69;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Gainsboro;
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.Linen;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(825, 37);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(105, 32);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.gridTransfer);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(5, 151);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(969, 414);
            this.panel2.TabIndex = 33;
            // 
            // gridTransfer
            // 
            this.gridTransfer.AllowUserToAddRows = false;
            this.gridTransfer.AllowUserToDeleteRows = false;
            this.gridTransfer.AllowUserToOrderColumns = true;
            this.gridTransfer.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.gridTransfer.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.gridTransfer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTransfer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RowNum,
            this.ID,
            this.SenderName,
            this.TransferNo,
            this.SendDate,
            this.ReceiveDate,
            this.EShopName,
            this.TransferStatusName});
            this.gridTransfer.Location = new System.Drawing.Point(15, 2);
            this.gridTransfer.Name = "gridTransfer";
            this.gridTransfer.ReadOnly = true;
            this.gridTransfer.RowHeadersWidth = 10;
            this.gridTransfer.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridTransfer.RowTemplate.Height = 30;
            this.gridTransfer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridTransfer.Size = new System.Drawing.Size(945, 395);
            this.gridTransfer.TabIndex = 2;
            this.gridTransfer.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gridTransferBuyBook_MouseDoubleClick);
            // 
            // RowNum
            // 
            this.RowNum.DataPropertyName = "RowNum";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.RowNum.DefaultCellStyle = dataGridViewCellStyle1;
            this.RowNum.HeaderText = "No.";
            this.RowNum.Name = "RowNum";
            this.RowNum.ReadOnly = true;
            this.RowNum.Width = 50;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // SenderName
            // 
            this.SenderName.DataPropertyName = "SenderName";
            this.SenderName.HeaderText = "Sender";
            this.SenderName.Name = "SenderName";
            this.SenderName.ReadOnly = true;
            this.SenderName.Width = 130;
            // 
            // TransferNo
            // 
            this.TransferNo.DataPropertyName = "TransferNo";
            this.TransferNo.HeaderText = "TransferNo";
            this.TransferNo.Name = "TransferNo";
            this.TransferNo.ReadOnly = true;
            this.TransferNo.Width = 140;
            // 
            // SendDate
            // 
            this.SendDate.DataPropertyName = "SendDate";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle2.Format = "dd/MM/yyyy";
            this.SendDate.DefaultCellStyle = dataGridViewCellStyle2;
            this.SendDate.HeaderText = "SendDate";
            this.SendDate.Name = "SendDate";
            this.SendDate.ReadOnly = true;
            this.SendDate.Width = 110;
            // 
            // ReceiveDate
            // 
            this.ReceiveDate.DataPropertyName = "ReceiveDate";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle3.Format = "dd/MM/yyyy";
            dataGridViewCellStyle3.NullValue = "-";
            this.ReceiveDate.DefaultCellStyle = dataGridViewCellStyle3;
            this.ReceiveDate.HeaderText = "ReceiveDate";
            this.ReceiveDate.Name = "ReceiveDate";
            this.ReceiveDate.ReadOnly = true;
            this.ReceiveDate.Width = 110;
            // 
            // EShopName
            // 
            this.EShopName.DataPropertyName = "EShopName";
            this.EShopName.HeaderText = "Dest. Shop";
            this.EShopName.Name = "EShopName";
            this.EShopName.ReadOnly = true;
            this.EShopName.Width = 140;
            // 
            // TransferStatusName
            // 
            this.TransferStatusName.DataPropertyName = "TransferStatusName";
            this.TransferStatusName.HeaderText = "TransferStatus";
            this.TransferStatusName.Name = "TransferStatusName";
            this.TransferStatusName.ReadOnly = true;
            this.TransferStatusName.Width = 130;
            // 
            // TransferBuyBookList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(91)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(984, 577);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Name = "TransferBuyBookList";
            this.Text = "TransferBuyBookList";
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridTransfer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView gridTransfer;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cmbTransferStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtESendDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtSSendDate;
        private System.Windows.Forms.ComboBox cmbShop;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbSender;
        private System.Windows.Forms.ComboBox cmbEShop;
        private System.Windows.Forms.DataGridViewTextBoxColumn RowNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SenderName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransferNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn SendDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReceiveDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn EShopName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransferStatusName;
    }
}