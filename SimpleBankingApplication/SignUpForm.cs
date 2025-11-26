using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Accounts;
namespace SimpleBankingApplication
{
    public partial class SignUpForm : Form
    {
        
        public SignUpForm()
        {
            InitializeComponent();
            
        }

        private void linkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            try {
                int number = Convert.ToInt32(txtNumber.Text.ToString());
                string username = txtUsername.Text.ToString();
                string password = txtPassword.Text.ToString();
                string confirmPassword = txtConfirmPass.Text.ToString();

                Account account;

                if (!Regex.IsMatch(password, @"^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{8,}$"))
                {
                    MessageBox.Show("Password must include letters and numbers, at least 8 characters.");
                }

                else if (!chBoxTAC.Checked) {
                    MessageBox.Show("You must agree to the Terms and Conditions", "Error");
                }
                else
                {
                    if (password.Equals(confirmPassword))
                    {
                        account = new Account(number, username, password);
                        account.createTransactionHistory(number.ToString());
                        MessageBox.Show("Your account has succesfully registered!");
                    }

                    else {

                        MessageBox.Show("Password does not match!", "Password Mismatch");
                    }

                }
            }
            catch(FormatException) {

                MessageBox.Show("Please Fill In the Correct Information", "Error Message");
            }

            catch (Microsoft.Data.SqlClient.SqlException)
            {
                MessageBox.Show("Username or Number is already taken", "Error Message");
            }


        }

        private void cBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = cBoxShowPassword.Checked ? '\0' : '*'; //short-hand if-else
        }

        private void cBoxShowPassword2_CheckedChanged(object sender, EventArgs e)
        {
            txtConfirmPass.PasswordChar = cBoxShowPassword2.Checked ? '\0' : '*';
           
        }

        private void linkLabelTAC_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Account account = new Account();
            MessageBox.Show(account.TermsAndConditions(), "Terms and Conditions");
        }
    }
}
