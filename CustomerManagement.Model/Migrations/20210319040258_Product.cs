using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CustomerManagement.Model.Migrations
{
    public partial class Product : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CK_ProductClassify",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductClassifyName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsRemove = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CK_ProductClassify", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CK_ProductUnit",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductUnitName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsRemove = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CK_ProductUnit", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CK_Product",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    ProductClassifyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductUnitId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductCoding = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ProductPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ProductDescription = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Whetheronorofftheshelf = table.Column<bool>(type: "bit", nullable: false),
                    ProductImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductDetailsImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductQuantity = table.Column<int>(type: "int", nullable: false),
                    SellingPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ProductTotal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Founder = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Principal = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsRemove = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CK_Product", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CK_Product_CK_ProductClassify_ProductClassifyId",
                        column: x => x.ProductClassifyId,
                        principalTable: "CK_ProductClassify",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CK_Product_CK_ProductUnit_ProductUnitId",
                        column: x => x.ProductUnitId,
                        principalTable: "CK_ProductUnit",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CK_Product_ProductClassifyId",
                table: "CK_Product",
                column: "ProductClassifyId");

            migrationBuilder.CreateIndex(
                name: "IX_CK_Product_ProductUnitId",
                table: "CK_Product",
                column: "ProductUnitId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CK_Product");

            migrationBuilder.DropTable(
                name: "CK_ProductClassify");

            migrationBuilder.DropTable(
                name: "CK_ProductUnit");
        }
    }
}
