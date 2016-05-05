namespace DiamondShop
{
    partial class InventoryList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryList));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtPrefix = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gridInventory = new System.Windows.Forms.DataGridView();
            this.RowNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Image1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Amount1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Weight1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Weight2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Weight3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Weight4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RedCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MinPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceTag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Shop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridInventory)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(91)))), ((int)(((byte)(59)))));
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.btnAdd);
            this.panel4.Controls.Add(this.txtPrefix);
            this.panel4.Controls.Add(this.btnSearch);
            this.panel4.Controls.Add(this.txtCode);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.panel4.Location = new System.Drawing.Point(0, 1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1327, 119);
            this.panel4.TabIndex = 42;
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
            this.btnAdd.Location = new System.Drawing.Point(12, 11);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(70, 90);
            this.btnAdd.TabIndex = 70;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtPrefix
            // 
            this.txtPrefix.Enabled = false;
            this.txtPrefix.Location = new System.Drawing.Point(187, 20);
            this.txtPrefix.Name = "txtPrefix";
            this.txtPrefix.Size = new System.Drawing.Size(52, 27);
            this.txtPrefix.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Gainsboro;
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.Linen;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(187, 62);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(105, 32);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(263, 20);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(132, 27);
            this.txtCode.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(122, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 25);
            this.label3.TabIndex = 27;
            this.label3.Text = "Code";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.gridInventory);
            this.panel2.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(5, 124);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1311, 427);
            this.panel2.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(660, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 33);
            this.label5.TabIndex = 6;
            this.label5.Text = "No Gems Cer.";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(540, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 33);
            this.label4.TabIndex = 5;
            this.label4.Text = "Gems Cer.";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(410, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 33);
            this.label2.TabIndex = 4;
            this.label2.Text = "No Dia Cer.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(291, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 33);
            this.label1.TabIndex = 3;
            this.label1.Text = "Dia Cer.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gridInventory
            // 
            this.gridInventory.AllowUserToAddRows = false;
            this.gridInventory.AllowUserToDeleteRows = false;
            this.gridInventory.AllowUserToOrderColumns = true;
            this.gridInventory.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.gridInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridInventory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RowNum,
            this.ID,
            this.Code,
            this.Image1,
            this.Amount1,
            this.Weight1,
            this.Amount2,
            this.Weight2,
            this.Amount3,
            this.Weight3,
            this.Amount4,
            this.Weight4,
            this.RedCost,
            this.MinPrice,
            this.PriceTag,
            this.Shop,
            this.Status});
            this.gridInventory.Location = new System.Drawing.Point(0, 32);
            this.gridInventory.Name = "gridInventory";
            this.gridInventory.ReadOnly = true;
            this.gridInventory.RowHeadersWidth = 10;
            this.gridInventory.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridInventory.RowTemplate.Height = 60;
            this.gridInventory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridInventory.Size = new System.Drawing.Size(1311, 392);
            this.gridInventory.TabIndex = 2;
            this.gridInventory.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gridInventory_MouseDoubleClick);
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
            // Code
            // 
            this.Code.DataPropertyName = "Code";
            this.Code.HeaderText = "Code";
            this.Code.Name = "Code";
            this.Code.ReadOnly = true;
            // 
            // Image1
            // 
            this.Image1.DataPropertyName = "Image1";
            this.Image1.HeaderText = "Photo";
            this.Image1.Name = "Image1";
            this.Image1.ReadOnly = true;
            this.Image1.Width = 130;
            // 
            // Amount1
            // 
            this.Amount1.DataPropertyName = "Amount1";
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Format = "dd/MM/yyyy";
            this.Amount1.DefaultCellStyle = dataGridViewCellStyle4;
            this.Amount1.HeaderText = "Amount";
            this.Amount1.Name = "Amount1";
            this.Amount1.ReadOnly = true;
            this.Amount1.Width = 60;
            // 
            // Weight1
            // 
            this.Weight1.DataPropertyName = "Weight1";
            dataGridViewCellStyle5.Format = "dd/MM/yyyy";
            this.Weight1.DefaultCellStyle = dataGridViewCellStyle5;
            this.Weight1.HeaderText = "Weight";
            this.Weight1.Name = "Weight1";
            this.Weight1.ReadOnly = true;
            this.Weight1.Width = 60;
            // 
            // Amount2
            // 
            this.Amount2.DataPropertyName = "Amount2";
            this.Amount2.HeaderText = "Amount";
            this.Amount2.Name = "Amount2";
            this.Amount2.ReadOnly = true;
            this.Amount2.Width = 65;
            // 
            // Weight2
            // 
            this.Weight2.DataPropertyName = "Weight2";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "N2";
            this.Weight2.DefaultCellStyle = dataGridViewCellStyle6;
            this.Weight2.HeaderText = "Weight";
            this.Weight2.Name = "Weight2";
            this.Weight2.ReadOnly = true;
            this.Weight2.Width = 65;
            // 
            // Amount3
            // 
            this.Amount3.DataPropertyName = "Amount3";
            this.Amount3.HeaderText = "Amount";
            this.Amount3.Name = "Amount3";
            this.Amount3.ReadOnly = true;
            this.Amount3.Width = 60;
            // 
            // Weight3
            // 
            this.Weight3.DataPropertyName = "Weight3";
            this.Weight3.HeaderText = "Weight";
            this.Weight3.Name = "Weight3";
            this.Weight3.ReadOnly = true;
            this.Weight3.Width = 60;
            // 
            // Amount4
            // 
            this.Amount4.DataPropertyName = "Amount4";
            this.Amount4.HeaderText = "Amount";
            this.Amount4.Name = "Amount4";
            this.Amount4.ReadOnly = true;
            this.Amount4.Width = 60;
            // 
            // Weight4
            // 
            this.Weight4.DataPropertyName = "Weight4";
            this.Weight4.HeaderText = "Weight";
            this.Weight4.Name = "Weight4";
            this.Weight4.ReadOnly = true;
            this.Weight4.Width = 60;
            // 
            // RedCost
            // 
            this.RedCost.DataPropertyName = "RedCost";
            this.RedCost.HeaderText = "Red Cost";
            this.RedCost.Name = "RedCost";
            this.RedCost.ReadOnly = true;
            this.RedCost.Width = 110;
            // 
            // MinPrice
            // 
            this.MinPrice.DataPropertyName = "MinPrice";
            this.MinPrice.HeaderText = "Min Price";
            this.MinPrice.Name = "MinPrice";
            this.MinPrice.ReadOnly = true;
            this.MinPrice.Width = 110;
            // 
            // PriceTag
            // 
            this.PriceTag.DataPropertyName = "PriceTag";
            this.PriceTag.HeaderText = "Price Tag";
            this.PriceTag.Name = "PriceTag";
            this.PriceTag.ReadOnly = true;
            this.PriceTag.Width = 110;
            // 
            // Shop
            // 
            this.Shop.DataPropertyName = "Shop";
            this.Shop.HeaderText = "Shop";
            this.Shop.Name = "Shop";
            this.Shop.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(245, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 25);
            this.label6.TabIndex = 71;
            this.label6.Text = "-";
            // 
            // InventoryList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1328, 565);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Name = "InventoryList";
            this.Text = "ProductList";
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridInventory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView gridInventory;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrefix;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn RowNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewImageColumn Image1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Weight1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Weight2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Weight3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Weight4;
        private System.Windows.Forms.DataGridViewTextBoxColumn RedCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn MinPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceTag;
        private System.Windows.Forms.DataGridViewTextBoxColumn Shop;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label6;
    }
}