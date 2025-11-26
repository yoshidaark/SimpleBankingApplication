using Accounts;
using System;
using System.IO;
using System.Windows.Forms;

namespace SimpleBankingApplication
{
    public partial class Receipt : Form
    {
        private int Sender;
        private int Receiver;
        private double Amount;
        
        public Receipt()
        {
            InitializeComponent();
        }

        public Receipt(int Sender, int Receiver, double Amount) {
            InitializeComponent();
            this.Sender = Sender;
            this.Receiver = Receiver;
            this.Amount = Amount;

        }

        private void linkMainMenu_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void Receipt_Load(object sender, EventArgs e)
        {
            AccountManagementClass AMC = new AccountManagementClass();
            //lblSenderUsername.Text = Account.FindData(AMC.Search(Sender.ToString()), 1);
            //lblReceiverUsername.Text = Account.FindData(AMC.Search(Receiver.ToString()), 1);

            lblAmount.Text = "₱ " + Amount.ToString("F2");
            lblReceiverNumber.Text = Receiver.ToString();
            lblSenderNumber.Text = Sender.ToString();
            lblDate.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }
    }
}
