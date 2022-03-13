using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ATC_BE.Migrations
{
    public partial class Relations4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DeskModels_UserDetails_UserId",
                table: "DeskModels");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "DeskModels",
                newName: "User_Id");

            migrationBuilder.RenameIndex(
                name: "IX_DeskModels_UserId",
                table: "DeskModels",
                newName: "IX_DeskModels_User_Id");

            migrationBuilder.AddColumn<int>(
                name: "Building_Id",
                table: "OfficeModels",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "b6de9b0c-0ad4-476f-af68-aa8ae95a522e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "2544ce13-e60a-40b3-80e3-a3db71c1b63b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "402fcf65-f02d-437d-b656-8b03666e42ce");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8309c2a2-a1f4-4927-88a6-ca0e0425dbde", "AQAAAAEAACcQAAAAEFa/Yl9JMaWB9tVBNSKzT3qjC/Fhwyb4NvUza4YL9zu0LptIW6ZrvASPoD1IbBOvfA==", "9960bb86-99ca-4451-9da4-d7e8bf87b3f3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "897233f2-3d2d-48ac-a146-25d5807ca1b2", "AQAAAAEAACcQAAAAEMAow089CBpK66EsmNp7i4kzP0zG/ieoyr7rz+B/hNJORQiqcrXJdRH4sWL/BFlTBg==", "c69a963a-ee28-4508-9b8e-2d5ac9cfc721" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5dd35119-7962-4d6f-b018-2c48e5ae3d66", "AQAAAAEAACcQAAAAEMmpOtoxhEwRfkmqm2Lif/F+aX4oNoDfKVXQ27mepxEUyrstGhdy6SlwpbXYp039UQ==", "234ce5ac-17e4-493f-a4f9-0544f1e537a4" });

            migrationBuilder.AddForeignKey(
                name: "FK_DeskModels_UserDetails_User_Id",
                table: "DeskModels",
                column: "User_Id",
                principalTable: "UserDetails",
                principalColumn: "Email",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DeskModels_UserDetails_User_Id",
                table: "DeskModels");

            migrationBuilder.DropColumn(
                name: "Building_Id",
                table: "OfficeModels");

            migrationBuilder.RenameColumn(
                name: "User_Id",
                table: "DeskModels",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_DeskModels_User_Id",
                table: "DeskModels",
                newName: "IX_DeskModels_UserId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_DeskModels_UserDetails_UserId",
                table: "DeskModels",
                column: "UserId",
                principalTable: "UserDetails",
                principalColumn: "Email",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
