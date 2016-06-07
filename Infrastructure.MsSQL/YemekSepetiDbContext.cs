using Core.Domain;
using Core.Domain.Sale;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.MsSQL
{
    public class YemekSepetiDbContext : DbContext
    {
        public YemekSepetiDbContext()
            : base("primary")
        {

        }

        public DbSet<Shop> ShopSet { get; set; }

        public DbSet<Meal> MealSet { get; set; }

        public DbSet<Sale> SaleSet { get; set; }

        public DbSet<SaleDetail> SaleDetailSet { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Shop>().HasKey(a => a.Id);
            modelBuilder.Entity<Meal>().HasKey(a => a.Id);
            modelBuilder.Entity<Sale>().HasKey(a => a.Id);
            modelBuilder.Entity<SaleDetail>().HasKey(a => a.Id);

            modelBuilder.Entity<Shop>().HasMany(a => a.MealList).WithRequired(a => a.ShopItem).HasForeignKey(a => a.ShopId);
            modelBuilder.Entity<Sale>().HasMany(a => a.SaleDetailList).WithRequired(a => a.SaleItem).HasForeignKey(a => a.SaleId);

            base.OnModelCreating(modelBuilder);
        }
    }
}
