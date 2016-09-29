namespace DiamondShop
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WarningList));
            this.panel2 = new System.Windows.Forms.Panel();
            this.gridWarning = new System.Windows.Forms.DataGridView();
            this.IsRead = new System.Windows.Forms.DataGridViewImageColumn();
            this.RowNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SenderName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReceiverName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShopName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RefID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MessageStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderNo = new System.Windows.Forms.DataGridViewLinkColumn();
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tds = new DiamondDS.DS.dsWarning();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridWarning)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tds)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.gridWarning);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(5, 123);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1329, 452);
            this.panel2.TabIndex = 45;
            // 
            // gridWarning
            // 
            this.gridWarning.AllowUserToAddRows = false;
            this.gridWarning.AllowUserToDeleteRows = false;
            this.gridWarning.AllowUserToOrderColumns = true;
            this.gridWarning.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridWarning.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.gridWarning.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridWarning.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IsRead,
            this.RowNum,
            this.ID,
            this.SenderName,
            this.ReceiverName,
            this.Detail,
            this.Status,
            this.ShopName,
            this.Note,
            this.EditDate,
            this.RefID,
            this.StatusType,
            this.MessageStatus,
            this.OrderNo});
            this.gridWarning.Location = new System.Drawing.Point(14, 6);
            this.gridWarning.Name = "gridWarning";
            this.gridWarning.ReadOnly = true;
            this.gridWarning.RowHeadersWidth = 10;
            this.gridWarning.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridWarning.RowTemplate.Height = 30;
            this.gridWarning.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridWarning.Size = new System.Drawing.Size(1315, 446);
            this.gridWarning.TabIndex = 4;
            this.gridWarning.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridWarning_CellClick);
            // 
            // IsRead
            // 
            this.IsRead.DataPropertyName = "IsRead";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.NullValue = "System.Drawing.Bitmap";
            this.IsRead.DefaultCellStyle = dataGridViewCellStyle10;
            this.IsRead.HeaderText = "";
            this.IsRead.Name = "IsRead";
            this.IsRead.ReadOnly = true;
            this.IsRead.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.IsRead.Width = 50;
            // 
            // RowNum
            // 
            this.RowNum.DataPropertyName = "RowNum";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.RowNum.DefaultCellStyle = dataGridViewCellStyle11;
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
            this.Detail.Width = 180;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 180;
            // 
            // ShopName
            // 
            this.ShopName.DataPropertyName = "ShopName";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle12.Format = "N0";
            this.ShopName.DefaultCellStyle = dataGridViewCellStyle12;
            this.ShopName.HeaderText = "Location";
            this.ShopName.Name = "ShopName";
            this.ShopName.ReadOnly = true;
            this.ShopName.Width = 110;
            // 
            // Note
            // 
            this.Note.DataPropertyName = "Note";
            this.Note.HeaderText = "Note";
            this.Note.Name = "Note";
            this.Note.ReadOnly = true;
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
            // OrderNo
            // 
            this.OrderNo.ActiveLinkColor = System.Drawing.Color.Brown;
            this.OrderNo.DataPropertyName = "OrderNo";
            this.OrderNo.HeaderText = "RefID";
            this.OrderNo.LinkColor = System.Drawing.Color.Red;
            this.OrderNo.Name = "OrderNo";
            this.OrderNo.ReadOnly = true;
            this.OrderNo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.OrderNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.OrderNo.VisitedLinkColor = System.Drawing.Color.Gray;
            this.OrderNo.Width = 150;
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
            this.panel4.Size = new System.Drawing.Size(1322, 123);
            this.panel4.TabIndex = 44;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(557, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 26);
            this.label3.TabIndex = 94;
            this.label3.Text = "Date";
            // 
            // dtEEditDate
            // 
            this.dtEEditDate.CustomFormat = "dd/MM/yyyy";
            this.dtEEditDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtEEditDate.Location = new System.Drawing.Point(775, 30);
            this.dtEEditDate.Name = "dtEEditDate";
            this.dtEEditDate.Size = new System.Drawing.Size(131, 26);
            this.dtEEditDate.TabIndex = 92;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(756, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 25);
            this.label8.TabIndex = 93;
            this.label8.Text = "-";
            // 
            // dtSEditDate
            // 
            this.dtSEditDate.CustomFormat = "dd/MM/yyyy";
            this.dtSEditDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtSEditDate.Location = new System.Drawing.Point(619, 30);
            this.dtSEditDate.Name = "dtSEditDate";
            this.dtSEditDate.Size = new System.Drawing.Size(131, 26);
            this.dtSEditDate.TabIndex = 91;
            // 
            // btnSendBox
            // 
            this.btnSendBox.BackColor = System.Drawing.Color.PeachPuff;
            this.btnSendBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSendBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSendBox.FlatAppearance.BorderColor = System.Drawing.Color.Linen;
            this.btnSendBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendBox.Location = new System.Drawing.Point(126, 19);
            this.btnSendBox.Name = "btnSendBox";
            this.btnSendBox.Size = new System.Drawing.Size(70, 90);
            this.btnSendBox.TabIndex = 78;
            this.btnSendBox.Text = "Send box";
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
            this.btnInbox.Image = ((System.Drawing.Image)(resources.GetObject("btnInbox.Image")));
            this.btnInbox.Location = new System.Drawing.Point(20, 19);
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
            this.label1.Location = new System.Drawing.Point(283, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 26);
            this.label1.TabIndex = 76;
            this.label1.Text = "RefID";
            // 
            // txtRefID
            // 
            this.txtRefID.Location = new System.Drawing.Point(345, 30);
            this.txtRefID.Name = "txtRefID";
            this.txtRefID.Size = new System.Drawing.Size(172, 26);
            this.txtRefID.TabIndex = 75;
            // 
            // cmbStatusType
            // 
            this.cmbStatusType.FormattingEnabled = true;
            this.cmbStatusType.Location = new System.Drawing.Point(345, 70);
            this.cmbStatusType.Name = "cmbStatusType";
            this.cmbStatusType.Size = new System.Drawing.Size(172, 28);
            this.cmbStatusType.TabIndex = 73;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(225, 73);
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
            this.btnSearch.Location = new System.Drawing.Point(619, 70);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(105, 32);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
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
            // tds
            // 
            this.tds.DataSetName = "dsWarning";
            this.tds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
        private System.Windows.Forms.DataGridViewImageColumn IsRead;
        private System.Windows.Forms.DataGridViewTextBoxColumn RowNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SenderName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReceiverName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Detail;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShopName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Note;
        private System.Windows.Forms.DataGridViewTextBoxColumn EditDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn RefID;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusType;
        private System.Windows.Forms.DataGridViewTextBoxColumn MessageStatus;
        private System.Windows.Forms.DataGridViewLinkColumn OrderNo;
    }
}