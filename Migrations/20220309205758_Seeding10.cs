using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ATC_BE.Migrations
{
    public partial class Seeding10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "50bfdc91-e65b-4a14-8203-e481e4923e1f",
                columns: new[] { "ConcurrencyStamp", "NormalizedName" },
                values: new object[] { "1feefc17-0e88-409e-8a6a-eef89f9d7cfe", "ADMINISTRATOR" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "66634b0a-3d68-45f4-9c7d-2c20549494db",
                column: "ConcurrencyStamp",
                value: "ecf90e8f-8d85-418b-b173-c1f0c3552211");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d402aa31-f7eb-4b8a-9562-5488626cede8",
                column: "ConcurrencyStamp",
                value: "2c064549-6b83-495f-9361-0071f2871bf8");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4c8455e9-9e16-496d-bcb6-52f41526aa70",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEHQEGmcrGrIEItE5dKG0dj9nUI2jmxg20ya2Uf1Roa9N4T9HpYKiwElF6BljMihIoA==");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "50bfdc91-e65b-4a14-8203-e481e4923e1f",
                columns: new[] { "ConcurrencyStamp", "NormalizedName" },
                values: new object[] { "50bfdc91-e65b-4a14-8203-e481e4923e1f", null });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "66634b0a-3d68-45f4-9c7d-2c20549494db",
                column: "ConcurrencyStamp",
                value: "66634b0a-3d68-45f4-9c7d-2c20549494db");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d402aa31-f7eb-4b8a-9562-5488626cede8",
                column: "ConcurrencyStamp",
                value: "d402aa31-f7eb-4b8a-9562-5488626cede8");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4c8455e9-9e16-496d-bcb6-52f41526aa70",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEH9/379eGLGejnFv/rY2GaUGky1ndSjGd9j9vBJEANgQC6BuQ0+O40hsd3UqtQ7B2A==");
        }
    }
}
