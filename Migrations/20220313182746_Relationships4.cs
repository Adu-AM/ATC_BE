using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ATC_BE.Migrations
{
    public partial class Relationships4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "0c9bd545-c6a0-4b3d-b08a-8a82c5d686a6");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "6a003917-8b10-4496-8454-0bf53fba29e4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "6845018d-60f9-4cd6-8897-3e966a36b897");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8b71ddbd-2633-468b-bc85-133e7cdfb238", "AQAAAAEAACcQAAAAEIZ5ctwxGQ77xyutwaPYioY5td7l4cPBTjIxC2t4LFcTGq04/g2QhNkrdHKBFwvnFw==", "62ef865a-d577-41c4-902c-cbe7696e999e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8d2a436b-5712-4cd2-b9d3-2b461a346d69", "AQAAAAEAACcQAAAAEEBN/gkc0SJ0bAuj0XXnBbtDvlPL5ZE735ohs4THz5ANrbb0llwpPBKs67XvTcXrqg==", "4f3f2aaa-12b7-4ade-937c-7d279c2494fb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "de09390d-f3b9-4c64-9a94-a5c2dde10f2c", "AQAAAAEAACcQAAAAEKuxg0jUi+zdBPVY0v9tcXX5rsxSvJ9nM2TBUSBE2GeAr4GrNoBbF0XK9flK1xuq5w==", "5bdecacc-3d76-4c80-a3e3-16b7435c20bf" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "64c2a1e9-1fa8-43cd-b084-76c9af8705b6");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "920f3cfb-e1af-4248-bf2c-a4c7e5df3fb4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "499358a9-70ba-44f5-8f57-3eb5b3353998");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e9046e60-d70f-4f18-9fac-e88f3d93e21d", "AQAAAAEAACcQAAAAEEA+AaBIEk68S36SIjqws2V8Nh+Ge/FqDM6Fn8dhklOKv/uUFDsHdraHaQZvuYSi1Q==", "50c069d5-9087-4ddf-9961-c0973731c0be" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "78e074d8-2c99-4b14-b1f4-75f794d5c3b9", "AQAAAAEAACcQAAAAEH/Mhn74te2JH0/6LlJ0GlzaoY6oEXsgT547Ig5e44fVtVAmoMkeW/6ubzvA3ne6Eg==", "af2ec338-a827-47df-b5c9-67ab572650d1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3d355855-e4d0-47c4-bfcc-0dbe94def555", "AQAAAAEAACcQAAAAEJ91ogX+H1Neo4jYUFFGh4gp7HT6MDcrp8hu9J1MWhqb1qa1r48EdDqYQjqmIbAf+Q==", "27bc3343-59ef-42e6-8d50-32d76a392174" });
        }
    }
}
