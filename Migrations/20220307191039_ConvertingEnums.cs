using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ATC_BE.Migrations
{
    public partial class ConvertingEnums : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Nationality",
                table: "UserDetails",
                type: "nvarchar(24)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Nationality",
                table: "UserDetails",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(24)",
                oldNullable: true);
        }
    }
}
