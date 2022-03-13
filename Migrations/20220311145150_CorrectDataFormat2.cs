using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ATC_BE.Migrations
{
    public partial class CorrectDataFormat2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "BirthDate",
                table: "UserDetails",
                type: "Date",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "47fb0ef7-5261-4c80-8d1c-beea5639efa8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "08da6fc3-91e2-4580-adb9-3092732df663");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "acbd572a-4776-4528-bf39-8cd148a856be");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8109d5e6-319a-4546-83b3-a4db4c568d92", "AQAAAAEAACcQAAAAELgvh75S85x4mwhNzBSo5gXVQhFIRdMJ+HKwK6Y9Ompn/85xIeL0pkT4DFcrMI65UA==", "ba0ef7f3-dd71-4882-ad03-a649dc3999ec" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "BirthDate",
                table: "UserDetails",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "Date",
                oldNullable: true);

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
    }
}
