using System;
using System.Windows.Forms;
using Accounts;

namespace SimpleBankingApplication
{
    public partial class LoginForm : Form
    {
        OTPForm otp = new OTPForm();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void linkSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                int number = Convert.ToInt32(txtUsername.Text.ToString());
                string password = txtPassword.Text.ToString();
                string OTPtextbox = txtGenerateOTP.Text.ToString();

                Account account = new Account(number,password);

                string OTP = account.RetrieveOTP();

                if (OTPtextbox == null)
                {
                    MessageBox.Show("Enter the OTP");
                }

                else if (!OTPtextbox.Equals(OTP))
                {
                    MessageBox.Show("Incorrect OTP");
                }

                else
                {

                    if (account.LoginAccount(number, password))
                    {
                        otp.Close();
                        MainMenuForm mainMenu = new MainMenuForm();
                        mainMenu.FormClosed += MainMenu_FormClosed;
                        mainMenu.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Incorrect Number or Password", "Error");
                    }

                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please input the correct information", "Error Input");
            }

        }

        private void btnGenerateOTP_Click(object sender, EventArgs e)
        {
            otp.Show();
        }

        private void cBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = cBoxShowPassword.Checked ? '\0' : '*';
        }

        private void MainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
    }
