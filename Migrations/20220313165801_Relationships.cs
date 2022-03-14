using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ATC_BE.Migrations
{
    public partial class Relationships : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "44293ec3-95f2-4e74-a2c9-63281a3faa16");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "11cbb3f9-122a-4216-b782-9e157a8bc808");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "64510ee8-40f5-4d7c-940e-f1311deb867a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "97712b44-a61e-46f9-a61a-369c5ea8949c", "AQAAAAEAACcQAAAAEDYzDmYVbdHSokUyBG2iSC0oeU9/PezXUhHVTxhHwgpqrSg1xe2cMe1sPez2ngSo3g==", "5003dee8-61c4-4fe8-b267-1be2386c9ef9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fde3dfb0-1f75-4e1f-a28a-7ca19e50921d", "AQAAAAEAACcQAAAAEMf5ZLcjeOQ3R1tJ8hZYpcEEjsmdhkka9FDYZSb82ZjzKs6ad5zX7mIwucHvU7/aPA==", "1f4642bf-5c3c-4c18-bf1f-e97aa3796fe7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "21a00fea-bf5e-4f13-be30-188c9a265ded", "AQAAAAEAACcQAAAAEF08xOCLZdR3Ls5YOj7XLi+HJCp/lJDsS/tiH5x9JJJTbX4/K7L9w5E+dLhSgm9xGA==", "68ee0b70-11db-4a93-8bbb-d31a3239e337" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "a5ed8d34-9912-4eb8-9fff-dda432d86c4c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "cf4c1ede-bd9d-43ea-944f-100e33f85237");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "801d4760-b112-4df9-b550-ff2263317610");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8ff38298-0dc0-4651-b026-2d293a3f1d7c", "AQAAAAEAACcQAAAAEHdj+fALVYkY3Qp5BpjZN2Vj8snl0WiIyChhFG0seLUoO838BFs/aWZRnAKuujE8mw==", "ce66ff1d-5c9c-4723-8efa-0aec4c407bd3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ed424fbc-b15f-48a5-9354-23bd2c9b04e3", "AQAAAAEAACcQAAAAENZpGLdYVNK/Xxa3+FA1gTRFMeJnNGW1MkBi/mX2SKj9/EeHxxtwxo4CH7ArmFL0Xw==", "ee977166-52af-45df-bbcb-8e17f97ad5ab" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "413e3fa4-31cd-44a9-8c15-2ff32a1b86d6", "AQAAAAEAACcQAAAAEK7TgOwabaHEON9iU4Dgo929cNs3hkm2S21RAweQ7pBQVlR9WeONf7ZLJ7gQg5ND+g==", "ed049a6b-3788-43a2-bf55-49d975711a6b" });
        }
    }
}
