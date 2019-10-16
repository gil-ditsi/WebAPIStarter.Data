using Microsoft.EntityFrameworkCore;
using WebAPIStarter.Data.Models;

namespace WebAPIStarter.Data
{
    public class WebAPIStarterContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Comment> Comments { get; set; }

        protected WebAPIStarterContext(
            DbContextOptions<WebAPIStarterContext> options
        ) : base(options){
        }
    }
}