﻿// <auto-generated />
using System;
using ECommerce.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ECommerce.Context.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ECommerce.Entities.Brand", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedTime")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.ToTable("Brands");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            CreatedBy = "NKula",
                            CreatedTime = new DateTime(2020, 12, 7, 21, 24, 9, 990, DateTimeKind.Local).AddTicks(5382),
                            Name = "H&M",
                            UpdatedBy = "NKula",
                            UpdatedTime = new DateTime(2020, 12, 7, 21, 24, 9, 990, DateTimeKind.Local).AddTicks(5403)
                        },
                        new
                        {
                            ID = 2,
                            CreatedBy = "NKula",
                            CreatedTime = new DateTime(2020, 12, 7, 21, 24, 9, 990, DateTimeKind.Local).AddTicks(5439),
                            Name = "Marks&Spencer",
                            UpdatedBy = "NKula",
                            UpdatedTime = new DateTime(2020, 12, 7, 21, 24, 9, 990, DateTimeKind.Local).AddTicks(5443)
                        },
                        new
                        {
                            ID = 3,
                            CreatedBy = "NKula",
                            CreatedTime = new DateTime(2020, 12, 7, 21, 24, 9, 990, DateTimeKind.Local).AddTicks(5446),
                            Name = "LC Waikiki",
                            UpdatedBy = "NKula",
                            UpdatedTime = new DateTime(2020, 12, 7, 21, 24, 9, 990, DateTimeKind.Local).AddTicks(5449)
                        });
                });

            modelBuilder.Entity("ECommerce.Entities.Category", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedTime")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            CreatedBy = "NKula",
                            CreatedTime = new DateTime(2020, 12, 7, 21, 24, 9, 990, DateTimeKind.Local).AddTicks(1423),
                            Name = "SportsWear",
                            UpdatedBy = "NKula",
                            UpdatedTime = new DateTime(2020, 12, 7, 21, 24, 9, 990, DateTimeKind.Local).AddTicks(1451)
                        },
                        new
                        {
                            ID = 2,
                            CreatedBy = "NKula",
                            CreatedTime = new DateTime(2020, 12, 7, 21, 24, 9, 990, DateTimeKind.Local).AddTicks(1480),
                            Name = "Men",
                            UpdatedBy = "NKula",
                            UpdatedTime = new DateTime(2020, 12, 7, 21, 24, 9, 990, DateTimeKind.Local).AddTicks(1484)
                        },
                        new
                        {
                            ID = 3,
                            CreatedBy = "NKula",
                            CreatedTime = new DateTime(2020, 12, 7, 21, 24, 9, 990, DateTimeKind.Local).AddTicks(1487),
                            Name = "Women",
                            UpdatedBy = "NKula",
                            UpdatedTime = new DateTime(2020, 12, 7, 21, 24, 9, 990, DateTimeKind.Local).AddTicks(1490)
                        });
                });

            modelBuilder.Entity("ECommerce.Entities.Comment", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Comments")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedTime")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.HasIndex("ProductId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("ECommerce.Entities.Menu", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("datetime2");

                    b.Property<int?>("MenuId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("ID");

                    b.HasIndex("MenuId");

                    b.ToTable("Menus");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            CreatedBy = "NKula",
                            CreatedTime = new DateTime(2020, 12, 7, 21, 24, 9, 985, DateTimeKind.Local).AddTicks(5554),
                            Name = "Home",
                            UpdatedBy = "NKula",
                            UpdatedTime = new DateTime(2020, 12, 7, 21, 24, 9, 988, DateTimeKind.Local).AddTicks(4031),
                            Url = "/"
                        },
                        new
                        {
                            ID = 2,
                            CreatedBy = "NKula",
                            CreatedTime = new DateTime(2020, 12, 7, 21, 24, 9, 988, DateTimeKind.Local).AddTicks(4695),
                            Name = "Shopping",
                            UpdatedBy = "NKula",
                            UpdatedTime = new DateTime(2020, 12, 7, 21, 24, 9, 988, DateTimeKind.Local).AddTicks(4724),
                            Url = "#"
                        },
                        new
                        {
                            ID = 3,
                            CreatedBy = "NKula",
                            CreatedTime = new DateTime(2020, 12, 7, 21, 24, 9, 988, DateTimeKind.Local).AddTicks(5299),
                            MenuId = 2,
                            Name = "Products",
                            UpdatedBy = "NKula",
                            UpdatedTime = new DateTime(2020, 12, 7, 21, 24, 9, 988, DateTimeKind.Local).AddTicks(5312),
                            Url = "/Products"
                        },
                        new
                        {
                            ID = 4,
                            CreatedBy = "NKula",
                            CreatedTime = new DateTime(2020, 12, 7, 21, 24, 9, 988, DateTimeKind.Local).AddTicks(5319),
                            MenuId = 2,
                            Name = "Basket",
                            UpdatedBy = "NKula",
                            UpdatedTime = new DateTime(2020, 12, 7, 21, 24, 9, 988, DateTimeKind.Local).AddTicks(5321),
                            Url = "/Products/Basket"
                        },
                        new
                        {
                            ID = 5,
                            CreatedBy = "NKula",
                            CreatedTime = new DateTime(2020, 12, 7, 21, 24, 9, 988, DateTimeKind.Local).AddTicks(5378),
                            Name = "About",
                            UpdatedBy = "NKula",
                            UpdatedTime = new DateTime(2020, 12, 7, 21, 24, 9, 988, DateTimeKind.Local).AddTicks(5381),
                            Url = "/About"
                        },
                        new
                        {
                            ID = 6,
                            CreatedBy = "NKula",
                            CreatedTime = new DateTime(2020, 12, 7, 21, 24, 9, 988, DateTimeKind.Local).AddTicks(5385),
                            Name = "Contact",
                            UpdatedBy = "NKula",
                            UpdatedTime = new DateTime(2020, 12, 7, 21, 24, 9, 988, DateTimeKind.Local).AddTicks(5388),
                            Url = "/Contact"
                        });
                });

            modelBuilder.Entity("ECommerce.Entities.Picture", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Path")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedTime")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.HasIndex("ProductId");

                    b.ToTable("Pictures");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            CreatedBy = "NKula",
                            CreatedTime = new DateTime(2020, 12, 7, 21, 24, 9, 991, DateTimeKind.Local).AddTicks(9368),
                            Path = "~/images/home/product6.jpg",
                            ProductId = 1,
                            UpdatedBy = "NKula",
                            UpdatedTime = new DateTime(2020, 12, 7, 21, 24, 9, 991, DateTimeKind.Local).AddTicks(9389)
                        },
                        new
                        {
                            ID = 2,
                            CreatedBy = "NKula",
                            CreatedTime = new DateTime(2020, 12, 7, 21, 24, 9, 991, DateTimeKind.Local).AddTicks(9438),
                            Path = "~/images/home/product5.jpg",
                            ProductId = 2,
                            UpdatedBy = "NKula",
                            UpdatedTime = new DateTime(2020, 12, 7, 21, 24, 9, 991, DateTimeKind.Local).AddTicks(9441)
                        },
                        new
                        {
                            ID = 3,
                            CreatedBy = "NKula",
                            CreatedTime = new DateTime(2020, 12, 7, 21, 24, 9, 991, DateTimeKind.Local).AddTicks(9445),
                            Path = "~/images/home/product4.jpg",
                            ProductId = 2,
                            UpdatedBy = "NKula",
                            UpdatedTime = new DateTime(2020, 12, 7, 21, 24, 9, 991, DateTimeKind.Local).AddTicks(9448)
                        });
                });

            modelBuilder.Entity("ECommerce.Entities.Product", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BrandId")
                        .HasColumnType("int");

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsBannerProduct")
                        .HasColumnType("bit");

                    b.Property<bool>("IsNewProduct")
                        .HasColumnType("bit");

                    b.Property<bool>("IsRecommended")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Rate")
                        .HasColumnType("int");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedTime")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.HasIndex("BrandId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            BrandId = 1,
                            CategoryId = 1,
                            CreatedBy = "NKula",
                            CreatedTime = new DateTime(2020, 12, 7, 21, 24, 9, 991, DateTimeKind.Local).AddTicks(4873),
                            IsBannerProduct = false,
                            IsNewProduct = false,
                            IsRecommended = false,
                            Name = "Polo Yaka T-Shirt",
                            Price = 10m,
                            Rate = 0,
                            UpdatedBy = "NKula",
                            UpdatedTime = new DateTime(2020, 12, 7, 21, 24, 9, 991, DateTimeKind.Local).AddTicks(4895)
                        },
                        new
                        {
                            ID = 2,
                            BrandId = 2,
                            CategoryId = 1,
                            CreatedBy = "NKula",
                            CreatedTime = new DateTime(2020, 12, 7, 21, 24, 9, 991, DateTimeKind.Local).AddTicks(4964),
                            IsBannerProduct = false,
                            IsNewProduct = false,
                            IsRecommended = false,
                            Name = "Kahaki Short",
                            Price = 15m,
                            Rate = 0,
                            UpdatedBy = "NKula",
                            UpdatedTime = new DateTime(2020, 12, 7, 21, 24, 9, 991, DateTimeKind.Local).AddTicks(4967)
                        },
                        new
                        {
                            ID = 3,
                            BrandId = 1,
                            CategoryId = 3,
                            CreatedBy = "NKula",
                            CreatedTime = new DateTime(2020, 12, 7, 21, 24, 9, 991, DateTimeKind.Local).AddTicks(4972),
                            IsBannerProduct = false,
                            IsNewProduct = false,
                            IsRecommended = false,
                            Name = "Summer Dress",
                            Price = 30m,
                            Rate = 0,
                            UpdatedBy = "NKula",
                            UpdatedTime = new DateTime(2020, 12, 7, 21, 24, 9, 991, DateTimeKind.Local).AddTicks(4976)
                        });
                });

            modelBuilder.Entity("ECommerce.Entities.ProductTag", b =>
                {
                    b.Property<int?>("TagId")
                        .HasColumnType("int");

                    b.Property<int?>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("TagId", "ProductId");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductTags");

                    b.HasData(
                        new
                        {
                            TagId = 1,
                            ProductId = 1
                        });
                });

            modelBuilder.Entity("ECommerce.Entities.Tag", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedTime")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.ToTable("Tags");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            CreatedBy = "NKula",
                            CreatedTime = new DateTime(2020, 12, 7, 21, 24, 9, 992, DateTimeKind.Local).AddTicks(2499),
                            Name = "Summer clothes",
                            UpdatedBy = "NKula",
                            UpdatedTime = new DateTime(2020, 12, 7, 21, 24, 9, 992, DateTimeKind.Local).AddTicks(2519)
                        });
                });

            modelBuilder.Entity("ECommerce.Entities.Comment", b =>
                {
                    b.HasOne("ECommerce.Entities.Product", "Product")
                        .WithMany("Comments")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ECommerce.Entities.Menu", b =>
                {
                    b.HasOne("ECommerce.Entities.Menu", null)
                        .WithMany("Menus")
                        .HasForeignKey("MenuId");
                });

            modelBuilder.Entity("ECommerce.Entities.Picture", b =>
                {
                    b.HasOne("ECommerce.Entities.Product", "Product")
                        .WithMany("Pictures")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ECommerce.Entities.Product", b =>
                {
                    b.HasOne("ECommerce.Entities.Brand", "Brand")
                        .WithMany("Products")
                        .HasForeignKey("BrandId");

                    b.HasOne("ECommerce.Entities.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId");
                });

            modelBuilder.Entity("ECommerce.Entities.ProductTag", b =>
                {
                    b.HasOne("ECommerce.Entities.Product", "Product")
                        .WithMany("ProductTags")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ECommerce.Entities.Tag", "Tag")
                        .WithMany("ProductTags")
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}