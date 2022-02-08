using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace AtmBanking.Entity.Models
{
    public class TransactionDetails
    {
        [Key]
        public int transactionId { get; set; }
        public int accountId { get; set; }
        public int withdrawal { get; set; }
        public int deposit { get; set; }
        public string transfer { get; set; }
        public int Transaction_amount { get; set; }
    }
}