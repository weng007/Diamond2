namespace DiamondShop
{
    partial class OrderList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderList));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tds = new DiamondDS.DS.dsDiamondCer();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cmbSeller = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbJewelryType = new System.Windows.Forms.ComboBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gridOrder = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RowNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JewelryTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SShopName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReceiveDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShopName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AppointDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShopName1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tds)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // tds
            // 
            this.tds.DataSetName = "dsDiamondCer";
            this.tds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(105)))), ((int)(((byte)(79)))));
            this.panel4.Controls.Add(this.cmbSeller);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.cmbJewelryType);
            this.panel4.Controls.Add(this.txtCustomerName);
            this.panel4.Controls.Add(this.label14);
            this.panel4.Controls.Add(this.btnSearch);
            this.panel4.Controls.Add(this.txtCode);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.btnAdd);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1329, 160);
            this.panel4.TabIndex = 40;
            // 
            // cmbSeller
            // 
            this.cmbSeller.FormattingEnabled = true;
            this.cmbSeller.Location = new System.Drawing.Point(519, 60);
            this.cmbSeller.Name = "cmbSeller";
            this.cmbSeller.Size = new System.Drawing.Size(161, 29);
            this.cmbSeller.TabIndex = 80;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(464, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 33);
            this.label1.TabIndex = 79;
            this.label1.Text = "Seller";
            // 
            // cmbJewelryType
            // 
            this.cmbJewelryType.FormattingEnabled = true;
            this.cmbJewelryType.Location = new System.Drawing.Point(519, 18);
            this.cmbJewelryType.Name = "cmbJewelryType";
            this.cmbJewelryType.Size = new System.Drawing.Size(161, 29);
            this.cmbJewelryType.TabIndex = 78;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(263, 62);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(161, 27);
            this.txtCustomerName.TabIndex = 76;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(120, 65);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(143, 31);
            this.label14.TabIndex = 77;
            this.label14.Text = "Customer Name";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Gainsboro;
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.Linen;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(263, 106);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(105, 32);
            this.btnSearch.TabIndex = 52;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(263, 20);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(161, 27);
            this.txtCode.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(177, 23);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 31);
            this.label12.TabIndex = 74;
            this.label12.Text = "Order No.";
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
            this.btnAdd.TabIndex = 68;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(464, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 33);
            this.label7.TabIndex = 67;
            this.label7.Text = "Type";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.gridOrder);
            this.panel2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(1, 166);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1335, 409);
            this.panel2.TabIndex = 34;
            // 
            // gridOrder
            // 
            this.gridOrder.AllowUserToAddRows = false;
            this.gridOrder.AllowUserToDeleteRows = false;
            this.gridOrder.AllowUserToOrderColumns = true;
            this.gridOrder.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gridOrder.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.gridOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.RowNum,
            this.OrderNo,
            this.CustomerName,
            this.JewelryTypeName,
            this.SShopName,
            this.ReceiveDate,
            this.ShopName,
            this.AppointDate,
            this.ShopName1});
            this.gridOrder.Location = new System.Drawing.Point(15, 3);
            this.gridOrder.Name = "gridOrder";
            this.gridOrder.ReadOnly = true;
            this.gridOrder.RowHeadersWidth = 10;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridOrder.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.gridOrder.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridOrder.RowTemplate.Height = 30;
            this.gridOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridOrder.Size = new System.Drawing.Size(1313, 388);
            this.gridOrder.TabIndex = 2;
            this.gridOrder.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gridDiamondCer_MouseDoubleClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // RowNum
            // 
            this.RowNum.DataPropertyName = "RowNum";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.Format = "N0";
            this.RowNum.DefaultCellStyle = dataGridViewCellStyle1;
            this.RowNum.HeaderText = "No.";
            this.RowNum.Name = "RowNum";
            this.RowNum.ReadOnly = true;
            this.RowNum.Width = 50;
            // 
            // OrderNo
            // 
            this.OrderNo.DataPropertyName = "OrderNo";
            this.OrderNo.HeaderText = "OrderNo";
            this.OrderNo.Name = "OrderNo";
            this.OrderNo.ReadOnly = true;
            this.OrderNo.Width = 150;
            // 
            // CustomerName
            // 
            this.CustomerName.DataPropertyName = "CustomerName";
            this.CustomerName.HeaderText = "Customer";
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.ReadOnly = true;
            this.CustomerName.Width = 120;
            // 
            // JewelryTypeName
            // 
            this.JewelryTypeName.DataPropertyName = "JewelryTypeName";
            this.JewelryTypeName.HeaderText = "Type";
            this.JewelryTypeName.Name = "JewelryTypeName";
            this.JewelryTypeName.ReadOnly = true;
            this.JewelryTypeName.Width = 150;
            // 
            // SShopName
            // 
            this.SShopName.DataPropertyName = "SShopName";
            this.SShopName.HeaderText = "Location (Order)";
            this.SShopName.Name = "SShopName";
            this.SShopName.ReadOnly = true;
            this.SShopName.Width = 170;
            // 
            // ReceiveDate
            // 
            this.ReceiveDate.DataPropertyName = "ReceiveDate";
            dataGridViewCellStyle2.Format = "dd/MM/yyyy";
            this.ReceiveDate.DefaultCellStyle = dataGridViewCellStyle2;
            this.ReceiveDate.HeaderText = "วันนัดรับสินค้า";
            this.ReceiveDate.Name = "ReceiveDate";
            this.ReceiveDate.ReadOnly = true;
            this.ReceiveDate.Width = 170;
            // 
            // ShopName
            // 
            this.ShopName.DataPropertyName = "ShopName";
            this.ShopName.HeaderText = "Location (นัดรับ)";
            this.ShopName.Name = "ShopName";
            this.ShopName.ReadOnly = true;
            this.ShopName.Width = 160;
            // 
            // AppointDate
            // 
            this.AppointDate.DataPropertyName = "AppointDate";
            dataGridViewCellStyle3.NullValue = "-";
            this.AppointDate.DefaultCellStyle = dataGridViewCellStyle3;
            this.AppointDate.HeaderText = "วันนัดดูตัวเรือน";
            this.AppointDate.Name = "AppointDate";
            this.AppointDate.ReadOnly = true;
            this.AppointDate.Width = 160;
            // 
            // ShopName1
            // 
            this.ShopName1.DataPropertyName = "ShopName1";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle4.Format = "N2";
            this.ShopName1.DefaultCellStyle = dataGridViewCellStyle4;
            this.ShopName1.HeaderText = "Location (นัดดู)";
            this.ShopName1.Name = "ShopName1";
            this.ShopName1.ReadOnly = true;
            this.ShopName1.Width = 160;
            // 
            // OrderList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(105)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(1335, 577);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Name = "OrderList";
            this.Text = "DiamondCerList";
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tds)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridOrder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView gridOrder;
        private System.Windows.Forms.Panel panel4;
        private DiamondDS.DS.dsDiamondCer tds;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cmbSeller;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbJewelryType;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn RowNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn JewelryTypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SShopName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReceiveDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShopName;
        private System.Windows.Forms.DataGridViewTextBoxColumn AppointDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShopName1;
    }
}