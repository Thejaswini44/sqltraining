using AtmBanking.DAL.Data;
using AtmBanking.Entity.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AtmBanking.DAL.Repository
{
    public class CustomerRepository : ICustomerRepository

    {
        AtmDbContext _atmDbContext;
        public CustomerRepository(AtmDbContext atmDbContext)
        {
            _atmDbContext = atmDbContext;
        }
        public void AddCustomer(Customer customer)
        {
            _atmDbContext.customer.Add(customer);
            _atmDbContext.SaveChanges();
        }

        public void DeleteCustomer(int card_no)
        {
            var customer = _atmDbContext.customer.Find(card_no);
            _atmDbContext.customer.Remove(customer);
            _atmDbContext.SaveChanges();
        }

        public Customer GetCustomerBycard_no(int card_no)
        {
            return _atmDbContext.customer.Find(card_no);
        }

        public IEnumerable<Customer> GetCustomers()
        {
            return _atmDbContext.customer.ToList();
        }

        public void UpdateCustomer(Customer customer)
        {
            _atmDbContext.Entry(customer).State = EntityState.Modified;
            _atmDbContext.SaveChanges();
        }
    }
}
