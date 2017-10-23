/// <auto-generated>
/// This file was automatically generated using Protogen.
/// </auto-generated>
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using System.Linq;

namespace CompoundKey.Models
{
    /// <summary>
    /// EntityFramework DbContext subclass for CompoundKey
    /// </summary>
    public partial class CompoundKeyDbContext : OverrideSuperclass
    {
        /// <summary>
        /// Gets or sets the collection of <see cref="Product"/>
        /// </summary>
        public DbSet<Product> Products { get; set; }

        /// <summary>
        /// Gets or sets the collection of <see cref="Store"/>
        /// </summary>
        public DbSet<Store> Stores { get; set; }

        /// <summary>
        /// Gets or sets the collection of <see cref="StoreProduct"/>
        /// </summary>
        public DbSet<StoreProduct> StoreProducts { get; set; }

        
        /// <summary>
        /// Overrides to add complex keys and other features. Calls the superclasses OnModelCreating.
        /// </summary>
        /// <param name="modelBuilder">The model builder being created.</param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StoreProduct>().HasKey(t => new { t.ProductId, t.StoreId });

            base.OnModelCreating(modelBuilder);
        }
    }
}
