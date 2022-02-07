using AtmBanking.DAL.Repository;
using AtmBanking.Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AtmBanking.BAL.services
{
    public class AccountDetailsService
    {
        private IAccountDetailsRepository _accountDetailsRepository;
        public AccountDetailsService(IAccountDetailsRepository customerInfoRepository)
        {
            _accountDetailsRepository = customerInfoRepository;
        }

        public void AccountDetailsEntry(AccountDetails accountDetails)
        {
            _accountDetailsRepository.AccountDetailsEntry(accountDetails);
        }
    }
}