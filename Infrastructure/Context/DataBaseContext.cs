using BHDSeguros.Domain.Entities.Client;
using BHDSeguros.Domain.Entities.SecureApplications;
using Microsoft.EntityFrameworkCore;

namespace BHDSeguros.Infrastructure.Context
{
    public partial class DataBaseContext : DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options) :
            base(options)
        { }

        public DbSet<ProductTypeEntitie> ProductType { get; set; }
        public DbSet<SecureCodeProductTypeEntitie> SecureCodeProductType { get; set; }
        public DbSet<ClientEntitie> Client { get; set; }
        public DbSet<ClientSecureEntitie> ClientSecure { get; set; }
        public DbSet<SecureApplicationsEntitie> SecureApplications { get; set; }
        public DbSet<SecureCodeEntitie> SecureCode { get; set; }
        public DbSet<SecurePlansEntitie> SecurePlans { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}