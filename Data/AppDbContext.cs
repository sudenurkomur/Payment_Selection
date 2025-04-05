using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Payment_Selection.Models;
using System.Data.Entity;

namespace Payment_Selection.DataAccess
{

    public class AppDbContext : DbContext
    {
        public AppDbContext() : base("name=MyConnectionString") { }

        public DbSet<PaymentType> PaymentTypes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PaymentType>().ToTable("TblPaymentTypes");
        }
    }
}
