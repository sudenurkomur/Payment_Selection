using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Payment_Selection.Models;
using Microsoft.EntityFrameworkCore;


namespace Payment_Selection.DataAccess
{

    public class AppDbContext : DbContext
    {
        public DbSet<PaymentType> PaymentTypes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=MONSTERSUDE\\SQLEXPRESS;Database=PaymentDB;Trusted_Connection=True;Encrypt=False;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PaymentType>().ToTable("TblPaymentTypes");
        }
    }
}
