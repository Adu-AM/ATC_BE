using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ATC_BE.Migrations
{
    public partial class Check2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "437e2fd6-c557-428a-8f92-289ead86052a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "6e46fbe1-628c-4b77-a6c5-c1b57d0a6a01");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "b917b97d-37f6-4fa5-87bd-e3dbd7b908d2");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4759fa71-8e70-45f2-a97a-013bce8fe727", "AQAAAAEAACcQAAAAEGMfnxxicwa0lQo1tq2K7KFWwCQntAdeVO8L4tjMoI37IbdOFZh+IIFx3Fb2p8UGRw==", "a60ed5c4-1595-4fc1-8bf5-71bd6e5ccfe4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b58da4e0-e8bc-494c-a63f-f97d22cc5406", "AQAAAAEAACcQAAAAEE/6XJVFOGD7GS729euf3FerynZG455PdelmqhTnpHVvOLYg+RNBbXEbL4KJzhFztg==", "b4186260-9369-422a-9caf-ac3603c23413" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "675d7e7d-4bb4-47cb-9842-d8f9cecd7c43", "AQAAAAEAACcQAAAAEESn8XMcd2yE5PPHyBbNBLWlXs7157I5WZRYiBt35XQYC5BInoaHJTVZLxMlSj4YuQ==", "0efa4cc6-3156-4126-a15f-8ca457df5430" });
        }
    }
}
