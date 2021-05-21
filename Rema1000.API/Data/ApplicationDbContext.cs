using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Rema1000.API.Data.Config;
using Rema1000.Shared.Models;

namespace Rema1000.API.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        // models to create tables from
        public DbSet<Category> Categories { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Product> Products { get; set; }

        // seed data method
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // call config classes for seeding db
            builder.ApplyConfiguration(new CategorySeedConfig());

            builder.ApplyConfiguration(new SupplierSeedConfig());

            builder.ApplyConfiguration(new ProductSeedConfig());
        }
    }
}
