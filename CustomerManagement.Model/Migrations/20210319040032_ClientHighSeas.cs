using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CustomerManagement.Model.Migrations
{
    public partial class ClientHighSeas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CK_ClientHighSeas",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClientName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: true),
                    NextContactDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Remarks = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    ClientLevel = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ClientSourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClientTradeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClientStatus = table.Column<bool>(type: "bit", nullable: false),
                    AtLastFollowDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsRemove = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CK_ClientHighSeas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CK_ClientHighSeas_Ck_ClientSource_ClientSourceId",
                        column: x => x.ClientSourceId,
                        principalTable: "Ck_ClientSource",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CK_ClientHighSeas_Ck_ClientTrade_ClientTradeId",
                        column: x => x.ClientTradeId,
                        principalTable: "Ck_ClientTrade",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CK_ClientHighSeas_ClientSourceId",
                table: "CK_ClientHighSeas",
                column: "ClientSourceId");

            migrationBuilder.CreateIndex(
                name: "IX_CK_ClientHighSeas_ClientTradeId",
                table: "CK_ClientHighSeas",
                column: "ClientTradeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CK_ClientHighSeas");
        }
    }
}
