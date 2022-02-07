using AtmBanking.Entity.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AtmBanking.UI.Controllers
{
    public class CustomersController : Controller
    {
        private IConfiguration _configuration;
        public CustomersController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CustomerEntry()
        {
            return View();
        }
        //[HttpPost]
        //public async Task<IActionResult> Register(Customer customer)
        //{
        //    ViewBag.status = "";
        //    using (HttpClient client = new HttpClient())
        //    {
        //        StringContent content = new StringContent(JsonConvert.SerializeObject(customer), Encoding.UTF8, "application/json");
        //        string endPoint = _configuration["WebApiBaseUrl"] + "Customers/Register";
        //        using (var response = await client.PostAsync(endPoint, content))
        //        {
        //            if (response.StatusCode == System.Net.HttpStatusCode.OK)
        //            {
        //                ViewBag.status = "Ok";
        //                ViewBag.message = "Register successfully!";
        //            }
        //            else
        //            {
        //                ViewBag.status = "Error";
        //                ViewBag.message = "Wrong entries!";
        //            }
        //        }
        //    }
        //    return View();
        //}
    }
}