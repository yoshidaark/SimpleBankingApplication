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
            //transactionLog = History();
            linkMainMenu.LinkClicked += new LinkLabelLinkClickedEventHandler(linkMainMenu_LinkClicked);
        }

       /* private List<TransactionHistoryClass> History()
        {
            var list = new List<TransactionHistoryClass>();

            try {
                Account account = new Account();
                string filePath = account.TransactionHistory(Account.number.ToString());
                using (StreamReader reader = new StreamReader(filePath))
                {
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        var values = line.Split(',');
                        var transactionHistory = new TransactionHistoryClass
                        {
                            Amount = values[0],
                            Sender = values[1],
                            Receiver = values[2],
                            Date = values[3]
                        };
                        list.Add(transactionHistory);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            return list;
        }
       */

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
            //var history = this.transactionLog;
            //dataGVTransactionHistory.DataSource = history;
            //dataGVTransactionHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            
        }

    }
}
