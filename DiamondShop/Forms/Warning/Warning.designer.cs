namespace DiamondShop
{
    partial class Warning
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtMessageStatus = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.txtCancelDate = new System.Windows.Forms.TextBox();
            this.txtConfirmDate = new System.Windows.Forms.TextBox();
            this.txtReadDate = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.cmbShop = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbFactoryStatus = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbReceiver = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSender = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.txtMessageStatus);
            this.panel3.Controls.Add(this.btnCancel);
            this.panel3.Controls.Add(this.btnConfirm);
            this.panel3.Controls.Add(this.txtCancelDate);
            this.panel3.Controls.Add(this.txtConfirmDate);
            this.panel3.Controls.Add(this.txtReadDate);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.txtNote);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.cmbShop);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.cmbFactoryStatus);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.cmbReceiver);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.txtSender);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label25);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(89)))), ((int)(((byte)(52)))));
            this.panel3.Location = new System.Drawing.Point(7, 72);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(707, 284);
            this.panel3.TabIndex = 1;
            // 
            // txtMessageStatus
            // 
            this.txtMessageStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtMessageStatus.Enabled = false;
            this.txtMessageStatus.Location = new System.Drawing.Point(162, 178);
            this.txtMessageStatus.Name = "txtMessageStatus";
            this.txtMessageStatus.Size = new System.Drawing.Size(167, 27);
            this.txtMessageStatus.TabIndex = 219;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(280, 225);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(97, 34);
            this.btnCancel.TabIndex = 218;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.SandyBrown;
            this.btnConfirm.FlatAppearance.BorderSize = 0;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.ForeColor = System.Drawing.Color.Black;
            this.btnConfirm.Location = new System.Drawing.Point(162, 225);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(97, 34);
            this.btnConfirm.TabIndex = 217;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // txtCancelDate
            // 
            this.txtCancelDate.BackColor = System.Drawing.SystemColors.Window;
            this.txtCancelDate.Enabled = false;
            this.txtCancelDate.Location = new System.Drawing.Point(524, 94);
            this.txtCancelDate.Name = "txtCancelDate";
            this.txtCancelDate.Size = new System.Drawing.Size(150, 27);
            this.txtCancelDate.TabIndex = 216;
            // 
            // txtConfirmDate
            // 
            this.txtConfirmDate.BackColor = System.Drawing.SystemColors.Window;
            this.txtConfirmDate.Enabled = false;
            this.txtConfirmDate.Location = new System.Drawing.Point(524, 56);
            this.txtConfirmDate.Name = "txtConfirmDate";
            this.txtConfirmDate.Size = new System.Drawing.Size(150, 27);
            this.txtConfirmDate.TabIndex = 215;
            // 
            // txtReadDate
            // 
            this.txtReadDate.BackColor = System.Drawing.SystemColors.Window;
            this.txtReadDate.Enabled = false;
            this.txtReadDate.Location = new System.Drawing.Point(524, 19);
            this.txtReadDate.Name = "txtReadDate";
            this.txtReadDate.Size = new System.Drawing.Size(150, 27);
            this.txtReadDate.TabIndex = 214;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(407, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 25);
            this.label8.TabIndex = 213;
            this.label8.Text = "Confirm Date";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(412, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 25);
            this.label6.TabIndex = 211;
            this.label6.Text = "Cancel Date";
            // 
            // txtNote
            // 
            this.txtNote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtNote.Location = new System.Drawing.Point(423, 152);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(251, 107);
            this.txtNote.TabIndex = 4;
            this.txtNote.TextChanged += new System.EventHandler(this.txtNote_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(89)))), ((int)(((byte)(52)))));
            this.label16.Location = new System.Drawing.Point(372, 152);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(45, 19);
            this.label16.TabIndex = 209;
            this.label16.Text = "Note";
            // 
            // cmbShop
            // 
            this.cmbShop.FormattingEnabled = true;
            this.cmbShop.Location = new System.Drawing.Point(162, 133);
            this.cmbShop.Name = "cmbShop";
            this.cmbShop.Size = new System.Drawing.Size(167, 29);
            this.cmbShop.TabIndex = 3;
            this.cmbShop.SelectedValueChanged += new System.EventHandler(this.CmbFactoryStatus_SelectedValueChanged);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(78, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 28);
            this.label4.TabIndex = 207;
            this.label4.Text = "Location";
            // 
            // cmbFactoryStatus
            // 
            this.cmbFactoryStatus.FormattingEnabled = true;
            this.cmbFactoryStatus.Location = new System.Drawing.Point(162, 94);
            this.cmbFactoryStatus.Name = "cmbFactoryStatus";
            this.cmbFactoryStatus.Size = new System.Drawing.Size(167, 29);
            this.cmbFactoryStatus.TabIndex = 2;
            this.cmbFactoryStatus.SelectedValueChanged += new System.EventHandler(this.CmbFactoryStatus_SelectedValueChanged);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(34, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 28);
            this.label7.TabIndex = 205;
            this.label7.Text = "Factory Status";
            // 
            // cmbReceiver
            // 
            this.cmbReceiver.FormattingEnabled = true;
            this.cmbReceiver.Location = new System.Drawing.Point(162, 56);
            this.cmbReceiver.Name = "cmbReceiver";
            this.cmbReceiver.Size = new System.Drawing.Size(167, 29);
            this.cmbReceiver.TabIndex = 1;
            this.cmbReceiver.SelectedValueChanged += new System.EventHandler(this.CmbFactoryStatus_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(57, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 26);
            this.label2.TabIndex = 202;
            this.label2.Text = "Sender";
            // 
            // txtSender
            // 
            this.txtSender.BackColor = System.Drawing.SystemColors.Window;
            this.txtSender.Enabled = false;
            this.txtSender.Location = new System.Drawing.Point(162, 20);
            this.txtSender.Name = "txtSender";
            this.txtSender.Size = new System.Drawing.Size(167, 27);
            this.txtSender.TabIndex = 201;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(359, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 25);
            this.label3.TabIndex = 175;
            this.label3.Text = "Acknowledge Date";
            // 
            // label25
            // 
            this.label25.Location = new System.Drawing.Point(25, 180);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(134, 28);
            this.label25.TabIndex = 163;
            this.label25.Text = "Message Status";
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(56, 58);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(82, 26);
            this.label15.TabIndex = 94;
            this.label15.Text = "Receiver";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Warning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(195)))), ((int)(((byte)(157)))));
            this.ClientSize = new System.Drawing.Size(724, 368);
            this.Controls.Add(this.panel3);
            this.Name = "Warning";
            this.Text = "Sale";
            this.Controls.SetChildIndex(this.panel3, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbShop;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbFactoryStatus;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbReceiver;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSender;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtCancelDate;
        private System.Windows.Forms.TextBox txtConfirmDate;
        private System.Windows.Forms.TextBox txtReadDate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.TextBox txtMessageStatus;
    }
}