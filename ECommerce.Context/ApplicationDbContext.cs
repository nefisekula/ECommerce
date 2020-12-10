using ECommerce.Context.Extensions;
using ECommerce.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
        }

        public DbSet<Menu> Menus { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Picture> Pictures { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<ProductTag> ProductTags { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductTag>()
                .HasKey(bc => new { bc.TagId, bc.ProductId });

            modelBuilder.Entity<ProductTag>()
                .HasOne(bc => bc.Product)
                .WithMany(b => b.ProductTags)
                .HasForeignKey(bc => bc.ProductId);

            modelBuilder.Entity<ProductTag>()
                .HasOne(bc => bc.Tag)
                .WithMany(c => c.ProductTags)
                .HasForeignKey(bc => bc.TagId);

            modelBuilder.Seed();        
        }

    }
}
