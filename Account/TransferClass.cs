using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace Accounts
{
    public class TransferClass
    {
        //amount, sender, receiver, date
        //retrieve the sender and receiver data - findData method 
        //find the balance of the sender and receiver
        //minus the balance of sender and add the balanace to receiver
        public void Transfer(int SenderNumber, int ReceiverNumber, double amount)
        {
            SenderNumber = Account.number;

            Account account = new Account();
            double SenderBalance = Convert.ToDouble(account.GetBalance(SenderNumber)); //100    amount = 50
            double ReceiverBalance = Convert.ToDouble(account.GetBalance(ReceiverNumber)); //50

            SenderBalance -= amount; // SenderBalance - amount = SenderBalance
            ReceiverBalance += amount; // 100

            var repo = new dbRepo(Account.conn);
            //update balance
            repo.UpdateAccountBalance(SenderNumber, (decimal)SenderBalance);
            repo.UpdateAccountBalance(ReceiverNumber, (decimal)ReceiverBalance);
            //update transaction history
            repo.AddTransactionHistory(SenderNumber.ToString(), (decimal)amount, SenderNumber, ReceiverNumber, DateTime.Now);
            repo.AddTransactionHistory(ReceiverNumber.ToString(), (decimal)amount, SenderNumber, ReceiverNumber, DateTime.Now);
        }

        
    }
}
