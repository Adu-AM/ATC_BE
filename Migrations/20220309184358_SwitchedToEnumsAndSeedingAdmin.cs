using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ATC_BE.Migrations
{
    public partial class SwitchedToEnumsAndSeedingAdmin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "25559cf8-2ca0-4b14-b62c-2eb496f42bdf");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "61797990-5498-4852-b809-f53ea8481fce");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "67de9f89-7d88-41bc-8d03-0ceb70eea9d5");

            migrationBuilder.AlterColumn<string>(
                name: "Role",
                table: "UserDetails",
                type: "nvarchar(24)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Gender",
                table: "UserDetails",
                type: "nvarchar(24)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "AccountStatus",
                table: "UserDetails",
                type: "nvarchar(24)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<int>(
                name: "Role",
                table: "UserDetails",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(24)");

            migrationBuilder.AlterColumn<string>(
                name: "Gender",
                table: "UserDetails",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(24)");

            migrationBuilder.AlterColumn<string>(
                name: "AccountStatus",
                table: "UserDetails",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(24)");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "25559cf8-2ca0-4b14-b62c-2eb496f42bdf", "79e968c9-2465-49de-9925-dd488ef12598", "Administrator", null });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "61797990-5498-4852-b809-f53ea8481fce", "69fd5182-a585-4051-98a1-113174ffc47e", "OfficeAdministrator", null });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "67de9f89-7d88-41bc-8d03-0ceb70eea9d5", "148b401c-b654-4008-b19d-89e15e497876", "Employee", null });
        }
    }
}
