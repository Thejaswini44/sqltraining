using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TutorialCoreApp.Models
{
    public class TutorialDbContext : DbContext
    {
        //The base keyword is used to access members of the base class from within a derived class
        //Specify which base-class constructor should be called when creating instances of the
        //derived class.
        public TutorialDbContext(DbContextOptions<TutorialDbContext> options) : base(options)
        {

        }
        public DbSet<Tutorial> tutorial { get; set; }
    }
}
