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
        public async Task<IActionResult> Post(CustomerInfo _userData)
        {

            if (_userData != null && _userData.email_address != null && _userData.Password != null)
            {
                var user = await GetCustomerInfo(_userData.email_address, _userData.Password);

                if (user != null)
                {
                    //create claims details based on the user information
                    var claims = new[] {
                    new Claim(JwtRegisteredClaimNames.Sub, _configuration["Jwt:Subject"]),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                    new Claim(JwtRegisteredClaimNames.Iat, DateTime.UtcNow.ToString()),
                    new Claim("CustomerId", user.CustomerId.ToString()),
                    new Claim("name", user.name),
                    new Claim("email_address", user.email_address),
                    //new Claim("Email", user.Email),
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

        private async Task<CustomerInfo> GetCustomerInfo(string email, string password)
        {
            CustomerInfo userInfo = null;
            var result = _context.customerInfo.Where(u => u.email_address == email && u.Password == password);
            foreach (var item in result)
            {
                userInfo = new CustomerInfo();
                userInfo.CustomerId = item.CustomerId;
                userInfo.name = item.name;
                userInfo.address = item.address;
                userInfo.city = item.city;
                userInfo.card_no = item.card_no;
            }
            return userInfo;

        }
    }
}
    