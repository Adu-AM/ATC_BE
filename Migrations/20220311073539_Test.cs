using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ATC_BE.Migrations
{
    public partial class Test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "8aa84143-3ffa-417b-bd41-2c3a98a8d0a1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "d4359ab5-63f4-4269-bce9-88e5b4a9c5e2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "6625cb82-deef-4ba5-8b45-b06e7f2d4845");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a682f4b6-6e1c-4f6e-adf3-f76cd4bf0d13", "AQAAAAEAACcQAAAAEJXBia+tLUTi8ozoL3Pcd5varHx+TIoPu3zY0GV2xEpFuSJnutQI03PJzai0crIYVg==", "08f80b3d-484b-45d3-9175-3e4a49178e57" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "12211fd0-09f0-44c9-904e-dbd46507015c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "7491af0d-1db4-4082-9fad-05565facc3b5");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "338d7f6a-64fa-4696-98fc-9c337b92b1df");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cbc5ad1f-060f-4282-b2f1-d5467c087428", "AQAAAAEAACcQAAAAECx82Kih75g6oBx2Iyqgw3FjKqjrlXG0WiEbfxF+/fVKY5ZT/ioiu6Ut2EWPjJ6n1g==", "eca74196-2743-404f-8ae8-f3dc533e7494" });
        }
    }
}
