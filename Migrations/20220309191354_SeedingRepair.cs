using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ATC_BE.Migrations
{
    public partial class SeedingRepair : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "50bfdc91-e65b-4a14-8203-e481e4923e1f",
                column: "ConcurrencyStamp",
                value: "50bfdc91-e65b-4a14-8203-e481e4923e1f");

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
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp", "UserName" },
                values: new object[] { "1", "1", "admin@example.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "50bfdc91-e65b-4a14-8203-e481e4923e1f",
                column: "ConcurrencyStamp",
                value: "43acb671-7998-4bf4-a1ba-538553ab0bdb");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "66634b0a-3d68-45f4-9c7d-2c20549494db",
                column: "ConcurrencyStamp",
                value: "fa04583b-2585-466b-9a83-8112d7c9c208");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d402aa31-f7eb-4b8a-9562-5488626cede8",
                column: "ConcurrencyStamp",
                value: "e512da51-08b2-4f28-a7fb-34cd0d8370ef");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp", "UserName" },
                values: new object[] { "f8efd812-68c2-4405-8dc5-5c5902c51b12", "a66717d3-56e4-4da6-a9e4-83fe868b7ef4", "admin" });
        }
    }
}
