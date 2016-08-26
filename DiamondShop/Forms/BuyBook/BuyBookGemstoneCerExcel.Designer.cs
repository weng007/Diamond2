namespace DiamondShop
{
    partial class BuyBookGemstoneCerExcel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuyBookGemstoneCerExcel));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.grid1 = new System.Windows.Forms.DataGridView();
            this.Seller = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Shape = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReportNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Identification = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lab = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Origin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Shop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Payment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PayByUSD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceCaratUSD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceCaratBaht = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.USDRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalUSD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalBath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Location = new System.Drawing.Point(15, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 133);
            this.button1.TabIndex = 32;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.grid1);
            this.panel3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(12, 72);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1254, 370);
            this.panel3.TabIndex = 73;
            // 
            // grid1
            // 
            this.grid1.AllowUserToAddRows = false;
            this.grid1.AllowUserToDeleteRows = false;
            this.grid1.AllowUserToOrderColumns = true;
            this.grid1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grid1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grid1.ColumnHeadersHeight = 33;
            this.grid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seller,
            this.Shape,
            this.Cut,
            this.Weight,
            this.ReportNumber,
            this.Identification,
            this.Color,
            this.Lab,
            this.Origin,
            this.Comment,
            this.Shop,
            this.Payment,
            this.PayByUSD,
            this.PriceCaratUSD,
            this.PriceCaratBaht,
            this.USDRate,
            this.TotalUSD,
            this.TotalBath,
            this.Note});
            this.grid1.Location = new System.Drawing.Point(12, 35);
            this.grid1.Name = "grid1";
            this.grid1.ReadOnly = true;
            this.grid1.RowHeadersWidth = 10;
            this.grid1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grid1.RowTemplate.Height = 30;
            this.grid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid1.Size = new System.Drawing.Size(1220, 319);
            this.grid1.TabIndex = 46;
            // 
            // Seller
            // 
            this.Seller.DataPropertyName = "Seller";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.Seller.DefaultCellStyle = dataGridViewCellStyle1;
            this.Seller.HeaderText = "Seller";
            this.Seller.Name = "Seller";
            this.Seller.ReadOnly = true;
            this.Seller.Width = 130;
            // 
            // Shape
            // 
            this.Shape.DataPropertyName = "Shape";
            this.Shape.HeaderText = "Shape";
            this.Shape.Name = "Shape";
            this.Shape.ReadOnly = true;
            this.Shape.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Shape.Width = 150;
            // 
            // Cut
            // 
            this.Cut.DataPropertyName = "Cut";
            this.Cut.HeaderText = "Cut";
            this.Cut.Name = "Cut";
            this.Cut.ReadOnly = true;
            this.Cut.Width = 60;
            // 
            // Weight
            // 
            this.Weight.DataPropertyName = "Weight";
            this.Weight.HeaderText = "Weight";
            this.Weight.Name = "Weight";
            this.Weight.ReadOnly = true;
            this.Weight.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Weight.Width = 90;
            // 
            // ReportNumber
            // 
            this.ReportNumber.DataPropertyName = "ReportNumber";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.ReportNumber.DefaultCellStyle = dataGridViewCellStyle2;
            this.ReportNumber.HeaderText = "Report Number";
            this.ReportNumber.Name = "ReportNumber";
            this.ReportNumber.ReadOnly = true;
            this.ReportNumber.Width = 150;
            // 
            // Identification
            // 
            this.Identification.DataPropertyName = "Identification";
            this.Identification.HeaderText = "Identification";
            this.Identification.Name = "Identification";
            this.Identification.ReadOnly = true;
            // 
            // Color
            // 
            this.Color.DataPropertyName = "Color";
            this.Color.HeaderText = "Color";
            this.Color.Name = "Color";
            this.Color.ReadOnly = true;
            this.Color.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Color.Width = 120;
            // 
            // Lab
            // 
            this.Lab.DataPropertyName = "Lab";
            this.Lab.HeaderText = "Lab";
            this.Lab.Name = "Lab";
            this.Lab.ReadOnly = true;
            this.Lab.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Lab.Width = 90;
            // 
            // Origin
            // 
            this.Origin.DataPropertyName = "Origin";
            this.Origin.HeaderText = "Origin";
            this.Origin.Name = "Origin";
            this.Origin.ReadOnly = true;
            // 
            // Comment
            // 
            this.Comment.DataPropertyName = "Comment";
            this.Comment.HeaderText = "Comment";
            this.Comment.Name = "Comment";
            this.Comment.ReadOnly = true;
            this.Comment.Visible = false;
            this.Comment.Width = 60;
            // 
            // Shop
            // 
            this.Shop.DataPropertyName = "Shop";
            this.Shop.HeaderText = "Shop";
            this.Shop.Name = "Shop";
            this.Shop.ReadOnly = true;
            // 
            // Payment
            // 
            this.Payment.DataPropertyName = "Payment";
            this.Payment.HeaderText = "Payment";
            this.Payment.Name = "Payment";
            this.Payment.ReadOnly = true;
            // 
            // PayByUSD
            // 
            this.PayByUSD.DataPropertyName = "PayByUSD";
            this.PayByUSD.HeaderText = "PayByUSD";
            this.PayByUSD.Name = "PayByUSD";
            this.PayByUSD.ReadOnly = true;
            // 
            // PriceCaratUSD
            // 
            this.PriceCaratUSD.DataPropertyName = "PriceCaratUSD";
            this.PriceCaratUSD.HeaderText = "PriceCaratUSD";
            this.PriceCaratUSD.Name = "PriceCaratUSD";
            this.PriceCaratUSD.ReadOnly = true;
            // 
            // PriceCaratBaht
            // 
            this.PriceCaratBaht.DataPropertyName = "PriceCaratBaht";
            this.PriceCaratBaht.HeaderText = "PriceCaratBaht";
            this.PriceCaratBaht.Name = "PriceCaratBaht";
            this.PriceCaratBaht.ReadOnly = true;
            // 
            // USDRate
            // 
            this.USDRate.DataPropertyName = "USDRate";
            this.USDRate.HeaderText = "USDRate";
            this.USDRate.Name = "USDRate";
            this.USDRate.ReadOnly = true;
            // 
            // TotalUSD
            // 
            this.TotalUSD.DataPropertyName = "TotalUSD";
            this.TotalUSD.HeaderText = "TotalUSD";
            this.TotalUSD.Name = "TotalUSD";
            this.TotalUSD.ReadOnly = true;
            // 
            // TotalBath
            // 
            this.TotalBath.DataPropertyName = "TotalBath";
            this.TotalBath.HeaderText = "TotalBath";
            this.TotalBath.Name = "TotalBath";
            this.TotalBath.ReadOnly = true;
            // 
            // Note
            // 
            this.Note.DataPropertyName = "Note";
            this.Note.HeaderText = "Note";
            this.Note.Name = "Note";
            this.Note.ReadOnly = true;
            // 
            // BuyBookGemstoneCerExcel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(195)))), ((int)(((byte)(157)))));
            this.ClientSize = new System.Drawing.Size(1278, 454);
            this.Controls.Add(this.panel3);
            this.Name = "BuyBookGemstoneCerExcel";
            this.Text = "GemstoneCer";
            this.Controls.SetChildIndex(this.panel3, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView grid1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Seller;
        private System.Windows.Forms.DataGridViewTextBoxColumn Shape;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cut;
        private System.Windows.Forms.DataGridViewTextBoxColumn Weight;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReportNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Identification;
        private System.Windows.Forms.DataGridViewTextBoxColumn Color;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lab;
        private System.Windows.Forms.DataGridViewTextBoxColumn Origin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comment;
        private System.Windows.Forms.DataGridViewTextBoxColumn Shop;
        private System.Windows.Forms.DataGridViewTextBoxColumn Payment;
        private System.Windows.Forms.DataGridViewTextBoxColumn PayByUSD;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceCaratUSD;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceCaratBaht;
        private System.Windows.Forms.DataGridViewTextBoxColumn USDRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalUSD;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalBath;
        private System.Windows.Forms.DataGridViewTextBoxColumn Note;
    }
}