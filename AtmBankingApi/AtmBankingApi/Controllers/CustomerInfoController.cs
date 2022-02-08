﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AtmBanking.BAL.services;
using AtmBanking.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace AtmBankingApi.Controllers
{
    //[Authorize]
    [Route("api/[controller]")]
    [ApiController]
    
    public class CustomerInfoController : ControllerBase
    {
        private CustomerInfoService _customerInfoService;
        public CustomerInfoController(CustomerInfoService customerInfoService)
        {
            _customerInfoService = customerInfoService;
        }

        [HttpPost("Register")]
        public IActionResult Register([FromBody] CustomerInfo customerInfo)
        {
            _customerInfoService.Register(customerInfo);
            return Ok("Register successfully!!");

        }
        [HttpPost("Login")]
        public IActionResult Login([FromBody] CustomerInfo customerInfo)
        {
            CustomerInfo customer = _customerInfoService.Login(customerInfo);
            if (customer != null)
                return Ok("Login success!!");
            else
                return NotFound();
        }
        [HttpGet("GetCustomerInfoDetails")]
        public IEnumerable<CustomerInfo> GetCustomerInfoDetails()
        {
            return _customerInfoService.GetCustomerInfoDetails();
        }
    }
}

