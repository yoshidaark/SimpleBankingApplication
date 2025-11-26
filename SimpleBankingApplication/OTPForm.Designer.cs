namespace SimpleBankingApplication
{
    partial class OTPForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OTPForm));
            this.label1 = new System.Windows.Forms.Label();
            this.linkLblOTP = new System.Windows.Forms.LinkLabel();
            this.lblOTPTimer = new System.Windows.Forms.Label();
            this.lblClipboard = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(77, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "OTP";
            // 
            // linkLblOTP
            // 
            this.linkLblOTP.AutoSize = true;
            this.linkLblOTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLblOTP.LinkColor = System.Drawing.SystemColors.Window;
            this.linkLblOTP.Location = new System.Drawing.Point(90, 50);
            this.linkLblOTP.Name = "linkLblOTP";
            this.linkLblOTP.Size = new System.Drawing.Size(84, 25);
            this.linkLblOTP.TabIndex = 16;
            this.linkLblOTP.TabStop = true;
            this.linkLblOTP.Text = "000000";
            this.linkLblOTP.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLblOTP_LinkClicked);
            // 
            // lblOTPTimer
            // 
            this.lblOTPTimer.AutoSize = true;
            this.lblOTPTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOTPTimer.ForeColor = System.Drawing.SystemColors.Window;
            this.lblOTPTimer.Location = new System.Drawing.Point(38, 55);
            this.lblOTPTimer.Name = "lblOTPTimer";
            this.lblOTPTimer.Size = new System.Drawing.Size(27, 20);
            this.lblOTPTimer.TabIndex = 17;
            this.lblOTPTimer.Text = "00";
            // 
            // lblClipboard
            // 
            this.lblClipboard.AutoSize = true;
            this.lblClipboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClipboard.ForeColor = System.Drawing.SystemColors.Window;
            this.lblClipboard.Location = new System.Drawing.Point(39, 86);
            this.lblClipboard.Name = "lblClipboard";
            this.lblClipboard.Size = new System.Drawing.Size(127, 16);
            this.lblClipboard.TabIndex = 18;
            this.lblClipboard.Text = "Copied to Clipboard";
            // 
            // OTPForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(112)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(212, 111);
            this.Controls.Add(this.lblClipboard);
            this.Controls.Add(this.lblOTPTimer);
            this.Controls.Add(this.linkLblOTP);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OTPForm";
            this.Text = "OTPForm";
            this.Load += new System.EventHandler(this.OTPForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLblOTP;
        private System.Windows.Forms.Label lblOTPTimer;
        private System.Windows.Forms.Label lblClipboard;
    }
}