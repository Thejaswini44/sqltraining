using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using AtmBanking.Entity.Models;

namespace AtmBanking.DAL.Data
{
    public class AtmDbContext : DbContext
    {
        public AtmDbContext(DbContextOptions<AtmDbContext> options) : base(options)
        {

        }
       // public DbSet<Admin> admin { get; set; }
        public DbSet<Customer> customer { get; set; }

    }
}
