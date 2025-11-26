using Accounts;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
namespace SimpleBankingApplication
{
    public partial class AccountManagement : Form
    {
        private Account.DelegateNumber DelNumber;
        private Account.DelegateText DelUsername;
        private Account.DelegateText DelPassword;
        public delegate void UpdateDelegate(string username);
        public event UpdateDelegate Updated;
        AccountManagementClass AMC = new AccountManagementClass();
        public AccountManagement()
        {
            InitializeComponent();
            DelUsername = new Account.DelegateText(Account.GetAccountUsername);
            DelNumber = new Account.DelegateNumber(Account.GetAccountNumber);
            DelPassword = new Account.DelegateText(Account.GetAccountPassword);
            linkMainMenu.LinkClicked += new LinkLabelLinkClickedEventHandler(linkMainMenu_LinkClicked);
            this.FormClosed += new FormClosedEventHandler(AccountManagement_FormClosed);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //transform label to textbox and show a confirm button
            lblUserName.Visible = false;
            lblPassword.Visible = false;
            btnEdit.Visible = false;

            txtUsername.Text = lblUserName.Text;
            txtUsername.Location = lblUserName.Location;
            txtUsername.Visible = true;
            txtUsername.Focus();

            txtPassword.Text = lblPassword.Text;
            txtPassword.Location = txtPassword.Location;
            txtPassword.Visible = true;

            btnConfirm.Visible = true;

        }

        private void linkMainMenu_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void AccountManagement_Load(object sender, EventArgs e)
        {
            
            AMC.showData(DelNumber(Account.number));

            lblUserName.Text = DelUsername(Account.username).ToString();
            lblPassword.Text = DelPassword(Account.password).ToString();
            lblNumber.Text = DelNumber(Account.number).ToString();

            txtUsername.Visible = false;
            txtPassword.Visible = false;
            btnConfirm.Visible = false;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string oldUsername = DelUsername(Account.username).ToString();
            string newUsername = txtUsername.Text;

            string oldPassword = DelPassword(Account.password).ToString();
            string newPassword = txtPassword.Text;

            lblUserName.Text = newUsername;
            lblPassword.Text = newPassword;

            Account account = new Account();

            try {
                if (oldUsername.Equals(newUsername) && oldPassword.Equals(newPassword))
                {
                    MessageBox.Show("You did not change anything", "No changes detected");

                    lblUserName.Visible = true;
                    lblPassword.Visible = true;
                    btnEdit.Visible = true;

                    txtUsername.Visible = false;
                    txtPassword.Visible = false;
                    btnConfirm.Visible = false;
                }
                else if (string.IsNullOrWhiteSpace(newUsername) || string.IsNullOrWhiteSpace(newPassword))
                {
                    MessageBox.Show("Username or Password cannot be empty!", "An error occurred while updating your account");
                }

                else if (!Regex.IsMatch(newPassword, @"^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{8,}$"))
                {
                    MessageBox.Show("Password must include letters and numbers, at least 8 characters.");
                }

                else
                {
                    AMC.updateAccount(oldUsername, newUsername, oldPassword, newPassword, DelNumber(Account.number));

                    lblUserName.Visible = true;
                    lblPassword.Visible = true;
                    btnEdit.Visible = true;

                    txtUsername.Visible = false;
                    txtPassword.Visible = false;
                    btnConfirm.Visible = false;
                }
            }
            catch (Microsoft.Data.SqlClient.SqlException)
            {
                MessageBox.Show("Username or Number is already taken", "Error Message");
            }
        }

        private void AccountManagement_FormClosed(object sender, FormClosedEventArgs e)
        {
            Updated?.Invoke(txtUsername.Text);
        }

    }
}
