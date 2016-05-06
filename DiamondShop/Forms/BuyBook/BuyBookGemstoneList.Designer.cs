﻿namespace DiamondShop
{
    partial class BuyBookGemstoneList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuyBookGemstoneList));
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbShape = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gridGemstone = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RowNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BuyDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seller = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShapeNmae = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Identification = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OriginName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceCaratUSD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceCaratBaht = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MarketPriceBaht = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remain = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tds = new DiamondDS.DS.dsDiamondCer();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridGemstone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tds)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(105)))), ((int)(((byte)(79)))));
            this.panel4.Controls.Add(this.txtSize);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.txtCode);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.btnAdd);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.cmbShape);
            this.panel4.Controls.Add(this.btnSearch);
            this.panel4.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1329, 152);
            this.panel4.TabIndex = 40;
            // 
            // txtSize
            // 
            this.txtSize.Location = new System.Drawing.Point(510, 20);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(58, 27);
            this.txtSize.TabIndex = 8;
            this.txtSize.Text = "0";
            this.txtSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSize.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSize_KeyPress);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(462, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 31);
            this.label1.TabIndex = 76;
            this.label1.Text = "Size";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(251, 20);
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
            this.cmbShape.Size = new System.Drawing.Size(161, 29);
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
            this.panel2.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(5, 157);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1311, 422);
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
            this.ShapeNmae,
            this.Identification,
            this.OriginName,
            this.Amount,
            this.Weight,
            this.PriceCaratUSD,
            this.PriceCaratBaht,
            this.MarketPriceBaht,
            this.Remain});
            this.gridGemstone.Location = new System.Drawing.Point(7, 0);
            this.gridGemstone.Name = "gridGemstone";
            this.gridGemstone.ReadOnly = true;
            this.gridGemstone.RowHeadersWidth = 10;
            this.gridGemstone.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridGemstone.RowTemplate.Height = 30;
            this.gridGemstone.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridGemstone.Size = new System.Drawing.Size(1301, 418);
            this.gridGemstone.TabIndex = 2;
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
            // BuyDate
            // 
            this.BuyDate.DataPropertyName = "BuyDate";
            this.BuyDate.HeaderText = "Buy Date";
            this.BuyDate.Name = "BuyDate";
            this.BuyDate.ReadOnly = true;
            // 
            // Seller
            // 
            this.Seller.DataPropertyName = "Seller";
            this.Seller.HeaderText = "Seller";
            this.Seller.Name = "Seller";
            this.Seller.ReadOnly = true;
            this.Seller.Width = 120;
            // 
            // ShapeNmae
            // 
            this.ShapeNmae.DataPropertyName = "ShapeNmae";
            this.ShapeNmae.HeaderText = "Shape";
            this.ShapeNmae.Name = "ShapeNmae";
            this.ShapeNmae.ReadOnly = true;
            this.ShapeNmae.Width = 110;
            // 
            // Identification
            // 
            this.Identification.DataPropertyName = "Identification";
            this.Identification.HeaderText = "Identification";
            this.Identification.Name = "Identification";
            this.Identification.ReadOnly = true;
            this.Identification.Width = 120;
            // 
            // OriginName
            // 
            this.OriginName.DataPropertyName = "OriginName";
            this.OriginName.HeaderText = "Origin";
            this.OriginName.Name = "OriginName";
            this.OriginName.ReadOnly = true;
            this.OriginName.Width = 80;
            // 
            // Amount
            // 
            this.Amount.DataPropertyName = "Amount";
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            this.Amount.Width = 80;
            // 
            // Weight
            // 
            this.Weight.DataPropertyName = "Weight";
            this.Weight.HeaderText = "Weight";
            this.Weight.Name = "Weight";
            this.Weight.ReadOnly = true;
            this.Weight.Width = 80;
            // 
            // PriceCaratUSD
            // 
            this.PriceCaratUSD.DataPropertyName = "PriceCaratUSD";
            this.PriceCaratUSD.HeaderText = "Price /Carat USD";
            this.PriceCaratUSD.Name = "PriceCaratUSD";
            this.PriceCaratUSD.ReadOnly = true;
            this.PriceCaratUSD.Width = 140;
            // 
            // PriceCaratBaht
            // 
            this.PriceCaratBaht.DataPropertyName = "PriceCaratBaht";
            this.PriceCaratBaht.HeaderText = "Price /Carat Baht";
            this.PriceCaratBaht.Name = "PriceCaratBaht";
            this.PriceCaratBaht.ReadOnly = true;
            this.PriceCaratBaht.Width = 140;
            // 
            // MarketPriceBaht
            // 
            this.MarketPriceBaht.DataPropertyName = "MarketPriceBaht";
            this.MarketPriceBaht.HeaderText = "Market Price Baht";
            this.MarketPriceBaht.Name = "MarketPriceBaht";
            this.MarketPriceBaht.ReadOnly = true;
            this.MarketPriceBaht.Width = 140;
            // 
            // Remain
            // 
            this.Remain.DataPropertyName = "Remain";
            this.Remain.HeaderText = "คงเหลือ";
            this.Remain.Name = "Remain";
            this.Remain.ReadOnly = true;
            // 
            // tds
            // 
            this.tds.DataSetName = "dsDiamondCer";
            this.tds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BuyBookGemstoneList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1328, 587);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Name = "BuyBookGemstoneList";
            this.Text = "DiamondCerList";
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridGemstone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tds)).EndInit();
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
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn RowNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn BuyDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Seller;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShapeNmae;
        private System.Windows.Forms.DataGridViewTextBoxColumn Identification;
        private System.Windows.Forms.DataGridViewTextBoxColumn OriginName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Weight;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceCaratUSD;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceCaratBaht;
        private System.Windows.Forms.DataGridViewTextBoxColumn MarketPriceBaht;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remain;
    }
}