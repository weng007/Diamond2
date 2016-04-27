﻿namespace DiamondShop
{
    partial class BuyBookDiamondList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuyBookDiamondList));
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtESize = new System.Windows.Forms.TextBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtSSize = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbShape = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gridDiamond = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RowNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BuyDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seller = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Shape = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clearity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceCaratUSD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceCaratBaht = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MarketPriceBaht = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tds = new DiamondDS.DS.dsDiamondCer();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDiamond)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tds)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(105)))), ((int)(((byte)(79)))));
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.txtESize);
            this.panel4.Controls.Add(this.txtCode);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.btnAdd);
            this.panel4.Controls.Add(this.txtSSize);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.cmbShape);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.btnSearch);
            this.panel4.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1329, 149);
            this.panel4.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(554, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 26);
            this.label1.TabIndex = 76;
            this.label1.Text = "-";
            // 
            // txtESize
            // 
            this.txtESize.Location = new System.Drawing.Point(573, 20);
            this.txtESize.Name = "txtESize";
            this.txtESize.Size = new System.Drawing.Size(54, 27);
            this.txtESize.TabIndex = 12;
            this.txtESize.Text = "0";
            this.txtESize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(245, 20);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(161, 27);
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
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.BackgroundImage")));
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.Linen;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(17, 20);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(70, 90);
            this.btnAdd.TabIndex = 68;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtSSize
            // 
            this.txtSSize.Location = new System.Drawing.Point(494, 20);
            this.txtSSize.Name = "txtSSize";
            this.txtSSize.Size = new System.Drawing.Size(54, 27);
            this.txtSSize.TabIndex = 8;
            this.txtSSize.Text = "0";
            this.txtSSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSSize.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtWeightTo_KeyPress);
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
            this.cmbShape.Location = new System.Drawing.Point(245, 55);
            this.cmbShape.Name = "cmbShape";
            this.cmbShape.Size = new System.Drawing.Size(161, 29);
            this.cmbShape.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(444, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 26);
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
            this.btnSearch.Location = new System.Drawing.Point(245, 100);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(105, 32);
            this.btnSearch.TabIndex = 16;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.gridDiamond);
            this.panel2.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(5, 155);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1311, 422);
            this.panel2.TabIndex = 34;
            // 
            // gridDiamond
            // 
            this.gridDiamond.AllowUserToAddRows = false;
            this.gridDiamond.AllowUserToDeleteRows = false;
            this.gridDiamond.AllowUserToOrderColumns = true;
            this.gridDiamond.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.gridDiamond.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDiamond.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.RowNum,
            this.Code,
            this.BuyDate,
            this.Seller,
            this.Shape,
            this.Amount,
            this.Weight,
            this.Color,
            this.Clearity,
            this.PriceCaratUSD,
            this.PriceCaratBaht,
            this.MarketPriceBaht});
            this.gridDiamond.Location = new System.Drawing.Point(7, 0);
            this.gridDiamond.Name = "gridDiamond";
            this.gridDiamond.ReadOnly = true;
            this.gridDiamond.RowHeadersWidth = 10;
            this.gridDiamond.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridDiamond.RowTemplate.Height = 30;
            this.gridDiamond.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridDiamond.Size = new System.Drawing.Size(1301, 415);
            this.gridDiamond.TabIndex = 2;
            this.gridDiamond.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridDiamond_CellContentDoubleClick);
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
            this.Code.Width = 120;
            // 
            // BuyDate
            // 
            this.BuyDate.DataPropertyName = "BuyDate";
            this.BuyDate.HeaderText = "Buy Date";
            this.BuyDate.Name = "BuyDate";
            this.BuyDate.ReadOnly = true;
            this.BuyDate.Width = 90;
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
            // Shape
            // 
            this.Shape.DataPropertyName = "Shape";
            this.Shape.HeaderText = "Shape";
            this.Shape.Name = "Shape";
            this.Shape.ReadOnly = true;
            this.Shape.Width = 90;
            // 
            // Amount
            // 
            this.Amount.DataPropertyName = "Amount";
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            this.Amount.Width = 60;
            // 
            // Weight
            // 
            this.Weight.DataPropertyName = "Weight";
            this.Weight.HeaderText = "Weight";
            this.Weight.Name = "Weight";
            this.Weight.ReadOnly = true;
            this.Weight.Width = 60;
            // 
            // Color
            // 
            this.Color.DataPropertyName = "Color";
            this.Color.HeaderText = "Color";
            this.Color.Name = "Color";
            this.Color.ReadOnly = true;
            this.Color.Width = 90;
            // 
            // Clearity
            // 
            this.Clearity.DataPropertyName = "Clearity";
            this.Clearity.HeaderText = "Clearity";
            this.Clearity.Name = "Clearity";
            this.Clearity.ReadOnly = true;
            this.Clearity.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // PriceCaratUSD
            // 
            this.PriceCaratUSD.DataPropertyName = "PriceCaratUSD";
            this.PriceCaratUSD.HeaderText = "Price/Carat USD";
            this.PriceCaratUSD.Name = "PriceCaratUSD";
            this.PriceCaratUSD.ReadOnly = true;
            this.PriceCaratUSD.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.PriceCaratUSD.Width = 150;
            // 
            // PriceCaratBaht
            // 
            this.PriceCaratBaht.DataPropertyName = "PriceCaratBaht";
            this.PriceCaratBaht.HeaderText = "Price/Carat Baht";
            this.PriceCaratBaht.Name = "PriceCaratBaht";
            this.PriceCaratBaht.ReadOnly = true;
            this.PriceCaratBaht.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.PriceCaratBaht.Width = 150;
            // 
            // MarketPriceBaht
            // 
            this.MarketPriceBaht.DataPropertyName = "MarketPriceBaht";
            this.MarketPriceBaht.HeaderText = "Market Price Baht";
            this.MarketPriceBaht.Name = "MarketPriceBaht";
            this.MarketPriceBaht.ReadOnly = true;
            this.MarketPriceBaht.Width = 150;
            // 
            // tds
            // 
            this.tds.DataSetName = "dsDiamondCer";
            this.tds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BuyBookDiamondList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1328, 587);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Name = "BuyBookDiamondList";
            this.Text = "DiamondCerList";
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridDiamond)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tds)).EndInit();
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
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtESize;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn RowNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn BuyDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Seller;
        private System.Windows.Forms.DataGridViewTextBoxColumn Shape;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Weight;
        private System.Windows.Forms.DataGridViewTextBoxColumn Color;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clearity;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceCaratUSD;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceCaratBaht;
        private System.Windows.Forms.DataGridViewTextBoxColumn MarketPriceBaht;
    }
}