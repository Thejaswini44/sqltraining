﻿using System;
using System.Collections.Generic;
using System.Text;
using AtmBanking.DAL.Repository;
using AtmBanking.Entity.Models;

namespace AtmBanking.BAL.services
{
   public class CustomerService
    {
        ICustomerRepository _customerRepository;
        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        //add customer
        public void AddCustomer(Customer customer)
        {
            _customerRepository.AddCustomer(customer);
        }
        //update customer
        public void UpdateCustomer(Customer customer)
        {
            _customerRepository.UpdateCustomer(customer);
        }
        //delete customer
        public void DeleteCustomer(int card_no)
        {
            _customerRepository.DeleteCustomer(card_no);
        }
        //Get GetCustomerBycard_no
        public void GetCustomerBycard_no(int card_no)
        {
            _customerRepository.GetCustomerBycard_no(card_no);
        }
        //Get GetCustomers
        public IEnumerable<Customer> GetCustomers()
        {
          return _customerRepository.GetCustomers();
        }
    }
}
