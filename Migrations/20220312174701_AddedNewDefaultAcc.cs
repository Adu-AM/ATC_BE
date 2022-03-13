using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ATC_BE.Migrations
{
    public partial class AddedNewDefaultAcc : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "2", 0, "c657da59-88c6-4d14-a41f-125ed46cb710", null, false, false, null, null, "OFFICE@EXAMPLE.COM", "AQAAAAEAACcQAAAAEPDC4B0/HhIIxsfNXBwg5lTvTeg6pxq8lYEiFsEfRshtXrx5qPw5JT96bobkuWivHA==", null, false, "f54e1502-7d19-4fff-bf4e-23db458f0a45", false, "office@example.com" },
                    { "3", 0, "48798ce0-ddcd-468b-b81a-42f6e0cb4a80", null, false, false, null, null, "EMP@EXAMPLE.COM", "AQAAAAEAACcQAAAAENqOJxuOPhfuYDijwVlhaRrkAV3/BivCx0K/h+GozB7lNDr9sh3ItyYHxD5pRtDmMg==", null, false, "770c076a-3c40-40b6-beed-6d5637e71ecc", false, "emp@example.com" }
                });

            migrationBuilder.InsertData(
                table: "UserDetails",
                columns: new[] { "Email", "AccountId", "AccountStatus", "BirthDate", "FirstName", "Gender", "LastName", "Nationality", "RemotePercentage", "Role" },
                values: new object[,]
                {
                    { "emp@example.com", "3", "Active", new DateTime(1995, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jim", "Male", "Nim", "British", 0, "Employee" },
                    { "office@example.com", "2", "Active", new DateTime(1997, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mara", "Female", "Ciun", "Swedish", 0, "OfficeAdministrator" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "2", "2" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "3", "3" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "2" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "3" });

            migrationBuilder.DeleteData(
                table: "UserDetails",
                keyColumn: "Email",
                keyValue: "emp@example.com");

            migrationBuilder.DeleteData(
                table: "UserDetails",
                keyColumn: "Email",
                keyValue: "office@example.com");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "47fb0ef7-5261-4c80-8d1c-beea5639efa8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "08da6fc3-91e2-4580-adb9-3092732df663");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "acbd572a-4776-4528-bf39-8cd148a856be");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8109d5e6-319a-4546-83b3-a4db4c568d92", "AQAAAAEAACcQAAAAELgvh75S85x4mwhNzBSo5gXVQhFIRdMJ+HKwK6Y9Ompn/85xIeL0pkT4DFcrMI65UA==", "ba0ef7f3-dd71-4882-ad03-a649dc3999ec" });
        }
    }
}
