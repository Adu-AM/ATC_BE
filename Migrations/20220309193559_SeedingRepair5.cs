using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ATC_BE.Migrations
{
    public partial class SeedingRepair5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "50bfdc91-e65b-4a14-8203-e481e4923e1f", 0, "50bfdc91-e65b-4a14-8203-e481e4923e1f", null, false, false, null, null, null, "admin", null, false, "50bfdc91-e65b-4a14-8203-e481e4923e1f", false, "admin@example.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "50bfdc91-e65b-4a14-8203-e481e4923e1f");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "1", 0, "f472f12e-cbc0-4121-b91e-555a95ddc388", null, false, false, null, null, null, "admin", null, false, "415f99dd-c460-4e46-87a2-2e1a6e290e79", false, "admin@example.com" });
        }
    }
}
