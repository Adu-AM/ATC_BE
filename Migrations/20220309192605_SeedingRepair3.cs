using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ATC_BE.Migrations
{
    public partial class SeedingRepair3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "033f6165-6597-41fc-92c2-29241b98a55d", "f6c20512-6785-4584-9e6c-a4dea735d1cd" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "532cf651-3490-4af9-bb65-10bf9829c930", "5a49551b-15ed-4773-804c-cd85726ea157" });
        }
    }
}
