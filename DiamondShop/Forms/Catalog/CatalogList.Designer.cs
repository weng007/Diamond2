namespace DiamondShop
{
    partial class CatalogList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CatalogList));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle36 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle37 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle38 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle39 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle40 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle41 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle42 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle43 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle44 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtPrefix = new System.Windows.Forms.TextBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.grdCatalog = new System.Windows.Forms.DataGridView();
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
            this.MinPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceTag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShopName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCatalog)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(91)))), ((int)(((byte)(59)))));
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.btnSearch);
            this.panel4.Controls.Add(this.txtPrefix);
            this.panel4.Controls.Add(this.txtCode);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.panel4.Location = new System.Drawing.Point(0, 1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1298, 78);
            this.panel4.TabIndex = 42;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(198, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 25);
            this.label6.TabIndex = 28;
            this.label6.Text = "-";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Gainsboro;
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.Linen;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(362, 17);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(105, 32);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtPrefix
            // 
            this.txtPrefix.Enabled = false;
            this.txtPrefix.Location = new System.Drawing.Point(147, 20);
            this.txtPrefix.Name = "txtPrefix";
            this.txtPrefix.Size = new System.Drawing.Size(48, 27);
            this.txtPrefix.TabIndex = 1;
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(214, 21);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(132, 27);
            this.txtCode.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(75, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 25);
            this.label3.TabIndex = 27;
            this.label3.Text = "Code";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.grdCatalog);
            this.panel2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(5, 84);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1281, 484);
            this.panel2.TabIndex = 33;
            // 
            // grdCatalog
            // 
            this.grdCatalog.AllowUserToAddRows = false;
            this.grdCatalog.AllowUserToDeleteRows = false;
            this.grdCatalog.AllowUserToOrderColumns = true;
            this.grdCatalog.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.grdCatalog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCatalog.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.MinPrice,
            this.PriceTag,
            this.ShopName,
            this.StatusName});
            this.grdCatalog.Location = new System.Drawing.Point(3, 0);
            this.grdCatalog.Name = "grdCatalog";
            this.grdCatalog.ReadOnly = true;
            this.grdCatalog.RowHeadersWidth = 10;
            this.grdCatalog.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdCatalog.RowTemplate.Height = 60;
            this.grdCatalog.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdCatalog.Size = new System.Drawing.Size(1270, 481);
            this.grdCatalog.TabIndex = 2;
            this.grdCatalog.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.grdCatalog_MouseDoubleClick);
            // 
            // RowNum
            // 
            this.RowNum.DataPropertyName = "RowNum";
            dataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.RowNum.DefaultCellStyle = dataGridViewCellStyle34;
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
            dataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle35.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle35.Format = "N0";
            this.Amount1.DefaultCellStyle = dataGridViewCellStyle35;
            this.Amount1.HeaderText = "Amount DC.";
            this.Amount1.Name = "Amount1";
            this.Amount1.ReadOnly = true;
            this.Amount1.Width = 140;
            // 
            // Weight1
            // 
            this.Weight1.DataPropertyName = "Weight1";
            dataGridViewCellStyle36.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle36.Format = "N2";
            this.Weight1.DefaultCellStyle = dataGridViewCellStyle36;
            this.Weight1.HeaderText = "Weight DC.";
            this.Weight1.Name = "Weight1";
            this.Weight1.ReadOnly = true;
            this.Weight1.Width = 140;
            // 
            // Amount2
            // 
            this.Amount2.DataPropertyName = "Amount2";
            dataGridViewCellStyle37.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle37.Format = "N0";
            this.Amount2.DefaultCellStyle = dataGridViewCellStyle37;
            this.Amount2.HeaderText = "Amount NDC.";
            this.Amount2.Name = "Amount2";
            this.Amount2.ReadOnly = true;
            this.Amount2.Width = 145;
            // 
            // Weight2
            // 
            this.Weight2.DataPropertyName = "Weight2";
            dataGridViewCellStyle38.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle38.Format = "N2";
            this.Weight2.DefaultCellStyle = dataGridViewCellStyle38;
            this.Weight2.HeaderText = "Weight NDC.";
            this.Weight2.Name = "Weight2";
            this.Weight2.ReadOnly = true;
            this.Weight2.Width = 145;
            // 
            // Amount3
            // 
            this.Amount3.DataPropertyName = "Amount3";
            dataGridViewCellStyle39.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle39.Format = "N0";
            this.Amount3.DefaultCellStyle = dataGridViewCellStyle39;
            this.Amount3.HeaderText = "Amount GC.";
            this.Amount3.Name = "Amount3";
            this.Amount3.ReadOnly = true;
            this.Amount3.Width = 140;
            // 
            // Weight3
            // 
            this.Weight3.DataPropertyName = "Weight3";
            dataGridViewCellStyle40.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle40.Format = "N2";
            this.Weight3.DefaultCellStyle = dataGridViewCellStyle40;
            this.Weight3.HeaderText = "Weight GC.";
            this.Weight3.Name = "Weight3";
            this.Weight3.ReadOnly = true;
            this.Weight3.Width = 140;
            // 
            // Amount4
            // 
            this.Amount4.DataPropertyName = "Amount4";
            dataGridViewCellStyle41.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle41.Format = "N0";
            this.Amount4.DefaultCellStyle = dataGridViewCellStyle41;
            this.Amount4.HeaderText = "Amount NGC.";
            this.Amount4.Name = "Amount4";
            this.Amount4.ReadOnly = true;
            this.Amount4.Width = 145;
            // 
            // Weight4
            // 
            this.Weight4.DataPropertyName = "Weight4";
            dataGridViewCellStyle42.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle42.Format = "N2";
            this.Weight4.DefaultCellStyle = dataGridViewCellStyle42;
            this.Weight4.HeaderText = "Weight NGC.";
            this.Weight4.Name = "Weight4";
            this.Weight4.ReadOnly = true;
            this.Weight4.Width = 145;
            // 
            // MinPrice
            // 
            this.MinPrice.DataPropertyName = "MinPrice";
            dataGridViewCellStyle43.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle43.Format = "N0";
            this.MinPrice.DefaultCellStyle = dataGridViewCellStyle43;
            this.MinPrice.HeaderText = "Min Price";
            this.MinPrice.Name = "MinPrice";
            this.MinPrice.ReadOnly = true;
            this.MinPrice.Width = 110;
            // 
            // PriceTag
            // 
            this.PriceTag.DataPropertyName = "PriceTag";
            dataGridViewCellStyle44.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle44.Format = "N0";
            this.PriceTag.DefaultCellStyle = dataGridViewCellStyle44;
            this.PriceTag.HeaderText = "Price Tag";
            this.PriceTag.Name = "PriceTag";
            this.PriceTag.ReadOnly = true;
            this.PriceTag.Width = 110;
            // 
            // ShopName
            // 
            this.ShopName.DataPropertyName = "ShopName";
            this.ShopName.HeaderText = "Shop";
            this.ShopName.Name = "ShopName";
            this.ShopName.ReadOnly = true;
            // 
            // StatusName
            // 
            this.StatusName.DataPropertyName = "StatusName";
            this.StatusName.HeaderText = "Status";
            this.StatusName.Name = "StatusName";
            this.StatusName.ReadOnly = true;
            // 
            // CatalogList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1299, 578);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Name = "CatalogList";
            this.Text = "ProductList";
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdCatalog)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView grdCatalog;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrefix;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label6;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn MinPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceTag;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShopName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusName;
    }
}