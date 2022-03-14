using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ATC_BE.Migrations
{
    public partial class Relationships3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DeskModels_OfficeModels_OfficeId",
                table: "DeskModels");

            migrationBuilder.AlterColumn<int>(
                name: "OfficeId",
                table: "DeskModels",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "64c2a1e9-1fa8-43cd-b084-76c9af8705b6");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "920f3cfb-e1af-4248-bf2c-a4c7e5df3fb4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "499358a9-70ba-44f5-8f57-3eb5b3353998");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e9046e60-d70f-4f18-9fac-e88f3d93e21d", "AQAAAAEAACcQAAAAEEA+AaBIEk68S36SIjqws2V8Nh+Ge/FqDM6Fn8dhklOKv/uUFDsHdraHaQZvuYSi1Q==", "50c069d5-9087-4ddf-9961-c0973731c0be" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "78e074d8-2c99-4b14-b1f4-75f794d5c3b9", "AQAAAAEAACcQAAAAEH/Mhn74te2JH0/6LlJ0GlzaoY6oEXsgT547Ig5e44fVtVAmoMkeW/6ubzvA3ne6Eg==", "af2ec338-a827-47df-b5c9-67ab572650d1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3d355855-e4d0-47c4-bfcc-0dbe94def555", "AQAAAAEAACcQAAAAEJ91ogX+H1Neo4jYUFFGh4gp7HT6MDcrp8hu9J1MWhqb1qa1r48EdDqYQjqmIbAf+Q==", "27bc3343-59ef-42e6-8d50-32d76a392174" });

            migrationBuilder.AddForeignKey(
                name: "FK_DeskModels_OfficeModels_OfficeId",
                table: "DeskModels",
                column: "OfficeId",
                principalTable: "OfficeModels",
                principalColumn: "OfficeId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DeskModels_OfficeModels_OfficeId",
                table: "DeskModels");

            migrationBuilder.AlterColumn<int>(
                name: "OfficeId",
                table: "DeskModels",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "4a40afa2-fb90-48ca-b5a9-7338e0113fd5");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "4bd4719a-6f52-4ece-bf04-89873dbdaccf");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "c95bf3a2-94cc-4b66-849d-11b42dec1fdc");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7a24015c-5f65-44d5-8ea7-56f9bf807b93", "AQAAAAEAACcQAAAAEJfbLnZDOBcO1qGBXgq51aZewvWntDLLKepvxRRH8MLpT0Fmc6oAyc4jMVdmojeaNw==", "292a60c4-cac7-43d3-a1ae-e497cf4c08e4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4416bd67-468d-4abc-96d2-1c0dff3fec5c", "AQAAAAEAACcQAAAAECxuqzmtRdGIVL7IxmN3PzUBauhp32RVOJet6sHd+K1ULaYq3AvxAjpFRJcrmxSz5g==", "973d4ecc-4734-49ff-8489-c15c9fd0ad83" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ef0493c8-2e97-47ad-ae43-825858762ac9", "AQAAAAEAACcQAAAAEA4i48odFDCVMTkPEUisnrW6w9ByLapfx1zGo1ZIYxV4ebJwY1JzA2M/zuyvFiAyuA==", "cd9956bc-e568-45e6-89fb-083645513123" });

            migrationBuilder.AddForeignKey(
                name: "FK_DeskModels_OfficeModels_OfficeId",
                table: "DeskModels",
                column: "OfficeId",
                principalTable: "OfficeModels",
                principalColumn: "OfficeId");
        }
    }
}
