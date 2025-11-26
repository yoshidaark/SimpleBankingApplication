namespace SimpleBankingApplication
{
    partial class SignUpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUpForm));
            this.linkLogin = new System.Windows.Forms.LinkLabel();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtConfirmPass = new System.Windows.Forms.TextBox();
            this.cBoxShowPassword = new System.Windows.Forms.CheckBox();
            this.cBoxShowPassword2 = new System.Windows.Forms.CheckBox();
            this.linkLabelTAC = new System.Windows.Forms.LinkLabel();
            this.chBoxTAC = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // linkLogin
            // 
            this.linkLogin.AutoSize = true;
            this.linkLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(112)))), ((int)(((byte)(255)))));
            this.linkLogin.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(112)))), ((int)(((byte)(255)))));
            this.linkLogin.Location = new System.Drawing.Point(314, 400);
            this.linkLogin.Name = "linkLogin";
            this.linkLogin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.linkLogin.Size = new System.Drawing.Size(111, 16);
            this.linkLogin.TabIndex = 14;
            this.linkLogin.TabStop = true;
            this.linkLogin.Text = "I have an account";
            this.linkLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLogin_LinkClicked);
            // 
            // btnSignUp
            // 
            this.btnSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignUp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(112)))), ((int)(((byte)(255)))));
            this.btnSignUp.Location = new System.Drawing.Point(303, 353);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSignUp.Size = new System.Drawing.Size(138, 33);
            this.btnSignUp.TabIndex = 13;
            this.btnSignUp.Text = "Sign Up";
            this.btnSignUp.UseVisualStyleBackColor = true;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(112)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(274, 163);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(112)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(271, 119);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Username:";
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(112)))), ((int)(((byte)(255)))));
            this.txtPassword.Location = new System.Drawing.Point(274, 182);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPassword.Size = new System.Drawing.Size(202, 22);
            this.txtPassword.TabIndex = 10;
            // 
            // txtUsername
            // 
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(112)))), ((int)(((byte)(255)))));
            this.txtUsername.Location = new System.Drawing.Point(274, 138);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtUsername.Size = new System.Drawing.Size(202, 22);
            this.txtUsername.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(112)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(269, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Sign Up";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(112)))), ((int)(((byte)(255)))));
            this.label4.Location = new System.Drawing.Point(271, 72);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "Number:";
            // 
            // txtNumber
            // 
            this.txtNumber.BackColor = System.Drawing.SystemColors.Window;
            this.txtNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(112)))), ((int)(((byte)(255)))));
            this.txtNumber.Location = new System.Drawing.Point(274, 94);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNumber.Size = new System.Drawing.Size(202, 22);
            this.txtNumber.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(112)))), ((int)(((byte)(255)))));
            this.label5.Location = new System.Drawing.Point(271, 236);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(118, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "Confirm Password:";
            // 
            // txtConfirmPass
            // 
            this.txtConfirmPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConfirmPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(112)))), ((int)(((byte)(255)))));
            this.txtConfirmPass.Location = new System.Drawing.Point(274, 255);
            this.txtConfirmPass.Name = "txtConfirmPass";
            this.txtConfirmPass.PasswordChar = '*';
            this.txtConfirmPass.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtConfirmPass.Size = new System.Drawing.Size(202, 22);
            this.txtConfirmPass.TabIndex = 17;
            // 
            // cBoxShowPassword
            // 
            this.cBoxShowPassword.AutoSize = true;
            this.cBoxShowPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(112)))), ((int)(((byte)(255)))));
            this.cBoxShowPassword.Location = new System.Drawing.Point(277, 210);
            this.cBoxShowPassword.Name = "cBoxShowPassword";
            this.cBoxShowPassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cBoxShowPassword.Size = new System.Drawing.Size(102, 17);
            this.cBoxShowPassword.TabIndex = 19;
            this.cBoxShowPassword.Text = "Show Password";
            this.cBoxShowPassword.UseVisualStyleBackColor = true;
            this.cBoxShowPassword.CheckedChanged += new System.EventHandler(this.cBoxShowPassword_CheckedChanged);
            // 
            // cBoxShowPassword2
            // 
            this.cBoxShowPassword2.AutoSize = true;
            this.cBoxShowPassword2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(112)))), ((int)(((byte)(255)))));
            this.cBoxShowPassword2.Location = new System.Drawing.Point(280, 283);
            this.cBoxShowPassword2.Name = "cBoxShowPassword2";
            this.cBoxShowPassword2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cBoxShowPassword2.Size = new System.Drawing.Size(102, 17);
            this.cBoxShowPassword2.TabIndex = 20;
            this.cBoxShowPassword2.Text = "Show Password";
            this.cBoxShowPassword2.UseVisualStyleBackColor = true;
            this.cBoxShowPassword2.CheckedChanged += new System.EventHandler(this.cBoxShowPassword2_CheckedChanged);
            // 
            // linkLabelTAC
            // 
            this.linkLabelTAC.AutoSize = true;
            this.linkLabelTAC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelTAC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(112)))), ((int)(((byte)(255)))));
            this.linkLabelTAC.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(112)))), ((int)(((byte)(255)))));
            this.linkLabelTAC.Location = new System.Drawing.Point(300, 317);
            this.linkLabelTAC.Name = "linkLabelTAC";
            this.linkLabelTAC.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.linkLabelTAC.Size = new System.Drawing.Size(168, 15);
            this.linkLabelTAC.TabIndex = 21;
            this.linkLabelTAC.TabStop = true;
            this.linkLabelTAC.Text = "I Agree Terms and Conditions";
            this.linkLabelTAC.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelTAC_LinkClicked);
            // 
            // chBoxTAC
            // 
            this.chBoxTAC.AutoSize = true;
            this.chBoxTAC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(112)))), ((int)(((byte)(255)))));
            this.chBoxTAC.Location = new System.Drawing.Point(279, 319);
            this.chBoxTAC.Name = "chBoxTAC";
            this.chBoxTAC.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chBoxTAC.Size = new System.Drawing.Size(15, 14);
            this.chBoxTAC.TabIndex = 22;
            this.chBoxTAC.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(112)))), ((int)(((byte)(255)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.SystemColors.Menu;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(254, 457);
            this.panel1.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(112)))), ((int)(((byte)(255)))));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Window;
            this.label6.Location = new System.Drawing.Point(49, 199);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(155, 87);
            this.label6.TabIndex = 24;
            this.label6.Text = "Bank easy. \r\nLive breezy.\r\nCloudFund. ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SimpleBankingApplication.Properties.Resources.CloudFund;
            this.pictureBox1.Location = new System.Drawing.Point(39, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(166, 155);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(509, 457);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chBoxTAC);
            this.Controls.Add(this.linkLabelTAC);
            this.Controls.Add(this.cBoxShowPassword2);
            this.Controls.Add(this.cBoxShowPassword);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtConfirmPass);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.linkLogin);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SignUpForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "Sign Up";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLogin;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtConfirmPass;
        private System.Windows.Forms.CheckBox cBoxShowPassword;
        private System.Windows.Forms.CheckBox cBoxShowPassword2;
        private System.Windows.Forms.LinkLabel linkLabelTAC;
        private System.Windows.Forms.CheckBox chBoxTAC;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
    }
}