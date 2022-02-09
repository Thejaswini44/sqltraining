using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AtmBanking.Entity.Models;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;

namespace AtmBanking.UI.Controllers
{
    public class TransactionDetailsController : Controller
    {
        private IConfiguration _configuration;
        public TransactionDetailsController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> TransactionDetails()
        {
            //StringContent content = new StringContent(JsonConvert.SerializeObject(customerInfo), Encoding.UTF8, "application/json");
            IEnumerable<TransactionDetails> transactiondetailsresult = null;
            using (HttpClient client = new HttpClient())
            {
                string endPoint = _configuration["WebApiBaseUrl"] + "TransactionDetails/GetTransactionDetails";
                using (var response = await client.GetAsync(endPoint))
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        var result = await response.Content.ReadAsStringAsync();
                        transactiondetailsresult = JsonConvert.DeserializeObject<IEnumerable<TransactionDetails>>(result);
                    }
                }
            }
            return View(transactiondetailsresult);
        }
        public IActionResult TransactionDetailsEntry()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> TransactionDetailsEntry(TransactionDetails transactionDetails)
        {
            ViewBag.status = "";
            using (HttpClient client = new HttpClient())
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(transactionDetails), Encoding.UTF8, "application/json");
                string endPoint = _configuration["WebApiBaseUrl"] + "TransactionDetails/TransactionDetailsEntry";
                using (var response = await client.PostAsync(endPoint, content))
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        ViewBag.status = "Ok";
                        ViewBag.message = "Transaction Details entered successfully!!";
                    }
                    else
                    {
                        ViewBag.status = "Error";
                        ViewBag.message = "Wrong entries!";
                    }
                }
            }
            return View();
        }
    }
}