namespace SimpleBankingApplication
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.linkSignUp = new System.Windows.Forms.LinkLabel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cBoxShowPassword = new System.Windows.Forms.CheckBox();
            this.txtOTP = new System.Windows.Forms.Label();
            this.txtGenerateOTP = new System.Windows.Forms.TextBox();
            this.btnGenerateOTP = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // linkSignUp
            // 
            this.linkSignUp.AutoSize = true;
            this.linkSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkSignUp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(112)))), ((int)(((byte)(255)))));
            this.linkSignUp.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(112)))), ((int)(((byte)(255)))));
            this.linkSignUp.Location = new System.Drawing.Point(299, 301);
            this.linkSignUp.Name = "linkSignUp";
            this.linkSignUp.Size = new System.Drawing.Size(132, 15);
            this.linkSignUp.TabIndex = 14;
            this.linkSignUp.TabStop = true;
            this.linkSignUp.Text = "I don\'t have an account";
            this.linkSignUp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkSignUp_LinkClicked);
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(112)))), ((int)(((byte)(255)))));
            this.btnLogin.Location = new System.Drawing.Point(302, 254);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(120, 33);
            this.btnLogin.TabIndex = 13;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(112)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(273, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(112)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(273, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Number:";
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(112)))), ((int)(((byte)(255)))));
            this.txtPassword.Location = new System.Drawing.Point(276, 139);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(210, 22);
            this.txtPassword.TabIndex = 10;
            // 
            // txtUsername
            // 
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(112)))), ((int)(((byte)(255)))));
            this.txtUsername.Location = new System.Drawing.Point(276, 90);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(210, 22);
            this.txtUsername.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(112)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(271, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Login ";
            // 
            // cBoxShowPassword
            // 
            this.cBoxShowPassword.AutoSize = true;
            this.cBoxShowPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(112)))), ((int)(((byte)(255)))));
            this.cBoxShowPassword.Location = new System.Drawing.Point(276, 167);
            this.cBoxShowPassword.Name = "cBoxShowPassword";
            this.cBoxShowPassword.Size = new System.Drawing.Size(102, 17);
            this.cBoxShowPassword.TabIndex = 20;
            this.cBoxShowPassword.Text = "Show Password";
            this.cBoxShowPassword.UseVisualStyleBackColor = true;
            this.cBoxShowPassword.CheckedChanged += new System.EventHandler(this.cBoxShowPassword_CheckedChanged);
            // 
            // txtOTP
            // 
            this.txtOTP.AutoSize = true;
            this.txtOTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOTP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(112)))), ((int)(((byte)(255)))));
            this.txtOTP.Location = new System.Drawing.Point(273, 200);
            this.txtOTP.Name = "txtOTP";
            this.txtOTP.Size = new System.Drawing.Size(38, 16);
            this.txtOTP.TabIndex = 22;
            this.txtOTP.Text = "OTP:";
            // 
            // txtGenerateOTP
            // 
            this.txtGenerateOTP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGenerateOTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGenerateOTP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(112)))), ((int)(((byte)(255)))));
            this.txtGenerateOTP.Location = new System.Drawing.Point(317, 200);
            this.txtGenerateOTP.Name = "txtGenerateOTP";
            this.txtGenerateOTP.Size = new System.Drawing.Size(88, 22);
            this.txtGenerateOTP.TabIndex = 21;
            // 
            // btnGenerateOTP
            // 
            this.btnGenerateOTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateOTP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(112)))), ((int)(((byte)(255)))));
            this.btnGenerateOTP.Location = new System.Drawing.Point(411, 193);
            this.btnGenerateOTP.Name = "btnGenerateOTP";
            this.btnGenerateOTP.Size = new System.Drawing.Size(75, 36);
            this.btnGenerateOTP.TabIndex = 23;
            this.btnGenerateOTP.Text = "Generate OTP";
            this.btnGenerateOTP.UseVisualStyleBackColor = true;
            this.btnGenerateOTP.Click += new System.EventHandler(this.btnGenerateOTP_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(112)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(254, 457);
            this.panel1.TabIndex = 24;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SimpleBankingApplication.Properties.Resources.CloudFund;
            this.pictureBox1.Location = new System.Drawing.Point(39, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(166, 155);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(112)))), ((int)(((byte)(255)))));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Window;
            this.label6.Location = new System.Drawing.Point(31, 200);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(187, 87);
            this.label6.TabIndex = 25;
            this.label6.Text = "Smart banking\r\nwith a touch of \r\ncloud comfort.";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(509, 457);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnGenerateOTP);
            this.Controls.Add(this.txtOTP);
            this.Controls.Add(this.txtGenerateOTP);
            this.Controls.Add(this.cBoxShowPassword);
            this.Controls.Add(this.linkSignUp);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.Text = "Log In";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkSignUp;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cBoxShowPassword;
        private System.Windows.Forms.Label txtOTP;
        private System.Windows.Forms.TextBox txtGenerateOTP;
        private System.Windows.Forms.Button btnGenerateOTP;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
    }
}