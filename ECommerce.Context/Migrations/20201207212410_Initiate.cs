using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ECommerce.Context.Migrations
{
    public partial class Initiate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedTime = table.Column<DateTime>(nullable: false),
                    UpdatedBy = table.Column<string>(nullable: true),
                    UpdatedTime = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedTime = table.Column<DateTime>(nullable: false),
                    UpdatedBy = table.Column<string>(nullable: true),
                    UpdatedTime = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Menus",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedTime = table.Column<DateTime>(nullable: false),
                    UpdatedBy = table.Column<string>(nullable: true),
                    UpdatedTime = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Url = table.Column<string>(maxLength: 50, nullable: false),
                    MenuId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menus", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Menus_Menus_MenuId",
                        column: x => x.MenuId,
                        principalTable: "Menus",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tags",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedTime = table.Column<DateTime>(nullable: false),
                    UpdatedBy = table.Column<string>(nullable: true),
                    UpdatedTime = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tags", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedTime = table.Column<DateTime>(nullable: false),
                    UpdatedBy = table.Column<string>(nullable: true),
                    UpdatedTime = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Price = table.Column<decimal>(nullable: false),
                    IsNewProduct = table.Column<bool>(nullable: false),
                    Rate = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    IsRecommended = table.Column<bool>(nullable: false),
                    IsBannerProduct = table.Column<bool>(nullable: false),
                    CategoryId = table.Column<int>(nullable: true),
                    BrandId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Products_Brands_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brands",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedTime = table.Column<DateTime>(nullable: false),
                    UpdatedBy = table.Column<string>(nullable: true),
                    UpdatedTime = table.Column<DateTime>(nullable: false),
                    Comments = table.Column<string>(maxLength: 50, nullable: false),
                    ProductId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Comments_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Pictures",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedTime = table.Column<DateTime>(nullable: false),
                    UpdatedBy = table.Column<string>(nullable: true),
                    UpdatedTime = table.Column<DateTime>(nullable: false),
                    Path = table.Column<string>(maxLength: 100, nullable: false),
                    ProductId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pictures", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Pictures_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductTags",
                columns: table => new
                {
                    ProductId = table.Column<int>(nullable: false),
                    TagId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductTags", x => new { x.TagId, x.ProductId });
                    table.ForeignKey(
                        name: "FK_ProductTags_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductTags_Tags_TagId",
                        column: x => x.TagId,
                        principalTable: "Tags",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Name", "UpdatedBy", "UpdatedTime" },
                values: new object[,]
                {
                    { 1, "NKula", new DateTime(2020, 12, 7, 21, 24, 9, 990, DateTimeKind.Local).AddTicks(5382), "H&M", "NKula", new DateTime(2020, 12, 7, 21, 24, 9, 990, DateTimeKind.Local).AddTicks(5403) },
                    { 2, "NKula", new DateTime(2020, 12, 7, 21, 24, 9, 990, DateTimeKind.Local).AddTicks(5439), "Marks&Spencer", "NKula", new DateTime(2020, 12, 7, 21, 24, 9, 990, DateTimeKind.Local).AddTicks(5443) },
                    { 3, "NKula", new DateTime(2020, 12, 7, 21, 24, 9, 990, DateTimeKind.Local).AddTicks(5446), "LC Waikiki", "NKula", new DateTime(2020, 12, 7, 21, 24, 9, 990, DateTimeKind.Local).AddTicks(5449) }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Name", "UpdatedBy", "UpdatedTime" },
                values: new object[,]
                {
                    { 1, "NKula", new DateTime(2020, 12, 7, 21, 24, 9, 990, DateTimeKind.Local).AddTicks(1423), "SportsWear", "NKula", new DateTime(2020, 12, 7, 21, 24, 9, 990, DateTimeKind.Local).AddTicks(1451) },
                    { 2, "NKula", new DateTime(2020, 12, 7, 21, 24, 9, 990, DateTimeKind.Local).AddTicks(1480), "Men", "NKula", new DateTime(2020, 12, 7, 21, 24, 9, 990, DateTimeKind.Local).AddTicks(1484) },
                    { 3, "NKula", new DateTime(2020, 12, 7, 21, 24, 9, 990, DateTimeKind.Local).AddTicks(1487), "Women", "NKula", new DateTime(2020, 12, 7, 21, 24, 9, 990, DateTimeKind.Local).AddTicks(1490) }
                });

            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "MenuId", "Name", "UpdatedBy", "UpdatedTime", "Url" },
                values: new object[,]
                {
                    { 1, "NKula", new DateTime(2020, 12, 7, 21, 24, 9, 985, DateTimeKind.Local).AddTicks(5554), null, "Home", "NKula", new DateTime(2020, 12, 7, 21, 24, 9, 988, DateTimeKind.Local).AddTicks(4031), "/" },
                    { 2, "NKula", new DateTime(2020, 12, 7, 21, 24, 9, 988, DateTimeKind.Local).AddTicks(4695), null, "Shopping", "NKula", new DateTime(2020, 12, 7, 21, 24, 9, 988, DateTimeKind.Local).AddTicks(4724), "#" },
                    { 5, "NKula", new DateTime(2020, 12, 7, 21, 24, 9, 988, DateTimeKind.Local).AddTicks(5378), null, "About", "NKula", new DateTime(2020, 12, 7, 21, 24, 9, 988, DateTimeKind.Local).AddTicks(5381), "/About" },
                    { 6, "NKula", new DateTime(2020, 12, 7, 21, 24, 9, 988, DateTimeKind.Local).AddTicks(5385), null, "Contact", "NKula", new DateTime(2020, 12, 7, 21, 24, 9, 988, DateTimeKind.Local).AddTicks(5388), "/Contact" }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Name", "UpdatedBy", "UpdatedTime" },
                values: new object[] { 1, "NKula", new DateTime(2020, 12, 7, 21, 24, 9, 992, DateTimeKind.Local).AddTicks(2499), "Summer clothes", "NKula", new DateTime(2020, 12, 7, 21, 24, 9, 992, DateTimeKind.Local).AddTicks(2519) });

            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "MenuId", "Name", "UpdatedBy", "UpdatedTime", "Url" },
                values: new object[,]
                {
                    { 3, "NKula", new DateTime(2020, 12, 7, 21, 24, 9, 988, DateTimeKind.Local).AddTicks(5299), 2, "Products", "NKula", new DateTime(2020, 12, 7, 21, 24, 9, 988, DateTimeKind.Local).AddTicks(5312), "/Products" },
                    { 4, "NKula", new DateTime(2020, 12, 7, 21, 24, 9, 988, DateTimeKind.Local).AddTicks(5319), 2, "Basket", "NKula", new DateTime(2020, 12, 7, 21, 24, 9, 988, DateTimeKind.Local).AddTicks(5321), "/Products/Basket" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ID", "BrandId", "CategoryId", "CreatedBy", "CreatedTime", "Description", "IsBannerProduct", "IsNewProduct", "IsRecommended", "Name", "Price", "Rate", "UpdatedBy", "UpdatedTime" },
                values: new object[,]
                {
                    { 1, 1, 1, "NKula", new DateTime(2020, 12, 7, 21, 24, 9, 991, DateTimeKind.Local).AddTicks(4873), null, false, false, false, "Polo Yaka T-Shirt", 10m, 0, "NKula", new DateTime(2020, 12, 7, 21, 24, 9, 991, DateTimeKind.Local).AddTicks(4895) },
                    { 2, 2, 1, "NKula", new DateTime(2020, 12, 7, 21, 24, 9, 991, DateTimeKind.Local).AddTicks(4964), null, false, false, false, "Kahaki Short", 15m, 0, "NKula", new DateTime(2020, 12, 7, 21, 24, 9, 991, DateTimeKind.Local).AddTicks(4967) },
                    { 3, 1, 3, "NKula", new DateTime(2020, 12, 7, 21, 24, 9, 991, DateTimeKind.Local).AddTicks(4972), null, false, false, false, "Summer Dress", 30m, 0, "NKula", new DateTime(2020, 12, 7, 21, 24, 9, 991, DateTimeKind.Local).AddTicks(4976) }
                });

            migrationBuilder.InsertData(
                table: "Pictures",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Path", "ProductId", "UpdatedBy", "UpdatedTime" },
                values: new object[,]
                {
                    { 1, "NKula", new DateTime(2020, 12, 7, 21, 24, 9, 991, DateTimeKind.Local).AddTicks(9368), "~/images/home/product6.jpg", 1, "NKula", new DateTime(2020, 12, 7, 21, 24, 9, 991, DateTimeKind.Local).AddTicks(9389) },
                    { 2, "NKula", new DateTime(2020, 12, 7, 21, 24, 9, 991, DateTimeKind.Local).AddTicks(9438), "~/images/home/product5.jpg", 2, "NKula", new DateTime(2020, 12, 7, 21, 24, 9, 991, DateTimeKind.Local).AddTicks(9441) },
                    { 3, "NKula", new DateTime(2020, 12, 7, 21, 24, 9, 991, DateTimeKind.Local).AddTicks(9445), "~/images/home/product4.jpg", 2, "NKula", new DateTime(2020, 12, 7, 21, 24, 9, 991, DateTimeKind.Local).AddTicks(9448) }
                });

            migrationBuilder.InsertData(
                table: "ProductTags",
                columns: new[] { "TagId", "ProductId" },
                values: new object[] { 1, 1 });

            migrationBuilder.CreateIndex(
                name: "IX_Comments_ProductId",
                table: "Comments",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Menus_MenuId",
                table: "Menus",
                column: "MenuId");

            migrationBuilder.CreateIndex(
                name: "IX_Pictures_ProductId",
                table: "Pictures",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_BrandId",
                table: "Products",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductTags_ProductId",
                table: "ProductTags",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Menus");

            migrationBuilder.DropTable(
                name: "Pictures");

            migrationBuilder.DropTable(
                name: "ProductTags");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Tags");

            migrationBuilder.DropTable(
                name: "Brands");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
