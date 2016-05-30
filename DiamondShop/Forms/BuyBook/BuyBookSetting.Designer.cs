﻿namespace DiamondShop
{
    partial class BuyBookSetting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuyBookSetting));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtBuyDate = new System.Windows.Forms.DateTimePicker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBuyPrice = new System.Windows.Forms.TextBox();
            this.txtSalePrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gridSetting = new System.Windows.Forms.DataGridView();
            this.RowNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SettingTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaterialName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PricePerGram = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PricePerUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalBaht = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RefID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SettingType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Material = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSeller = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSetting)).BeginInit();
            this.SuspendLayout();
            // 
            // dtBuyDate
            // 
            this.dtBuyDate.CustomFormat = "dd/MM/yyyy";
            this.dtBuyDate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtBuyDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtBuyDate.Location = new System.Drawing.Point(127, 17);
            this.dtBuyDate.Name = "dtBuyDate";
            this.dtBuyDate.Size = new System.Drawing.Size(131, 27);
            this.dtBuyDate.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnDel);
            this.panel3.Controls.Add(this.btnAdd);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txtBuyPrice);
            this.panel3.Controls.Add(this.txtSalePrice);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.gridSetting);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.txtSeller);
            this.panel3.Controls.Add(this.dtBuyDate);
            this.panel3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(10, 72);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(976, 427);
            this.panel3.TabIndex = 74;
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
            this.btnDel.Location = new System.Drawing.Point(923, 134);
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
            this.btnAdd.Location = new System.Drawing.Point(923, 98);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(30, 30);
            this.btnAdd.TabIndex = 93;
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(89)))), ((int)(((byte)(52)))));
            this.label4.Location = new System.Drawing.Point(670, 359);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 21);
            this.label4.TabIndex = 92;
            this.label4.Text = "ขายออก";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(89)))), ((int)(((byte)(52)))));
            this.label3.Location = new System.Drawing.Point(555, 359);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 21);
            this.label3.TabIndex = 91;
            this.label3.Text = "รับซื้อ";
            // 
            // txtBuyPrice
            // 
            this.txtBuyPrice.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuyPrice.Location = new System.Drawing.Point(537, 383);
            this.txtBuyPrice.Name = "txtBuyPrice";
            this.txtBuyPrice.Size = new System.Drawing.Size(81, 27);
            this.txtBuyPrice.TabIndex = 6;
            this.txtBuyPrice.Text = "0";
            this.txtBuyPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBuyPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuyPrice_KeyPress);
            this.txtBuyPrice.Leave += new System.EventHandler(this.txtBuyPrice_Leave);
            // 
            // txtSalePrice
            // 
            this.txtSalePrice.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalePrice.Location = new System.Drawing.Point(663, 383);
            this.txtSalePrice.Name = "txtSalePrice";
            this.txtSalePrice.Size = new System.Drawing.Size(81, 27);
            this.txtSalePrice.TabIndex = 8;
            this.txtSalePrice.Text = "0";
            this.txtSalePrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSalePrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuyPrice_KeyPress);
            this.txtSalePrice.Leave += new System.EventHandler(this.txtSalePrice_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(89)))), ((int)(((byte)(52)))));
            this.label2.Location = new System.Drawing.Point(330, 386);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 21);
            this.label2.TabIndex = 88;
            this.label2.Text = "ทองคำแท่ง 96.5% ณ วันที่ซื้อ";
            // 
            // gridSetting
            // 
            this.gridSetting.AllowUserToAddRows = false;
            this.gridSetting.AllowUserToOrderColumns = true;
            this.gridSetting.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gridSetting.ColumnHeadersHeight = 33;
            this.gridSetting.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RowNum,
            this.ID,
            this.SettingTypeName,
            this.MaterialName,
            this.Amount,
            this.Weight,
            this.PricePerGram,
            this.PricePerUnit,
            this.TotalBaht,
            this.RefID,
            this.SettingType,
            this.Material});
            this.gridSetting.Location = new System.Drawing.Point(23, 98);
            this.gridSetting.Name = "gridSetting";
            this.gridSetting.ReadOnly = true;
            this.gridSetting.RowHeadersWidth = 10;
            this.gridSetting.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridSetting.RowTemplate.Height = 25;
            this.gridSetting.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.gridSetting.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridSetting.Size = new System.Drawing.Size(891, 248);
            this.gridSetting.TabIndex = 86;
            this.gridSetting.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.gridSetting_CellFormatting);
            this.gridSetting.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridSetting_CellMouseDoubleClick);
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
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // SettingTypeName
            // 
            this.SettingTypeName.DataPropertyName = "SettingTypeName";
            this.SettingTypeName.HeaderText = "Type";
            this.SettingTypeName.Name = "SettingTypeName";
            this.SettingTypeName.ReadOnly = true;
            this.SettingTypeName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SettingTypeName.Width = 170;
            // 
            // MaterialName
            // 
            this.MaterialName.DataPropertyName = "MaterialName";
            this.MaterialName.HeaderText = "Material";
            this.MaterialName.Name = "MaterialName";
            this.MaterialName.ReadOnly = true;
            this.MaterialName.Width = 150;
            // 
            // Amount
            // 
            this.Amount.DataPropertyName = "Amount";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle2.Format = "N0";
            this.Amount.DefaultCellStyle = dataGridViewCellStyle2;
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            this.Amount.Width = 80;
            // 
            // Weight
            // 
            this.Weight.DataPropertyName = "Weight";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle3.Format = "N2";
            this.Weight.DefaultCellStyle = dataGridViewCellStyle3;
            this.Weight.HeaderText = "Weight";
            this.Weight.Name = "Weight";
            this.Weight.ReadOnly = true;
            this.Weight.Width = 80;
            // 
            // PricePerGram
            // 
            this.PricePerGram.DataPropertyName = "PricePerGram";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle4.Format = "N0";
            this.PricePerGram.DefaultCellStyle = dataGridViewCellStyle4;
            this.PricePerGram.HeaderText = "Price/Gram";
            this.PricePerGram.Name = "PricePerGram";
            this.PricePerGram.ReadOnly = true;
            this.PricePerGram.Width = 110;
            // 
            // PricePerUnit
            // 
            this.PricePerUnit.DataPropertyName = "PricePerUnit";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle5.Format = "N0";
            this.PricePerUnit.DefaultCellStyle = dataGridViewCellStyle5;
            this.PricePerUnit.HeaderText = "Price/Unit";
            this.PricePerUnit.Name = "PricePerUnit";
            this.PricePerUnit.ReadOnly = true;
            // 
            // TotalBaht
            // 
            this.TotalBaht.DataPropertyName = "TotalBaht";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle6.Format = "N0";
            this.TotalBaht.DefaultCellStyle = dataGridViewCellStyle6;
            this.TotalBaht.HeaderText = "TotalBaht";
            this.TotalBaht.Name = "TotalBaht";
            this.TotalBaht.ReadOnly = true;
            this.TotalBaht.Width = 140;
            // 
            // RefID
            // 
            this.RefID.DataPropertyName = "RefID";
            this.RefID.HeaderText = "RefID";
            this.RefID.Name = "RefID";
            this.RefID.ReadOnly = true;
            this.RefID.Visible = false;
            // 
            // SettingType
            // 
            this.SettingType.DataPropertyName = "SettingType";
            this.SettingType.HeaderText = "SettingType";
            this.SettingType.Name = "SettingType";
            this.SettingType.ReadOnly = true;
            this.SettingType.Visible = false;
            // 
            // Material
            // 
            this.Material.DataPropertyName = "Material";
            this.Material.HeaderText = "Material";
            this.Material.Name = "Material";
            this.Material.ReadOnly = true;
            this.Material.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(89)))), ((int)(((byte)(52)))));
            this.label1.Location = new System.Drawing.Point(19, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 21);
            this.label1.TabIndex = 85;
            this.label1.Text = "Seller";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(89)))), ((int)(((byte)(52)))));
            this.label6.Location = new System.Drawing.Point(19, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 21);
            this.label6.TabIndex = 84;
            this.label6.Text = "Buy Date";
            // 
            // txtSeller
            // 
            this.txtSeller.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSeller.Location = new System.Drawing.Point(127, 53);
            this.txtSeller.Name = "txtSeller";
            this.txtSeller.Size = new System.Drawing.Size(157, 27);
            this.txtSeller.TabIndex = 4;
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
            // BuyBookSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(195)))), ((int)(((byte)(157)))));
            this.ClientSize = new System.Drawing.Size(998, 502);
            this.Controls.Add(this.panel3);
            this.Name = "BuyBookSetting";
            this.Text = "DiamondCer";
            this.Controls.SetChildIndex(this.panel3, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSetting)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtBuyDate;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtSeller;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBuyPrice;
        private System.Windows.Forms.TextBox txtSalePrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView gridSetting;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.DataGridViewTextBoxColumn RowNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SettingTypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaterialName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Weight;
        private System.Windows.Forms.DataGridViewTextBoxColumn PricePerGram;
        private System.Windows.Forms.DataGridViewTextBoxColumn PricePerUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalBaht;
        private System.Windows.Forms.DataGridViewTextBoxColumn RefID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SettingType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Material;
    }
}