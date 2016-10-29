namespace DiamondShop
{
    partial class SearchBuyBookGemstoneList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchBuyBookGemstoneList));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tds = new DiamondDS.DS.dsDiamondCer();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtCode2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtESize = new System.Windows.Forms.TextBox();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbShape = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gridGemstone = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RowNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BuyDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seller = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Code2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShapeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdentificationName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OriginName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceCaratUSD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceCarat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MarketPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remain = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tds)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridGemstone)).BeginInit();
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
            this.panel4.Controls.Add(this.btnSelect);
            this.panel4.Controls.Add(this.btnClose);
            this.panel4.Controls.Add(this.txtCode2);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.txtESize);
            this.panel4.Controls.Add(this.txtSize);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.txtCode);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.cmbShape);
            this.panel4.Controls.Add(this.btnSearch);
            this.panel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1352, 149);
            this.panel4.TabIndex = 40;
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
            this.btnSelect.Location = new System.Drawing.Point(20, 23);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(70, 90);
            this.btnSelect.TabIndex = 87;
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(1310, 9);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(38, 32);
            this.btnClose.TabIndex = 86;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtCode2
            // 
            this.txtCode2.Location = new System.Drawing.Point(510, 20);
            this.txtCode2.Name = "txtCode2";
            this.txtCode2.Size = new System.Drawing.Size(161, 26);
            this.txtCode2.TabIndex = 79;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(437, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 31);
            this.label3.TabIndex = 80;
            this.label3.Text = "Code2";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(574, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 24);
            this.label2.TabIndex = 78;
            this.label2.Text = "-";
            // 
            // txtESize
            // 
            this.txtESize.Location = new System.Drawing.Point(592, 53);
            this.txtESize.Name = "txtESize";
            this.txtESize.Size = new System.Drawing.Size(58, 26);
            this.txtESize.TabIndex = 77;
            this.txtESize.Text = "50";
            this.txtESize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSize
            // 
            this.txtSize.Location = new System.Drawing.Point(510, 53);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(58, 26);
            this.txtSize.TabIndex = 8;
            this.txtSize.Text = "0";
            this.txtSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSize.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSize_KeyPress);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(462, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 31);
            this.label1.TabIndex = 76;
            this.label1.Text = "Size";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(251, 20);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(161, 26);
            this.txtCode.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(172, 23);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 31);
            this.label12.TabIndex = 74;
            this.label12.Text = "Code";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(172, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 26);
            this.label5.TabIndex = 51;
            this.label5.Text = "Shape";
            // 
            // cmbShape
            // 
            this.cmbShape.FormattingEnabled = true;
            this.cmbShape.Location = new System.Drawing.Point(251, 55);
            this.cmbShape.Name = "cmbShape";
            this.cmbShape.Size = new System.Drawing.Size(161, 28);
            this.cmbShape.TabIndex = 4;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Gainsboro;
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.Linen;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(251, 101);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(105, 32);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.gridGemstone);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 151);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1334, 428);
            this.panel2.TabIndex = 34;
            // 
            // gridGemstone
            // 
            this.gridGemstone.AllowUserToAddRows = false;
            this.gridGemstone.AllowUserToDeleteRows = false;
            this.gridGemstone.AllowUserToOrderColumns = true;
            this.gridGemstone.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.gridGemstone.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridGemstone.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.RowNum,
            this.BuyDate,
            this.Seller,
            this.Code,
            this.Code2,
            this.ShapeName,
            this.IdentificationName,
            this.OriginName,
            this.Amount,
            this.Weight,
            this.Size,
            this.PriceCaratUSD,
            this.PriceCarat,
            this.MarketPrice,
            this.Remain});
            this.gridGemstone.Location = new System.Drawing.Point(20, 0);
            this.gridGemstone.Name = "gridGemstone";
            this.gridGemstone.ReadOnly = true;
            this.gridGemstone.RowHeadersWidth = 10;
            this.gridGemstone.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridGemstone.RowTemplate.Height = 30;
            this.gridGemstone.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridGemstone.Size = new System.Drawing.Size(1314, 425);
            this.gridGemstone.TabIndex = 2;
            this.gridGemstone.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridGemstone_CellClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.ID.DefaultCellStyle = dataGridViewCellStyle1;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // RowNum
            // 
            this.RowNum.DataPropertyName = "RowNum";
            this.RowNum.HeaderText = "No.";
            this.RowNum.Name = "RowNum";
            this.RowNum.ReadOnly = true;
            this.RowNum.Width = 50;
            // 
            // BuyDate
            // 
            this.BuyDate.DataPropertyName = "BuyDate";
            dataGridViewCellStyle2.Format = "dd/MM/yyyy";
            this.BuyDate.DefaultCellStyle = dataGridViewCellStyle2;
            this.BuyDate.HeaderText = "Buy Date";
            this.BuyDate.Name = "BuyDate";
            this.BuyDate.ReadOnly = true;
            this.BuyDate.Width = 120;
            // 
            // Seller
            // 
            this.Seller.DataPropertyName = "Seller";
            this.Seller.HeaderText = "Seller";
            this.Seller.Name = "Seller";
            this.Seller.ReadOnly = true;
            this.Seller.Width = 120;
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
            this.Code2.Width = 120;
            // 
            // ShapeName
            // 
            this.ShapeName.DataPropertyName = "ShapeName";
            this.ShapeName.HeaderText = "Shape";
            this.ShapeName.Name = "ShapeName";
            this.ShapeName.ReadOnly = true;
            this.ShapeName.Width = 110;
            // 
            // IdentificationName
            // 
            this.IdentificationName.DataPropertyName = "IdentificationName";
            this.IdentificationName.HeaderText = "Identification";
            this.IdentificationName.Name = "IdentificationName";
            this.IdentificationName.ReadOnly = true;
            this.IdentificationName.Width = 120;
            // 
            // OriginName
            // 
            this.OriginName.DataPropertyName = "OriginName";
            this.OriginName.HeaderText = "Origin";
            this.OriginName.Name = "OriginName";
            this.OriginName.ReadOnly = true;
            this.OriginName.Width = 120;
            // 
            // Amount
            // 
            this.Amount.DataPropertyName = "Amount";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle3.Format = "N0";
            this.Amount.DefaultCellStyle = dataGridViewCellStyle3;
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            this.Amount.Width = 80;
            // 
            // Weight
            // 
            this.Weight.DataPropertyName = "Weight";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle4.Format = "N2";
            this.Weight.DefaultCellStyle = dataGridViewCellStyle4;
            this.Weight.HeaderText = "Weight";
            this.Weight.Name = "Weight";
            this.Weight.ReadOnly = true;
            this.Weight.Width = 80;
            // 
            // Size
            // 
            this.Size.DataPropertyName = "Size";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle5.Format = "N2";
            this.Size.DefaultCellStyle = dataGridViewCellStyle5;
            this.Size.HeaderText = "Size";
            this.Size.Name = "Size";
            this.Size.ReadOnly = true;
            // 
            // PriceCaratUSD
            // 
            this.PriceCaratUSD.DataPropertyName = "PriceCaratUSD";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle6.Format = "N0";
            this.PriceCaratUSD.DefaultCellStyle = dataGridViewCellStyle6;
            this.PriceCaratUSD.HeaderText = "Price/Ct USD";
            this.PriceCaratUSD.Name = "PriceCaratUSD";
            this.PriceCaratUSD.ReadOnly = true;
            this.PriceCaratUSD.Width = 135;
            // 
            // PriceCarat
            // 
            this.PriceCarat.DataPropertyName = "PriceCarat";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle7.Format = "N0";
            this.PriceCarat.DefaultCellStyle = dataGridViewCellStyle7;
            this.PriceCarat.HeaderText = "Price/Ct Baht";
            this.PriceCarat.Name = "PriceCarat";
            this.PriceCarat.ReadOnly = true;
            this.PriceCarat.Width = 140;
            // 
            // MarketPrice
            // 
            this.MarketPrice.DataPropertyName = "MarketPrice";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle8.Format = "N0";
            this.MarketPrice.DefaultCellStyle = dataGridViewCellStyle8;
            this.MarketPrice.HeaderText = "Market Price Baht";
            this.MarketPrice.Name = "MarketPrice";
            this.MarketPrice.ReadOnly = true;
            this.MarketPrice.Width = 175;
            // 
            // Remain
            // 
            this.Remain.DataPropertyName = "Remain";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.Remain.DefaultCellStyle = dataGridViewCellStyle9;
            this.Remain.HeaderText = "คงเหลือ";
            this.Remain.Name = "Remain";
            this.Remain.ReadOnly = true;
            // 
            // SearchBuyBookGemstoneList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(105)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(1352, 594);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Name = "SearchBuyBookGemstoneList";
            this.Text = "DiamondCerList";
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tds)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridGemstone)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView gridGemstone;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbShape;
        private DiamondDS.DS.dsDiamondCer tds;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtESize;
        private System.Windows.Forms.TextBox txtCode2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn RowNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn BuyDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Seller;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShapeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdentificationName;
        private System.Windows.Forms.DataGridViewTextBoxColumn OriginName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Weight;
        private System.Windows.Forms.DataGridViewTextBoxColumn Size;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceCaratUSD;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceCarat;
        private System.Windows.Forms.DataGridViewTextBoxColumn MarketPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remain;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSelect;
    }
}