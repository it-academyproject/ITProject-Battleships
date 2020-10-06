using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ITProject_Battleships.Migrations
{
    public partial class addAdminData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "AdminId", "CreatedUserData", "Email", "LastLogin", "Password" },
                values: new object[] { 1, new DateTime(2020, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@gmail.com", new DateTime(2020, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin100#" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "AdminId",
                keyValue: 1);
        }
    }
}
