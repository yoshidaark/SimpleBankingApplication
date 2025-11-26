namespace SimpleBankingApplication
{
    partial class MainMenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuForm));
            this.lblBalance = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.btnAccount = new System.Windows.Forms.Button();
            this.btnHistory = new System.Windows.Forms.Button();
            this.lblUsername = new System.Windows.Forms.Label();
            this.linkLogOut = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(112)))), ((int)(((byte)(255)))));
            this.lblBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.ForeColor = System.Drawing.SystemColors.Window;
            this.lblBalance.Location = new System.Drawing.Point(162, 63);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(98, 37);
            this.lblBalance.TabIndex = 10;
            this.lblBalance.Text = "00.00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(112)))), ((int)(((byte)(255)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(164, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Balance:";
            // 
            // btnTransfer
            // 
            this.btnTransfer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(112)))), ((int)(((byte)(255)))));
            this.btnTransfer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransfer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransfer.ForeColor = System.Drawing.SystemColors.Window;
            this.btnTransfer.Location = new System.Drawing.Point(126, 144);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(167, 33);
            this.btnTransfer.TabIndex = 12;
            this.btnTransfer.Text = "Transfer";
            this.btnTransfer.UseVisualStyleBackColor = false;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // btnAccount
            // 
            this.btnAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(112)))), ((int)(((byte)(255)))));
            this.btnAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccount.ForeColor = System.Drawing.SystemColors.Window;
            this.btnAccount.Location = new System.Drawing.Point(126, 235);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Size = new System.Drawing.Size(167, 46);
            this.btnAccount.TabIndex = 13;
            this.btnAccount.Text = "Account Management";
            this.btnAccount.UseVisualStyleBackColor = false;
            this.btnAccount.Click += new System.EventHandler(this.btnAccount_Click);
            // 
            // btnHistory
            // 
            this.btnHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(112)))), ((int)(((byte)(255)))));
            this.btnHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistory.ForeColor = System.Drawing.SystemColors.Window;
            this.btnHistory.Location = new System.Drawing.Point(126, 183);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(167, 46);
            this.btnHistory.TabIndex = 14;
            this.btnHistory.Text = "Transaction History";
            this.btnHistory.UseVisualStyleBackColor = false;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(112)))), ((int)(((byte)(255)))));
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.SystemColors.Window;
            this.lblUsername.Location = new System.Drawing.Point(12, 9);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(70, 16);
            this.lblUsername.TabIndex = 15;
            this.lblUsername.Text = "Username";
            // 
            // linkLogOut
            // 
            this.linkLogOut.AutoSize = true;
            this.linkLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLogOut.LinkColor = System.Drawing.SystemColors.Window;
            this.linkLogOut.Location = new System.Drawing.Point(343, 9);
            this.linkLogOut.Name = "linkLogOut";
            this.linkLogOut.Size = new System.Drawing.Size(53, 16);
            this.linkLogOut.TabIndex = 16;
            this.linkLogOut.TabStop = true;
            this.linkLogOut.Text = "Log Out";
            this.linkLogOut.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLogOut_LinkClicked);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(112)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.linkLogOut);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblBalance);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(413, 121);
            this.panel1.TabIndex = 17;
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(413, 308);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.btnHistory);
            this.Controls.Add(this.btnAccount);
            this.Controls.Add(this.btnTransfer);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainMenuForm";
            this.Text = "Clound Fund";
            this.Load += new System.EventHandler(this.MainMenuForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.Button btnAccount;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.LinkLabel linkLogOut;
        private System.Windows.Forms.Panel panel1;
    }
}