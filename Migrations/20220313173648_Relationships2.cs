using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ATC_BE.Migrations
{
    public partial class Relationships2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Building_Id",
                table: "OfficeModels");

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                value: "adaf031e-edc7-4148-806f-4b668e414677");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "483e76af-c192-428c-8963-f7612460898c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "228c5804-9e37-408e-9b14-f85ea597ed16");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4f446939-f57c-4a58-8473-4c01daa58598", "AQAAAAEAACcQAAAAENpSFoflcZNMg/O6BXrOsAjcJv0BmyE5kYnQpM/NME6Nr4b/deJIgHbOetYBo2IaqQ==", "5525995f-6240-416a-b417-7a700cafa3f1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "44804465-8514-45b1-baf2-b3905ca687f3", "AQAAAAEAACcQAAAAEL37YEMbifWvpwkt1tJapPuDJxJaMLzHU6W8atV3lYnMB3r/QmIIxAdGWWoXQKd4dQ==", "30b5ac1b-df53-493c-ae84-3f748ae79bba" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1410f163-85b4-4c7e-a3c3-84f70602cb90", "AQAAAAEAACcQAAAAEEg72JOLbvkaoma+oXDSnDAAeZD8NIW4HLJgGiWvbn32rt4Q3ivh/wWDpVekuwh9kw==", "b59eafc6-42d2-4d10-8398-50765c3d09d4" });
        }
    }
}
