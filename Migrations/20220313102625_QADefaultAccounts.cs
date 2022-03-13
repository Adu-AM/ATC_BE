using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ATC_BE.Migrations
{
    public partial class QADefaultAccounts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserDetails",
                keyColumn: "Email",
                keyValue: "emp@example.com");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "4a8d4ed5-a98c-4ce3-8f6e-1902daaa69f6");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "9dd31667-dd43-40f7-b03a-651d1dca2513");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "433351a0-9e5a-4d13-bfd4-8c93a23eaed0");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "76455ccc-39bf-45d2-8011-f3dc4edbb413", "AQAAAAEAACcQAAAAEKWzgCjo1U3lVIxcQhBV3bVq2lL8RWYyUV+CEmNmpTJGwuTJYVujEnbVHRcYXE/UBA==", "506c491d-5069-4514-9455-ebb2d060f965" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "763113a2-4c76-4200-89b8-1e14296ce384", "AQAAAAEAACcQAAAAENP3xz8mEQb6Kuu1z54m5c3ctdOK0NKNdNWNv6PK8ugzkBYT4ZsUSrvO9UStkaQv6Q==", "6e13fc14-6d80-4eb2-ba9b-def2b583e914" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "7de5ca19-fa70-4de2-838c-142a2ad71685", "EMPLOYEE@EXAMPLE.COM", "AQAAAAEAACcQAAAAEGROVwhBq6X3TIEtMBVXIbxY+u1A/ac6az6XkZTYVNUr3F3Ar7n+hPFMfEOlUCo2TQ==", "46ffa960-7d35-4768-8721-1426bb44d356", "employee@example.com" });

            migrationBuilder.UpdateData(
                table: "UserDetails",
                keyColumn: "Email",
                keyValue: "admin@example.com",
                columns: new[] { "BirthDate", "FirstName", "Gender", "LastName", "RemotePercentage" },
                values: new object[] { new DateTime(1990, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Corina", "Female", "Popescu", 0 });

            migrationBuilder.UpdateData(
                table: "UserDetails",
                keyColumn: "Email",
                keyValue: "office@example.com",
                columns: new[] { "BirthDate", "FirstName", "Gender", "LastName", "Nationality" },
                values: new object[] { new DateTime(1985, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Matei", "Male", "Ionescu", "British" });

            migrationBuilder.InsertData(
                table: "UserDetails",
                columns: new[] { "Email", "AccountId", "AccountStatus", "BirthDate", "FirstName", "Gender", "LastName", "Nationality", "RemotePercentage", "Role" },
                values: new object[] { "employee@example.com", "3", "Active", new DateTime(1995, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mirela", "Female", "Pavaliuc", "Romanian", 0, "Employee" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserDetails",
                keyColumn: "Email",
                keyValue: "employee@example.com");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "dc3be801-6ba8-466d-b1c2-abad42c385f4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "02c882e2-1e87-45ea-bca0-fde1eae586ef");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "4485fc01-d764-4281-978b-db9d7336425e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "818aa683-f807-4dd1-a4ce-65674692c7f4", "AQAAAAEAACcQAAAAELWW0CYDP3VyXMfUTGfdWuCbNLQL24kakPGt2I2ph/aRocQE0Y3rwWE26aWRhEmN7w==", "bd92adac-cbf4-4ec9-89d3-fca080df7135" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c657da59-88c6-4d14-a41f-125ed46cb710", "AQAAAAEAACcQAAAAEPDC4B0/HhIIxsfNXBwg5lTvTeg6pxq8lYEiFsEfRshtXrx5qPw5JT96bobkuWivHA==", "f54e1502-7d19-4fff-bf4e-23db458f0a45" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "48798ce0-ddcd-468b-b81a-42f6e0cb4a80", "EMP@EXAMPLE.COM", "AQAAAAEAACcQAAAAENqOJxuOPhfuYDijwVlhaRrkAV3/BivCx0K/h+GozB7lNDr9sh3ItyYHxD5pRtDmMg==", "770c076a-3c40-40b6-beed-6d5637e71ecc", "emp@example.com" });

            migrationBuilder.UpdateData(
                table: "UserDetails",
                keyColumn: "Email",
                keyValue: "admin@example.com",
                columns: new[] { "BirthDate", "FirstName", "Gender", "LastName", "RemotePercentage" },
                values: new object[] { new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin", "Other", "admin", 100 });

            migrationBuilder.UpdateData(
                table: "UserDetails",
                keyColumn: "Email",
                keyValue: "office@example.com",
                columns: new[] { "BirthDate", "FirstName", "Gender", "LastName", "Nationality" },
                values: new object[] { new DateTime(1997, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mara", "Female", "Ciun", "Swedish" });

            migrationBuilder.InsertData(
                table: "UserDetails",
                columns: new[] { "Email", "AccountId", "AccountStatus", "BirthDate", "FirstName", "Gender", "LastName", "Nationality", "RemotePercentage", "Role" },
                values: new object[] { "emp@example.com", "3", "Active", new DateTime(1995, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jim", "Male", "Nim", "British", 0, "Employee" });
        }
    }
}
