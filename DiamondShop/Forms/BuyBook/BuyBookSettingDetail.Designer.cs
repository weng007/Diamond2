namespace DiamondShop
{
    partial class BuyBookSettingDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuyBookSettingDetail));
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnImage1 = new System.Windows.Forms.Button();
            this.txtTotalBaht = new System.Windows.Forms.TextBox();
            this.TotalBaht = new System.Windows.Forms.Label();
            this.txtUSDRate = new System.Windows.Forms.TextBox();
            this.lblll = new System.Windows.Forms.Label();
            this.txtTotalUSD = new System.Windows.Forms.TextBox();
            this.TotalUSD = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDetail = new System.Windows.Forms.TextBox();
            this.txtPricePerUnit = new System.Windows.Forms.TextBox();
            this.txtPricePerGram = new System.Windows.Forms.TextBox();
            this.lblPricePerUnit = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbMaterial = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLaborCost = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.cmbSettingType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnImage1);
            this.panel3.Controls.Add(this.txtTotalBaht);
            this.panel3.Controls.Add(this.TotalBaht);
            this.panel3.Controls.Add(this.txtUSDRate);
            this.panel3.Controls.Add(this.lblll);
            this.panel3.Controls.Add(this.txtTotalUSD);
            this.panel3.Controls.Add(this.TotalUSD);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.txtDetail);
            this.panel3.Controls.Add(this.txtPricePerUnit);
            this.panel3.Controls.Add(this.txtPricePerGram);
            this.panel3.Controls.Add(this.lblPricePerUnit);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.cmbMaterial);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txtLaborCost);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.txtWeight);
            this.panel3.Controls.Add(this.cmbSettingType);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.txtAmount);
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.panel3.Location = new System.Drawing.Point(12, 72);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(693, 366);
            this.panel3.TabIndex = 74;
            // 
            // btnImage1
            // 
            this.btnImage1.BackColor = System.Drawing.SystemColors.Control;
            this.btnImage1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnImage1.BackgroundImage")));
            this.btnImage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnImage1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImage1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImage1.Location = new System.Drawing.Point(18, 192);
            this.btnImage1.Name = "btnImage1";
            this.btnImage1.Size = new System.Drawing.Size(150, 150);
            this.btnImage1.TabIndex = 109;
            this.btnImage1.UseVisualStyleBackColor = false;
            this.btnImage1.Click += new System.EventHandler(this.btnImage1_Click);
            // 
            // txtTotalBaht
            // 
            this.txtTotalBaht.Enabled = false;
            this.txtTotalBaht.Location = new System.Drawing.Point(285, 320);
            this.txtTotalBaht.Name = "txtTotalBaht";
            this.txtTotalBaht.Size = new System.Drawing.Size(118, 26);
            this.txtTotalBaht.TabIndex = 200;
            this.txtTotalBaht.Text = "0";
            this.txtTotalBaht.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTotalBaht.TextChanged += new System.EventHandler(this.txtAmount_TextChanged);
            this.txtTotalBaht.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmount_KeyPress);
            // 
            // TotalBaht
            // 
            this.TotalBaht.AutoSize = true;
            this.TotalBaht.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.TotalBaht.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(89)))), ((int)(((byte)(52)))));
            this.TotalBaht.Location = new System.Drawing.Point(188, 323);
            this.TotalBaht.Name = "TotalBaht";
            this.TotalBaht.Size = new System.Drawing.Size(92, 20);
            this.TotalBaht.TabIndex = 107;
            this.TotalBaht.Text = "Total Baht";
            // 
            // txtUSDRate
            // 
            this.txtUSDRate.Location = new System.Drawing.Point(285, 285);
            this.txtUSDRate.Name = "txtUSDRate";
            this.txtUSDRate.Size = new System.Drawing.Size(64, 26);
            this.txtUSDRate.TabIndex = 18;
            this.txtUSDRate.Text = "0";
            this.txtUSDRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtUSDRate.TextChanged += new System.EventHandler(this.txtAmount_TextChanged);
            this.txtUSDRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmount_KeyPress);
            this.txtUSDRate.Leave += new System.EventHandler(this.txtUSDRate_Leave);
            // 
            // lblll
            // 
            this.lblll.AutoSize = true;
            this.lblll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(89)))), ((int)(((byte)(52)))));
            this.lblll.Location = new System.Drawing.Point(188, 288);
            this.lblll.Name = "lblll";
            this.lblll.Size = new System.Drawing.Size(91, 20);
            this.lblll.TabIndex = 105;
            this.lblll.Text = "USD Rate";
            // 
            // txtTotalUSD
            // 
            this.txtTotalUSD.Location = new System.Drawing.Point(285, 250);
            this.txtTotalUSD.Name = "txtTotalUSD";
            this.txtTotalUSD.Size = new System.Drawing.Size(118, 26);
            this.txtTotalUSD.TabIndex = 16;
            this.txtTotalUSD.Text = "0";
            this.txtTotalUSD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTotalUSD.TextChanged += new System.EventHandler(this.txtAmount_TextChanged);
            this.txtTotalUSD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmount_KeyPress);
            this.txtTotalUSD.Leave += new System.EventHandler(this.txtTotalUSD_Leave);
            // 
            // TotalUSD
            // 
            this.TotalUSD.AutoSize = true;
            this.TotalUSD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.TotalUSD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(89)))), ((int)(((byte)(52)))));
            this.TotalUSD.Location = new System.Drawing.Point(188, 253);
            this.TotalUSD.Name = "TotalUSD";
            this.TotalUSD.Size = new System.Drawing.Size(92, 20);
            this.TotalUSD.TabIndex = 103;
            this.TotalUSD.Text = "Total USD";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(89)))), ((int)(((byte)(52)))));
            this.label8.Location = new System.Drawing.Point(463, 205);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 20);
            this.label8.TabIndex = 102;
            this.label8.Text = "Detail";
            // 
            // txtDetail
            // 
            this.txtDetail.Location = new System.Drawing.Point(467, 229);
            this.txtDetail.Multiline = true;
            this.txtDetail.Name = "txtDetail";
            this.txtDetail.Size = new System.Drawing.Size(195, 115);
            this.txtDetail.TabIndex = 20;
            this.txtDetail.TextChanged += new System.EventHandler(this.txtAmount_TextChanged);
            // 
            // txtPricePerUnit
            // 
            this.txtPricePerUnit.Location = new System.Drawing.Point(467, 94);
            this.txtPricePerUnit.Name = "txtPricePerUnit";
            this.txtPricePerUnit.Size = new System.Drawing.Size(118, 26);
            this.txtPricePerUnit.TabIndex = 14;
            this.txtPricePerUnit.Text = "0";
            this.txtPricePerUnit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPricePerUnit.TextChanged += new System.EventHandler(this.txtAmount_TextChanged);
            this.txtPricePerUnit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmount_KeyPress);
            this.txtPricePerUnit.Leave += new System.EventHandler(this.txtPricePerUnit_Leave);
            // 
            // txtPricePerGram
            // 
            this.txtPricePerGram.Location = new System.Drawing.Point(467, 57);
            this.txtPricePerGram.Name = "txtPricePerGram";
            this.txtPricePerGram.Size = new System.Drawing.Size(118, 26);
            this.txtPricePerGram.TabIndex = 12;
            this.txtPricePerGram.Text = "0";
            this.txtPricePerGram.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPricePerGram.TextChanged += new System.EventHandler(this.txtAmount_TextChanged);
            this.txtPricePerGram.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmount_KeyPress);
            this.txtPricePerGram.Leave += new System.EventHandler(this.txtPricePerGram_Leave);
            // 
            // lblPricePerUnit
            // 
            this.lblPricePerUnit.AutoSize = true;
            this.lblPricePerUnit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(89)))), ((int)(((byte)(52)))));
            this.lblPricePerUnit.Location = new System.Drawing.Point(336, 97);
            this.lblPricePerUnit.Name = "lblPricePerUnit";
            this.lblPricePerUnit.Size = new System.Drawing.Size(105, 20);
            this.lblPricePerUnit.TabIndex = 96;
            this.lblPricePerUnit.Text = "Price Per Unit";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(89)))), ((int)(((byte)(52)))));
            this.label5.Location = new System.Drawing.Point(336, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 94;
            this.label5.Text = "Material";
            // 
            // cmbMaterial
            // 
            this.cmbMaterial.FormattingEnabled = true;
            this.cmbMaterial.Location = new System.Drawing.Point(467, 17);
            this.cmbMaterial.Name = "cmbMaterial";
            this.cmbMaterial.Size = new System.Drawing.Size(169, 28);
            this.cmbMaterial.TabIndex = 10;
            this.cmbMaterial.SelectedValueChanged += new System.EventHandler(this.cmbSettingType_SelectedValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(89)))), ((int)(((byte)(52)))));
            this.label4.Location = new System.Drawing.Point(336, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 20);
            this.label4.TabIndex = 92;
            this.label4.Text = "Price Per Gram";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(89)))), ((int)(((byte)(52)))));
            this.label3.Location = new System.Drawing.Point(14, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 91;
            this.label3.Text = "Labor Cost";
            // 
            // txtLaborCost
            // 
            this.txtLaborCost.Location = new System.Drawing.Point(122, 133);
            this.txtLaborCost.Name = "txtLaborCost";
            this.txtLaborCost.Size = new System.Drawing.Size(118, 26);
            this.txtLaborCost.TabIndex = 8;
            this.txtLaborCost.Text = "0";
            this.txtLaborCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtLaborCost.TextChanged += new System.EventHandler(this.txtAmount_TextChanged);
            this.txtLaborCost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmount_KeyPress);
            this.txtLaborCost.Leave += new System.EventHandler(this.txtLaborCost_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(89)))), ((int)(((byte)(52)))));
            this.label2.Location = new System.Drawing.Point(14, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 89;
            this.label2.Text = "Weight";
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(122, 97);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(87, 26);
            this.txtWeight.TabIndex = 6;
            this.txtWeight.Text = "0";
            this.txtWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtWeight.TextChanged += new System.EventHandler(this.txtAmount_TextChanged);
            this.txtWeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmount_KeyPress);
            this.txtWeight.Leave += new System.EventHandler(this.txtWeight_Leave);
            // 
            // cmbSettingType
            // 
            this.cmbSettingType.FormattingEnabled = true;
            this.cmbSettingType.Location = new System.Drawing.Point(122, 20);
            this.cmbSettingType.Name = "cmbSettingType";
            this.cmbSettingType.Size = new System.Drawing.Size(182, 28);
            this.cmbSettingType.TabIndex = 2;
            this.cmbSettingType.SelectedValueChanged += new System.EventHandler(this.cmbSettingType_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(89)))), ((int)(((byte)(52)))));
            this.label1.Location = new System.Drawing.Point(14, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 85;
            this.label1.Text = "Amount";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(89)))), ((int)(((byte)(52)))));
            this.label6.Location = new System.Drawing.Point(14, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 20);
            this.label6.TabIndex = 84;
            this.label6.Text = "Type";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(122, 60);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(87, 26);
            this.txtAmount.TabIndex = 4;
            this.txtAmount.Text = "0";
            this.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAmount.TextChanged += new System.EventHandler(this.txtAmount_TextChanged);
            this.txtAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmount_KeyPress);
            this.txtAmount.Leave += new System.EventHandler(this.txtAmount_Leave);
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
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // BuyBookSettingDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(195)))), ((int)(((byte)(157)))));
            this.ClientSize = new System.Drawing.Size(717, 456);
            this.Controls.Add(this.panel3);
            this.Name = "BuyBookSettingDetail";
            this.Text = "DiamondCer";
            this.Controls.SetChildIndex(this.panel3, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSettingType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.ComboBox cmbMaterial;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLaborCost;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblPricePerUnit;
        private System.Windows.Forms.TextBox txtTotalBaht;
        private System.Windows.Forms.Label TotalBaht;
        private System.Windows.Forms.TextBox txtUSDRate;
        private System.Windows.Forms.Label lblll;
        private System.Windows.Forms.TextBox txtTotalUSD;
        private System.Windows.Forms.Label TotalUSD;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDetail;
        private System.Windows.Forms.TextBox txtPricePerUnit;
        private System.Windows.Forms.TextBox txtPricePerGram;
        private System.Windows.Forms.Button btnImage1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}