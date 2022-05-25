using Customers.Models;
using Microsoft.EntityFrameworkCore;

namespace Customers.Data
{
    public class CustomerDbContext : DbContext
    {
        public CustomerDbContext(DbContextOptions<CustomerDbContext> options) : base(options)
        {

        }
        public DbSet<Customer> Customers  { get; set; }
        public DbSet<Address> Addresses { get; set; }
    }
}
