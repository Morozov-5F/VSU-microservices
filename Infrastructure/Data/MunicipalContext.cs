using ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data
{
    public class MunicipalContext : DbContext
    {
        public MunicipalContext(DbContextOptions<MunicipalContext> options) : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>(ConfigureCustomer);
        }

        private void ConfigureCustomer(EntityTypeBuilder<Customer> builder)
        {
            builder.ToTable("Customers");

            // TODO: Customer configuration. Look up WTF is that.
        }
    }
}
