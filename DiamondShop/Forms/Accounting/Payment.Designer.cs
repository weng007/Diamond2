namespace DiamondShop
{
    partial class Payment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Payment));
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnChooseDate = new System.Windows.Forms.Button();
            this.txtPayDate = new System.Windows.Forms.TextBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.txtUSDRate = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdoYes = new System.Windows.Forms.RadioButton();
            this.rdoNo = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            this.panel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnChooseDate);
            this.panel3.Controls.Add(this.txtPayDate);
            this.panel3.Controls.Add(this.monthCalendar1);
            this.panel3.Controls.Add(this.txtUSDRate);
            this.panel3.Controls.Add(this.label23);
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.txtPrice);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.panel3.Location = new System.Drawing.Point(12, 74);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(438, 212);
            this.panel3.TabIndex = 74;
            // 
            // btnChooseDate
            // 
            this.btnChooseDate.FlatAppearance.BorderSize = 0;
            this.btnChooseDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChooseDate.Image = ((System.Drawing.Image)(resources.GetObject("btnChooseDate.Image")));
            this.btnChooseDate.Location = new System.Drawing.Point(309, 12);
            this.btnChooseDate.Name = "btnChooseDate";
            this.btnChooseDate.Size = new System.Drawing.Size(28, 28);
            this.btnChooseDate.TabIndex = 251;
            this.btnChooseDate.UseVisualStyleBackColor = true;
            this.btnChooseDate.Click += new System.EventHandler(this.btnChooseDate_Click);
            // 
            // txtPayDate
            // 
            this.txtPayDate.Location = new System.Drawing.Point(182, 14);
            this.txtPayDate.Name = "txtPayDate";
            this.txtPayDate.Size = new System.Drawing.Size(123, 26);
            this.txtPayDate.TabIndex = 250;
            this.txtPayDate.TextChanged += new System.EventHandler(this.txtPayDate_TextChanged);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(110, 47);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 249;
            this.monthCalendar1.Visible = false;
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            // 
            // txtUSDRate
            // 
            this.txtUSDRate.Location = new System.Drawing.Point(195, 48);
            this.txtUSDRate.Name = "txtUSDRate";
            this.txtUSDRate.Size = new System.Drawing.Size(61, 26);
            this.txtUSDRate.TabIndex = 2;
            this.txtUSDRate.Text = "0";
            this.txtUSDRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtUSDRate.TextChanged += new System.EventHandler(this.txtUSDRate_TextChanged);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(89)))), ((int)(((byte)(52)))));
            this.label23.Location = new System.Drawing.Point(95, 51);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(83, 20);
            this.label23.TabIndex = 160;
            this.label23.Text = "USD Rate";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdoYes);
            this.groupBox2.Controls.Add(this.rdoNo);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(89)))), ((int)(((byte)(52)))));
            this.groupBox2.Location = new System.Drawing.Point(195, 129);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 58);
            this.groupBox2.TabIndex = 158;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Payment";
            // 
            // rdoYes
            // 
            this.rdoYes.AutoSize = true;
            this.rdoYes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(89)))), ((int)(((byte)(52)))));
            this.rdoYes.Location = new System.Drawing.Point(12, 23);
            this.rdoYes.Name = "rdoYes";
            this.rdoYes.Size = new System.Drawing.Size(55, 24);
            this.rdoYes.TabIndex = 100;
            this.rdoYes.Text = "Yes";
            this.rdoYes.UseVisualStyleBackColor = true;
            this.rdoYes.CheckedChanged += new System.EventHandler(this.rdoYes_CheckedChanged);
            // 
            // rdoNo
            // 
            this.rdoNo.AutoSize = true;
            this.rdoNo.Checked = true;
            this.rdoNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(89)))), ((int)(((byte)(52)))));
            this.rdoNo.Location = new System.Drawing.Point(107, 23);
            this.rdoNo.Name = "rdoNo";
            this.rdoNo.Size = new System.Drawing.Size(47, 24);
            this.rdoNo.TabIndex = 104;
            this.rdoNo.TabStop = true;
            this.rdoNo.Text = "No";
            this.rdoNo.UseVisualStyleBackColor = true;
            this.rdoNo.CheckedChanged += new System.EventHandler(this.rdoYes_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(89)))), ((int)(((byte)(52)))));
            this.label8.Location = new System.Drawing.Point(343, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 20);
            this.label8.TabIndex = 97;
            this.label8.Text = "Baht";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(89)))), ((int)(((byte)(52)))));
            this.label7.Location = new System.Drawing.Point(97, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 20);
            this.label7.TabIndex = 96;
            this.label7.Text = "Total Price";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(195, 85);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(131, 26);
            this.txtPrice.TabIndex = 4;
            this.txtPrice.Text = "0";
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPrice.TextChanged += new System.EventHandler(this.txtUSDRate_TextChanged);
            this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrice_KeyPress);
            this.txtPrice.Leave += new System.EventHandler(this.txtPrice_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(89)))), ((int)(((byte)(52)))));
            this.label6.Location = new System.Drawing.Point(55, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 20);
            this.label6.TabIndex = 84;
            this.label6.Text = "Payment Date";
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
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(195)))), ((int)(((byte)(157)))));
            this.ClientSize = new System.Drawing.Size(464, 298);
            this.Controls.Add(this.panel3);
            this.Name = "Payment";
            this.Text = "DiamondCer";
            this.Controls.SetChildIndex(this.panel3, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdoYes;
        private System.Windows.Forms.RadioButton rdoNo;
        private System.Windows.Forms.TextBox txtUSDRate;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Button btnChooseDate;
        private System.Windows.Forms.TextBox txtPayDate;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
    }
}