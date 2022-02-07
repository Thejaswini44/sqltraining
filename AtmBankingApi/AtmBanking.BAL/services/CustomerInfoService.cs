using AtmBanking.DAL.Repository;
using AtmBanking.Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;


namespace AtmBanking.BAL.services
{
    public class CustomerInfoService
    {
        private ICustomerInfoRepository _customerInfoRepository;
        public CustomerInfoService(ICustomerInfoRepository customerInfoRepository)
        {
            _customerInfoRepository = customerInfoRepository;
        }

        public void Register(CustomerInfo customerInfo)
        {
            _customerInfoRepository.Register(customerInfo);
        }
        public CustomerInfo Login(CustomerInfo customerInfo)
        {
            return _customerInfoRepository.Login(customerInfo);
        }
    }
}
