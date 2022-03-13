using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ATC_BE.Migrations
{
    public partial class Relations5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OfficeModels");

            migrationBuilder.DropTable(
                name: "BuildingModels");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "014e8112-a321-45d6-acdd-de832a1e9611");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "82a39fb5-852a-4b82-934f-c73a036b1fb7");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "5ad03ab6-cebe-4514-be92-303200d13c30");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8e6c66e2-6f80-4bfc-9576-ad9037917f31", "AQAAAAEAACcQAAAAEICf/PL8e+R+21yAiqIwgEFl9XqiLIMwiebyETYHFpb3NwHS/oh7btjUiqc479cCUA==", "37725d28-a57d-41e6-bbae-db9025fddd4e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4b59f540-47ac-4fe1-a02d-6de2c1267432", "AQAAAAEAACcQAAAAEFb+yf02b09oDnDKwMgMLXvjQKSrgnUn4mQYEPswk9gMWnQyKBqTlrNtrWxU9J5Yjg==", "56d0a9c2-f96b-4779-b720-91c5c729b9fd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c0f7725c-a683-4987-9b32-952ebcecc3f8", "AQAAAAEAACcQAAAAEHmW98YL/8lD+tL80M2QtH6olwOu/eXw+FjhVm8VwwyOJnyd2LXqkLzWLhaLUlZCQg==", "871eacd9-6d63-4ee1-887e-1c69ddfe7637" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BuildingModels",
                columns: table => new
                {
                    BuildingId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BuildingAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FloorCount = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BuildingModels", x => x.BuildingId);
                });

            migrationBuilder.CreateTable(
                name: "OfficeModels",
                columns: table => new
                {
                    OfficeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BuildingId = table.Column<int>(type: "int", nullable: false),
                    BuildingName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Building_Id = table.Column<int>(type: "int", nullable: false),
                    Floor = table.Column<int>(type: "int", nullable: false),
                    Length = table.Column<double>(type: "float", nullable: false),
                    OfficeAdmin = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TotalDeskCount = table.Column<int>(type: "int", nullable: false),
                    UsableDeskCount = table.Column<int>(type: "int", nullable: false),
                    Width = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OfficeModels", x => x.OfficeId);
                    table.ForeignKey(
                        name: "FK_OfficeModels_BuildingModels_BuildingId",
                        column: x => x.BuildingId,
                        principalTable: "BuildingModels",
                        principalColumn: "BuildingId",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_OfficeModels_BuildingId",
                table: "OfficeModels",
                column: "BuildingId");
        }
    }
}
