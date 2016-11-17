namespace DiamondShop
{
    partial class SearchTransferInventory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchTransferInventory));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnSelect = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbJewelryType = new System.Windows.Forms.ComboBox();
            this.txtCode2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gridTransferInventory = new System.Windows.Forms.DataGridView();
            this.Select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.RowNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Code2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JewelryTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShapeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColorTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EShop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsBuyBook = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalBaht = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTransferInventory)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(1170, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(38, 32);
            this.btnClose.TabIndex = 79;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(91)))), ((int)(((byte)(59)))));
            this.panel4.Controls.Add(this.btnSelect);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.cmbJewelryType);
            this.panel4.Controls.Add(this.txtCode2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.txtCode);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.btnSearch);
            this.panel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.panel4.Location = new System.Drawing.Point(5, 1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1162, 108);
            this.panel4.TabIndex = 42;
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.Color.Transparent;
            this.btnSelect.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSelect.BackgroundImage")));
            this.btnSelect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSelect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelect.FlatAppearance.BorderColor = System.Drawing.Color.Linen;
            this.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelect.Image = ((System.Drawing.Image)(resources.GetObject("btnSelect.Image")));
            this.btnSelect.Location = new System.Drawing.Point(9, 10);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(70, 90);
            this.btnSelect.TabIndex = 81;
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(357, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 26);
            this.label2.TabIndex = 80;
            this.label2.Text = "Jewelry Type";
            // 
            // cmbJewelryType
            // 
            this.cmbJewelryType.FormattingEnabled = true;
            this.cmbJewelryType.Location = new System.Drawing.Point(474, 19);
            this.cmbJewelryType.Name = "cmbJewelryType";
            this.cmbJewelryType.Size = new System.Drawing.Size(172, 28);
            this.cmbJewelryType.TabIndex = 79;
            // 
            // txtCode2
            // 
            this.txtCode2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCode2.Location = new System.Drawing.Point(178, 60);
            this.txtCode2.Name = "txtCode2";
            this.txtCode2.Size = new System.Drawing.Size(145, 26);
            this.txtCode2.TabIndex = 78;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(111, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 26);
            this.label1.TabIndex = 77;
            this.label1.Text = "Code2";
            // 
            // txtCode
            // 
            this.txtCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCode.Location = new System.Drawing.Point(178, 18);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(145, 26);
            this.txtCode.TabIndex = 76;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(111, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 26);
            this.label5.TabIndex = 75;
            this.label5.Text = "Code";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Gainsboro;
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.Linen;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(541, 60);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(105, 32);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.gridTransferInventory);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(5, 112);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1190, 458);
            this.panel2.TabIndex = 33;
            // 
            // gridTransferInventory
            // 
            this.gridTransferInventory.AllowUserToAddRows = false;
            this.gridTransferInventory.AllowUserToDeleteRows = false;
            this.gridTransferInventory.AllowUserToOrderColumns = true;
            this.gridTransferInventory.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.gridTransferInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTransferInventory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Select,
            this.RowNum,
            this.ID,
            this.Code,
            this.Code2,
            this.Weight,
            this.JewelryTypeName,
            this.ShapeName,
            this.ColorTypeName,
            this.ColorName,
            this.EShop,
            this.IsBuyBook,
            this.TotalBaht});
            this.gridTransferInventory.Location = new System.Drawing.Point(9, 3);
            this.gridTransferInventory.Name = "gridTransferInventory";
            this.gridTransferInventory.ReadOnly = true;
            this.gridTransferInventory.RowHeadersWidth = 10;
            this.gridTransferInventory.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridTransferInventory.RowTemplate.Height = 30;
            this.gridTransferInventory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridTransferInventory.Size = new System.Drawing.Size(1178, 452);
            this.gridTransferInventory.TabIndex = 2;
            this.gridTransferInventory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridTransferInventory_CellClick);
            // 
            // Select
            // 
            this.Select.HeaderText = "Select";
            this.Select.Name = "Select";
            this.Select.ReadOnly = true;
            this.Select.Width = 60;
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
            // Code
            // 
            this.Code.DataPropertyName = "Code";
            this.Code.HeaderText = "Code";
            this.Code.Name = "Code";
            this.Code.ReadOnly = true;
            this.Code.Width = 150;
            // 
            // Code2
            // 
            this.Code2.DataPropertyName = "Code2";
            this.Code2.HeaderText = "Code2";
            this.Code2.Name = "Code2";
            this.Code2.ReadOnly = true;
            this.Code2.Width = 150;
            // 
            // Weight
            // 
            this.Weight.DataPropertyName = "Weight";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle2.Format = "N2";
            this.Weight.DefaultCellStyle = dataGridViewCellStyle2;
            this.Weight.HeaderText = "Weight";
            this.Weight.Name = "Weight";
            this.Weight.ReadOnly = true;
            this.Weight.Width = 80;
            // 
            // JewelryTypeName
            // 
            this.JewelryTypeName.DataPropertyName = "JewelryTypeName";
            this.JewelryTypeName.HeaderText = "JewelryType";
            this.JewelryTypeName.Name = "JewelryTypeName";
            this.JewelryTypeName.ReadOnly = true;
            this.JewelryTypeName.Width = 130;
            // 
            // ShapeName
            // 
            this.ShapeName.DataPropertyName = "ShapeName";
            this.ShapeName.HeaderText = "Shape";
            this.ShapeName.Name = "ShapeName";
            this.ShapeName.ReadOnly = true;
            this.ShapeName.Width = 150;
            // 
            // ColorTypeName
            // 
            this.ColorTypeName.DataPropertyName = "ColorTypeName";
            this.ColorTypeName.HeaderText = "ColorType";
            this.ColorTypeName.Name = "ColorTypeName";
            this.ColorTypeName.ReadOnly = true;
            this.ColorTypeName.Width = 130;
            // 
            // ColorName
            // 
            this.ColorName.DataPropertyName = "ColorName";
            this.ColorName.HeaderText = "ColorName";
            this.ColorName.Name = "ColorName";
            this.ColorName.ReadOnly = true;
            this.ColorName.Width = 120;
            // 
            // EShop
            // 
            this.EShop.DataPropertyName = "EShop";
            this.EShop.HeaderText = "EShop";
            this.EShop.Name = "EShop";
            this.EShop.ReadOnly = true;
            this.EShop.Visible = false;
            // 
            // IsBuyBook
            // 
            this.IsBuyBook.DataPropertyName = "IsBuyBook";
            this.IsBuyBook.HeaderText = "IsBuyBook";
            this.IsBuyBook.Name = "IsBuyBook";
            this.IsBuyBook.ReadOnly = true;
            this.IsBuyBook.Visible = false;
            // 
            // TotalBaht
            // 
            this.TotalBaht.DataPropertyName = "TotalBaht";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N0";
            this.TotalBaht.DefaultCellStyle = dataGridViewCellStyle3;
            this.TotalBaht.HeaderText = "TotalBaht";
            this.TotalBaht.Name = "TotalBaht";
            this.TotalBaht.ReadOnly = true;
            this.TotalBaht.Width = 120;
            // 
            // SearchTransferInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(91)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(1207, 577);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Name = "SearchTransferInventory";
            this.Text = "ProductList";
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridTransferInventory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView gridTransferInventory;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.TextBox txtCode2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbJewelryType;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Select;
        private System.Windows.Forms.DataGridViewTextBoxColumn RowNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Weight;
        private System.Windows.Forms.DataGridViewTextBoxColumn JewelryTypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShapeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColorTypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn EShop;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsBuyBook;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalBaht;
    }
}