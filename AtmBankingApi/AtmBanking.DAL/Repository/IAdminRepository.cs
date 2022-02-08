using AtmBanking.Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AtmBanking.DAL.Repository
{
    public interface IAdminRepository
    {
        void AddAdmin(Admin admin);
        void UpdateAdmin(Admin admin);
        void DeleteAdmin(int AdminId);
        Customer GetAdminByAdminId(int AdminId);
        IEnumerable<Admin> GetAdmin();

        Admin Login(Admin admin1);
       
    }
}