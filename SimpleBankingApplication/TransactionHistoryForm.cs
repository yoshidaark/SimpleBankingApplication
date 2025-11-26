using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Accounts;
namespace SimpleBankingApplication
{
    public partial class TransactionHistoryForm : Form
    {
        public List<TransactionHistoryClass> transactionLog { get; set; }
        public TransactionHistoryForm()
        {
            InitializeComponent();
            History();
            linkMainMenu.LinkClicked += new LinkLabelLinkClickedEventHandler(linkMainMenu_LinkClicked);
        }

        private void History()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Transaction ID", typeof(int));
            dt.Columns.Add("Amount", typeof(decimal));
            dt.Columns.Add("Sender", typeof(int));
            dt.Columns.Add("Receiver", typeof(int));
            dt.Columns.Add("Date", typeof(string));
          
            var repo = new dbRepo(Account.conn);
            var history = repo.getTransactionHistory(Account.number.ToString());

            foreach (var item in history)
            {
                var row = dt.NewRow();
                row["Transaction ID"] = item.transactionId;
                row["Amount"] = item.amount;
                row["Sender"] = item.senderNumber;
                row["Receiver"] = item.receiverNumber;
                row["Date"] = item.date.ToString("g");
                dt.Rows.Add(row);
            }
            this.dataGVTransactionHistory.DataSource = dt;
            this.dataGVTransactionHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
       

        private void dataGVTransactionHistory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //show data
        }

        private void linkMainMenu_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void TransactionHistoryForm_Load(object sender, EventArgs e)
        {
            
        }

    }
}
