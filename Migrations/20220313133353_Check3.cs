using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ATC_BE.Migrations
{
    public partial class Check3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "BuildingModels",
                newName: "BuildingId");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "2bcc3b45-fe18-4ee7-a763-aa3861e2b15c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "89e438df-2604-43c7-8bb5-ff2b3be10626");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "1249dedc-9809-4bf3-b9c8-491cfb637378");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1a913ed6-9b01-4a60-943a-56b4593f2ad2", "AQAAAAEAACcQAAAAEPpV8hatxm/b2q8eycuUAkk1TBj43udSSKsnSEHwJ/JXqETSHef5a1d0vOoAkXdqnQ==", "ff37b931-6580-4696-b2b5-9e29511cda5b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "390c36d5-76d8-4125-9242-175f9f0fdefd", "AQAAAAEAACcQAAAAEEXlmyDbz4ak2g7O+kUxNyaaxhA8iHyj4LhZqVVnKuSSgwTKueky1H7s3BHFmGzbLg==", "44174581-7b53-4f58-8230-c90691439a1f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "30ae3057-abbd-4c02-bdec-aea53ab48044", "AQAAAAEAACcQAAAAEDznMofFbck5Qr4kbkMcTJNkAR9LXRwiIextwqXSjzsBXc4wod7kyHEIAfnhPlHDnQ==", "2f48f2e6-4cf3-48ae-b841-298f67aa04a1" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "BuildingId",
                table: "BuildingModels",
                newName: "Id");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "739c970f-f7d9-4000-a9fd-58c1df12eb3a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "39b2f692-9793-4915-8073-995d91010658");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "d5f848d3-940a-4ad3-842f-dce5f0770a24");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cbdfda4e-83e3-4d79-99ce-524a1ac6f36d", "AQAAAAEAACcQAAAAEMKTDDglOQptCiRT2yzhTTH7DQ0L2lktzmdHwHCtyIr2F4j6migOwVn68WEdGVQu0A==", "200cd348-aa7e-4f85-ad66-645d6271a14a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "319294d1-6127-4967-bd92-3d944d6d191a", "AQAAAAEAACcQAAAAEEfNgxWK4FkPcvUqL4yej6K5sojz3awIWV7gxcB/UA2fm5VZgIb9niy1pASULRe2sQ==", "329d0563-8cbd-4aee-a4f5-e4eae12ec8c9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c11d0540-25e1-4965-af80-7e539b102bc4", "AQAAAAEAACcQAAAAEJ2AtNNwjDI9EBwtX4lXVoR+GHLZyFCjtpYqarBBzZmSHBrvgIeuPk+0tQN+OoyAcg==", "8eda6a30-613a-4e61-8734-21451f6a3093" });
        }
    }
}
