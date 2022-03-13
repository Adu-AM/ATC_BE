using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ATC_BE.Migrations
{
    public partial class Relationships : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DeskId",
                table: "UserDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BuildingId",
                table: "OfficeModels",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "DeskModels",
                columns: table => new
                {
                    DeskId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Vacancy = table.Column<string>(type: "nvarchar(24)", nullable: false),
                    Width = table.Column<double>(type: "float", nullable: false),
                    Length = table.Column<double>(type: "float", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeskModels", x => x.DeskId);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "f7a8b9ac-a8b5-4586-9972-9ca91d0fbb94");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "63a85198-2cb5-49c1-b73b-8962a183aacb");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "bf4931e7-bea6-45c5-aeb6-0343ac43c6fb");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4b039024-4c66-4b26-80ea-41b7b3613d9a", "AQAAAAEAACcQAAAAEC8FtSlXaIqJEokxsTfUdGrZ8mJvw3BO7uU2/429FeOilGVDY+IYbjZs3BhnIb1+vw==", "918a5ab8-0a36-47b4-b72e-0ac0ec90719a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3e3b7b91-0b92-4056-92bd-8fffe3e44123", "AQAAAAEAACcQAAAAEJ+f6Mzd6O7zF0GVXo8w5uRwQHNfKa0zPzUsf5+9e7BuGxp/zj+oZ8fipaYLO85sPQ==", "f20fd8e5-7bae-4592-8010-a2270fe65934" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2a879a57-10d6-477e-9b8d-97fea0469587", "AQAAAAEAACcQAAAAEN1JcmUUA9RN4sNQBGvw+6jaxxRqU0/SCiuCGDB9f1cOt84MA8HFV9/Y4EH01ZP1Zg==", "7857604e-1730-4326-ad72-f3296b52fd5f" });

            migrationBuilder.CreateIndex(
                name: "IX_UserDetails_DeskId",
                table: "UserDetails",
                column: "DeskId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_OfficeModels_BuildingId",
                table: "OfficeModels",
                column: "BuildingId");

            migrationBuilder.AddForeignKey(
                name: "FK_OfficeModels_BuildingModels_BuildingId",
                table: "OfficeModels",
                column: "BuildingId",
                principalTable: "BuildingModels",
                principalColumn: "BuildingId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserDetails_DeskModels_DeskId",
                table: "UserDetails",
                column: "DeskId",
                principalTable: "DeskModels",
                principalColumn: "DeskId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OfficeModels_BuildingModels_BuildingId",
                table: "OfficeModels");

            migrationBuilder.DropForeignKey(
                name: "FK_UserDetails_DeskModels_DeskId",
                table: "UserDetails");

            migrationBuilder.DropTable(
                name: "DeskModels");

            migrationBuilder.DropIndex(
                name: "IX_UserDetails_DeskId",
                table: "UserDetails");

            migrationBuilder.DropIndex(
                name: "IX_OfficeModels_BuildingId",
                table: "OfficeModels");

            migrationBuilder.DropColumn(
                name: "DeskId",
                table: "UserDetails");

            migrationBuilder.DropColumn(
                name: "BuildingId",
                table: "OfficeModels");

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7de5ca19-fa70-4de2-838c-142a2ad71685", "AQAAAAEAACcQAAAAEGROVwhBq6X3TIEtMBVXIbxY+u1A/ac6az6XkZTYVNUr3F3Ar7n+hPFMfEOlUCo2TQ==", "46ffa960-7d35-4768-8721-1426bb44d356" });
        }
    }
}
