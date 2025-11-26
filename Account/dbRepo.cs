using Accounts;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;

namespace Accounts
{
    public class dbRepo
    {
        private readonly string _connectionString;
        private readonly Action<string> _log;

        // Accept connection string and optional logger (use Trace by default)
        public dbRepo(string connectionString, Action<string> log = null)
        {
            if (string.IsNullOrWhiteSpace(connectionString))
                throw new ArgumentException("connectionString is required", nameof(connectionString));

            _connectionString = connectionString;
            _log = log ?? (msg => Trace.WriteLine(msg));
        }

        public List<dbAccount> GetAllAccounts()
        {
            var accounts = new List<dbAccount>();
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                const string query = "SELECT id, number, username, password, balance FROM Accounts";
                using (var command = new SqlCommand(query, connection))
                using (var reader = command.ExecuteReader())
                {
                    long rowIndex = 0;
                    while (reader.Read())
                    {
                        rowIndex++;
                        try
                        {
                            accounts.Add(new dbAccount
                            {
                                id = SafeGetInt32(reader, 0, rowIndex),
                                number = SafeGetInt32(reader, 1, rowIndex),
                                username = SafeGetString(reader, 2, rowIndex),
                                password = SafeGetString(reader, 3, rowIndex),
                                balance = SafeGetDecimal(reader, 4, rowIndex)
                            });
                        }
                        catch (Exception ex)
                        {
                            _log?.Invoke($"{DateTime.UtcNow:o} - Unexpected error mapping row {rowIndex}: {ex}");
                            // continue reading remaining rows
                        }
                    }
                }
            }
            return accounts;
        }

