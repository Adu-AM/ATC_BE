using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ATC_BE.Migrations
{
    public partial class CorrectDataFormat : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "87c4f981-bdc5-4550-9c7b-d001f2fafa1c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "e393862d-b429-4235-962c-36e0b92b1c65");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "58cc7011-f9e2-402a-aec5-e00a2eea7724");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "edddcc1f-e34f-4178-b9ac-aacdfbf5f5c7", "AQAAAAEAACcQAAAAECVmLSmPpM2c/Rsq07St+neVMsI6/WTsFRCfmLEAHRmdidRyGhEvFE9hBAHjyYExoA==", "c7687b69-822b-4f5c-a981-b41a93c81300" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "ff2c4a06-8003-406d-982b-6e5a3c7159a8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "1b804f8e-fa40-4204-b3fd-a88881d19a16");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "29fa0ae0-8728-46eb-b4e0-12b7d0c50113");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9794417e-6c09-49ce-8ae9-54dfd2d33c17", "AQAAAAEAACcQAAAAEIwg5faCcyF1Z4VSgEELz9lVSM5cLbAybONLpdfOMJaUJvIMUZCr//RIw6NTFpzmNg==", "5c315ce1-48e2-41ef-a42f-cdc9d8d2c9bd" });
        }
    }
}
