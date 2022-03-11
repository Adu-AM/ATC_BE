using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ATC_BE.Migrations
{
    public partial class RepairDefaultRolesAddedAdmin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1fb15b46-dd16-4c20-bb89-4bfac295fc6c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2f0249a8-6966-49a8-8746-0dc57179d2b0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4df84a4f-5426-4545-ae56-925bed835d7e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6c7ca65a-b9cc-42ed-a74d-c4f875fad672");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "50bfdc91-e65b-4a14-8203-e481e4923e1f", "43acb671-7998-4bf4-a1ba-538553ab0bdb", "Administrator", null },
                    { "66634b0a-3d68-45f4-9c7d-2c20549494db", "fa04583b-2585-466b-9a83-8112d7c9c208", "OfficeAdministrator", null },
                    { "d402aa31-f7eb-4b8a-9562-5488626cede8", "e512da51-08b2-4f28-a7fb-34cd0d8370ef", "Employee", null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "1", 0, "f8efd812-68c2-4405-8dc5-5c5902c51b12", null, false, false, null, null, null, "admin", null, false, "a66717d3-56e4-4da6-a9e4-83fe868b7ef4", false, "admin" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1fb15b46-dd16-4c20-bb89-4bfac295fc6c", "66166c35-c807-4139-be0c-985ad4b82a8e", "Employee", null },
                    { "2f0249a8-6966-49a8-8746-0dc57179d2b0", "613b151a-56f7-4893-834d-a0724b1601c1", "Administrator", null },
                    { "4df84a4f-5426-4545-ae56-925bed835d7e", "dbcdb413-57ea-4836-b9aa-277d32137126", "OfficeAdministrator", null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "6c7ca65a-b9cc-42ed-a74d-c4f875fad672", 0, "dea4964e-d0c7-4479-bf10-b39fa27eb93d", null, false, false, null, null, null, "admin", null, false, "c19551aa-4a1d-4b82-a56c-00e6d5fd2388", false, "admin" });
        }
    }
}
