using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ATC_BE.Migrations
{
    public partial class SeedingRepair6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "50bfdc91-e65b-4a14-8203-e481e4923e1f",
                column: "NormalizedName",
                value: "ADMINISTRATOR");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "66634b0a-3d68-45f4-9c7d-2c20549494db",
                column: "NormalizedName",
                value: "OFFICEADMINISTRATOR");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d402aa31-f7eb-4b8a-9562-5488626cede8",
                column: "NormalizedName",
                value: "EMPLOYEE");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "50bfdc91-e65b-4a14-8203-e481e4923e1f",
                column: "NormalizedUserName",
                value: "ADMIN@EXAMPLE.COM");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "50bfdc91-e65b-4a14-8203-e481e4923e1f",
                column: "NormalizedName",
                value: null);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "66634b0a-3d68-45f4-9c7d-2c20549494db",
                column: "NormalizedName",
                value: null);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d402aa31-f7eb-4b8a-9562-5488626cede8",
                column: "NormalizedName",
                value: null);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "50bfdc91-e65b-4a14-8203-e481e4923e1f",
                column: "NormalizedUserName",
                value: null);
        }
    }
}
