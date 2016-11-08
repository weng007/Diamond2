namespace DiamondShop
{
    partial class SellBookList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SellBookList));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gridSellBook = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tds = new DiamondDS.DS.dsSell();
            this.RowNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SellDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SellNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JewelryTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaymentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SellByName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShopReceiveName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSellBook)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tds)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.gridSellBook);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(5, 123);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1329, 452);
            this.panel2.TabIndex = 45;
            // 
            // gridSellBook
            // 
            this.gridSellBook.AllowUserToAddRows = false;
            this.gridSellBook.AllowUserToDeleteRows = false;
            this.gridSellBook.AllowUserToOrderColumns = true;
            this.gridSellBook.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.gridSellBook.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridSellBook.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridSellBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridSellBook.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RowNum,
            this.ID,
            this.SellDate,
            this.CustomerName,
            this.SellNo,
            this.JewelryTypeName,
            this.PaymentName,
            this.SellByName,
            this.ShopReceiveName});
            this.gridSellBook.Location = new System.Drawing.Point(14, 6);
            this.gridSellBook.Name = "gridSellBook";
            this.gridSellBook.ReadOnly = true;
            this.gridSellBook.RowHeadersWidth = 10;
            this.gridSellBook.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridSellBook.RowTemplate.Height = 30;
            this.gridSellBook.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridSellBook.Size = new System.Drawing.Size(1315, 446);
            this.gridSellBook.TabIndex = 4;
            this.gridSellBook.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gridSell_MouseDoubleClick);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(161)))), ((int)(((byte)(118)))));
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.Controls.Add(this.btnAdd);
            this.panel4.Controls.Add(this.btnSearch);
            this.panel4.Controls.Add(this.txtCode);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(-1, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1322, 123);
            this.panel4.TabIndex = 44;
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
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.Linen;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(206, 65);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(105, 32);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(206, 18);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(188, 26);
            this.txtCode.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(142, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 26);
            this.label3.TabIndex = 27;
            this.label3.Text = "Code";
            // 
            // tds
            // 
            this.tds.DataSetName = "dsSell";
            this.tds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // SellDate
            // 
            this.SellDate.DataPropertyName = "SellDate";
            dataGridViewCellStyle3.Format = "dd/MM/yyyy";
            this.SellDate.DefaultCellStyle = dataGridViewCellStyle3;
            this.SellDate.HeaderText = "Sold Date";
            this.SellDate.Name = "SellDate";
            this.SellDate.ReadOnly = true;
            this.SellDate.Width = 110;
            // 
            // CustomerName
            // 
            this.CustomerName.DataPropertyName = "CustomerName";
            this.CustomerName.HeaderText = "Customer";
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.ReadOnly = true;
            this.CustomerName.Width = 150;
            // 
            // SellNo
            // 
            this.SellNo.DataPropertyName = "SellNo";
            this.SellNo.HeaderText = "Code";
            this.SellNo.Name = "SellNo";
            this.SellNo.ReadOnly = true;
            this.SellNo.Width = 160;
            // 
            // JewelryTypeName
            // 
            this.JewelryTypeName.DataPropertyName = "JewelryTypeName";
            this.JewelryTypeName.HeaderText = "Type";
            this.JewelryTypeName.Name = "JewelryTypeName";
            this.JewelryTypeName.ReadOnly = true;
            this.JewelryTypeName.Visible = false;
            this.JewelryTypeName.Width = 150;
            // 
            // PaymentName
            // 
            this.PaymentName.DataPropertyName = "PaymentName";
            dataGridViewCellStyle4.Format = "N2";
            this.PaymentName.DefaultCellStyle = dataGridViewCellStyle4;
            this.PaymentName.HeaderText = "Payment";
            this.PaymentName.Name = "PaymentName";
            this.PaymentName.ReadOnly = true;
            // 
            // SellByName
            // 
            this.SellByName.DataPropertyName = "SellByName";
            this.SellByName.HeaderText = "Seller";
            this.SellByName.Name = "SellByName";
            this.SellByName.ReadOnly = true;
            this.SellByName.Width = 120;
            // 
            // ShopReceiveName
            // 
            this.ShopReceiveName.DataPropertyName = "ShopReceiveName";
            this.ShopReceiveName.HeaderText = "Receive At";
            this.ShopReceiveName.Name = "ShopReceiveName";
            this.ShopReceiveName.ReadOnly = true;
            this.ShopReceiveName.Width = 150;
            // 
            // SellBookList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1335, 577);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Name = "SellBookList";
            this.Text = "SaleList";
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridSellBook)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tds)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView gridSellBook;
        private DiamondDS.DS.dsSell tds;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn RowNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SellDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SellNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn JewelryTypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SellByName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShopReceiveName;
    }
}