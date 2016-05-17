namespace DiamondShop
{
    partial class BBJewelryGemstoneDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BBJewelryGemstoneDetail));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.grid2 = new System.Windows.Forms.DataGridView();
            this.RowNum1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GemstoneType1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Shape1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Amount1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Weight1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Origin1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.txtSumWeight1 = new System.Windows.Forms.TextBox();
            this.txtSumAmount1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSumWeight = new System.Windows.Forms.TextBox();
            this.txtSumAmount = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.grid1 = new System.Windows.Forms.DataGridView();
            this.panel6 = new System.Windows.Forms.Panel();
            this.RowNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReportNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GemstoneType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Company = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Shape = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Color = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Origin = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid2)).BeginInit();
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
            this.panel3.Controls.Add(this.grid2);
            this.panel3.Controls.Add(this.txtSumWeight1);
            this.panel3.Controls.Add(this.txtSumAmount1);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.txtSumWeight);
            this.panel3.Controls.Add(this.txtSumAmount);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.grid1);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(12, 68);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1270, 534);
            this.panel3.TabIndex = 73;
            // 
            // grid2
            // 
            this.grid2.AllowUserToOrderColumns = true;
            this.grid2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grid2.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grid2.ColumnHeadersHeight = 33;
            this.grid2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RowNum1,
            this.ID1,
            this.GemstoneType1,
            this.Shape1,
            this.Amount1,
            this.Weight1,
            this.Origin1});
            this.grid2.Location = new System.Drawing.Point(12, 281);
            this.grid2.Name = "grid2";
            this.grid2.RowHeadersWidth = 10;
            this.grid2.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grid2.RowTemplate.Height = 25;
            this.grid2.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.grid2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid2.Size = new System.Drawing.Size(691, 188);
            this.grid2.TabIndex = 126;
            this.grid2.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid1_CellEnter);
            // 
            // RowNum1
            // 
            this.RowNum1.DataPropertyName = "RowNum";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.RowNum1.DefaultCellStyle = dataGridViewCellStyle1;
            this.RowNum1.HeaderText = "No.";
            this.RowNum1.Name = "RowNum1";
            this.RowNum1.Width = 40;
            // 
            // ID1
            // 
            this.ID1.DataPropertyName = "ID";
            this.ID1.HeaderText = "ID";
            this.ID1.Name = "ID1";
            this.ID1.Visible = false;
            // 
            // GemstoneType1
            // 
            this.GemstoneType1.DataPropertyName = "GemstoneType";
            this.GemstoneType1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GemstoneType1.HeaderText = "Type";
            this.GemstoneType1.Name = "GemstoneType1";
            this.GemstoneType1.Width = 150;
            // 
            // Shape1
            // 
            this.Shape1.DataPropertyName = "Shape";
            this.Shape1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Shape1.HeaderText = "Shape";
            this.Shape1.Name = "Shape1";
            this.Shape1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Shape1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Shape1.Width = 130;
            // 
            // Amount1
            // 
            this.Amount1.DataPropertyName = "Amount";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle2.Format = "N0";
            this.Amount1.DefaultCellStyle = dataGridViewCellStyle2;
            this.Amount1.HeaderText = "Amount";
            this.Amount1.Name = "Amount1";
            // 
            // Weight1
            // 
            this.Weight1.DataPropertyName = "Weight";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle3.Format = "N2";
            this.Weight1.DefaultCellStyle = dataGridViewCellStyle3;
            this.Weight1.HeaderText = "Weight";
            this.Weight1.Name = "Weight1";
            // 
            // Origin1
            // 
            this.Origin1.DataPropertyName = "Origin";
            this.Origin1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Origin1.HeaderText = "Origin";
            this.Origin1.Name = "Origin1";
            this.Origin1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Origin1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Origin1.Width = 150;
            // 
            // txtSumWeight1
            // 
            this.txtSumWeight1.BackColor = System.Drawing.SystemColors.Window;
            this.txtSumWeight1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSumWeight1.Location = new System.Drawing.Point(454, 486);
            this.txtSumWeight1.Name = "txtSumWeight1";
            this.txtSumWeight1.ReadOnly = true;
            this.txtSumWeight1.Size = new System.Drawing.Size(94, 27);
            this.txtSumWeight1.TabIndex = 123;
            this.txtSumWeight1.Text = "0";
            this.txtSumWeight1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSumAmount1
            // 
            this.txtSumAmount1.BackColor = System.Drawing.SystemColors.Window;
            this.txtSumAmount1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSumAmount1.Location = new System.Drawing.Point(345, 486);
            this.txtSumAmount1.Name = "txtSumAmount1";
            this.txtSumAmount1.ReadOnly = true;
            this.txtSumAmount1.Size = new System.Drawing.Size(100, 27);
            this.txtSumAmount1.TabIndex = 122;
            this.txtSumAmount1.Text = "0";
            this.txtSumAmount1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(89)))), ((int)(((byte)(52)))));
            this.label1.Location = new System.Drawing.Point(283, 489);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 24);
            this.label1.TabIndex = 121;
            this.label1.Text = "Total";
            // 
            // txtSumWeight
            // 
            this.txtSumWeight.BackColor = System.Drawing.SystemColors.Window;
            this.txtSumWeight.Enabled = false;
            this.txtSumWeight.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSumWeight.Location = new System.Drawing.Point(867, 236);
            this.txtSumWeight.Name = "txtSumWeight";
            this.txtSumWeight.ReadOnly = true;
            this.txtSumWeight.Size = new System.Drawing.Size(91, 27);
            this.txtSumWeight.TabIndex = 118;
            this.txtSumWeight.Text = "0";
            this.txtSumWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSumAmount
            // 
            this.txtSumAmount.BackColor = System.Drawing.SystemColors.Window;
            this.txtSumAmount.Enabled = false;
            this.txtSumAmount.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSumAmount.Location = new System.Drawing.Point(774, 236);
            this.txtSumAmount.Name = "txtSumAmount";
            this.txtSumAmount.ReadOnly = true;
            this.txtSumAmount.Size = new System.Drawing.Size(87, 27);
            this.txtSumAmount.TabIndex = 117;
            this.txtSumAmount.Text = "0";
            this.txtSumAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(89)))), ((int)(((byte)(52)))));
            this.label14.Location = new System.Drawing.Point(713, 239);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 24);
            this.label14.TabIndex = 116;
            this.label14.Text = "Total";
            // 
            // grid1
            // 
            this.grid1.AllowUserToOrderColumns = true;
            this.grid1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grid1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grid1.ColumnHeadersHeight = 33;
            this.grid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RowNum,
            this.ID,
            this.Code,
            this.ReportNumber,
            this.GemstoneType,
            this.Company,
            this.Shape,
            this.Amount,
            this.Weight,
            this.Color,
            this.Origin});
            this.grid1.Location = new System.Drawing.Point(12, 35);
            this.grid1.Name = "grid1";
            this.grid1.RowHeadersWidth = 10;
            this.grid1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grid1.RowTemplate.Height = 25;
            this.grid1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.grid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.grid1.Size = new System.Drawing.Size(1245, 188);
            this.grid1.TabIndex = 16;
            this.grid1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid1_CellEnter);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(35)))), ((int)(((byte)(69)))));
            this.panel6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel6.BackgroundImage")));
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel6.Location = new System.Drawing.Point(12, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(207, 32);
            this.panel6.TabIndex = 15;
            // 
            // RowNum
            // 
            this.RowNum.DataPropertyName = "RowNum";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.RowNum.DefaultCellStyle = dataGridViewCellStyle4;
            this.RowNum.HeaderText = "No.";
            this.RowNum.Name = "RowNum";
            this.RowNum.Width = 40;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // Code
            // 
            this.Code.DataPropertyName = "Code";
            this.Code.HeaderText = "Code";
            this.Code.Name = "Code";
            this.Code.ReadOnly = true;
            this.Code.Width = 160;
            // 
            // ReportNumber
            // 
            this.ReportNumber.DataPropertyName = "ReportNumber";
            this.ReportNumber.HeaderText = "Report Number";
            this.ReportNumber.Name = "ReportNumber";
            this.ReportNumber.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ReportNumber.Width = 150;
            // 
            // GemstoneType
            // 
            this.GemstoneType.DataPropertyName = "GemstoneType";
            this.GemstoneType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GemstoneType.HeaderText = "Type";
            this.GemstoneType.Name = "GemstoneType";
            this.GemstoneType.Width = 150;
            // 
            // Company
            // 
            this.Company.DataPropertyName = "Company";
            this.Company.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Company.HeaderText = "Company";
            this.Company.Name = "Company";
            this.Company.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Company.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Company.Width = 120;
            // 
            // Shape
            // 
            this.Shape.DataPropertyName = "Shape";
            this.Shape.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Shape.HeaderText = "Shape";
            this.Shape.Name = "Shape";
            this.Shape.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Shape.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Shape.Width = 130;
            // 
            // Amount
            // 
            this.Amount.DataPropertyName = "Amount";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle5.Format = "N0";
            this.Amount.DefaultCellStyle = dataGridViewCellStyle5;
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            this.Amount.Width = 90;
            // 
            // Weight
            // 
            this.Weight.DataPropertyName = "Weight";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle6.Format = "N2";
            this.Weight.DefaultCellStyle = dataGridViewCellStyle6;
            this.Weight.HeaderText = "Weight";
            this.Weight.Name = "Weight";
            this.Weight.Width = 90;
            // 
            // Color
            // 
            this.Color.DataPropertyName = "Color";
            this.Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Color.HeaderText = "Color";
            this.Color.Name = "Color";
            this.Color.Width = 130;
            // 
            // Origin
            // 
            this.Origin.DataPropertyName = "Origin";
            this.Origin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Origin.HeaderText = "Origin";
            this.Origin.Name = "Origin";
            this.Origin.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Origin.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Origin.Width = 170;
            // 
            // BBJewelryGemstoneDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(195)))), ((int)(((byte)(157)))));
            this.ClientSize = new System.Drawing.Size(1294, 614);
            this.Controls.Add(this.panel3);
            this.Name = "BBJewelryGemstoneDetail";
            this.Text = "GemstoneCer";
            this.Controls.SetChildIndex(this.panel3, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView grid1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtSumWeight;
        private System.Windows.Forms.TextBox txtSumAmount;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtSumWeight1;
        private System.Windows.Forms.TextBox txtSumAmount1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grid2;
        private System.Windows.Forms.DataGridViewTextBoxColumn RowNum1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID1;
        private System.Windows.Forms.DataGridViewComboBoxColumn GemstoneType1;
        private System.Windows.Forms.DataGridViewComboBoxColumn Shape1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Weight1;
        private System.Windows.Forms.DataGridViewComboBoxColumn Origin1;
        private System.Windows.Forms.DataGridViewTextBoxColumn RowNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReportNumber;
        private System.Windows.Forms.DataGridViewComboBoxColumn GemstoneType;
        private System.Windows.Forms.DataGridViewComboBoxColumn Company;
        private System.Windows.Forms.DataGridViewComboBoxColumn Shape;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Weight;
        private System.Windows.Forms.DataGridViewComboBoxColumn Color;
        private System.Windows.Forms.DataGridViewComboBoxColumn Origin;
    }
}