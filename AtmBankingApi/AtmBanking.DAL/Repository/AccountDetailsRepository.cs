using AtmBanking.DAL.Data;
using AtmBanking.Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AtmBanking.DAL.Repository
{
    public class AccountDetailsRepository : IAccountDetailsRepository
    {
        private AtmDbContext _atmDbContext;
        public AccountDetailsRepository(AtmDbContext atmDbContext)
        {
            _atmDbContext = atmDbContext;
        }
        public void AccountDetailsEntry(AccountDetails accountDetails)
        {
            _atmDbContext.accountDetails.Add(accountDetails);
            _atmDbContext.SaveChanges();
        }
    }

}