namespace DiamondShop
{
    partial class ProductionLineInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductionLineInfo));
            this.panel3 = new System.Windows.Forms.Panel();
            this.cmbFactoryStatus = new System.Windows.Forms.ComboBox();
            this.label23 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.cmbFactoryStatus);
            this.panel3.Controls.Add(this.label23);
            this.panel3.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.panel3.Location = new System.Drawing.Point(12, 74);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(438, 102);
            this.panel3.TabIndex = 74;
            // 
            // cmbFactoryStatus
            // 
            this.cmbFactoryStatus.FormattingEnabled = true;
            this.cmbFactoryStatus.Location = new System.Drawing.Point(176, 35);
            this.cmbFactoryStatus.Name = "cmbFactoryStatus";
            this.cmbFactoryStatus.Size = new System.Drawing.Size(207, 29);
            this.cmbFactoryStatus.TabIndex = 221;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(89)))), ((int)(((byte)(52)))));
            this.label23.Location = new System.Drawing.Point(48, 38);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(122, 21);
            this.label23.TabIndex = 160;
            this.label23.Text = "Factory Status";
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
            // ProductionLineInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(195)))), ((int)(((byte)(157)))));
            this.ClientSize = new System.Drawing.Size(464, 188);
            this.Controls.Add(this.panel3);
            this.Name = "ProductionLineInfo";
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ComboBox cmbFactoryStatus;
    }
}