namespace SimpleBankingApplication
{
    partial class TransferForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransferForm));
            this.label3 = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.btnGenerateOTP = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOTP = new System.Windows.Forms.TextBox();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.linkMainMenu = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblInsufficient = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(102, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "Balance:";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.ForeColor = System.Drawing.SystemColors.Window;
            this.lblBalance.Location = new System.Drawing.Point(100, 34);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(98, 37);
            this.lblBalance.TabIndex = 12;
            this.lblBalance.Text = "00.00";
            // 
            // btnTransfer
            // 
            this.btnTransfer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransfer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(112)))), ((int)(((byte)(255)))));
            this.btnTransfer.Location = new System.Drawing.Point(66, 255);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(167, 46);
            this.btnTransfer.TabIndex = 16;
            this.btnTransfer.Text = "Transfer";
            this.btnTransfer.UseVisualStyleBackColor = true;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // btnGenerateOTP
            // 
            this.btnGenerateOTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateOTP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(112)))), ((int)(((byte)(255)))));
            this.btnGenerateOTP.Location = new System.Drawing.Point(66, 216);
            this.btnGenerateOTP.Name = "btnGenerateOTP";
            this.btnGenerateOTP.Size = new System.Drawing.Size(167, 33);
            this.btnGenerateOTP.TabIndex = 15;
            this.btnGenerateOTP.Text = "Generate OTP";
            this.btnGenerateOTP.UseVisualStyleBackColor = true;
            this.btnGenerateOTP.Click += new System.EventHandler(this.btnGenerateOTP_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(112)))), ((int)(((byte)(255)))));
            this.label4.Location = new System.Drawing.Point(63, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 22;
            this.label4.Text = "Amount:";
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(112)))), ((int)(((byte)(255)))));
            this.txtAmount.Location = new System.Drawing.Point(127, 119);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(122, 22);
            this.txtAmount.TabIndex = 21;
            this.txtAmount.Text = "00.00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(112)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(60, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "OTP:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(112)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(60, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "Number:";
            // 
            // txtOTP
            // 
            this.txtOTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOTP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(112)))), ((int)(((byte)(255)))));
            this.txtOTP.Location = new System.Drawing.Point(127, 175);
            this.txtOTP.Name = "txtOTP";
            this.txtOTP.Size = new System.Drawing.Size(122, 22);
            this.txtOTP.TabIndex = 18;
            // 
            // txtNumber
            // 
            this.txtNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(112)))), ((int)(((byte)(255)))));
            this.txtNumber.Location = new System.Drawing.Point(127, 147);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(122, 22);
            this.txtNumber.TabIndex = 17;
            // 
            // linkMainMenu
            // 
            this.linkMainMenu.AutoSize = true;
            this.linkMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkMainMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(112)))), ((int)(((byte)(255)))));
            this.linkMainMenu.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(112)))), ((int)(((byte)(255)))));
            this.linkMainMenu.Location = new System.Drawing.Point(115, 314);
            this.linkMainMenu.Name = "linkMainMenu";
            this.linkMainMenu.Size = new System.Drawing.Size(72, 16);
            this.linkMainMenu.TabIndex = 25;
            this.linkMainMenu.TabStop = true;
            this.linkMainMenu.Text = "Main Menu";
            this.linkMainMenu.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkMainMenu_LinkClicked);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(112)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblBalance);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(297, 94);
            this.panel1.TabIndex = 26;
            // 
            // lblInsufficient
            // 
            this.lblInsufficient.AutoSize = true;
            this.lblInsufficient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInsufficient.ForeColor = System.Drawing.Color.Red;
            this.lblInsufficient.Location = new System.Drawing.Point(129, 100);
            this.lblInsufficient.Name = "lblInsufficient";
            this.lblInsufficient.Size = new System.Drawing.Size(134, 16);
            this.lblInsufficient.TabIndex = 27;
            this.lblInsufficient.Text = "Balance is Insufficient";
            // 
            // TransferForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(297, 366);
            this.Controls.Add(this.lblInsufficient);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.linkMainMenu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtOTP);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.btnTransfer);
            this.Controls.Add(this.btnGenerateOTP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TransferForm";
            this.Text = "TransferForm";
            this.Load += new System.EventHandler(this.TransferForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.Button btnGenerateOTP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOTP;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.LinkLabel linkMainMenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblInsufficient;
    }
}