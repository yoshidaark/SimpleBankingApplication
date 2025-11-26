using System;
using System.Windows.Forms;
using Accounts;

namespace SimpleBankingApplication
{
    public partial class MainMenuForm : Form
    {
        private Account.DelegateNumber DelNumber;
        private Account.DelegateText DelUsername;

        TransactionHistoryForm transactionHistory;
        AccountManagement accountManagement;
        TransferForm transfer;
        Account account;

        public MainMenuForm() 
        {
            InitializeComponent();
            DelNumber = new Account.DelegateNumber(Account.GetAccountNumber);
            DelUsername = new Account.DelegateText(Account.GetAccountUsername);

        }


        private void MainMenuForm_Load(object sender, EventArgs e)
        {
            account = new Account();
            AccountManagementClass AMC = new AccountManagementClass();
            AMC.showData(DelNumber(Account.number));

            lblUsername.Text = DelUsername(Account.username).ToString();
            lblBalance.Text = "₱ " + account.GetBalance(DelNumber(Account.number)); //00.00
        }

        private void btnTransfer_Click(object sender, EventArgs e) //nath
        {
            transfer = new TransferForm();
            transfer.FormClosed += TransferForm_FormClosed;
            transfer.BalanceUpdated += TransferForm_UpdatedBalance;
            transfer.Show();
            this.Hide();
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            accountManagement = new AccountManagement();
            accountManagement.FormClosed += AccountManagement_FormClosed;
            accountManagement.Updated += AccountManagement_Updated;
            accountManagement.Show();
            this.Hide();
        }

        private void btnHistory_Click(object sender, EventArgs e) //maya
        {

            transactionHistory = new TransactionHistoryForm();
            transactionHistory.FormClosed += TransactionHistoryForm_FormClosed;
            transactionHistory.Show();
            this.Hide();
        }

        private void TransferForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void TransactionHistoryForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void AccountManagement_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void AccountManagement_Updated(string username) //updates username label when changed in account management
        {
            if (username != "")
            {
                lblUsername.Text = username;
            }
            else {
                lblUsername.Text = DelUsername(Account.username).ToString();
            }
        }

        private void TransferForm_UpdatedBalance(string bal) //updates balance label when changed in transaction
        {
            if (bal != "")
            {
                lblBalance.Text = bal;
            }
            else
            {
                lblBalance.Text = account.GetBalance(DelNumber(Account.number));
            }
        }

        private void linkLogOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }


    }
}
