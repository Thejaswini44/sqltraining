using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using System.Text;

namespace AtmBanking.Entity.Models
{
  public  class Admin
    {

        [Key]
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
