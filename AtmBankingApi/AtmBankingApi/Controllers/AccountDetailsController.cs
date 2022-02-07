using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AtmBanking.BAL.services;
using AtmBanking.Entity.Models;

namespace AtmBankingApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountDetailsController : ControllerBase
    {

        private AccountDetailsService _accountDetailsService;
        public AccountDetailsController(AccountDetailsService accountDetailsService)
        {
            _accountDetailsService = accountDetailsService;
        }

        [HttpPost("AccountDetailsEntry")]
        public IActionResult AccountDetailsEntry([FromBody] AccountDetails accountDetails)
        {
            _accountDetailsService.AccountDetailsEntry(accountDetails);
            return Ok("Account Details registered successfully!!");

        }
    }
}