using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ATC_BE.Migrations
{
    public partial class SeedingAdmin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1", "4c8455e9-9e16-496d-bcb6-52f41526aa70" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4c8455e9-9e16-496d-bcb6-52f41526aa70");

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

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "1", 0, "07dd571e-70f5-40c9-8fb5-8dfe33fc3eac", null, false, false, null, null, "ADMIN@EXAMPLE.COM", "AQAAAAEAACcQAAAAEGqsaj1eLugaarBdUV65DhqsCc1P8hKQiV020Rh9mCgunHpt2J1AZTHLXAgCah5ePQ==", null, false, "478bfbbc-3cf0-47e7-980c-0d4c3c10ef87", false, "admin@example.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "1", "1" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "58006b58-ac8a-41fc-8797-ac5d5746fded");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "d86c3e07-2bf7-4d26-a166-c470cb4b022c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "8be4419f-ad24-4a34-bb66-6fd55bd35106");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "4c8455e9-9e16-496d-bcb6-52f41526aa70", 0, "fded1e2f-0d27-4aa6-9a87-f419ea33f4d7", null, false, false, null, null, "ADMIN@EXAMPLE.COM", "AQAAAAEAACcQAAAAEOjJyita81pc/vk6nAqRAvqbBnPPBZjXbRMw24hdsMLsx2y1zks9eVIVa9AlS/IcdQ==", null, false, "NYQAOSS7MR6UMXLFFZGLQQ2LRJZYYOIO", false, "admin@example.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "1", "4c8455e9-9e16-496d-bcb6-52f41526aa70" });
        }
    }
}
