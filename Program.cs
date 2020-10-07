using System;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkMigrationScript
{
    class Program
    {
        // dotnet add package Microsoft.EntityFrameworkCore.SqlServer
        // dotnet publish -c Release -o out
        // dotnet out\EntityFrameworkMigrationScript.dll

        static void Main(string[] args)
        {
            using (var context = new CustomersContext(args[0]))
            {
                // This code works with the customers database included in the Windocks samples
                // Run your migrations here. In this case we are adding a row as the migration script
                var cust = new Customer()
                {
                    customer_id = 23,
                    first_name ="John",
                    last_name="Doe"
                };

                context.Customers.Add(cust);
                context.SaveChanges();
            }
        }
    }
}
