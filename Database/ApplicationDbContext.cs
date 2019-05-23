using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OnlineMedicineStore.Models;

namespace OnlineMedicineStore.Database
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Stores> Stores { get; set; }
        public DbSet<Drugs> Drugs { get; set; }
        public DbSet<States> States { get; set; }
    }

}
