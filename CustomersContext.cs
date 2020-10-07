using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkMigrationScript
{
    public class CustomersContext : DbContext
    {
        public string containerPort { get; set; }

        public CustomersContext(string port)
        {
            containerPort = port;
        }

        public DbSet<Customer> Customers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\INSTANCE" + containerPort + ";Database=customers;Trusted_Connection=True;");
        }
    }
}
