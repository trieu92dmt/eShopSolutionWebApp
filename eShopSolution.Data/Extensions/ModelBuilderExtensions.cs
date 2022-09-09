using eShopSolution.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppConfig>().HasData(
                new AppConfig() { 
                    Key = "HomeTitle", 
                    Value = "This is home page of eShopSolution" },
                new AppConfig() { 
                    Key = "HomeKeyword", 
                    Value = "This is home page of eShopSolution" },
                new AppConfig() { 
                    Key = "HomeDescription", 
                    Value = "This is home page of eShopSolution" }
                );
            modelBuilder.Entity<Category>().HasData(
                new Category() { 
                    Id = 1,
                    IsShowOnHome = true, 
                    ParentId = null, 
                    SortOrder = 1, 
                    Status = Enum.Status.Active }
                );
            modelBuilder.Entity<Product>().HasData(
                new Product() { 
                    Id = 1,
                    DateCreated = DateTime.Now, 
                    OriginalPrice = 100000, 
                    Price = 200000, 
                    SeoAlias = "ao-nam", 
                    Stock = 0, 
                    ViewCount = 0
                });
            modelBuilder.Entity<ProductInCategory>().HasData(
                    new ProductInCategory() { ProductId = 1, CategoryId = 1 }
                );
        }
    }
}
