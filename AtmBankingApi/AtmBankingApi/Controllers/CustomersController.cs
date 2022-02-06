using AtmBanking.BAL.services;
using AtmBanking.DAL.Data;
using AtmBanking.Entity.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace AtmBankingApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
  
    public class UserController : ControllerBase
    {
        private CustomerService _customerService;
        public UserController(CustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpPost("Register")]
        public IActionResult Register([FromBody] Customer customer)
        {
            _customerService.Register(customer);
            return Ok("Register successfully!!");
        }
        //[HttpPost("Login")]
        //public IActionResult Login([FromBody] UserInfo userInfo)
        //{
        //    UserInfo user = _userInfoService.Login(userInfo);
        //    if (user != null)
        //        return Ok("Login success!!");
        //    else
        //        return NotFound();
        //}

    }
}
