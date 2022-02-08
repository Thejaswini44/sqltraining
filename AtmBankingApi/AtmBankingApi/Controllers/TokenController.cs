using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using AtmBanking.DAL.Data;
using AtmBanking.Entity.Models;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace AtmBanking.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TokenController : ControllerBase
    {
        public IConfiguration _configuration;
        private readonly AtmDbContext _context;

        public TokenController(IConfiguration config, AtmDbContext context)
        {
            _configuration = config;
            _context = context;
        }

        [HttpPost("Login")]
        public async Task<IActionResult> Post(CustomerInfo _customerData)
        {

            if (_customerData != null && _customerData.email_address != null && _customerData.Password != null)
            {
                var customer = await GetCustomerInfoDetails(_customerData.email_address, _customerData.Password);

                if (customer != null)
                {
                    //create claims details based on the user information
                    var claims = new[] {
                    new Claim(JwtRegisteredClaimNames.Sub, _configuration["Jwt:Subject"]),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                    new Claim(JwtRegisteredClaimNames.Iat, DateTime.UtcNow.ToString()),
                    new Claim("CustomerId", customer.CustomerId.ToString()),
                    new Claim("name", customer.name),
                    new Claim("address", customer.address),
                    new Claim("city", customer.city),
                    new Claim("email_address", customer.email_address),
                    new Claim("contact_info", customer.contact_info),
                     new Claim("card_no", customer.card_no),
                      new Claim("pin_no", customer.pin_no),
                       new Claim("account_type",customer. account_type),
                       
                         new Claim("account_number", customer. account_number),
                           new Claim("Password", customer. password),


                   };

                    var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));

                    var signIn = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

                    var token = new JwtSecurityToken(_configuration["Jwt:Issuer"], _configuration["Jwt:Audience"], claims, expires: DateTime.UtcNow.AddDays(1), signingCredentials: signIn);

                    return Ok(new JwtSecurityTokenHandler().WriteToken(token));
                }
                else
                {
                    return BadRequest("Invalid credentials");
                }
            }
            else
            {
                return BadRequest();
            }
        }

        private async Task<CustomerInfo> GetCustomerInfoDetails(string email_address, string password)
        {
            CustomerInfo customerInfo = null;
            var result = _context.customerInfo.Where(u => u.email_address == email_address && u.Password == password);
            foreach (var item in result)
            {
                customerInfo = new CustomerInfo();
                
                customerInfo.CustomerId = item.CustomerId;
                customerInfo.name = item.name;
                customerInfo.address = item.address;
                customerInfo.city = item.city;
                customerInfo.email_address = item.email_address;
                customerInfo.contact_info = item.contact_info;
                customerInfo.card_no = item.card_no;
                customerInfo.pin_no = item.pin_no;
                customerInfo.account_type = item.account_type;
                customerInfo.account_number = item.account_number;
                customerInfo.Password = item.Password;
            }
            return customerInfo;

        }
    }
}
