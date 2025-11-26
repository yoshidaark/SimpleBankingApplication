using System;
using System.Windows.Forms;

namespace SimpleBankingApplication
{
    public partial class SimpleBankingApplication : Form
    {
        public SimpleBankingApplication()
        {
            InitializeComponent();
            DBbackend dBbackend = new DBbackend();
            dBbackend.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.FormClosed += new FormClosedEventHandler(LoginForm_FormClosed);
            loginForm.Show();
            this.Hide();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            SignUpForm signUpForm = new SignUpForm();
            signUpForm.FormClosed += new FormClosedEventHandler(SignUpForm_FormClosed);
            signUpForm.Show();
            this.Hide();
        }

        private void SimpleBankingApplication_Load(object sender, EventArgs e)
        {

        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
        private void SignUpForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
    }
}
