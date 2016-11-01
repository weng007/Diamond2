namespace DiamondShop
{
    partial class DiamondCerList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiamondCerList));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tds = new DiamondDS.DS.dsDiamondCer();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cmbColorType = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cmbShop = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbLab = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbEColor = new System.Windows.Forms.ComboBox();
            this.cmbEClearity = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEWeight = new System.Windows.Forms.TextBox();
            this.txtSWeight = new System.Windows.Forms.TextBox();
            this.cmbSColor = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbShape = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbSClearity = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtReportNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gridDiamondCer = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RowNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LabName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShapeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColorTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClearityName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CutName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PolishName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SymmetryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.W = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.L = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReportNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShopName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Setting = new System.Windows.Forms.DataGridViewLinkColumn();
            this.BuyDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tds)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDiamondCer)).BeginInit();
            this.SuspendLayout();
            // 
            // tds
            // 
            this.tds.DataSetName = "dsDiamondCer";
            this.tds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(1295, 3);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(38, 32);
            this.btnClose.TabIndex = 41;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Visible = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(105)))), ((int)(((byte)(79)))));
            this.panel4.Controls.Add(this.cmbColorType);
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.txtCode);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.btnSearch);
            this.panel4.Controls.Add(this.cmbShop);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.cmbStatus);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.cmbLab);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.cmbEColor);
            this.panel4.Controls.Add(this.cmbEClearity);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.txtEWeight);
            this.panel4.Controls.Add(this.txtSWeight);
            this.panel4.Controls.Add(this.cmbSColor);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.cmbShape);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.cmbSClearity);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.txtReportNumber);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1293, 174);
            this.panel4.TabIndex = 40;
            // 
            // cmbColorType
            // 
            this.cmbColorType.FormattingEnabled = true;
            this.cmbColorType.Location = new System.Drawing.Point(495, 20);
            this.cmbColorType.Name = "cmbColorType";
            this.cmbColorType.Size = new System.Drawing.Size(158, 28);
            this.cmbColorType.TabIndex = 75;
            this.cmbColorType.SelectedIndexChanged += new System.EventHandler(this.cmbColorType_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(395, 23);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(94, 26);
            this.label13.TabIndex = 76;
            this.label13.Text = "ColorType";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(205, 55);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(161, 26);
            this.txtCode.TabIndex = 73;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(120, 56);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 31);
            this.label12.TabIndex = 74;
            this.label12.Text = "Code";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Gainsboro;
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.Linen;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(929, 98);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(105, 32);
            this.btnSearch.TabIndex = 44;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cmbShop
            // 
            this.cmbShop.FormattingEnabled = true;
            this.cmbShop.Location = new System.Drawing.Point(929, 59);
            this.cmbShop.Name = "cmbShop";
            this.cmbShop.Size = new System.Drawing.Size(148, 28);
            this.cmbShop.TabIndex = 40;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(854, 62);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 26);
            this.label11.TabIndex = 72;
            this.label11.Text = "Shop";
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(929, 20);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(148, 28);
            this.cmbStatus.TabIndex = 36;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(854, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 26);
            this.label10.TabIndex = 70;
            this.label10.Text = "Status";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(134, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 33);
            this.label7.TabIndex = 67;
            this.label7.Text = "Lab";
            // 
            // cmbLab
            // 
            this.cmbLab.FormattingEnabled = true;
            this.cmbLab.Location = new System.Drawing.Point(205, 129);
            this.cmbLab.Name = "cmbLab";
            this.cmbLab.Size = new System.Drawing.Size(161, 28);
            this.cmbLab.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(556, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 26);
            this.label1.TabIndex = 65;
            this.label1.Text = "-";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(593, 61);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(16, 26);
            this.label9.TabIndex = 64;
            this.label9.Text = "-";
            // 
            // cmbEColor
            // 
            this.cmbEColor.FormattingEnabled = true;
            this.cmbEColor.Location = new System.Drawing.Point(615, 58);
            this.cmbEColor.Name = "cmbEColor";
            this.cmbEColor.Size = new System.Drawing.Size(95, 28);
            this.cmbEColor.TabIndex = 24;
            // 
            // cmbEClearity
            // 
            this.cmbEClearity.FormattingEnabled = true;
            this.cmbEClearity.Location = new System.Drawing.Point(678, 95);
            this.cmbEClearity.Name = "cmbEClearity";
            this.cmbEClearity.Size = new System.Drawing.Size(151, 28);
            this.cmbEClearity.TabIndex = 32;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(659, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 26);
            this.label8.TabIndex = 61;
            this.label8.Text = "-";
            // 
            // txtEWeight
            // 
            this.txtEWeight.Location = new System.Drawing.Point(577, 131);
            this.txtEWeight.Name = "txtEWeight";
            this.txtEWeight.Size = new System.Drawing.Size(51, 26);
            this.txtEWeight.TabIndex = 16;
            this.txtEWeight.Text = "50";
            this.txtEWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtEWeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtWeightTo_KeyPress);
            // 
            // txtSWeight
            // 
            this.txtSWeight.Location = new System.Drawing.Point(495, 131);
            this.txtSWeight.Name = "txtSWeight";
            this.txtSWeight.Size = new System.Drawing.Size(54, 26);
            this.txtSWeight.TabIndex = 12;
            this.txtSWeight.Text = "0";
            this.txtSWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSWeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtWeightTo_KeyPress);
            // 
            // cmbSColor
            // 
            this.cmbSColor.FormattingEnabled = true;
            this.cmbSColor.Location = new System.Drawing.Point(495, 58);
            this.cmbSColor.Name = "cmbSColor";
            this.cmbSColor.Size = new System.Drawing.Size(91, 28);
            this.cmbSColor.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(395, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 26);
            this.label6.TabIndex = 53;
            this.label6.Text = "Color";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(120, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 26);
            this.label5.TabIndex = 51;
            this.label5.Text = "Shape";
            // 
            // cmbShape
            // 
            this.cmbShape.FormattingEnabled = true;
            this.cmbShape.Location = new System.Drawing.Point(205, 91);
            this.cmbShape.Name = "cmbShape";
            this.cmbShape.Size = new System.Drawing.Size(161, 28);
            this.cmbShape.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(395, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 26);
            this.label2.TabIndex = 49;
            this.label2.Text = "Clearity";
            // 
            // cmbSClearity
            // 
            this.cmbSClearity.FormattingEnabled = true;
            this.cmbSClearity.Location = new System.Drawing.Point(495, 95);
            this.cmbSClearity.Name = "cmbSClearity";
            this.cmbSClearity.Size = new System.Drawing.Size(158, 28);
            this.cmbSClearity.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(395, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 26);
            this.label4.TabIndex = 45;
            this.label4.Text = "Weight";
            // 
            // txtReportNumber
            // 
            this.txtReportNumber.Location = new System.Drawing.Point(205, 20);
            this.txtReportNumber.Name = "txtReportNumber";
            this.txtReportNumber.Size = new System.Drawing.Size(161, 26);
            this.txtReportNumber.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(63, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 31);
            this.label3.TabIndex = 42;
            this.label3.Text = "Report Number";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.gridDiamondCer);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 165);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1339, 412);
            this.panel2.TabIndex = 34;
            // 
            // gridDiamondCer
            // 
            this.gridDiamondCer.AllowUserToAddRows = false;
            this.gridDiamondCer.AllowUserToDeleteRows = false;
            this.gridDiamondCer.AllowUserToOrderColumns = true;
            this.gridDiamondCer.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.gridDiamondCer.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.gridDiamondCer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDiamondCer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.RowNum,
            this.StatusName,
            this.Code,
            this.LabName,
            this.ShapeName,
            this.Weight,
            this.ColorTypeName,
            this.ColorName,
            this.ClearityName,
            this.CutName,
            this.PolishName,
            this.SymmetryName,
            this.W,
            this.L,
            this.D,
            this.ReportNumber,
            this.ShopName,
            this.Setting,
            this.BuyDate});
            this.gridDiamondCer.Location = new System.Drawing.Point(18, 9);
            this.gridDiamondCer.Name = "gridDiamondCer";
            this.gridDiamondCer.ReadOnly = true;
            this.gridDiamondCer.RowHeadersWidth = 10;
            this.gridDiamondCer.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridDiamondCer.RowTemplate.Height = 30;
            this.gridDiamondCer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridDiamondCer.Size = new System.Drawing.Size(1316, 402);
            this.gridDiamondCer.TabIndex = 2;
            this.gridDiamondCer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridDiamondCer_CellClick);
            this.gridDiamondCer.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gridDiamondCer_MouseDoubleClick);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.RowNum.DefaultCellStyle = dataGridViewCellStyle1;
            this.RowNum.HeaderText = "No.";
            this.RowNum.Name = "RowNum";
            this.RowNum.ReadOnly = true;
            this.RowNum.Width = 50;
            // 
            // StatusName
            // 
            this.StatusName.DataPropertyName = "StatusName";
            this.StatusName.HeaderText = "Status";
            this.StatusName.Name = "StatusName";
            this.StatusName.ReadOnly = true;
            // 
            // Code
            // 
            this.Code.DataPropertyName = "Code";
            this.Code.HeaderText = "Code";
            this.Code.Name = "Code";
            this.Code.ReadOnly = true;
            this.Code.Width = 150;
            // 
            // LabName
            // 
            this.LabName.DataPropertyName = "LabName";
            this.LabName.HeaderText = "Lab";
            this.LabName.Name = "LabName";
            this.LabName.ReadOnly = true;
            // 
            // ShapeName
            // 
            this.ShapeName.DataPropertyName = "ShapeName";
            this.ShapeName.HeaderText = "Shape";
            this.ShapeName.Name = "ShapeName";
            this.ShapeName.ReadOnly = true;
            this.ShapeName.Width = 120;
            // 
            // Weight
            // 
            this.Weight.DataPropertyName = "Weight";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle2.Format = "N2";
            this.Weight.DefaultCellStyle = dataGridViewCellStyle2;
            this.Weight.HeaderText = "Weight";
            this.Weight.Name = "Weight";
            this.Weight.ReadOnly = true;
            this.Weight.Width = 90;
            // 
            // ColorTypeName
            // 
            this.ColorTypeName.DataPropertyName = "ColorTypeName";
            this.ColorTypeName.HeaderText = "ColorType";
            this.ColorTypeName.Name = "ColorTypeName";
            this.ColorTypeName.ReadOnly = true;
            this.ColorTypeName.Width = 130;
            // 
            // ColorName
            // 
            this.ColorName.DataPropertyName = "ColorName";
            this.ColorName.HeaderText = "Color";
            this.ColorName.Name = "ColorName";
            this.ColorName.ReadOnly = true;
            this.ColorName.Width = 80;
            // 
            // ClearityName
            // 
            this.ClearityName.DataPropertyName = "ClearityName";
            this.ClearityName.HeaderText = "Clearity";
            this.ClearityName.Name = "ClearityName";
            this.ClearityName.ReadOnly = true;
            this.ClearityName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ClearityName.Width = 80;
            // 
            // CutName
            // 
            this.CutName.DataPropertyName = "CutName";
            this.CutName.HeaderText = "Cut";
            this.CutName.Name = "CutName";
            this.CutName.ReadOnly = true;
            this.CutName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CutName.Width = 80;
            // 
            // PolishName
            // 
            this.PolishName.DataPropertyName = "PolishName";
            this.PolishName.HeaderText = "Polish";
            this.PolishName.Name = "PolishName";
            this.PolishName.ReadOnly = true;
            this.PolishName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.PolishName.Width = 80;
            // 
            // SymmetryName
            // 
            this.SymmetryName.DataPropertyName = "SymmetryName";
            this.SymmetryName.HeaderText = "Symmetry";
            this.SymmetryName.Name = "SymmetryName";
            this.SymmetryName.ReadOnly = true;
            this.SymmetryName.Width = 90;
            // 
            // W
            // 
            this.W.DataPropertyName = "W";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle3.Format = "N2";
            this.W.DefaultCellStyle = dataGridViewCellStyle3;
            this.W.HeaderText = "W";
            this.W.Name = "W";
            this.W.ReadOnly = true;
            this.W.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.W.Visible = false;
            this.W.Width = 50;
            // 
            // L
            // 
            this.L.DataPropertyName = "L";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle4.Format = "N2";
            this.L.DefaultCellStyle = dataGridViewCellStyle4;
            this.L.HeaderText = "L";
            this.L.Name = "L";
            this.L.ReadOnly = true;
            this.L.Visible = false;
            this.L.Width = 50;
            // 
            // D
            // 
            this.D.DataPropertyName = "D";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle5.Format = "N2";
            this.D.DefaultCellStyle = dataGridViewCellStyle5;
            this.D.HeaderText = "D";
            this.D.Name = "D";
            this.D.ReadOnly = true;
            this.D.Visible = false;
            this.D.Width = 50;
            // 
            // ReportNumber
            // 
            this.ReportNumber.DataPropertyName = "ReportNumber";
            this.ReportNumber.HeaderText = "Report Number";
            this.ReportNumber.Name = "ReportNumber";
            this.ReportNumber.ReadOnly = true;
            this.ReportNumber.Width = 145;
            // 
            // ShopName
            // 
            this.ShopName.DataPropertyName = "ShopName";
            this.ShopName.HeaderText = "Location";
            this.ShopName.Name = "ShopName";
            this.ShopName.ReadOnly = true;
            this.ShopName.Width = 120;
            // 
            // Setting
            // 
            this.Setting.DataPropertyName = "Setting";
            this.Setting.HeaderText = "Setting";
            this.Setting.Name = "Setting";
            this.Setting.ReadOnly = true;
            this.Setting.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Setting.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Setting.Visible = false;
            this.Setting.Width = 170;
            // 
            // BuyDate
            // 
            this.BuyDate.DataPropertyName = "BuyDate";
            dataGridViewCellStyle6.Format = "dd/MM/yyyy";
            this.BuyDate.DefaultCellStyle = dataGridViewCellStyle6;
            this.BuyDate.HeaderText = "Buy Date";
            this.BuyDate.Name = "BuyDate";
            this.BuyDate.ReadOnly = true;
            this.BuyDate.Width = 110;
            // 
            // DiamondCerList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(105)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(1335, 577);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Name = "DiamondCerList";
            this.Text = "DiamondCerList";
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tds)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridDiamondCer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView gridDiamondCer;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox cmbSClearity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtReportNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbShape;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbSColor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEWeight;
        private System.Windows.Forms.TextBox txtSWeight;
        private DiamondDS.DS.dsDiamondCer tds;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbEColor;
        private System.Windows.Forms.ComboBox cmbEClearity;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbLab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbShop;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbColorType;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn RowNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn LabName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShapeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Weight;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColorTypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClearityName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CutName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PolishName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SymmetryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn W;
        private System.Windows.Forms.DataGridViewTextBoxColumn L;
        private System.Windows.Forms.DataGridViewTextBoxColumn D;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReportNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShopName;
        private System.Windows.Forms.DataGridViewLinkColumn Setting;
        private System.Windows.Forms.DataGridViewTextBoxColumn BuyDate;
    }
}