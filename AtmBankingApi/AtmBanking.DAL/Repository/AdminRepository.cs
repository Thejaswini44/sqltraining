using AtmBanking.DAL.Data;
using AtmBanking.Entity.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AtmBanking.DAL.Repository
{
    public class AdminRepository : IAdminRepository
    {
         private  AtmDbContext _atmDbContext;
        public AdminRepository(AtmDbContext atmDbContext)
        {
            _atmDbContext = atmDbContext;
        }
        public void AddAdmin(Admin admin)
        {
            _atmDbContext.admin.Add(admin);
            _atmDbContext.SaveChanges();
        }

        public void DeleteAdmin(int AdminId)
        {
            var admin = _atmDbContext.admin.Find(AdminId);
            _atmDbContext.admin.Remove(admin);
            _atmDbContext.SaveChanges();
        }

        public Customer GetAdminByAdminId(int AdminId)
        {
            return _atmDbContext.customer.Find(AdminId);
        }

        public IEnumerable<Admin> GetAdmin()
        {
            return _atmDbContext.admin.ToList();
        }

        public void UpdateAdmin(Admin admin)
        {
            _atmDbContext.Entry(admin).State = EntityState.Modified;
            _atmDbContext.SaveChanges();
        }

        public Admin Login(Admin admin1)
        {
           Admin admin = null;
            var result = _atmDbContext.admin.Where(obj => obj.Username == admin1.Username && obj.password == admin1.password).ToList();
            if (result.Count > 0)
            {
                admin = result[0];
            }
            return admin1;
        }
    }

}