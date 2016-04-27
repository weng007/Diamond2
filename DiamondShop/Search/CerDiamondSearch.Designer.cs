namespace DiamondShop.Search
{
    partial class CerDiamondSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CerDiamondSearch));
            this.panel4 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIAReportNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CuttingStyle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Measurement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CaratWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClarityGrade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColorGrade = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.CutGrade = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Polish = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Fluorescence = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Symmetry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(161)))), ((int)(((byte)(118)))));
            this.panel4.Controls.Add(this.button3);
            this.panel4.Controls.Add(this.textBox1);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(28, 54);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(967, 68);
            this.panel4.TabIndex = 44;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Honeydew;
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Linen;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(431, 19);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(106, 30);
            this.button3.TabIndex = 34;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(110, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(303, 26);
            this.textBox1.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(27, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 19);
            this.label3.TabIndex = 27;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(28, 128);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(967, 397);
            this.panel2.TabIndex = 45;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(201)))), ((int)(((byte)(119)))));
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(12, 8);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(944, 32);
            this.panel3.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.Date,
            this.GIAReportNumber,
            this.CuttingStyle,
            this.Measurement,
            this.CaratWeight,
            this.ClarityGrade,
            this.ColorGrade,
            this.CutGrade,
            this.Polish,
            this.Fluorescence,
            this.Symmetry,
            this.Comment});
            this.dataGridView1.Location = new System.Drawing.Point(12, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 10;
            this.dataGridView1.Size = new System.Drawing.Size(944, 344);
            this.dataGridView1.TabIndex = 2;
            // 
            // No
            // 
            this.No.HeaderText = "No.";
            this.No.Name = "No";
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.Width = 200;
            // 
            // GIAReportNumber
            // 
            this.GIAReportNumber.HeaderText = "GIA Report Number";
            this.GIAReportNumber.Name = "GIAReportNumber";
            this.GIAReportNumber.Width = 200;
            // 
            // CuttingStyle
            // 
            this.CuttingStyle.HeaderText = "Shape and Cutting Style";
            this.CuttingStyle.Name = "CuttingStyle";
            this.CuttingStyle.Width = 200;
            // 
            // Measurement
            // 
            this.Measurement.HeaderText = "Measurement";
            this.Measurement.Name = "Measurement";
            this.Measurement.Width = 150;
            // 
            // CaratWeight
            // 
            this.CaratWeight.HeaderText = "Carat Weight";
            this.CaratWeight.Name = "CaratWeight";
            this.CaratWeight.Width = 120;
            // 
            // ClarityGrade
            // 
            this.ClarityGrade.HeaderText = "Clarity Grade";
            this.ClarityGrade.Name = "ClarityGrade";
            this.ClarityGrade.Width = 120;
            // 
            // ColorGrade
            // 
            this.ColorGrade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ColorGrade.HeaderText = "Color Grade";
            this.ColorGrade.Name = "ColorGrade";
            this.ColorGrade.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColorGrade.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColorGrade.Width = 120;
            // 
            // CutGrade
            // 
            this.CutGrade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CutGrade.HeaderText = "Cut Grade";
            this.CutGrade.Name = "CutGrade";
            this.CutGrade.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CutGrade.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.CutGrade.Width = 120;
            // 
            // Polish
            // 
            this.Polish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Polish.HeaderText = "Polish";
            this.Polish.Name = "Polish";
            this.Polish.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Polish.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Fluorescence
            // 
            this.Fluorescence.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Fluorescence.HeaderText = "Fluorescence";
            this.Fluorescence.Name = "Fluorescence";
            this.Fluorescence.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Fluorescence.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Symmetry
            // 
            this.Symmetry.HeaderText = "Symmetry";
            this.Symmetry.Name = "Symmetry";
            // 
            // Comment
            // 
            this.Comment.HeaderText = "Comment";
            this.Comment.Name = "Comment";
            // 
            // CerDiamondSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 550);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Name = "CerDiamondSearch";
            this.Text = "CertificateSearch";
            this.Controls.SetChildIndex(this.panel4, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIAReportNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn CuttingStyle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Measurement;
        private System.Windows.Forms.DataGridViewTextBoxColumn CaratWeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClarityGrade;
        private System.Windows.Forms.DataGridViewComboBoxColumn ColorGrade;
        private System.Windows.Forms.DataGridViewComboBoxColumn CutGrade;
        private System.Windows.Forms.DataGridViewComboBoxColumn Polish;
        private System.Windows.Forms.DataGridViewComboBoxColumn Fluorescence;
        private System.Windows.Forms.DataGridViewTextBoxColumn Symmetry;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comment;
    }
}