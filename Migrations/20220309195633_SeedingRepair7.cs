using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ATC_BE.Migrations
{
    public partial class SeedingRepair7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "50bfdc91-e65b-4a14-8203-e481e4923e1f");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "50bfdc91-e65b-4a14-8203-e481e4923e1g", 0, "50bfdc91-e65b-4a14-8203-e481e4923e1g", null, false, false, null, null, "ADMIN@EXAMPLE.COM", "AQAAAAEAACcQAAAAEL0ufkIoqsp2I0F9ks+Pyt/Eh4QgBvdshod72w/D6FUF7GL3RNq6w5eOJU5u9eMf8w==", null, false, "50bfdc91-e65b-4a14-8203-e481e4923e1g", false, "admin@example.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "50bfdc91-e65b-4a14-8203-e481e4923e1f", "50bfdc91-e65b-4a14-8203-e481e4923e1g" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "50bfdc91-e65b-4a14-8203-e481e4923e1f", "50bfdc91-e65b-4a14-8203-e481e4923e1g" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "50bfdc91-e65b-4a14-8203-e481e4923e1g");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "50bfdc91-e65b-4a14-8203-e481e4923e1f", 0, "50bfdc91-e65b-4a14-8203-e481e4923e1f", null, false, false, null, null, "ADMIN@EXAMPLE.COM", "admin", null, false, "50bfdc91-e65b-4a14-8203-e481e4923e1f", false, "admin@example.com" });
        }
    }
}
