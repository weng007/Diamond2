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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WarningList));
            this.panel2 = new System.Windows.Forms.Panel();
            this.gridWarning = new System.Windows.Forms.DataGridView();
            this.RowNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SenderName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReceiverName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MessageStatusName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FactoryStatusName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShopName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cmbSender = new System.Windows.Forms.ComboBox();
            this.cmbShop = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbFactoryStatus = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbMessageStatus = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cmbReceiver = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tds = new DiamondDS.DS.dsSell();
            this.button1 = new System.Windows.Forms.Button();
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
            this.panel2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridWarning.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridWarning.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridWarning.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RowNum,
            this.ID,
            this.SenderName,
            this.ReceiverName,
            this.MessageStatusName,
            this.FactoryStatusName,
            this.ShopName,
            this.Note});
            this.gridWarning.Location = new System.Drawing.Point(14, 6);
            this.gridWarning.Name = "gridWarning";
            this.gridWarning.ReadOnly = true;
            this.gridWarning.RowHeadersWidth = 10;
            this.gridWarning.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridWarning.RowTemplate.Height = 30;
            this.gridWarning.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridWarning.Size = new System.Drawing.Size(1315, 446);
            this.gridWarning.TabIndex = 4;
            this.gridWarning.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gridSell_MouseDoubleClick);
            // 
            // RowNum
            // 
            this.RowNum.DataPropertyName = "RowNum";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.RowNum.DefaultCellStyle = dataGridViewCellStyle2;
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
            // MessageStatusName
            // 
            this.MessageStatusName.DataPropertyName = "MessageStatusName";
            this.MessageStatusName.HeaderText = "Message Status";
            this.MessageStatusName.Name = "MessageStatusName";
            this.MessageStatusName.ReadOnly = true;
            this.MessageStatusName.Width = 160;
            // 
            // FactoryStatusName
            // 
            this.FactoryStatusName.DataPropertyName = "FactoryStatusName";
            this.FactoryStatusName.HeaderText = "Factory Status";
            this.FactoryStatusName.Name = "FactoryStatusName";
            this.FactoryStatusName.ReadOnly = true;
            this.FactoryStatusName.Width = 150;
            // 
            // ShopName
            // 
            this.ShopName.DataPropertyName = "ShopName";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle3.Format = "N0";
            this.ShopName.DefaultCellStyle = dataGridViewCellStyle3;
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
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.IndianRed;
            this.panel4.Controls.Add(this.button1);
            this.panel4.Controls.Add(this.cmbSender);
            this.panel4.Controls.Add(this.cmbShop);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.cmbFactoryStatus);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.cmbMessageStatus);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.btnAdd);
            this.panel4.Controls.Add(this.cmbReceiver);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.btnSearch);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(-1, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1322, 123);
            this.panel4.TabIndex = 44;
            // 
            // cmbSender
            // 
            this.cmbSender.FormattingEnabled = true;
            this.cmbSender.Location = new System.Drawing.Point(239, 18);
            this.cmbSender.Name = "cmbSender";
            this.cmbSender.Size = new System.Drawing.Size(172, 29);
            this.cmbSender.TabIndex = 1;
            // 
            // cmbShop
            // 
            this.cmbShop.FormattingEnabled = true;
            this.cmbShop.Location = new System.Drawing.Point(517, 62);
            this.cmbShop.Name = "cmbShop";
            this.cmbShop.Size = new System.Drawing.Size(172, 29);
            this.cmbShop.TabIndex = 75;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(429, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 26);
            this.label5.TabIndex = 76;
            this.label5.Text = "Location";
            // 
            // cmbFactoryStatus
            // 
            this.cmbFactoryStatus.FormattingEnabled = true;
            this.cmbFactoryStatus.Location = new System.Drawing.Point(239, 62);
            this.cmbFactoryStatus.Name = "cmbFactoryStatus";
            this.cmbFactoryStatus.Size = new System.Drawing.Size(172, 29);
            this.cmbFactoryStatus.TabIndex = 73;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(111, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 26);
            this.label2.TabIndex = 74;
            this.label2.Text = "Factory Status";
            // 
            // cmbMessageStatus
            // 
            this.cmbMessageStatus.FormattingEnabled = true;
            this.cmbMessageStatus.Location = new System.Drawing.Point(854, 15);
            this.cmbMessageStatus.Name = "cmbMessageStatus";
            this.cmbMessageStatus.Size = new System.Drawing.Size(172, 29);
            this.cmbMessageStatus.TabIndex = 71;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(713, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 26);
            this.label1.TabIndex = 72;
            this.label1.Text = "Message Status";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.BackgroundImage")));
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.Linen;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(20, 21);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(70, 90);
            this.btnAdd.TabIndex = 70;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cmbReceiver
            // 
            this.cmbReceiver.FormattingEnabled = true;
            this.cmbReceiver.Location = new System.Drawing.Point(517, 16);
            this.cmbReceiver.Name = "cmbReceiver";
            this.cmbReceiver.Size = new System.Drawing.Size(172, 29);
            this.cmbReceiver.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(430, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 26);
            this.label4.TabIndex = 46;
            this.label4.Text = "Receiver";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.Linen;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(854, 61);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(105, 32);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(169, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 26);
            this.label3.TabIndex = 27;
            this.label3.Text = "Sender";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tds
            // 
            this.tds.DataSetName = "dsSell";
            this.tds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1111, 77);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 34);
            this.button1.TabIndex = 77;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            ((System.ComponentModel.ISupportInitialize)(this.tds)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView gridWarning;
        private System.Windows.Forms.ComboBox cmbReceiver;
        private DiamondDS.DS.dsSell tds;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cmbShop;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbFactoryStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbMessageStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox cmbSender;
        private System.Windows.Forms.DataGridViewTextBoxColumn RowNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SenderName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReceiverName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MessageStatusName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FactoryStatusName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShopName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Note;
        private System.Windows.Forms.Button button1;
    }
}