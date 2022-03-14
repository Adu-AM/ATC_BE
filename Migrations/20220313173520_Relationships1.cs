using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ATC_BE.Migrations
{
    public partial class Relationships1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "adaf031e-edc7-4148-806f-4b668e414677");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "483e76af-c192-428c-8963-f7612460898c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "228c5804-9e37-408e-9b14-f85ea597ed16");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4f446939-f57c-4a58-8473-4c01daa58598", "AQAAAAEAACcQAAAAENpSFoflcZNMg/O6BXrOsAjcJv0BmyE5kYnQpM/NME6Nr4b/deJIgHbOetYBo2IaqQ==", "5525995f-6240-416a-b417-7a700cafa3f1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "44804465-8514-45b1-baf2-b3905ca687f3", "AQAAAAEAACcQAAAAEL37YEMbifWvpwkt1tJapPuDJxJaMLzHU6W8atV3lYnMB3r/QmIIxAdGWWoXQKd4dQ==", "30b5ac1b-df53-493c-ae84-3f748ae79bba" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1410f163-85b4-4c7e-a3c3-84f70602cb90", "AQAAAAEAACcQAAAAEEg72JOLbvkaoma+oXDSnDAAeZD8NIW4HLJgGiWvbn32rt4Q3ivh/wWDpVekuwh9kw==", "b59eafc6-42d2-4d10-8398-50765c3d09d4" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
