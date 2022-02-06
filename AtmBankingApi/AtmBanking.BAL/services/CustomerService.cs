using AtmBanking.DAL.Repository;
using AtmBanking.Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AtmBanking.BAL.services
{
    public class CustomerService
    {
       private ICustomerRepository _customerRepository;
    
        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public void Register(Customer customer)
        {
            _customerRepository.Register(customer);
        }
        //public UserInfo Login(Customer userInfo)
        //{
        //    return _userInfoRepository.Login(userInfo);
        //}

    }
}
