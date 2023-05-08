using ArunExtraedgeassignment.Model;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace ArunExtraedgeassignment.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> option) : base(option)
        {

        }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Mobile> Mobiles { get; set; }
        public DbSet<Sell> Sales { get; set; }
    }
}
