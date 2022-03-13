using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ATC_BE.Migrations
{
    public partial class MergedDev : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "BuildingModels",
                newName: "BuildingId");

            migrationBuilder.CreateTable(
                name: "OfficeModels",
                columns: table => new
                {
                    OfficeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BuildingName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Floor = table.Column<int>(type: "int", nullable: false),
                    TotalDeskCount = table.Column<int>(type: "int", nullable: false),
                    UsableDeskCount = table.Column<int>(type: "int", nullable: false),
                    OfficeAdmin = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Width = table.Column<double>(type: "float", nullable: false),
                    Length = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OfficeModels", x => x.OfficeId);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OfficeModels");

            migrationBuilder.RenameColumn(
                name: "BuildingId",
                table: "BuildingModels",
                newName: "Id");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "1b3b2d56-5867-4550-bc12-505b2fc3acec");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "91bc374b-9434-4ebd-9de1-dae29bd850d1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "45cd8882-66a1-4346-9ca1-a3f77f266ff9");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fdab1936-ae28-4ef0-ad66-5d7a0cd6d7a4", "AQAAAAEAACcQAAAAEDURiVOtk8Yl4dvgEtvYQnHN7gE4KOZM5k8RQ35TcKX8rdc/ExVq2Xyjoje4BZYDBg==", "f617d753-314e-4b43-ae50-7d0a62a75e60" });
        }
    }
}
