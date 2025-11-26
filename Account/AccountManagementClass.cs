using System;
using System.Collections.Generic;
using System.IO;

namespace Accounts //the label of username changes
{
    public class AccountManagementClass //display the username, password, and number
    {
        public void showData(int number)
        {

            var repo = new dbRepo(Account.conn);
            dbAccount dbAccount = repo.GetAccountByNumber(number);
            Account.username = dbAccount.username;
            Account.password = dbAccount.password;
        }

        public void updateAccount(string oldUsername, string newUsername, string oldPassword, string newPassword, int number)
        {
            var repo = new dbRepo(Account.conn);
            dbAccount dbAccount = repo.GetAccountByNumber(number);
            if (dbAccount != null)
            {
                if (!string.IsNullOrEmpty(newUsername) && oldUsername == dbAccount.username)
                {
                    repo.UpdateAccountUsername(number, newUsername);
                }
                if (!string.IsNullOrEmpty(newPassword) && oldPassword == dbAccount.password)
                {
                    repo.UpdateAccountPassword(number, newPassword);
                }
            }
        }

    }
}
