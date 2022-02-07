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
    public class AdminController : ControllerBase
    {
        private AdminService _adminService;
        public AdminController(AdminService adminService)
        {
            _adminService = adminService;
        }
        [HttpGet("GetAdmin")]
        public IEnumerable<Admin> GetAdmin()
        {
            return _adminService.GetAdmin();
        }
        [HttpPost("AddAdmin")]
        public IActionResult AddAdmin([FromBody] Admin admin)
        {
            _adminService.AddAdmin(admin);
            return Ok("Admin details registered successfully!!");
        }
        [HttpDelete("DeleteAdmin")]
        public IActionResult DeleteAdmin(int card_no)
        {
            _adminService.DeleteAdmin(card_no);
            return Ok("Admin details deleted successfully!!");
        }
        [HttpPut("UpdateAdmin")]
        public IActionResult UpdateAdmin([FromBody] Admin admin)
        {
            _adminService.UpdateAdmin(admin);
            return Ok("Admin details updated successfully!!");
        }
        [HttpPost("Login")]
        public IActionResult Login([FromBody] Admin admin)
        {
            Admin admin1 = _adminService.Login(admin);
            if (admin1 != null)
                return Ok("Login success!!");
            else
                return NotFound();
        }
    }
}
