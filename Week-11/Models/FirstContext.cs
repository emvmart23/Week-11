using Microsoft.EntityFrameworkCore;

namespace Week_11.Models
{
    public class FirstContext : DbContext
    {

        public FirstContext (DbContextOptions<FirstContext> options) : base(options) { }

        public DbSet<Customer> Customer { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<Detail> Details { get; set; }  
        public DbSet<Product> Products { get; set; }
    }
}
