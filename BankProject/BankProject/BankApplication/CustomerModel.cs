using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BankProject.BankApplication
{
    public class CustomerModel
    {
        public string name { get; set; }
        public string address{ get; set; }
        public string city { get; set; }
        public string  email_address{ get; set; }
        public int contact_info{ get; set; }
        public int card_no { get; set; }
        public int pin_no{ get; set; }
        public string account_type { get; set; }
        public int account_num { get; set; }
        public string Password { get; set; }


    }
}