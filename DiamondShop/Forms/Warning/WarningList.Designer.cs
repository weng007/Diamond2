﻿namespace DiamondShop
{
    partial class WarningList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WarningList));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.gridWarning = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.dtEEditDate = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.dtSEditDate = new System.Windows.Forms.DateTimePicker();
            this.btnSendBox = new System.Windows.Forms.Button();
            this.btnInbox = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRefID = new System.Windows.Forms.TextBox();
            this.cmbStatusType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tds = new DiamondDS.DS.dsWarning();
            this.IsRead = new System.Windows.Forms.DataGridViewImageColumn();
            this.RowNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SenderName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReceiverName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SShopName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EShopName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RefID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MessageStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsBuyBook = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderNo = new System.Windows.Forms.DataGridViewLinkColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridWarning)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tds)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "btnUnread.png");
            this.imageList1.Images.SetKeyName(1, "btnRead.png");
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "btnInbox2.png");
            this.imageList2.Images.SetKeyName(1, "btnSendbox2.png");
            this.imageList2.Images.SetKeyName(2, "btnSendbox.png");
            this.imageList2.Images.SetKeyName(3, "btnInbox.png");
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.gridWarning);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(5, 119);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1329, 452);
            this.panel2.TabIndex = 45;
            // 
            // gridWarning
            // 
            this.gridWarning.AllowUserToAddRows = false;
            this.gridWarning.AllowUserToDeleteRows = false;
            this.gridWarning.AllowUserToOrderColumns = true;
            this.gridWarning.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.gridWarning.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridWarning.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridWarning.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridWarning.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IsRead,
            this.RowNum,
            this.ID,
            this.SenderName,
            this.ReceiverName,
            this.Detail,
            this.Status,
            this.SShopName,
            this.EShopName,
            this.Note,
            this.EditDate,
            this.RefID,
            this.StatusType,
            this.MessageStatus,
            this.IsBuyBook,
            this.OrderNo});
            this.gridWarning.Location = new System.Drawing.Point(7, 3);
            this.gridWarning.Name = "gridWarning";
            this.gridWarning.ReadOnly = true;
            this.gridWarning.RowHeadersWidth = 10;
            this.gridWarning.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridWarning.RowTemplate.Height = 30;
            this.gridWarning.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridWarning.Size = new System.Drawing.Size(1315, 446);
            this.gridWarning.TabIndex = 4;
            this.gridWarning.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridWarning_CellClick);
            this.gridWarning.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.gridWarning_DataError);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.IndianRed;
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.dtEEditDate);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.dtSEditDate);
            this.panel4.Controls.Add(this.btnSendBox);
            this.panel4.Controls.Add(this.btnInbox);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.txtRefID);
            this.panel4.Controls.Add(this.cmbStatusType);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.btnSearch);
            this.panel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(-1, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1322, 117);
            this.panel4.TabIndex = 44;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(534, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 26);
            this.label3.TabIndex = 94;
            this.label3.Text = "Date";
            // 
            // dtEEditDate
            // 
            this.dtEEditDate.CustomFormat = "dd/MM/yyyy";
            this.dtEEditDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtEEditDate.Location = new System.Drawing.Point(752, 30);
            this.dtEEditDate.Name = "dtEEditDate";
            this.dtEEditDate.Size = new System.Drawing.Size(131, 26);
            this.dtEEditDate.TabIndex = 92;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(733, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 25);
            this.label8.TabIndex = 93;
            this.label8.Text = "-";
            // 
            // dtSEditDate
            // 
            this.dtSEditDate.CustomFormat = "dd/MM/yyyy";
            this.dtSEditDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtSEditDate.Location = new System.Drawing.Point(596, 30);
            this.dtSEditDate.Name = "dtSEditDate";
            this.dtSEditDate.Size = new System.Drawing.Size(131, 26);
            this.dtSEditDate.TabIndex = 91;
            // 
            // btnSendBox
            // 
            this.btnSendBox.BackColor = System.Drawing.Color.Transparent;
            this.btnSendBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSendBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSendBox.FlatAppearance.BorderColor = System.Drawing.Color.Linen;
            this.btnSendBox.FlatAppearance.BorderSize = 0;
            this.btnSendBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendBox.Image = ((System.Drawing.Image)(resources.GetObject("btnSendBox.Image")));
            this.btnSendBox.Location = new System.Drawing.Point(108, 19);
            this.btnSendBox.Name = "btnSendBox";
            this.btnSendBox.Size = new System.Drawing.Size(70, 90);
            this.btnSendBox.TabIndex = 78;
            this.btnSendBox.UseVisualStyleBackColor = false;
            this.btnSendBox.Click += new System.EventHandler(this.btnSendBox_Click);
            // 
            // btnInbox
            // 
            this.btnInbox.BackColor = System.Drawing.Color.OldLace;
            this.btnInbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnInbox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInbox.FlatAppearance.BorderColor = System.Drawing.Color.Linen;
            this.btnInbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInbox.Font = new System.Drawing.Font("Angsana New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInbox.Image = ((System.Drawing.Image)(resources.GetObject("btnInbox.Image")));
            this.btnInbox.Location = new System.Drawing.Point(20, 19);
            this.btnInbox.Margin = new System.Windows.Forms.Padding(0);
            this.btnInbox.Name = "btnInbox";
            this.btnInbox.Size = new System.Drawing.Size(70, 90);
            this.btnInbox.TabIndex = 77;
            this.btnInbox.Text = "UnRead()";
            this.btnInbox.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnInbox.UseVisualStyleBackColor = false;
            this.btnInbox.Click += new System.EventHandler(this.btnInbox_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(271, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 26);
            this.label1.TabIndex = 76;
            this.label1.Text = "RefID";
            // 
            // txtRefID
            // 
            this.txtRefID.Location = new System.Drawing.Point(333, 30);
            this.txtRefID.Name = "txtRefID";
            this.txtRefID.Size = new System.Drawing.Size(172, 26);
            this.txtRefID.TabIndex = 75;
            // 
            // cmbStatusType
            // 
            this.cmbStatusType.FormattingEnabled = true;
            this.cmbStatusType.Location = new System.Drawing.Point(333, 70);
            this.cmbStatusType.Name = "cmbStatusType";
            this.cmbStatusType.Size = new System.Drawing.Size(172, 28);
            this.cmbStatusType.TabIndex = 73;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(213, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 26);
            this.label2.TabIndex = 74;
            this.label2.Text = "Message Jobs";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.Linen;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(596, 70);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(105, 32);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tds
            // 
            this.tds.DataSetName = "dsWarning";
            this.tds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // IsRead
            // 
            this.IsRead.DataPropertyName = "IsRead";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.NullValue = "System.Drawing.Bitmap";
            this.IsRead.DefaultCellStyle = dataGridViewCellStyle2;
            this.IsRead.HeaderText = "";
            this.IsRead.Name = "IsRead";
            this.IsRead.ReadOnly = true;
            this.IsRead.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.IsRead.Width = 50;
            // 
            // RowNum
            // 
            this.RowNum.DataPropertyName = "RowNum";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.RowNum.DefaultCellStyle = dataGridViewCellStyle3;
            this.RowNum.HeaderText = "No.";
            this.RowNum.Name = "RowNum";
            this.RowNum.ReadOnly = true;
            this.RowNum.Width = 60;
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
            this.SenderName.Width = 120;
            // 
            // ReceiverName
            // 
            this.ReceiverName.DataPropertyName = "ReceiverName";
            this.ReceiverName.HeaderText = "Receiver";
            this.ReceiverName.Name = "ReceiverName";
            this.ReceiverName.ReadOnly = true;
            this.ReceiverName.Width = 150;
            // 
            // Detail
            // 
            this.Detail.DataPropertyName = "Detail";
            this.Detail.HeaderText = "Detail";
            this.Detail.Name = "Detail";
            this.Detail.ReadOnly = true;
            this.Detail.Width = 250;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 110;
            // 
            // SShopName
            // 
            this.SShopName.DataPropertyName = "SShopName";
            dataGridViewCellStyle4.Format = "N0";
            this.SShopName.DefaultCellStyle = dataGridViewCellStyle4;
            this.SShopName.HeaderText = "Location (From)";
            this.SShopName.Name = "SShopName";
            this.SShopName.ReadOnly = true;
            this.SShopName.Width = 150;
            // 
            // EShopName
            // 
            this.EShopName.DataPropertyName = "EShopName";
            this.EShopName.HeaderText = "Location (Dest.)";
            this.EShopName.Name = "EShopName";
            this.EShopName.ReadOnly = true;
            this.EShopName.Width = 150;
            // 
            // Note
            // 
            this.Note.DataPropertyName = "Note";
            this.Note.HeaderText = "Note";
            this.Note.Name = "Note";
            this.Note.ReadOnly = true;
            this.Note.Width = 200;
            // 
            // EditDate
            // 
            this.EditDate.DataPropertyName = "EditDate";
            this.EditDate.HeaderText = "Date";
            this.EditDate.Name = "EditDate";
            this.EditDate.ReadOnly = true;
            this.EditDate.Width = 150;
            // 
            // RefID
            // 
            this.RefID.DataPropertyName = "RefID";
            this.RefID.HeaderText = "RefID1";
            this.RefID.Name = "RefID";
            this.RefID.ReadOnly = true;
            this.RefID.Visible = false;
            // 
            // StatusType
            // 
            this.StatusType.DataPropertyName = "StatusType";
            this.StatusType.HeaderText = "StatusType";
            this.StatusType.Name = "StatusType";
            this.StatusType.ReadOnly = true;
            this.StatusType.Visible = false;
            // 
            // MessageStatus
            // 
            this.MessageStatus.DataPropertyName = "MessageStatus";
            this.MessageStatus.HeaderText = "MessageStatus";
            this.MessageStatus.Name = "MessageStatus";
            this.MessageStatus.ReadOnly = true;
            this.MessageStatus.Visible = false;
            // 
            // IsBuyBook
            // 
            this.IsBuyBook.DataPropertyName = "IsBuyBook";
            this.IsBuyBook.HeaderText = "IsBuyBook";
            this.IsBuyBook.Name = "IsBuyBook";
            this.IsBuyBook.ReadOnly = true;
            this.IsBuyBook.Visible = false;
            // 
            // OrderNo
            // 
            this.OrderNo.ActiveLinkColor = System.Drawing.Color.Brown;
            this.OrderNo.DataPropertyName = "OrderNo";
            this.OrderNo.HeaderText = "RefID";
            this.OrderNo.LinkColor = System.Drawing.Color.LightGreen;
            this.OrderNo.Name = "OrderNo";
            this.OrderNo.ReadOnly = true;
            this.OrderNo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.OrderNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.OrderNo.VisitedLinkColor = System.Drawing.Color.Gray;
            this.OrderNo.Width = 150;
            // 
            // WarningList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(1335, 577);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Name = "WarningList";
            this.Text = "SaleList";
            this.Load += new System.EventHandler(this.WarningList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridWarning)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tds)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView gridWarning;
        private DiamondDS.DS.dsWarning tds;
        private System.Windows.Forms.ComboBox cmbStatusType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRefID;
        private System.Windows.Forms.Button btnSendBox;
        private System.Windows.Forms.Button btnInbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtEEditDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtSEditDate;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.DataGridViewImageColumn IsRead;
        private System.Windows.Forms.DataGridViewTextBoxColumn RowNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SenderName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReceiverName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Detail;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn SShopName;
        private System.Windows.Forms.DataGridViewTextBoxColumn EShopName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Note;
        private System.Windows.Forms.DataGridViewTextBoxColumn EditDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn RefID;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusType;
        private System.Windows.Forms.DataGridViewTextBoxColumn MessageStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsBuyBook;
        private System.Windows.Forms.DataGridViewLinkColumn OrderNo;
    }
}