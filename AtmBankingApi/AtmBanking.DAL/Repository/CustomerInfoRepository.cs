using AtmBanking.DAL.Data;
using AtmBanking.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
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
        public CustomerInfo Login(CustomerInfo customer)
        {
            CustomerInfo customerInfo= null;
            var result = _atmDbContext.customerInfo.Where(obj => obj.email_address == customer.email_address && obj.Password == customer.Password).ToList();
           if (result.Count > 0)
            {
               customerInfo = result[0];
           }
            return customerInfo;
        }
        public void Register(CustomerInfo customerInfo)
        {
            _atmDbContext.customerInfo.Add(customerInfo);
            _atmDbContext.SaveChanges();
        }
        

        public IEnumerable<CustomerInfo> GetCustomerInfoDetails()
        {
            return _atmDbContext.customerInfo.ToList();
        }
    }
}
