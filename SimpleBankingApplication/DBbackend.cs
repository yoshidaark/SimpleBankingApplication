using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Accounts;

namespace SimpleBankingApplication
{
    public partial class DBbackend : Form
    {
        public DBbackend()
        {
            InitializeComponent();
            ReadClients();
        }

        private void ReadClients() {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Account Number", typeof(int));
            dt.Columns.Add("Username", typeof(string));
            dt.Columns.Add("Password", typeof(string));
            dt.Columns.Add("Balance", typeof(decimal));

            var repo = new dbRepo(Account.conn);
            var accounts = repo.GetAllAccounts();

            foreach (var account in accounts)
            {
                var row = dt.NewRow();
                // box nullable values and fall back to DBNull when null
                row["ID"] = (object)account.id ?? DBNull.Value;
                row["Account Number"] = (object)account.number ?? DBNull.Value;
                row["Username"] = (object)account.username ?? DBNull.Value;
                row["Password"] = (object)account.password ?? DBNull.Value;
                row["Balance"] = (object)account.balance ?? DBNull.Value;
                dt.Rows.Add(row);
            }

            this.dataGridView1.DataSource = dt;
        }

        private void DBbackend_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReadClients();
        }
    }
}
