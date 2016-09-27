namespace DiamondShop
{
    partial class ExpenseList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExpenseList));
            this.panel4 = new System.Windows.Forms.Panel();
            this.cmbShop = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dtEMemoDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbExpenseGroup = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtSMemoDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dtEExpense = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtSExpense = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.grid = new System.Windows.Forms.DataGridView();
            this.RowNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpenseGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpenseDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(170)))), ((int)(((byte)(160)))));
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.Controls.Add(this.cmbShop);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.dtEMemoDate);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.cmbExpenseGroup);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.dtSMemoDate);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.dtEExpense);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.dtSExpense);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.btnAdd);
            this.panel4.Controls.Add(this.btnSearch);
            this.panel4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(983, 145);
            this.panel4.TabIndex = 43;
            // 
            // cmbShop
            // 
            this.cmbShop.FormattingEnabled = true;
            this.cmbShop.Location = new System.Drawing.Point(743, 60);
            this.cmbShop.Name = "cmbShop";
            this.cmbShop.Size = new System.Drawing.Size(169, 29);
            this.cmbShop.TabIndex = 275;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(652, 60);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 26);
            this.label11.TabIndex = 274;
            this.label11.Text = "Location";
            // 
            // dtEMemoDate
            // 
            this.dtEMemoDate.CustomFormat = "dd/MM/yyyy";
            this.dtEMemoDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtEMemoDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtEMemoDate.Location = new System.Drawing.Point(425, 21);
            this.dtEMemoDate.Name = "dtEMemoDate";
            this.dtEMemoDate.Size = new System.Drawing.Size(156, 26);
            this.dtEMemoDate.TabIndex = 273;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(403, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 26);
            this.label4.TabIndex = 272;
            this.label4.Text = "-";
            // 
            // cmbExpenseGroup
            // 
            this.cmbExpenseGroup.FormattingEnabled = true;
            this.cmbExpenseGroup.Location = new System.Drawing.Point(743, 21);
            this.cmbExpenseGroup.Name = "cmbExpenseGroup";
            this.cmbExpenseGroup.Size = new System.Drawing.Size(217, 29);
            this.cmbExpenseGroup.TabIndex = 71;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(607, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 26);
            this.label3.TabIndex = 27;
            this.label3.Text = "Expense Group";
            // 
            // dtSMemoDate
            // 
            this.dtSMemoDate.CustomFormat = "dd/MM/yyyy";
            this.dtSMemoDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtSMemoDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtSMemoDate.Location = new System.Drawing.Point(241, 21);
            this.dtSMemoDate.Name = "dtSMemoDate";
            this.dtSMemoDate.Size = new System.Drawing.Size(156, 26);
            this.dtSMemoDate.TabIndex = 271;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(115, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 26);
            this.label5.TabIndex = 270;
            this.label5.Text = "Memo Date";
            // 
            // dtEExpense
            // 
            this.dtEExpense.CustomFormat = "dd/MM/yyyy";
            this.dtEExpense.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtEExpense.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtEExpense.Location = new System.Drawing.Point(425, 60);
            this.dtEExpense.Name = "dtEExpense";
            this.dtEExpense.Size = new System.Drawing.Size(156, 26);
            this.dtEExpense.TabIndex = 269;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(403, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 26);
            this.label2.TabIndex = 268;
            this.label2.Text = "-";
            // 
            // dtSExpense
            // 
            this.dtSExpense.CustomFormat = "dd/MM/yyyy";
            this.dtSExpense.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtSExpense.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtSExpense.Location = new System.Drawing.Point(241, 60);
            this.dtSExpense.Name = "dtSExpense";
            this.dtSExpense.Size = new System.Drawing.Size(156, 26);
            this.dtSExpense.TabIndex = 267;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(115, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 26);
            this.label1.TabIndex = 266;
            this.label1.Text = "Expense Date";
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
            this.btnAdd.TabIndex = 70;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.Linen;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(241, 100);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(106, 30);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.grid);
            this.panel2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(5, 135);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(978, 464);
            this.panel2.TabIndex = 2;
            // 
            // grid
            // 
            this.grid.AllowUserToAddRows = false;
            this.grid.AllowUserToOrderColumns = true;
            this.grid.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RowNum,
            this.ID,
            this.ExpenseGroup,
            this.ExpenseDate,
            this.Cost});
            this.grid.Location = new System.Drawing.Point(14, 16);
            this.grid.MultiSelect = false;
            this.grid.Name = "grid";
            this.grid.ReadOnly = true;
            this.grid.RowHeadersWidth = 10;
            this.grid.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grid.RowTemplate.Height = 30;
            this.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid.Size = new System.Drawing.Size(961, 446);
            this.grid.TabIndex = 2;
            this.grid.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grid_CellMouseDoubleClick);
            this.grid.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.grid_UserDeletedRow);
            // 
            // RowNum
            // 
            this.RowNum.DataPropertyName = "RowNum";
            this.RowNum.HeaderText = "No.";
            this.RowNum.Name = "RowNum";
            this.RowNum.ReadOnly = true;
            this.RowNum.Width = 80;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // ExpenseGroup
            // 
            this.ExpenseGroup.DataPropertyName = "ExpenseGroup";
            this.ExpenseGroup.HeaderText = "ExpenseGroup";
            this.ExpenseGroup.Name = "ExpenseGroup";
            this.ExpenseGroup.ReadOnly = true;
            this.ExpenseGroup.Width = 300;
            // 
            // ExpenseDate
            // 
            this.ExpenseDate.DataPropertyName = "ExpenseDate";
            this.ExpenseDate.HeaderText = "ExpenseDate";
            this.ExpenseDate.Name = "ExpenseDate";
            this.ExpenseDate.ReadOnly = true;
            this.ExpenseDate.Width = 130;
            // 
            // Cost
            // 
            this.Cost.DataPropertyName = "Cost";
            this.Cost.HeaderText = "Cost";
            this.Cost.Name = "Cost";
            this.Cost.ReadOnly = true;
            this.Cost.Width = 130;
            // 
            // ExpenseList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(995, 608);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Name = "ExpenseList";
            this.Text = "UserList";
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn updateByDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn updateDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cmbExpenseGroup;
        private System.Windows.Forms.DateTimePicker dtEExpense;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtSExpense;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtEMemoDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtSMemoDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbShop;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridViewTextBoxColumn RowNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpenseGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpenseDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cost;
    }
}