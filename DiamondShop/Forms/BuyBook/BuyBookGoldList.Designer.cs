﻿namespace DiamondShop
{
    partial class BuyBookGoldList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuyBookGoldList));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cmbPercentGold = new System.Windows.Forms.ComboBox();
            this.dtEBuyDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtSBuyDate = new System.Windows.Forms.DateTimePicker();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gridGold = new System.Windows.Forms.DataGridView();
            this.RowNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BuyDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seller = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PricePerGram = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceGram1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceGram2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridGold)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(91)))), ((int)(((byte)(59)))));
            this.panel4.Controls.Add(this.cmbPercentGold);
            this.panel4.Controls.Add(this.dtEBuyDate);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.dtSBuyDate);
            this.panel4.Controls.Add(this.btnAdd);
            this.panel4.Controls.Add(this.btnSearch);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.panel4.Location = new System.Drawing.Point(0, 1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1327, 117);
            this.panel4.TabIndex = 42;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // cmbPercentGold
            // 
            this.cmbPercentGold.FormattingEnabled = true;
            this.cmbPercentGold.Items.AddRange(new object[] {
            "All",
            "96.5%",
            "99.99%"});
            this.cmbPercentGold.Location = new System.Drawing.Point(238, 24);
            this.cmbPercentGold.Name = "cmbPercentGold";
            this.cmbPercentGold.Size = new System.Drawing.Size(131, 29);
            this.cmbPercentGold.TabIndex = 1;
            // 
            // dtEBuyDate
            // 
            this.dtEBuyDate.CustomFormat = "dd/MM/yyyy";
            this.dtEBuyDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtEBuyDate.Location = new System.Drawing.Point(394, 63);
            this.dtEBuyDate.Name = "dtEBuyDate";
            this.dtEBuyDate.Size = new System.Drawing.Size(131, 27);
            this.dtEBuyDate.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(375, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 25);
            this.label2.TabIndex = 72;
            this.label2.Text = "-";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(144, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 25);
            this.label1.TabIndex = 71;
            this.label1.Text = "Buy Date";
            // 
            // dtSBuyDate
            // 
            this.dtSBuyDate.CustomFormat = "dd/MM/yyyy";
            this.dtSBuyDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtSBuyDate.Location = new System.Drawing.Point(238, 63);
            this.dtSBuyDate.Name = "dtSBuyDate";
            this.dtSBuyDate.Size = new System.Drawing.Size(131, 27);
            this.dtSBuyDate.TabIndex = 4;
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
            this.btnAdd.TabIndex = 69;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Gainsboro;
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.Linen;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(561, 61);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(105, 32);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(145, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 25);
            this.label3.TabIndex = 27;
            this.label3.Text = "% ทองคำ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.gridGold);
            this.panel2.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(5, 124);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1331, 451);
            this.panel2.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(874, 1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(454, 33);
            this.label4.TabIndex = 6;
            this.label4.Text = "ทองคำ 99.99%";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(323, 1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(553, 33);
            this.label5.TabIndex = 5;
            this.label5.Text = "ทองคำ 96.5%";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gridGold
            // 
            this.gridGold.AllowUserToAddRows = false;
            this.gridGold.AllowUserToDeleteRows = false;
            this.gridGold.AllowUserToOrderColumns = true;
            this.gridGold.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.gridGold.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridGold.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RowNum,
            this.ID,
            this.BuyDate,
            this.Seller,
            this.Amount1,
            this.Price1,
            this.Total1,
            this.PricePerGram,
            this.PriceGram1,
            this.Amount2,
            this.Price2,
            this.Total2,
            this.PriceGram2});
            this.gridGold.Location = new System.Drawing.Point(15, 33);
            this.gridGold.Name = "gridGold";
            this.gridGold.ReadOnly = true;
            this.gridGold.RowHeadersWidth = 10;
            this.gridGold.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridGold.RowTemplate.Height = 30;
            this.gridGold.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridGold.Size = new System.Drawing.Size(1315, 419);
            this.gridGold.TabIndex = 3;
            this.gridGold.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gridGold_MouseDoubleClick);
            // 
            // RowNum
            // 
            this.RowNum.DataPropertyName = "RowNum";
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
            // BuyDate
            // 
            this.BuyDate.DataPropertyName = "BuyDate";
            this.BuyDate.HeaderText = "Buy Date";
            this.BuyDate.Name = "BuyDate";
            this.BuyDate.ReadOnly = true;
            this.BuyDate.Width = 130;
            // 
            // Seller
            // 
            this.Seller.DataPropertyName = "Seller";
            this.Seller.HeaderText = "Seller";
            this.Seller.Name = "Seller";
            this.Seller.ReadOnly = true;
            this.Seller.Width = 120;
            // 
            // Amount1
            // 
            this.Amount1.DataPropertyName = "Amount1";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle1.Format = "N2";
            this.Amount1.DefaultCellStyle = dataGridViewCellStyle1;
            this.Amount1.HeaderText = "บาท";
            this.Amount1.Name = "Amount1";
            this.Amount1.ReadOnly = true;
            this.Amount1.Width = 80;
            // 
            // Price1
            // 
            this.Price1.DataPropertyName = "Price1";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle2.Format = "N0";
            this.Price1.DefaultCellStyle = dataGridViewCellStyle2;
            this.Price1.HeaderText = "ราคาบาทละ";
            this.Price1.Name = "Price1";
            this.Price1.ReadOnly = true;
            this.Price1.Width = 110;
            // 
            // Total1
            // 
            this.Total1.DataPropertyName = "Total1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle3.Format = "N0";
            this.Total1.DefaultCellStyle = dataGridViewCellStyle3;
            this.Total1.HeaderText = "Total";
            this.Total1.Name = "Total1";
            this.Total1.ReadOnly = true;
            this.Total1.Width = 110;
            // 
            // PricePerGram
            // 
            this.PricePerGram.DataPropertyName = "PricePerGram";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle4.Format = "N0";
            this.PricePerGram.DefaultCellStyle = dataGridViewCellStyle4;
            this.PricePerGram.HeaderText = "ราคากรัมละ";
            this.PricePerGram.Name = "PricePerGram";
            this.PricePerGram.ReadOnly = true;
            this.PricePerGram.Width = 110;
            // 
            // PriceGram1
            // 
            this.PriceGram1.DataPropertyName = "PriceGram1";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle5.Format = "N0";
            this.PriceGram1.DefaultCellStyle = dataGridViewCellStyle5;
            this.PriceGram1.HeaderText = "ทอง 75% กรัมละ";
            this.PriceGram1.Name = "PriceGram1";
            this.PriceGram1.ReadOnly = true;
            this.PriceGram1.Width = 140;
            // 
            // Amount2
            // 
            this.Amount2.DataPropertyName = "Amount2";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle6.Format = "N0";
            this.Amount2.DefaultCellStyle = dataGridViewCellStyle6;
            this.Amount2.HeaderText = "กรัม";
            this.Amount2.Name = "Amount2";
            this.Amount2.ReadOnly = true;
            this.Amount2.Width = 80;
            // 
            // Price2
            // 
            this.Price2.DataPropertyName = "Price2";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle7.Format = "N0";
            this.Price2.DefaultCellStyle = dataGridViewCellStyle7;
            this.Price2.HeaderText = "ราคากรัมละ";
            this.Price2.Name = "Price2";
            this.Price2.ReadOnly = true;
            this.Price2.Width = 120;
            // 
            // Total2
            // 
            this.Total2.DataPropertyName = "Total2";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle8.Format = "N0";
            this.Total2.DefaultCellStyle = dataGridViewCellStyle8;
            this.Total2.HeaderText = "Total";
            this.Total2.Name = "Total2";
            this.Total2.ReadOnly = true;
            this.Total2.Width = 110;
            // 
            // PriceGram2
            // 
            this.PriceGram2.DataPropertyName = "PriceGram2";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle9.Format = "N0";
            this.PriceGram2.DefaultCellStyle = dataGridViewCellStyle9;
            this.PriceGram2.HeaderText = "ทอง 75% กรัมละ";
            this.PriceGram2.Name = "PriceGram2";
            this.PriceGram2.ReadOnly = true;
            this.PriceGram2.Width = 140;
            // 
            // BuyBookGoldList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(91)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(1335, 577);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Name = "BuyBookGoldList";
            this.Text = "ProductList";
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridGold)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DateTimePicker dtEBuyDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtSBuyDate;
        private System.Windows.Forms.DataGridView gridGold;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbPercentGold;
        private System.Windows.Forms.DataGridViewTextBoxColumn RowNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn BuyDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Seller;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PricePerGram;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceGram1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total2;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceGram2;
    }
}