using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CustomerManagement.Model.Migrations
{
    public partial class Business : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CK_Business",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BusinessName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ClientId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BusinessMoney = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ExpectedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BusinessStateGroup = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    BusinessStage = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Remarks = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Founder = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Principal = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsRemove = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CK_Business", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CK_Business_Ck_Client_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Ck_Client",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CK_Business_CK_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "CK_Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CK_BusinessStateGroup",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BusinessStateGroupName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BusinessStateGroupId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsRemove = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CK_BusinessStateGroup", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CK_BusinessStateGroup_CK_BusinessStateGroup_BusinessStateGroupId",
                        column: x => x.BusinessStateGroupId,
                        principalTable: "CK_BusinessStateGroup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CK_Business_ClientId",
                table: "CK_Business",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_CK_Business_ProductId",
                table: "CK_Business",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_CK_BusinessStateGroup_BusinessStateGroupId",
                table: "CK_BusinessStateGroup",
                column: "BusinessStateGroupId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CK_Business");

            migrationBuilder.DropTable(
                name: "CK_BusinessStateGroup");
        }
    }
}
