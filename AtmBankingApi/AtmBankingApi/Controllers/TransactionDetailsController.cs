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
    public class TransactionDetailsController : ControllerBase
    {
        private TransactionDetailsService _transactionDetailsService;
        public TransactionDetailsController(TransactionDetailsService transactionDetailsService)
        {
            _transactionDetailsService = transactionDetailsService;
        }

        [HttpPost("TransactionDetailsEntry")]
        public IActionResult TransactionDetailsEntry([FromBody] TransactionDetails transactionDetails)
        {
            _transactionDetailsService.TransactionDetailsEntry(transactionDetails);
            return Ok("Transaction Details entered successfully!!");

        }
    }
}
