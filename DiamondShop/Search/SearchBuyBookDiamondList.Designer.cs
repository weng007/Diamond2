﻿namespace DiamondShop
{
    partial class SearchBuyBookDiamondList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchBuyBookDiamondList));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tds = new DiamondDS.DS.dsDiamondCer();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtCode2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtESize = new System.Windows.Forms.TextBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtSSize = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbShape = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gridDiamond = new System.Windows.Forms.DataGridView();
            this.Select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RowNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Code2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BuyDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seller = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShapeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClearityName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceCaratUSD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceCaratB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MarketPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tds)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDiamond)).BeginInit();
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
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.txtESize);
            this.panel4.Controls.Add(this.txtCode);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.txtSSize);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.cmbShape);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.btnSearch);
            this.panel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1318, 139);
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
            this.btnSelect.Location = new System.Drawing.Point(20, 20);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(70, 90);
            this.btnSelect.TabIndex = 81;
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
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(1284, 1);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(38, 32);
            this.btnClose.TabIndex = 79;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtCode2
            // 
            this.txtCode2.Location = new System.Drawing.Point(547, 20);
            this.txtCode2.Name = "txtCode2";
            this.txtCode2.Size = new System.Drawing.Size(161, 26);
            this.txtCode2.TabIndex = 77;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(474, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 31);
            this.label2.TabIndex = 78;
            this.label2.Text = "Code2";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(607, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 26);
            this.label1.TabIndex = 76;
            this.label1.Text = "-";
            // 
            // txtESize
            // 
            this.txtESize.Location = new System.Drawing.Point(626, 54);
            this.txtESize.Name = "txtESize";
            this.txtESize.Size = new System.Drawing.Size(54, 26);
            this.txtESize.TabIndex = 6;
            this.txtESize.Text = "50";
            this.txtESize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtESize.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSSize_KeyPress);
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(245, 21);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(161, 26);
            this.txtCode.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(172, 24);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 31);
            this.label12.TabIndex = 74;
            this.label12.Text = "Code";
            // 
            // txtSSize
            // 
            this.txtSSize.Location = new System.Drawing.Point(547, 54);
            this.txtSSize.Name = "txtSSize";
            this.txtSSize.Size = new System.Drawing.Size(54, 26);
            this.txtSSize.TabIndex = 4;
            this.txtSSize.Text = "0";
            this.txtSSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSSize.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSSize_KeyPress);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(172, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 26);
            this.label5.TabIndex = 51;
            this.label5.Text = "Shape";
            // 
            // cmbShape
            // 
            this.cmbShape.FormattingEnabled = true;
            this.cmbShape.Location = new System.Drawing.Point(245, 56);
            this.cmbShape.Name = "cmbShape";
            this.cmbShape.Size = new System.Drawing.Size(161, 28);
            this.cmbShape.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(497, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 26);
            this.label4.TabIndex = 45;
            this.label4.Text = "Size";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Gainsboro;
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.Linen;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(245, 101);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(105, 32);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.gridDiamond);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 145);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1318, 436);
            this.panel2.TabIndex = 34;
            // 
            // gridDiamond
            // 
            this.gridDiamond.AllowUserToAddRows = false;
            this.gridDiamond.AllowUserToDeleteRows = false;
            this.gridDiamond.AllowUserToOrderColumns = true;
            this.gridDiamond.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.gridDiamond.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.gridDiamond.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDiamond.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Select,
            this.ID,
            this.RowNum,
            this.Code,
            this.Code2,
            this.BuyDate,
            this.Seller,
            this.ShapeName,
            this.Amount,
            this.Weight,
            this.Size,
            this.ColorName,
            this.ClearityName,
            this.PriceCaratUSD,
            this.PriceCaratB,
            this.MarketPrice});
            this.gridDiamond.Location = new System.Drawing.Point(20, 0);
            this.gridDiamond.Name = "gridDiamond";
            this.gridDiamond.ReadOnly = true;
            this.gridDiamond.RowHeadersWidth = 10;
            this.gridDiamond.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridDiamond.RowTemplate.Height = 30;
            this.gridDiamond.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridDiamond.Size = new System.Drawing.Size(1291, 433);
            this.gridDiamond.TabIndex = 2;
            this.gridDiamond.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridDiamond_CellClick);
            // 
            // Select
            // 
            this.Select.HeaderText = "Select";
            this.Select.Name = "Select";
            this.Select.ReadOnly = true;
            this.Select.Width = 60;
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
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.RowNum.DefaultCellStyle = dataGridViewCellStyle9;
            this.RowNum.HeaderText = "No.";
            this.RowNum.Name = "RowNum";
            this.RowNum.ReadOnly = true;
            this.RowNum.Width = 50;
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
            // BuyDate
            // 
            this.BuyDate.DataPropertyName = "BuyDate";
            dataGridViewCellStyle10.Format = "dd/MM/yyyy";
            this.BuyDate.DefaultCellStyle = dataGridViewCellStyle10;
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
            this.Seller.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Seller.Width = 110;
            // 
            // ShapeName
            // 
            this.ShapeName.DataPropertyName = "ShapeName";
            this.ShapeName.HeaderText = "Shape";
            this.ShapeName.Name = "ShapeName";
            this.ShapeName.ReadOnly = true;
            this.ShapeName.Width = 90;
            // 
            // Amount
            // 
            this.Amount.DataPropertyName = "Amount";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle11.Format = "N0";
            this.Amount.DefaultCellStyle = dataGridViewCellStyle11;
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            this.Amount.Width = 90;
            // 
            // Weight
            // 
            this.Weight.DataPropertyName = "Weight";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle12.Format = "N2";
            this.Weight.DefaultCellStyle = dataGridViewCellStyle12;
            this.Weight.HeaderText = "Weight";
            this.Weight.Name = "Weight";
            this.Weight.ReadOnly = true;
            this.Weight.Width = 90;
            // 
            // Size
            // 
            this.Size.DataPropertyName = "Size";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.Size.DefaultCellStyle = dataGridViewCellStyle13;
            this.Size.HeaderText = "Size";
            this.Size.Name = "Size";
            this.Size.ReadOnly = true;
            // 
            // ColorName
            // 
            this.ColorName.DataPropertyName = "ColorName";
            this.ColorName.HeaderText = "Color";
            this.ColorName.Name = "ColorName";
            this.ColorName.ReadOnly = true;
            // 
            // ClearityName
            // 
            this.ClearityName.DataPropertyName = "ClearityName";
            this.ClearityName.HeaderText = "Clearity";
            this.ClearityName.Name = "ClearityName";
            this.ClearityName.ReadOnly = true;
            this.ClearityName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ClearityName.Width = 70;
            // 
            // PriceCaratUSD
            // 
            this.PriceCaratUSD.DataPropertyName = "PriceCaratUSD";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle14.Format = "N0";
            this.PriceCaratUSD.DefaultCellStyle = dataGridViewCellStyle14;
            this.PriceCaratUSD.HeaderText = "Price/Ct USD";
            this.PriceCaratUSD.Name = "PriceCaratUSD";
            this.PriceCaratUSD.ReadOnly = true;
            this.PriceCaratUSD.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.PriceCaratUSD.Width = 135;
            // 
            // PriceCaratB
            // 
            this.PriceCaratB.DataPropertyName = "PriceCarat";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle15.Format = "N0";
            this.PriceCaratB.DefaultCellStyle = dataGridViewCellStyle15;
            this.PriceCaratB.HeaderText = "Price/Ct Baht";
            this.PriceCaratB.Name = "PriceCaratB";
            this.PriceCaratB.ReadOnly = true;
            this.PriceCaratB.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.PriceCaratB.Width = 140;
            // 
            // MarketPrice
            // 
            this.MarketPrice.DataPropertyName = "MarketPrice";
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle16.Format = "N0";
            this.MarketPrice.DefaultCellStyle = dataGridViewCellStyle16;
            this.MarketPrice.HeaderText = "Market Price Baht";
            this.MarketPrice.Name = "MarketPrice";
            this.MarketPrice.ReadOnly = true;
            this.MarketPrice.Width = 180;
            // 
            // SearchBuyBookDiamondList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(105)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(1321, 593);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Name = "SearchBuyBookDiamondList";
            this.Text = "DiamondCerList";
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tds)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridDiamond)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView gridDiamond;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbShape;
        private System.Windows.Forms.TextBox txtSSize;
        private DiamondDS.DS.dsDiamondCer tds;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtESize;
        private System.Windows.Forms.TextBox txtCode2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Select;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn RowNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code2;
        private System.Windows.Forms.DataGridViewTextBoxColumn BuyDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Seller;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShapeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Weight;
        private System.Windows.Forms.DataGridViewTextBoxColumn Size;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClearityName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceCaratUSD;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceCaratB;
        private System.Windows.Forms.DataGridViewTextBoxColumn MarketPrice;
    }
}