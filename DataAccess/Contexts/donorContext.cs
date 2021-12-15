using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Contexts
{
    public class donorContext : DbContext
    {
        public donorContext()
        {
        }

        public donorContext(DbContextOptions<donorContext> options) : base(options)
        {

        }


        public DbSet<City> Cities { get; set; }
        public DbSet<Document> Documents { get; set; }
        public DbSet<DonationType> DonationTypes { get; set; }
        public DbSet<Town> Towns { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserDonationType> UserDonationTypes { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
            {
                options.UseSqlServer("Server=localhost,1433; Database=donorDb; User=sa; Password =AyremX.123");
            }
        }

    }   
}
