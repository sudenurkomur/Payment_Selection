using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Payment_Selection.Models;
using System.IO;

namespace Payment_Selection.DataAccess
{
    public class AppDbContext : DbContext
    {
        public DbSet<PaymentType> PaymentTypes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false)
                .Build();

            var connectionString = config.GetConnectionString("DefaultConnection");

            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PaymentType>().ToTable("TblPaymentTypes");
        }
    }
}
