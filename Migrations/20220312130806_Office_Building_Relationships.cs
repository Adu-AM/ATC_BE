using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ATC_BE.Migrations
{
    public partial class Office_Building_Relationships : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BuildingId",
                table: "OfficeModels",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OfficeModels_BuildingModels_BuildingId",
                table: "OfficeModels");

            migrationBuilder.DropIndex(
                name: "IX_OfficeModels_BuildingId",
                table: "OfficeModels");

            migrationBuilder.DropColumn(
                name: "BuildingId",
                table: "OfficeModels");
        }
    }
}
