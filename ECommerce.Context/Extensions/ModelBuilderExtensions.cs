using ECommerce.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace ECommerce.Context.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            CreateMenus(modelBuilder);
            CreateCategories(modelBuilder);
            CreateBrands(modelBuilder);
            CreateProducts(modelBuilder);
            CreatePictures(modelBuilder);
            CreateTags(modelBuilder);
            CreateProductTags(modelBuilder);
        }

        private static void CreateMenus(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Menu>().HasData(
                new Menu
                {
                    ID = 1,
                    Name = "Home",
                    Url = "/",
                    CreatedBy = "NKula",
                    CreatedTime = DateTime.Now,
                    UpdatedBy = "NKula",
                    UpdatedTime = DateTime.Now
                },
                new Menu
                {
                    ID = 2,
                    Name = "Shopping",
                    Url = "#",
                    CreatedBy = "NKula",
                    CreatedTime = DateTime.Now,
                    UpdatedBy = "NKula",
                    UpdatedTime = DateTime.Now
                },
                new Menu
                {
                    ID = 3,
                    Name = "Products",
                    Url = "/Products",
                    MenuId=2,
                    CreatedBy = "NKula",
                    CreatedTime = DateTime.Now,
                    UpdatedBy = "NKula",
                    UpdatedTime = DateTime.Now
                },
                new Menu
                {
                    ID = 4,
                    Name = "Basket",
                    Url = "/Products/Basket",
                    MenuId = 2,
                    CreatedBy = "NKula",
                    CreatedTime = DateTime.Now,
                    UpdatedBy = "NKula",
                    UpdatedTime = DateTime.Now
                },
                new Menu
                {
                    ID = 5,
                    Name = "About",
                    Url = "/About",
                    CreatedBy = "NKula",
                    CreatedTime = DateTime.Now,
                    UpdatedBy = "NKula",
                    UpdatedTime = DateTime.Now
                },
                new Menu
                {
                    ID = 6,
                    Name = "Contact",
                    Url = "/Contact",
                    CreatedBy = "NKula",
                    CreatedTime = DateTime.Now,
                    UpdatedBy = "NKula",
                    UpdatedTime = DateTime.Now
                });
        }

        private static void CreateCategories(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    ID = 1,
                    Name = "SportsWear",
                    CreatedBy = "NKula",
                    CreatedTime = DateTime.Now,
                    UpdatedBy = "NKula",
                    UpdatedTime = DateTime.Now
                },
                new Category
                {
                    ID = 2,
                    Name = "Men",
                    CreatedBy = "NKula",
                    CreatedTime = DateTime.Now,
                    UpdatedBy = "NKula",
                    UpdatedTime = DateTime.Now
                },
                new Category
                {
                    ID = 3,
                    Name = "Women",
                    CreatedBy = "NKula",
                    CreatedTime = DateTime.Now,
                    UpdatedBy = "NKula",
                    UpdatedTime = DateTime.Now
                });
        }

        private static void CreateBrands(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Brand>().HasData(
                new Brand
                {
                    ID = 1,
                    Name = "H&M",
                    CreatedBy = "NKula",
                    CreatedTime = DateTime.Now,
                    UpdatedBy = "NKula",
                    UpdatedTime = DateTime.Now
                },
                new Brand
                {
                    ID = 2,
                    Name = "Marks&Spencer",
                    CreatedBy = "NKula",
                    CreatedTime = DateTime.Now,
                    UpdatedBy = "NKula",
                    UpdatedTime = DateTime.Now
                },
                new Brand
                {
                    ID = 3,
                    Name = "LC Waikiki",
                    CreatedBy = "NKula",
                    CreatedTime = DateTime.Now,
                    UpdatedBy = "NKula",
                    UpdatedTime = DateTime.Now
                });
        }

        private static void CreateProducts(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    ID = 1,
                    BrandId = 1,
                    CategoryId = 1,
                    IsBannerProduct = false,
                    IsNewProduct = false,
                    IsRecommended = false,
                    Name = "Polo Yaka T-Shirt",
                    Price = 10,
                    Rate = 0,
                    CreatedBy = "NKula",
                    CreatedTime = DateTime.Now,
                    UpdatedBy = "NKula",
                    UpdatedTime = DateTime.Now
                },
                new Product
                {
                    ID = 2,
                    BrandId = 2,
                    CategoryId = 1,
                    IsBannerProduct = false,
                    IsNewProduct = false,
                    IsRecommended = false,
                    Name = "Kahaki Short",
                    Price = 15,
                    Rate = 0,
                    CreatedBy = "NKula",
                    CreatedTime = DateTime.Now,
                    UpdatedBy = "NKula",
                    UpdatedTime = DateTime.Now
                },
                new Product
                {
                    ID = 3,
                    BrandId = 1,
                    CategoryId = 3,
                    IsBannerProduct = false,
                    IsNewProduct = false,
                    IsRecommended = false,
                    Name = "Summer Dress",
                    Price = 30,
                    Rate = 0,
                    CreatedBy = "NKula",
                    CreatedTime = DateTime.Now,
                    UpdatedBy = "NKula",
                    UpdatedTime = DateTime.Now
                });
        }

        private static void CreatePictures(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Picture>().HasData(
                new Picture
                {
                    ID = 1,
                    Path = "~/images/home/product6.jpg",
                    ProductId = 1,
                    CreatedBy = "NKula",
                    CreatedTime = DateTime.Now,
                    UpdatedBy = "NKula",
                    UpdatedTime = DateTime.Now
                },
                new Picture
                {
                    ID = 2,
                    Path = "~/images/home/product5.jpg",
                    ProductId = 2,
                    CreatedBy = "NKula",
                    CreatedTime = DateTime.Now,
                    UpdatedBy = "NKula",
                    UpdatedTime = DateTime.Now
                },
                new Picture
                {
                    ID = 3,
                    Path = "~/images/home/product4.jpg",
                    ProductId = 2,
                    CreatedBy = "NKula",
                    CreatedTime = DateTime.Now,
                    UpdatedBy = "NKula",
                    UpdatedTime = DateTime.Now
                });
        }

        private static void CreateTags(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tag>().HasData(
                new Tag
                {
                    ID = 1,
                    Name = "Summer clothes",
                    CreatedBy = "NKula",
                    CreatedTime = DateTime.Now,
                    UpdatedBy = "NKula",
                    UpdatedTime = DateTime.Now
                });
        }

        private static void CreateProductTags(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductTag>().HasData(
                new ProductTag
                {
                    ProductId = 1,
                    TagId = 1
                });
        }

    }
}
