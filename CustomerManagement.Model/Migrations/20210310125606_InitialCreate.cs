using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CustomerManagement.Model.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CM_Branch",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BranchName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsRemove = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CM_Branch", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CM_Menu",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Image = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    MMenuId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Path = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    View = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    MenuState = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsRemove = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CM_Menu", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CM_Menu_CM_Menu_MMenuId",
                        column: x => x.MMenuId,
                        principalTable: "CM_Menu",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CM_Role",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    RoleDescribe = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsRemove = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CM_Role", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CM_Employee",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TheWorkNumber = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Sex = table.Column<bool>(type: "bit", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Image = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    Remarks = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    BranchId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsRemove = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CM_Employee", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CM_Employee_CM_Branch_BranchId",
                        column: x => x.BranchId,
                        principalTable: "CM_Branch",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CM_RoleOrMenu",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MenuId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsRemove = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CM_RoleOrMenu", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CM_RoleOrMenu_CM_Menu_MenuId",
                        column: x => x.MenuId,
                        principalTable: "CM_Menu",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CM_RoleOrMenu_CM_Role_RoleId",
                        column: x => x.RoleId,
                        principalTable: "CM_Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CM_EmployeeOrRole",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsRemove = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CM_EmployeeOrRole", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CM_EmployeeOrRole_CM_Employee_UserId",
                        column: x => x.UserId,
                        principalTable: "CM_Employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CM_EmployeeOrRole_CM_Role_RoleId",
                        column: x => x.RoleId,
                        principalTable: "CM_Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CM_Employee_BranchId",
                table: "CM_Employee",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_CM_EmployeeOrRole_RoleId",
                table: "CM_EmployeeOrRole",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_CM_EmployeeOrRole_UserId",
                table: "CM_EmployeeOrRole",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_CM_Menu_MMenuId",
                table: "CM_Menu",
                column: "MMenuId");

            migrationBuilder.CreateIndex(
                name: "IX_CM_RoleOrMenu_MenuId",
                table: "CM_RoleOrMenu",
                column: "MenuId");

            migrationBuilder.CreateIndex(
                name: "IX_CM_RoleOrMenu_RoleId",
                table: "CM_RoleOrMenu",
                column: "RoleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CM_EmployeeOrRole");

            migrationBuilder.DropTable(
                name: "CM_RoleOrMenu");

            migrationBuilder.DropTable(
                name: "CM_Employee");

            migrationBuilder.DropTable(
                name: "CM_Menu");

            migrationBuilder.DropTable(
                name: "CM_Role");

            migrationBuilder.DropTable(
                name: "CM_Branch");
        }
    }
}
