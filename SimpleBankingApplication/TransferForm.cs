using System;
using System.Windows.Forms;
using Accounts;
namespace SimpleBankingApplication
{
    //textbox name: txtAmount, txtUsername,txtOTP
    //lbl name: lblBalance
    //account.GetBalance(DelUsername(Account.username).ToString());
    public partial class TransferForm : Form
    {
        OTPForm otp;
        Account account;
        private Account.DelegateNumber DelNumber;
        public delegate void UpdateBalanceDelegate(string balance);
        public event UpdateBalanceDelegate BalanceUpdated;
        public TransferForm()  
        {
            InitializeComponent();
            DelNumber = new Account.DelegateNumber(Account.GetAccountNumber);
            linkMainMenu.LinkClicked += new LinkLabelLinkClickedEventHandler(linkMainMenu_LinkClicked);
            linkMainMenu.LinkClicked -= new LinkLabelLinkClickedEventHandler(linkMainMenu_LinkClicked);
            this.FormClosed += new FormClosedEventHandler(TransferForm_FormClosed);
        }

        private void btnGenerateOTP_Click(object sender, EventArgs e)
        {
            otp = new OTPForm();
            otp.Show();
        }

        private void btnTransfer_Click(object sender, EventArgs e) 
        {
            try {
                string OTPtextbox = txtOTP.Text.ToString();
                string OTP = account.RetrieveOTP();

                if (!OTPtextbox.Equals(OTP))
                {
                    MessageBox.Show("Incorrect OTP");
                }

                else if (Convert.ToDouble(account.GetBalance(DelNumber(Account.number))) < Convert.ToDouble(txtAmount.Text)) //if balance is sufficient
                {
                    lblInsufficient.Visible = true;
                }

                else if (!account.ifExist(txtNumber.Text, 0)) //if account does not exist
                {
                    MessageBox.Show("Account does not exist.");
                }

                else
                {
                    int Sender = DelNumber(Account.number);
                    int Receiver = Convert.ToInt32(txtNumber.Text);
                    double amount = Convert.ToDouble(txtAmount.Text);

                    TransferClass transfer = new TransferClass();
                    transfer.Transfer(Sender, Receiver, amount);
                    lblBalance.Text = "₱ " + account.GetBalance(DelNumber(Account.number));

                    Receipt receipt = new Receipt(Sender,Receiver,amount);
                    receipt.Show();
                }
            }
            

            catch (FormatException)
            {
                MessageBox.Show("Fill in the correct information.");
            }

            catch (Microsoft.Data.SqlClient.SqlException)
            {
                MessageBox.Show("Account does not exist. Double check the number", "Error Message");
            }
        }

        private void linkMainMenu_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) //confirm user to exit to main menu: yes/no
        {
            DialogResult result = MessageBox.Show("Are you sure you want to go back to Main Menu?", "The transfer will not be able to process.", MessageBoxButtons.YesNo);
            
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void TransferForm_Load(object sender, EventArgs e)
        {
            account = new Account();
            lblBalance.Text = "₱ " + account.GetBalance(DelNumber(Account.number));
            lblInsufficient.Visible = false;
        }

        private void TransferForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            BalanceUpdated?.Invoke(lblBalance.Text);
        }

    }
}
