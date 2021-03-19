using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CustomerManagement.Model.Migrations
{
    public partial class ContactPerson : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CK_ContactPerson",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ContactPersonName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ClientId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Post = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    DecisionMaker = table.Column<bool>(type: "bit", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    NextcontactDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Remarks = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Sex = table.Column<bool>(type: "bit", nullable: false),
                    Founder = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Principal = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsRemove = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CK_ContactPerson", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CK_ContactPerson_Ck_Client_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Ck_Client",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CK_ContactPerson_ClientId",
                table: "CK_ContactPerson",
                column: "ClientId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CK_ContactPerson");
        }
    }
}
