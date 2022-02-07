using AtmBanking.DAL.Data;
using AtmBanking.Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AtmBanking.DAL.Repository
{
     public class CustomerInfoRepository : ICustomerInfoRepository
    {
        private AtmDbContext _atmDbContext;
        public CustomerInfoRepository(AtmDbContext atmDbContext)
        {
            _atmDbContext = atmDbContext;
        }
        public void Register(CustomerInfo customerInfo)
        {
            _atmDbContext.customerInfo.Add(customerInfo);
            _atmDbContext.SaveChanges();
        }
    }
}