        public dbAccount Login(int accountNumber, string password) {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                const string query = "SELECT id, number, username, password, balance FROM Accounts WHERE number = @number AND password = @password";
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@number", accountNumber);
                    command.Parameters.AddWithValue("@password", password);
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new dbAccount
                            {
                                id = SafeGetInt32(reader, 0, 1),
                                number = SafeGetInt32(reader, 1, 1),
                                username = SafeGetString(reader, 2, 1),
                                password = SafeGetString(reader, 3, 1),
                                balance = SafeGetDecimal(reader, 4, 1)
                            };
                        }
                    }
                }
            }
            return null;

        }

        public dbAccount GetAccountByNumber(int accountNumber)
        {
            dbAccount account = null;

            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                const string query = "SELECT id, number, username, password, balance FROM Accounts WHERE number = @number";
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@number", accountNumber);
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            account = new dbAccount
                            {
                                id = SafeGetInt32(reader, 0, 1),
                                number = SafeGetInt32(reader, 1, 1),
                                username = SafeGetString(reader, 2, 1),
                                password = SafeGetString(reader, 3, 1),
                                balance = SafeGetDecimal(reader, 4, 1)
                            };
                        }
                    }
                }
            }

            return account;
        }

        public void AddAccount(dbAccount newAccount)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                const string query = "INSERT INTO Accounts (number, username, password, balance) VALUES (@number, @username, @password, @balance)";
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@number", (object)newAccount.number ?? DBNull.Value);
                    command.Parameters.AddWithValue("@username", (object)newAccount.username ?? DBNull.Value);
                    command.Parameters.AddWithValue("@password", (object)newAccount.password ?? DBNull.Value);
                    command.Parameters.AddWithValue("@balance", (object)newAccount.balance ?? DBNull.Value);
                    command.ExecuteNonQuery();
                }
            }
        }

        public decimal GetAccountBalance(int accountNumber)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                const string query = "SELECT balance FROM Accounts WHERE number = @number";
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@number", accountNumber);
                    var result = command.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        return Convert.ToDecimal(result, CultureInfo.InvariantCulture);
                    }
                    else
                    {
                        throw new Exception("Account not found or balance is null.");
                    }
                }
            }
        }
        public void UpdateAccountUsername(int accountNumber, string newUsername)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                const string query = "UPDATE Accounts SET username = @username WHERE number = @number";
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", newUsername);
                    command.Parameters.AddWithValue("@number", accountNumber);
                    command.ExecuteNonQuery();
                }
            }
        }
        public void UpdateAccountPassword(int accountNumber, string newPassword)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                const string query = "UPDATE Accounts SET password = @password WHERE number = @number";
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@password", newPassword);
                    command.Parameters.AddWithValue("@number", accountNumber);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void UpdateAccountBalance(int accountNumber, decimal newBalance)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                const string query = "UPDATE Accounts SET balance = @balance WHERE number = @number";
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@balance", newBalance);
                    command.Parameters.AddWithValue("@number", accountNumber);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void CreateTransactionHistoryTable(string number)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string tableName = $"TransactionHistory_{number}";
                string query = $@"
                    IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='{tableName}' AND xtype='U')
                    CREATE TABLE {tableName} (
                        Id INT IDENTITY(1,1) PRIMARY KEY,
                        Amount DECIMAL(18, 2),
                        Sender NVARCHAR(100),
                        Receiver NVARCHAR(100),
                        Date DATETIME
                    )";
                using (var command = new SqlCommand(query, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        public List<dbAccount> getTransactionHistory(string number) {
            var transactions = new List<dbAccount>();
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string tableName = $"TransactionHistory_{number}";
                string query = $@"
                    SELECT Id, Amount, Sender, Receiver, Date
                    FROM {tableName}
                    ORDER BY Date DESC";
                using (var command = new SqlCommand(query, connection))
                using (var reader = command.ExecuteReader())
                {
                    long rowIndex = 0;
                    while (reader.Read())
                    {
                        rowIndex++;
                        try
                        {
                            transactions.Add(new dbAccount
                            {
                                transactionId = SafeGetInt32(reader, 0, rowIndex),
                                amount = SafeGetDecimal(reader, 1, rowIndex) ?? 0,
                                senderNumber = SafeGetInt32(reader, 2, rowIndex) ?? 0,
                                receiverNumber = SafeGetInt32(reader, 3, rowIndex) ?? 0,
                                date = reader.IsDBNull(4) ? DateTime.MinValue : reader.GetDateTime(4)

                            });
                        }
                        catch (Exception ex)
                        {
                            _log?.Invoke($"{DateTime.UtcNow:o} - Unexpected error mapping row {rowIndex}: {ex}");
                            // continue reading remaining rows
                        }
                    }
                }
            }
            return transactions;
        }

        public void AddTransactionHistory(string number, decimal amount, int senderNumber, int receiverNumber, DateTime date)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string tableName = $"TransactionHistory_{number}";
                string query = $@"
                    INSERT INTO {tableName} (Amount, Sender, Receiver, Date)
                    VALUES (@amount, @sender, @receiver, @date)";
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@amount", amount);
                    command.Parameters.AddWithValue("@sender", senderNumber);
                    command.Parameters.AddWithValue("@receiver", receiverNumber);
                    command.Parameters.AddWithValue("@date", date);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void DeleteAccount(int accountNumber)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                const string query = "DELETE FROM Accounts WHERE number = @number";
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@number", accountNumber);
                    command.ExecuteNonQuery();
                }
            }
        }
        //auto-generated code for safe data retrieval with logging
        private static void LogConversionFailure(Action<string> log, SqlDataReader r, int colIndex, long rowIndex, object val, Exception ex)
        {
            try
            {
                var name = r.GetName(colIndex);
                var dbType = r.GetDataTypeName(colIndex);
                var actualType = val?.GetType().FullName ?? "null";
                var valueRepr = val == DBNull.Value ? "DBNULL" : (val == null ? "null" : val.ToString());
                log?.Invoke($"{DateTime.UtcNow:o} - Conversion failure row={rowIndex} colIndex={colIndex} ('{name}', dbType={dbType}) actualType={actualType} value='{valueRepr}' ex={ex.GetType().Name}: {ex.Message}");
            }
            catch (Exception loggingEx)
            {
                log?.Invoke($"{DateTime.UtcNow:o} - Conversion failure at colIndex={colIndex} row={rowIndex}. (Logging failure: {loggingEx.Message})");
            }
        }

        private int? SafeGetInt32(SqlDataReader r, int colIndex, long rowIndex)
        {
            object val = r.GetValue(colIndex);
            if (val == DBNull.Value)
            {
                _log?.Invoke($"{DateTime.UtcNow:o} - DBNull encountered at row={rowIndex}, colIndex={colIndex} ('{SafeGetName(r, colIndex)}').");
                return null;
            }

            try
            {
                // Use Convert to handle a variety of provider types (Int64, string, decimal, etc.)
                var converted = Convert.ToInt32(val, CultureInfo.InvariantCulture);
                return converted;
            }
            catch (Exception ex)
            {
                LogConversionFailure(_log, r, colIndex, rowIndex, val, ex);
                return null;
            }
        }

        private string SafeGetString(SqlDataReader r, int colIndex, long rowIndex)
        {
            object val = r.GetValue(colIndex);
            if (val == DBNull.Value)
            {
                _log?.Invoke($"{DateTime.UtcNow:o} - DBNull encountered at row={rowIndex}, colIndex={colIndex} ('{SafeGetName(r, colIndex)}').");
                return null;
            }

            try
            {
                return Convert.ToString(val, CultureInfo.InvariantCulture);
            }
            catch (Exception ex)
            {
                LogConversionFailure(_log, r, colIndex, rowIndex, val, ex);
                return null;
            }
        }

        private decimal? SafeGetDecimal(SqlDataReader r, int colIndex, long rowIndex)
        {
            object val = r.GetValue(colIndex);
            if (val == DBNull.Value)
            {
                _log?.Invoke($"{DateTime.UtcNow:o} - DBNull encountered at row={rowIndex}, colIndex={colIndex} ('{SafeGetName(r, colIndex)}').");
                return null;
            }

            try
            {
                // Convert handles string, double, decimal, etc.
                var converted = Convert.ToDecimal(val, CultureInfo.InvariantCulture);
                return converted;
            }
            catch (Exception ex)
            {
                LogConversionFailure(_log, r, colIndex, rowIndex, val, ex);
                return null;
            }
        }

        private static string SafeGetName(SqlDataReader r, int colIndex)
        {
            try { return r.GetName(colIndex); }
            catch { return $"Index:{colIndex}"; }
        }
    }
}