using System;

namespace Accounts
{
    public class dbAccount
    {
        //account properties
        public int? id { get; set; }
        public int? number { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public decimal? balance { get; set; }

        //transaction properties

        public int? transactionId { get; set; }
        public decimal amount { get; set; }
        public int receiverNumber { get; set; }
        
        public int senderNumber { get; set; }

        public DateTime date { get; set; }


    }
}