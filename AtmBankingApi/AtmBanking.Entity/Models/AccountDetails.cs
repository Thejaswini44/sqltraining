using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AtmBanking.Entity.Models
{
    public class AccountDetails
    {
        [Key]
        public int accountId_no { get; set; }
        public string name { get; set; }
        public string account_type { get; set; }
        public int account_number { get; set; }
        public int card_no { get; set; }
        public string credit_fields { get; set; }
        public int current_balance { get; set; }
    }
}