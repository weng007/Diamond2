namespace DiamondShop
{
    partial class TransferInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransferInfo));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtSendDate = new System.Windows.Forms.DateTimePicker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cmbTransferStatus = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtReceiveDate = new System.Windows.Forms.DateTimePicker();
            this.cmbReceiver = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.gridTransfer = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSender = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbShop = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.RowNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CatID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Weight1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Weight2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountGC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WeightGC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountNGC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WeightNGC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTransfer)).BeginInit();
            this.SuspendLayout();
            // 
            // dtSendDate
            // 
            this.dtSendDate.CustomFormat = "dd/MM/yyyy";
            this.dtSendDate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtSendDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtSendDate.Location = new System.Drawing.Point(127, 17);
            this.dtSendDate.Name = "dtSendDate";
            this.dtSendDate.Size = new System.Drawing.Size(131, 27);
            this.dtSendDate.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.txtNote);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.cmbShop);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.cmbTransferStatus);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.dtReceiveDate);
            this.panel3.Controls.Add(this.cmbReceiver);
            this.panel3.Controls.Add(this.label22);
            this.panel3.Controls.Add(this.btnDel);
            this.panel3.Controls.Add(this.btnAdd);
            this.panel3.Controls.Add(this.gridTransfer);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.txtSender);
            this.panel3.Controls.Add(this.dtSendDate);
            this.panel3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(10, 72);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(976, 448);
            this.panel3.TabIndex = 74;
            // 
            // cmbTransferStatus
            // 
            this.cmbTransferStatus.FormattingEnabled = true;
            this.cmbTransferStatus.Location = new System.Drawing.Point(730, 53);
            this.cmbTransferStatus.Name = "cmbTransferStatus";
            this.cmbTransferStatus.Size = new System.Drawing.Size(156, 29);
            this.cmbTransferStatus.TabIndex = 232;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(89)))), ((int)(((byte)(52)))));
            this.label2.Location = new System.Drawing.Point(601, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 21);
            this.label2.TabIndex = 233;
            this.label2.Text = "Transfer Status";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(89)))), ((int)(((byte)(52)))));
            this.label5.Location = new System.Drawing.Point(284, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 21);
            this.label5.TabIndex = 231;
            this.label5.Text = "Receive Date";
            // 
            // dtReceiveDate
            // 
            this.dtReceiveDate.CustomFormat = "dd/MM/yyyy";
            this.dtReceiveDate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtReceiveDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtReceiveDate.Location = new System.Drawing.Point(406, 17);
            this.dtReceiveDate.Name = "dtReceiveDate";
            this.dtReceiveDate.Size = new System.Drawing.Size(131, 27);
            this.dtReceiveDate.TabIndex = 230;
            // 
            // cmbReceiver
            // 
            this.cmbReceiver.FormattingEnabled = true;
            this.cmbReceiver.Location = new System.Drawing.Point(406, 53);
            this.cmbReceiver.Name = "cmbReceiver";
            this.cmbReceiver.Size = new System.Drawing.Size(156, 29);
            this.cmbReceiver.TabIndex = 228;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(89)))), ((int)(((byte)(52)))));
            this.label22.Location = new System.Drawing.Point(322, 58);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(78, 21);
            this.label22.TabIndex = 229;
            this.label22.Text = "Receiver";
            // 
            // btnDel
            // 
            this.btnDel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDel.BackgroundImage")));
            this.btnDel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDel.Enabled = false;
            this.btnDel.FlatAppearance.BorderSize = 0;
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.Image = ((System.Drawing.Image)(resources.GetObject("btnDel.Image")));
            this.btnDel.Location = new System.Drawing.Point(932, 134);
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
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(932, 98);
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
            this.gridTransfer.AllowUserToOrderColumns = true;
            this.gridTransfer.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gridTransfer.ColumnHeadersHeight = 33;
            this.gridTransfer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RowNum,
            this.CatID,
            this.ID,
            this.Code,
            this.Amount1,
            this.Weight1,
            this.Amount2,
            this.Weight2,
            this.AmountGC,
            this.WeightGC,
            this.AmountNGC,
            this.WeightNGC,
            this.Detail});
            this.gridTransfer.Location = new System.Drawing.Point(23, 98);
            this.gridTransfer.Name = "gridTransfer";
            this.gridTransfer.ReadOnly = true;
            this.gridTransfer.RowHeadersWidth = 10;
            this.gridTransfer.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridTransfer.RowTemplate.Height = 25;
            this.gridTransfer.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.gridTransfer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridTransfer.Size = new System.Drawing.Size(903, 248);
            this.gridTransfer.TabIndex = 86;
            this.gridTransfer.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.gridSetting_CellFormatting);
            this.gridTransfer.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridSetting_CellMouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(89)))), ((int)(((byte)(52)))));
            this.label1.Location = new System.Drawing.Point(19, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 21);
            this.label1.TabIndex = 85;
            this.label1.Text = "Sender";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(89)))), ((int)(((byte)(52)))));
            this.label6.Location = new System.Drawing.Point(19, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 21);
            this.label6.TabIndex = 84;
            this.label6.Text = "Send Date";
            // 
            // txtSender
            // 
            this.txtSender.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSender.Location = new System.Drawing.Point(127, 53);
            this.txtSender.Name = "txtSender";
            this.txtSender.Size = new System.Drawing.Size(157, 27);
            this.txtSender.TabIndex = 4;
            // 
            // btnEdit
            // 
            this.btnEdit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEdit.BackgroundImage")));
            this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // cmbShop
            // 
            this.cmbShop.FormattingEnabled = true;
            this.cmbShop.Location = new System.Drawing.Point(730, 16);
            this.cmbShop.Name = "cmbShop";
            this.cmbShop.Size = new System.Drawing.Size(156, 29);
            this.cmbShop.TabIndex = 234;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(601, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 28);
            this.label4.TabIndex = 235;
            this.label4.Text = "Location";
            // 
            // txtNote
            // 
            this.txtNote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtNote.Location = new System.Drawing.Point(675, 364);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(251, 68);
            this.txtNote.TabIndex = 236;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(89)))), ((int)(((byte)(52)))));
            this.label16.Location = new System.Drawing.Point(624, 364);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(45, 19);
            this.label16.TabIndex = 237;
            this.label16.Text = "Note";
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
            // CatID
            // 
            this.CatID.HeaderText = "CatID";
            this.CatID.Name = "CatID";
            this.CatID.ReadOnly = true;
            this.CatID.Visible = false;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "RefID";
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
            this.Code.Width = 170;
            // 
            // Amount1
            // 
            this.Amount1.DataPropertyName = "Amount1";
            this.Amount1.HeaderText = "Amount DC";
            this.Amount1.Name = "Amount1";
            this.Amount1.ReadOnly = true;
            this.Amount1.Width = 150;
            // 
            // Weight1
            // 
            this.Weight1.DataPropertyName = "Weight1";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle2.Format = "N2";
            this.Weight1.DefaultCellStyle = dataGridViewCellStyle2;
            this.Weight1.HeaderText = "Weight DC";
            this.Weight1.Name = "Weight1";
            this.Weight1.ReadOnly = true;
            this.Weight1.Width = 140;
            // 
            // Amount2
            // 
            this.Amount2.DataPropertyName = "Amount2";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle3.Format = "N0";
            this.Amount2.DefaultCellStyle = dataGridViewCellStyle3;
            this.Amount2.HeaderText = "Amount NDC";
            this.Amount2.Name = "Amount2";
            this.Amount2.ReadOnly = true;
            // 
            // Weight2
            // 
            this.Weight2.DataPropertyName = "Weight2";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle4.Format = "N0";
            this.Weight2.DefaultCellStyle = dataGridViewCellStyle4;
            this.Weight2.HeaderText = "Weight NDC";
            this.Weight2.Name = "Weight2";
            this.Weight2.ReadOnly = true;
            this.Weight2.Width = 140;
            // 
            // AmountGC
            // 
            this.AmountGC.HeaderText = "Amount GC";
            this.AmountGC.Name = "AmountGC";
            this.AmountGC.ReadOnly = true;
            // 
            // WeightGC
            // 
            this.WeightGC.HeaderText = "Weight GC";
            this.WeightGC.Name = "WeightGC";
            this.WeightGC.ReadOnly = true;
            // 
            // AmountNGC
            // 
            this.AmountNGC.HeaderText = "Amount NGC";
            this.AmountNGC.Name = "AmountNGC";
            this.AmountNGC.ReadOnly = true;
            // 
            // WeightNGC
            // 
            this.WeightNGC.HeaderText = "Weight NGC";
            this.WeightNGC.Name = "WeightNGC";
            this.WeightNGC.ReadOnly = true;
            // 
            // Detail
            // 
            this.Detail.DataPropertyName = "Detail";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle5.Format = "N0";
            this.Detail.DefaultCellStyle = dataGridViewCellStyle5;
            this.Detail.HeaderText = "Detail";
            this.Detail.Name = "Detail";
            this.Detail.ReadOnly = true;
            this.Detail.Width = 150;
            // 
            // TransferInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(195)))), ((int)(((byte)(157)))));
            this.ClientSize = new System.Drawing.Size(998, 532);
            this.Controls.Add(this.panel3);
            this.Name = "TransferInfo";
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
        private System.Windows.Forms.ComboBox cmbReceiver;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtReceiveDate;
        private System.Windows.Forms.ComboBox cmbTransferStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbShop;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridViewTextBoxColumn RowNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn CatID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Weight1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Weight2;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountGC;
        private System.Windows.Forms.DataGridViewTextBoxColumn WeightGC;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountNGC;
        private System.Windows.Forms.DataGridViewTextBoxColumn WeightNGC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Detail;
    }
}