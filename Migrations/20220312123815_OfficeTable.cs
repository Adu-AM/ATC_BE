using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ATC_BE.Migrations
{
    public partial class OfficeTable : Migration
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OfficeModels");

            migrationBuilder.RenameColumn(
                name: "BuildingId",
                table: "BuildingModels",
                newName: "Id");
        }
    }
}
