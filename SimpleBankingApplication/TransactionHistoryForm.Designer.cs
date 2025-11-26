namespace SimpleBankingApplication
{
    partial class TransactionHistoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransactionHistoryForm));
            this.dataGVTransactionHistory = new System.Windows.Forms.DataGridView();
            this.linkMainMenu = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVTransactionHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGVTransactionHistory
            // 
            this.dataGVTransactionHistory.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGVTransactionHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVTransactionHistory.ColumnHeadersVisible = false;
            this.dataGVTransactionHistory.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(112)))), ((int)(((byte)(255)))));
            this.dataGVTransactionHistory.Location = new System.Drawing.Point(29, 28);
            this.dataGVTransactionHistory.Name = "dataGVTransactionHistory";
            this.dataGVTransactionHistory.Size = new System.Drawing.Size(482, 235);
            this.dataGVTransactionHistory.TabIndex = 0;
            this.dataGVTransactionHistory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGVTransactionHistory_CellContentClick);
            // 
            // linkMainMenu
            // 
            this.linkMainMenu.AutoSize = true;
            this.linkMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkMainMenu.LinkColor = System.Drawing.Color.White;
            this.linkMainMenu.Location = new System.Drawing.Point(238, 326);
            this.linkMainMenu.Name = "linkMainMenu";
            this.linkMainMenu.Size = new System.Drawing.Size(72, 16);
            this.linkMainMenu.TabIndex = 26;
            this.linkMainMenu.TabStop = true;
            this.linkMainMenu.Text = "Main Menu";
            this.linkMainMenu.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkMainMenu_LinkClicked);
            // 
            // TransactionHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(112)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(547, 378);
            this.Controls.Add(this.linkMainMenu);
            this.Controls.Add(this.dataGVTransactionHistory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TransactionHistoryForm";
            this.Text = "Transaction History";
            this.Load += new System.EventHandler(this.TransactionHistoryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGVTransactionHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGVTransactionHistory;
        private System.Windows.Forms.LinkLabel linkMainMenu;
    }
}