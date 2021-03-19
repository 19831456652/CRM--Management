using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CustomerManagement.Model.Migrations
{
    public partial class Client : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ck_ClientLevel",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClientLevelName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsRemove = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ck_ClientLevel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ck_ClientSource",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClientSourceName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsRemove = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ck_ClientSource", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CK_ClientStatus",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClientStatusName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsRemove = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CK_ClientStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ck_ClientTrade",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClientTradeName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsRemove = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ck_ClientTrade", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ck_Client",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClientName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ClientSourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ClientTradeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClientLevel = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NextContactDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Remarks = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Province = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    City = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Area = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DetailsAddress = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    ClientStatus = table.Column<bool>(type: "bit", nullable: false),
                    Founder = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Principal = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsRemove = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ck_Client", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ck_Client_Ck_ClientSource_ClientSourceId",
                        column: x => x.ClientSourceId,
                        principalTable: "Ck_ClientSource",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ck_Client_Ck_ClientTrade_ClientTradeId",
                        column: x => x.ClientTradeId,
                        principalTable: "Ck_ClientTrade",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ck_Client_ClientSourceId",
                table: "Ck_Client",
                column: "ClientSourceId");

            migrationBuilder.CreateIndex(
                name: "IX_Ck_Client_ClientTradeId",
                table: "Ck_Client",
                column: "ClientTradeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ck_Client");

            migrationBuilder.DropTable(
                name: "Ck_ClientLevel");

            migrationBuilder.DropTable(
                name: "CK_ClientStatus");

            migrationBuilder.DropTable(
                name: "Ck_ClientSource");

            migrationBuilder.DropTable(
                name: "Ck_ClientTrade");
        }
    }
}
