using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ATC_BE.Migrations
{
    public partial class Seeding11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "50bfdc91-e65b-4a14-8203-e481e4923e1f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "66634b0a-3d68-45f4-9c7d-2c20549494db");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d402aa31-f7eb-4b8a-9562-5488626cede8");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1", "58006b58-ac8a-41fc-8797-ac5d5746fded", "Administrator", "ADMINISTRATOR" },
                    { "2", "d86c3e07-2bf7-4d26-a166-c470cb4b022c", "OfficeAdministrator", "OFFICEADMINISTRATOR" },
                    { "3", "8be4419f-ad24-4a34-bb66-6fd55bd35106", "Employee", "EMPLOYEE" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4c8455e9-9e16-496d-bcb6-52f41526aa70",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEOjJyita81pc/vk6nAqRAvqbBnPPBZjXbRMw24hdsMLsx2y1zks9eVIVa9AlS/IcdQ==");

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "1", "4c8455e9-9e16-496d-bcb6-52f41526aa70" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1", "4c8455e9-9e16-496d-bcb6-52f41526aa70" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "50bfdc91-e65b-4a14-8203-e481e4923e1f", "1feefc17-0e88-409e-8a6a-eef89f9d7cfe", "Administrator", "ADMINISTRATOR" },
                    { "66634b0a-3d68-45f4-9c7d-2c20549494db", "ecf90e8f-8d85-418b-b173-c1f0c3552211", "OfficeAdministrator", "OFFICEADMINISTRATOR" },
                    { "d402aa31-f7eb-4b8a-9562-5488626cede8", "2c064549-6b83-495f-9361-0071f2871bf8", "Employee", "EMPLOYEE" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4c8455e9-9e16-496d-bcb6-52f41526aa70",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEHQEGmcrGrIEItE5dKG0dj9nUI2jmxg20ya2Uf1Roa9N4T9HpYKiwElF6BljMihIoA==");
        }
    }
}
