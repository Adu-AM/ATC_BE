using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ATC_BE.Migrations
{
    public partial class SeedingAdminDetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "12211fd0-09f0-44c9-904e-dbd46507015c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "7491af0d-1db4-4082-9fad-05565facc3b5");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "338d7f6a-64fa-4696-98fc-9c337b92b1df");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cbc5ad1f-060f-4282-b2f1-d5467c087428", "AQAAAAEAACcQAAAAECx82Kih75g6oBx2Iyqgw3FjKqjrlXG0WiEbfxF+/fVKY5ZT/ioiu6Ut2EWPjJ6n1g==", "eca74196-2743-404f-8ae8-f3dc533e7494" });

            migrationBuilder.InsertData(
                table: "UserDetails",
                columns: new[] { "Email", "AccountId", "AccountStatus", "BirthDate", "FirstName", "Gender", "LastName", "Nationality", "RemotePercentage", "Role" },
                values: new object[] { "admin@example.com", "1", "Active", new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin", "Other", "admin", "Romanian", 100, "Administrator" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserDetails",
                keyColumn: "Email",
                keyValue: "admin@example.com");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "ddb335e0-2598-4381-a5ae-206c1f91220b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "46423762-d8f2-40e0-b038-4f48c7763360");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "4d0a7030-43c8-448b-89be-8fbf44cf176f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "07dd571e-70f5-40c9-8fb5-8dfe33fc3eac", "AQAAAAEAACcQAAAAEGqsaj1eLugaarBdUV65DhqsCc1P8hKQiV020Rh9mCgunHpt2J1AZTHLXAgCah5ePQ==", "478bfbbc-3cf0-47e7-980c-0d4c3c10ef87" });
        }
    }
}
