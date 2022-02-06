using AtmBanking.Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AtmBanking.DAL.Repository
{
    public  interface ICustomerRepository
    {
        void AddCustomer(Customer customer);
        void UpdateCustomer(Customer customer);
        void DeleteCustomer(int card_no);
        Customer GetCustomerBycard_no(int card_no);
        IEnumerable<Customer> GetCustomers();

    }
}
