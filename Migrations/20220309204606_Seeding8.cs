using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ATC_BE.Migrations
{
    public partial class Seeding8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "50bfdc91-e65b-4a14-8203-e481e4923e1f", "50bfdc91-e65b-4a14-8203-e481e4923e1g" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "50bfdc91-e65b-4a14-8203-e481e4923e1g");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "50bfdc91-e65b-4a14-8203-e481e4923e1f",
                column: "NormalizedName",
                value: null);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "4c8455e9-9e16-496d-bcb6-52f41526aa70", 0, "fded1e2f-0d27-4aa6-9a87-f419ea33f4d7", null, false, false, null, null, "ADMIN@EXAMPLE.COM", "AQAAAAEAACcQAAAAEH9/379eGLGejnFv/rY2GaUGky1ndSjGd9j9vBJEANgQC6BuQ0+O40hsd3UqtQ7B2A==", null, false, "NYQAOSS7MR6UMXLFFZGLQQ2LRJZYYOIO", false, "admin@example.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4c8455e9-9e16-496d-bcb6-52f41526aa70");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "50bfdc91-e65b-4a14-8203-e481e4923e1f",
                column: "NormalizedName",
                value: "ADMINISTRATOR");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "50bfdc91-e65b-4a14-8203-e481e4923e1g", 0, "50bfdc91-e65b-4a14-8203-e481e4923e1g", null, false, false, null, null, "ADMIN@EXAMPLE.COM", "AQAAAAEAACcQAAAAEL0ufkIoqsp2I0F9ks+Pyt/Eh4QgBvdshod72w/D6FUF7GL3RNq6w5eOJU5u9eMf8w==", null, false, "50bfdc91-e65b-4a14-8203-e481e4923e1g", false, "admin@example.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "50bfdc91-e65b-4a14-8203-e481e4923e1f", "50bfdc91-e65b-4a14-8203-e481e4923e1g" });
        }
    }
}
