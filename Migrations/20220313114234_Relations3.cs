using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ATC_BE.Migrations
{
    public partial class Relations3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserDetails_DeskModels_DeskId",
                table: "UserDetails");

            migrationBuilder.DropIndex(
                name: "IX_UserDetails_DeskId",
                table: "UserDetails");

            migrationBuilder.DropColumn(
                name: "DeskId",
                table: "UserDetails");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "DeskModels",
                type: "nvarchar(100)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "19dfd7a7-4051-4c46-a4f8-4244a2d560c4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "21306d9a-71e9-4db6-aa0e-744a3c51e664");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "3ecc3a0c-f25b-42cb-9cdb-f0948a4d0139");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "900724ec-be49-4933-ab1d-ec8bea8436e5", "AQAAAAEAACcQAAAAEIrueJnyA+2mLN2tqgiIoC6wF1iY5yGxUlBs09BxbLkys6w/kJ/OO75PMDPwkVYZAA==", "07879b97-fa65-49bd-8ddf-01a0a2b979e2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "716ebf75-e8b9-44a3-9a04-74825b20a37f", "AQAAAAEAACcQAAAAEJiIJhsGwL0+xVGZilKGTITWM9DdeTLd97gJXx8BBzr3tT7g9S8uQa/6WGwL1qzkww==", "cb0e090d-79d6-4431-bf41-5e53e9aa0e29" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "422368bc-5b4b-4d12-b26c-df5ebd01df1c", "AQAAAAEAACcQAAAAEGzfRs2IgG0K1lbHpCwQYphJojOHLUGpjMmX2BzVw7+ZDLvYKcrZLlAJSpUq40kg4w==", "d803ea52-4ae3-4c6f-a617-791c0e752f3d" });

            migrationBuilder.CreateIndex(
                name: "IX_DeskModels_UserId",
                table: "DeskModels",
                column: "UserId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_DeskModels_UserDetails_UserId",
                table: "DeskModels",
                column: "UserId",
                principalTable: "UserDetails",
                principalColumn: "Email",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DeskModels_UserDetails_UserId",
                table: "DeskModels");

            migrationBuilder.DropIndex(
                name: "IX_DeskModels_UserId",
                table: "DeskModels");

            migrationBuilder.AddColumn<int>(
                name: "DeskId",
                table: "UserDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "DeskModels",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)");

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

            migrationBuilder.AddForeignKey(
                name: "FK_UserDetails_DeskModels_DeskId",
                table: "UserDetails",
                column: "DeskId",
                principalTable: "DeskModels",
                principalColumn: "DeskId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
