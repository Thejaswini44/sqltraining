using AtmBanking.DAL.Repository;
using AtmBanking.Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AtmBanking.BAL.services
{
    public class AdminService
    {
      private  IAdminRepository _adminRepository;
        public AdminService(IAdminRepository adminRepository)
        {
            _adminRepository = adminRepository;
        }

        //add admin
        public void AddAdmin(Admin admin)
        {
            _adminRepository.AddAdmin(admin);
        }
        //update Admin
        public void UpdateAdmin(Admin admin)
        {
            _adminRepository.UpdateAdmin(admin);
        }
        //delete admin
        public void DeleteAdmin(int AdminId)
        {
            _adminRepository.DeleteAdmin(AdminId);
        }
        //Get GetAdminByAdminId
        public void GetAdminByAdminId(int AdminId)
        {
            _adminRepository.GetAdminByAdminId(AdminId);
        }
        //Get GetAdmin
        public IEnumerable<Admin> GetAdmin()
        {
            return _adminRepository.GetAdmin();
        }
        public Admin Login(Admin admin)
        {
            return _adminRepository.Login(admin);
        }
      

    }
}

