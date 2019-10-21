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
        public DbSet<AddressType> AddressTypes { get; set; }
        public DbSet<CustomerAddress> CustomerAddresses { get; set; }

        public WebAPIStarterContext(
            DbContextOptions<WebAPIStarterContext> options
        ) : base(options){
        }

        protected override void OnModelCreating(ModelBuilder builder){
            builder.Entity<CustomerAddress>()
                .HasKey((ca)=> new {ca.CustomerId, ca.AddressId});

            builder.Entity<CustomerAddress>()
                .HasOne(ca => ca.Customer)
                .WithMany(ca => ca.CustomerAddresses)
                .HasForeignKey(ca => ca.CustomerId);

            builder.Entity<CustomerAddress>()
                .HasOne(ca => ca.Address)
                .WithMany(ca => ca.CustomerAddresses)
                .HasForeignKey(ca => ca.AddressId);
        }
    }
}