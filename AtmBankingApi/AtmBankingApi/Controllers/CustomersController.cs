using AtmBanking.BAL.services;
using AtmBanking.Entity.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtmBankingApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private CustomerService _customerService;
        public CustomersController(CustomerService customerService)
        {
            _customerService = customerService;
        }
        [HttpGet("GetCustomers")]
        public IEnumerable<Customer> GetCustomers()
        {
            return _customerService.GetCustomers();
        }
        [HttpPost("AddCustomer")]
        public IActionResult AddCustomer([FromBody] Customer customer)
        {
            _customerService.AddCustomer(customer);
            return Ok("Customer details registered successfully!!");
        }
        [HttpDelete("DeleteCustomer")]
        public IActionResult DeleteCustomer(int card_no)
        {
            _customerService.DeleteCustomer(card_no);
            return Ok("Customer details deleted successfully!!");
        }
        [HttpPut("UpdateCustomer")]
        public IActionResult UpdateCustomer([FromBody] Customer customer)
        {
            _customerService.UpdateCustomer(customer);
            return Ok("Customer details updated successfully!!");
        }
        //[HttpPost("Register")]
        //public IActionResult Register([FromBody] Customer customer)
        //{
        //    _customerService.Register( customer);
        //    return Ok("Register successfully!!");
        //}
    }
}
