using System;
using System.IO;
using System.Linq;
using static System.Net.WebRequestMethods;


namespace Accounts
{
    public class Account
    {
        public delegate string DelegateText(string txt);
        public delegate int DelegateNumber(int num);

        public static int number;
        public static string username, password;
        public static double balance;
        //paste your local db here
        public static string conn = "";
        //make the file path dynamic
        private string filePathAccount = Path.Combine(Directory.GetCurrentDirectory(), "SimpleBankingAccounts.csv");
        private string filePathOTP = Path.Combine(Directory.GetCurrentDirectory(), "OTP.txt");
        private string filePathTAC = Path.Combine(Directory.GetCurrentDirectory(), "Terms and Conditions.txt");

        public Account() {
        }

        //login-temporary
        public Account(int number, string password) {
            
            Account.number = number;
            Account.password = password;

        }
        //registration
        public Account(int number, string username, string password)
        {
            Account.number = number;
            Account.username = username;
            Account.password = password;
            
            AccountRegistration();
        }
        public static int GetAccountNumber(int number) {
            return Account.number = number;
        }
        
        public static string GetAccountUsername(string username) {
            return Account.username = username;
        }

        public static string GetAccountPassword(string password) {
            return Account.password = password;
        }
        
        private void AccountRegistration() {
            //database
            dbAccount dbAccount = new dbAccount();
            dbAccount.number = number;
            dbAccount.username = username;
            dbAccount.password = password;
            dbAccount.balance = 0.00M;

            var repo = new dbRepo(conn);
            repo.AddAccount(dbAccount);

            //csv file
            try
            {
                using (StreamWriter writer = new StreamWriter(filePathAccount, true))
                {
                    writer.WriteLine(number + "," + username + "," + password + "," + "00.00"); // input the data to file
                    writer.Flush(); //ensure that the data is inputted
                    
                }
               
            }
            catch (IOException ex)  // Specific to I/O errors
            {
                Console.WriteLine($"I/O Error: {ex.Message}");
            }
        }

        public bool LoginAccount(int number, string password)
        {
            var repo = new dbRepo(conn);
            if (repo.Login(number,password) != null) {
                var account = repo.GetAccountByNumber(number);
                Account.username = account.username;
                Account.balance = (double)account.balance;
                Account.number = (int)account.number;
                Account.password = account.password;
                return true;
            }
            return false;
        }

        public string RetrieveOTP() {
            string OTP = "";
            try
            {
                using (StreamReader reader = new StreamReader(filePathOTP, true))
                {
                    string[] lines = System.IO.File.ReadAllLines(filePathOTP);  // Read all lines into an array
                    if (lines.Length > 0)
                    {
                        OTP = lines[lines.Length - 1].Trim();  // Get and trim the last line
                        //latest otp generated
                    }

                }

            }
            catch (IOException ex)  // Specific to I/O errors
            {
                Console.WriteLine($"I/O Error: {ex.Message}");
            }

            return OTP;
        }

        public static string FindData(string line, int loc) 
        {
            string[] data = line.Split(',');
            return data[loc];
        }

        //get balance code
        public string GetBalance(int number)
        {
            try
            {
                var repo = new dbRepo(conn);
                decimal balanceDecimal = repo.GetAccountBalance(number);
                return balanceDecimal.ToString("F2");

            }
            catch (IOException ex)  // Specific to I/O errors
            {
                Console.WriteLine($"I/O Error: {ex.Message}");
            }
            return "00.00";
        }

        public bool ifExist(string accountDetail, int loc) {
            try
            {
                using (StreamReader reader = new StreamReader(filePathAccount))
                {
                    string line;


                    while ((line = reader.ReadLine()) != null)
                    {
                        string [] parts = line.Split(',');
                        if (parts[loc].Equals(accountDetail))  // Check if the line contains the number
                        {

                            return true;  // it was found
                        }
                    }

                }

            }
            catch (IOException ex)  // Specific to I/O errors
            {
                Console.WriteLine($"I/O Error: {ex.Message}");
            }
            return false;
        }

        public string TermsAndConditions() {
            string termsAndConditions = "";
            try
            {
                using (StreamReader reader = new StreamReader(filePathTAC))
                {
                    string line;


                    while ((line = reader.ReadLine()) != null)
                    {
                        termsAndConditions = line;
                    }

                }

            }
            catch (IOException ex)  // Specific to I/O errors
            {
                Console.WriteLine($"I/O Error: {ex.Message}");
            }
            return termsAndConditions;
        }

        public void createTransactionHistory(string number)
        {
            var repo = new dbRepo(conn);
            repo.CreateTransactionHistoryTable(number);

        }
    }
}
