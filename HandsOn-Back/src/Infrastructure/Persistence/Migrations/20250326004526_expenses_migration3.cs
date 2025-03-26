using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class expenses_migration3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("994b378e-9c99-4aff-93c1-db11e4d184f5"), new Guid("2c02abc6-bf89-444f-a2b6-aedbe99969f1") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("6ffe939d-efed-4622-be49-17bf42ed46df"), new Guid("700601f6-02a4-47df-b61e-3c3b421132a0") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("20ccf720-2e0b-4793-86f1-2a429f358c5e"), new Guid("cccc7efd-1afd-48f7-bbb0-f455f27b218c") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5ca5093a-7568-46b5-a260-8f29745c29e6"), new Guid("dfedb183-9faa-49a4-aca2-31e6c6b5fd92") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("28e3baea-b553-4817-af44-c6561d2a7546"), new Guid("f55c8197-90cf-4f51-8958-515f204e6ca4") });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("20ccf720-2e0b-4793-86f1-2a429f358c5e"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("28e3baea-b553-4817-af44-c6561d2a7546"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("5ca5093a-7568-46b5-a260-8f29745c29e6"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("6ffe939d-efed-4622-be49-17bf42ed46df"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("994b378e-9c99-4aff-93c1-db11e4d184f5"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2c02abc6-bf89-444f-a2b6-aedbe99969f1"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("700601f6-02a4-47df-b61e-3c3b421132a0"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("cccc7efd-1afd-48f7-bbb0-f455f27b218c"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("dfedb183-9faa-49a4-aca2-31e6c6b5fd92"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f55c8197-90cf-4f51-8958-515f204e6ca4"));

            migrationBuilder.CreateTable(
                name: "Expenses",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Description = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Category = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UserId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    PaymentMethod = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ReceiptUrl = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Expenses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Expenses_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("38c74832-b818-4a00-8bb8-292101fdd9c7"), "1dbe8e95-0d5f-4851-8f0b-3ca57f875d3d", "Admin", "ADMIN" },
                    { new Guid("52bda100-6bc7-43a8-b4df-95c7157e781c"), "18b7c1c9-d1b0-4b05-8391-efce2ae7d267", "Owner", "OWNER" },
                    { new Guid("9b079db7-e2b4-4335-a2d8-36401ffe629b"), "6537d6e6-4a08-4c78-a0ab-2c0b4aadc0e0", "Collaborator", "COLLABORATOR" },
                    { new Guid("9e75ee03-e475-419b-bbbf-9a746b2711b1"), "f5c7c96b-0d24-4456-b5bc-1dd0145efaa0", "Manager", "MANAGER" },
                    { new Guid("ed23333b-a9a2-44ca-b346-d3c9623f73a3"), "b019119d-0267-4da8-808d-494fca6c122b", "Consultant", "CONSULTANT" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedAt", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Status", "TwoFactorEnabled", "UpdatedAt", "UserName" },
                values: new object[,]
                {
                    { new Guid("0b3d50f5-8942-4993-8044-d5bdba9ecb5c"), 0, "da4d22ba-dec0-4ae8-8038-0a1333ec48e9", new DateTime(2025, 3, 25, 21, 45, 24, 52, DateTimeKind.Local).AddTicks(7766), "example2@gmail.com", false, "Jane", "Doe", false, null, "EXAMPLE2@GMAIL.COM", "JANE", "$2a$11$Ck0haHQi5aPEYl6CA4U/R.LWAX8bdHiSvib7bCO7xg8RBXVFm3dx2", "(99) 99999-9992", false, "080eda9d-6e5b-49d8-ae21-b134938c22d2", 0, false, new DateTime(2025, 3, 25, 21, 45, 24, 52, DateTimeKind.Local).AddTicks(7728), "jane" },
                    { new Guid("43afce8e-a9ff-4617-beba-ff14df058e27"), 0, "f52308f6-d4e4-440e-8c1e-7a8328282be7", new DateTime(2025, 3, 25, 21, 45, 24, 52, DateTimeKind.Local).AddTicks(7778), "example4@gmail.com", false, "Bob", "Anderson", false, null, "EXAMPLE4@GMAIL.COM", "BOB", "$2a$11$wmslaQYY79nb0c.afYsDk.FyW/GuyXdlUW74563pO1BDYZBuVQwli", "(99) 99999-9994", false, "bef6ae7f-3f9c-4315-a50c-7b3e34a05478", 0, false, new DateTime(2025, 3, 25, 21, 45, 24, 52, DateTimeKind.Local).AddTicks(7773), "bob" },
                    { new Guid("655515eb-ba40-435f-a429-df4626c9aeeb"), 0, "8707c0b8-27eb-48b3-8421-903c22e2177e", new DateTime(2025, 3, 25, 21, 45, 24, 52, DateTimeKind.Local).AddTicks(7772), "example3@gmail.com", false, "Alice", "Anderson", false, null, "EXAMPLE3@GMAIL.COM", "ALICE", "$2a$11$8UWbOcbFW29ocs5W4iGEIeLZvU3W/AIvsjy1xETPTSUuvvdbs/uOO", "(99) 99999-9993", false, "38093889-e0e2-46cf-b00b-aac4e96be9d5", 0, false, new DateTime(2025, 3, 25, 21, 45, 24, 52, DateTimeKind.Local).AddTicks(7767), "alice" },
                    { new Guid("c558b522-92ec-49be-a65e-cac7c006d0d4"), 0, "8ccb7cb4-3856-4fb9-9c36-7a36bae36385", new DateTime(2025, 3, 25, 21, 45, 24, 52, DateTimeKind.Local).AddTicks(7783), "example5@gmail.com", false, "Charlie", "Smith", false, null, "EXAMPLE5@GMAIL.COM", "CHARLIE", "$2a$11$3Di301PKFFuCt6usHrNqLOhuQAvnjOPVBOwwkTnS5UoGQN8wc9Cd2", "(99) 99999-9995", false, "05644c2a-59fe-44b5-a72e-21b95b03f6dd", 0, false, new DateTime(2025, 3, 25, 21, 45, 24, 52, DateTimeKind.Local).AddTicks(7779), "charlie" },
                    { new Guid("cf950794-51c1-41cd-af0d-f65e4f972151"), 0, "2e15e0ee-fa4b-4aaf-a85c-9a6274168a23", new DateTime(2025, 3, 25, 21, 45, 24, 52, DateTimeKind.Local).AddTicks(7386), "example1@gmail.com", false, "John", "Doe", false, null, "EXAMPLE1@GMAIL.COM", "JOHN", "$2a$11$hsqPmooTjP1IhApBy6yUZuKDpODa5NrO2Yl4hU1mEiXLGgGy8p4xu", "(99) 99999-9991", false, "eee7e0e0-5827-4251-8223-29adffbaf31c", 0, false, new DateTime(2025, 3, 25, 21, 45, 24, 52, DateTimeKind.Local).AddTicks(4926), "john" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("52bda100-6bc7-43a8-b4df-95c7157e781c"), new Guid("0b3d50f5-8942-4993-8044-d5bdba9ecb5c") },
                    { new Guid("9e75ee03-e475-419b-bbbf-9a746b2711b1"), new Guid("43afce8e-a9ff-4617-beba-ff14df058e27") },
                    { new Guid("ed23333b-a9a2-44ca-b346-d3c9623f73a3"), new Guid("655515eb-ba40-435f-a429-df4626c9aeeb") },
                    { new Guid("9b079db7-e2b4-4335-a2d8-36401ffe629b"), new Guid("c558b522-92ec-49be-a65e-cac7c006d0d4") },
                    { new Guid("38c74832-b818-4a00-8bb8-292101fdd9c7"), new Guid("cf950794-51c1-41cd-af0d-f65e4f972151") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Expenses_UserId",
                table: "Expenses",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Expenses");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("52bda100-6bc7-43a8-b4df-95c7157e781c"), new Guid("0b3d50f5-8942-4993-8044-d5bdba9ecb5c") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("9e75ee03-e475-419b-bbbf-9a746b2711b1"), new Guid("43afce8e-a9ff-4617-beba-ff14df058e27") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("ed23333b-a9a2-44ca-b346-d3c9623f73a3"), new Guid("655515eb-ba40-435f-a429-df4626c9aeeb") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("9b079db7-e2b4-4335-a2d8-36401ffe629b"), new Guid("c558b522-92ec-49be-a65e-cac7c006d0d4") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("38c74832-b818-4a00-8bb8-292101fdd9c7"), new Guid("cf950794-51c1-41cd-af0d-f65e4f972151") });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("38c74832-b818-4a00-8bb8-292101fdd9c7"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("52bda100-6bc7-43a8-b4df-95c7157e781c"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("9b079db7-e2b4-4335-a2d8-36401ffe629b"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("9e75ee03-e475-419b-bbbf-9a746b2711b1"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("ed23333b-a9a2-44ca-b346-d3c9623f73a3"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("0b3d50f5-8942-4993-8044-d5bdba9ecb5c"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("43afce8e-a9ff-4617-beba-ff14df058e27"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("655515eb-ba40-435f-a429-df4626c9aeeb"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c558b522-92ec-49be-a65e-cac7c006d0d4"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("cf950794-51c1-41cd-af0d-f65e4f972151"));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("20ccf720-2e0b-4793-86f1-2a429f358c5e"), "6070eab0-681e-4ed7-9515-a6dcd17a4f68", "Collaborator", "COLLABORATOR" },
                    { new Guid("28e3baea-b553-4817-af44-c6561d2a7546"), "d432841c-e391-4514-9643-9497dbb3a7dc", "Manager", "MANAGER" },
                    { new Guid("5ca5093a-7568-46b5-a260-8f29745c29e6"), "04da3ff9-55b0-4b9e-bc31-cd1a60798a31", "Consultant", "CONSULTANT" },
                    { new Guid("6ffe939d-efed-4622-be49-17bf42ed46df"), "3ab2a34d-9819-4d76-b621-536196c704bf", "Admin", "ADMIN" },
                    { new Guid("994b378e-9c99-4aff-93c1-db11e4d184f5"), "be999db8-2753-451b-9b9a-f51ea3cf6bbe", "Owner", "OWNER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedAt", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Status", "TwoFactorEnabled", "UpdatedAt", "UserName" },
                values: new object[,]
                {
                    { new Guid("2c02abc6-bf89-444f-a2b6-aedbe99969f1"), 0, "b68bd2b4-a54a-42fa-93a8-68daba2c3a16", new DateTime(2025, 3, 25, 19, 11, 59, 818, DateTimeKind.Local).AddTicks(4684), "example2@gmail.com", false, "Jane", "Doe", false, null, "EXAMPLE2@GMAIL.COM", "JANE", "$2a$11$XSMmHjqjhjSMctv4TixT1OyCfLZUDXQ1.rssxV8AbxGCzK1UfKKp.", "(99) 99999-9992", false, "c65213c0-8f76-46f9-a7e3-5402a646099b", 0, false, new DateTime(2025, 3, 25, 19, 11, 59, 818, DateTimeKind.Local).AddTicks(4655), "jane" },
                    { new Guid("700601f6-02a4-47df-b61e-3c3b421132a0"), 0, "454143f3-12db-4023-bfa7-09d8b879c608", new DateTime(2025, 3, 25, 19, 11, 59, 818, DateTimeKind.Local).AddTicks(4325), "example1@gmail.com", false, "John", "Doe", false, null, "EXAMPLE1@GMAIL.COM", "JOHN", "$2a$11$ZFCGHOJSIWkyUo4QvkmpWuOfV/UZkAibbM8cmo/paN358jTTFfxIi", "(99) 99999-9991", false, "dc67a0cb-d4c4-4bc3-9af0-c68d71b29193", 0, false, new DateTime(2025, 3, 25, 19, 11, 59, 818, DateTimeKind.Local).AddTicks(1987), "john" },
                    { new Guid("cccc7efd-1afd-48f7-bbb0-f455f27b218c"), 0, "78bfdc00-78c9-45fa-8fbe-578bf5c8fe14", new DateTime(2025, 3, 25, 19, 11, 59, 818, DateTimeKind.Local).AddTicks(4713), "example5@gmail.com", false, "Charlie", "Smith", false, null, "EXAMPLE5@GMAIL.COM", "CHARLIE", "$2a$11$LWwI8qjBf8PojZW1x8y/D.BT6xHlndxXrFk9Uhub3zu87ZrkMmGmK", "(99) 99999-9995", false, "c7897793-5d6d-489c-853d-f943302bec5b", 0, false, new DateTime(2025, 3, 25, 19, 11, 59, 818, DateTimeKind.Local).AddTicks(4707), "charlie" },
                    { new Guid("dfedb183-9faa-49a4-aca2-31e6c6b5fd92"), 0, "356d55fa-9bc7-4487-8580-2d9825d3795c", new DateTime(2025, 3, 25, 19, 11, 59, 818, DateTimeKind.Local).AddTicks(4699), "example3@gmail.com", false, "Alice", "Anderson", false, null, "EXAMPLE3@GMAIL.COM", "ALICE", "$2a$11$8n90.286UrWxq6UbxVL/aeaStLENyx8cRLQuzpHs/ctWQVKma/Jv6", "(99) 99999-9993", false, "764e3de2-554d-43d1-a53c-c7293160fa30", 0, false, new DateTime(2025, 3, 25, 19, 11, 59, 818, DateTimeKind.Local).AddTicks(4686), "alice" },
                    { new Guid("f55c8197-90cf-4f51-8958-515f204e6ca4"), 0, "ddfddeef-3b2e-49ae-95e2-b06bc04ae843", new DateTime(2025, 3, 25, 19, 11, 59, 818, DateTimeKind.Local).AddTicks(4706), "example4@gmail.com", false, "Bob", "Anderson", false, null, "EXAMPLE4@GMAIL.COM", "BOB", "$2a$11$.yh64H2pSbUy7qE44xb/B.QHBQmV0EBDR9GJa5Mp9o7OYjFlJ6xHq", "(99) 99999-9994", false, "da4d3cc0-cc55-4a12-a786-817c1951a5a2", 0, false, new DateTime(2025, 3, 25, 19, 11, 59, 818, DateTimeKind.Local).AddTicks(4700), "bob" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("994b378e-9c99-4aff-93c1-db11e4d184f5"), new Guid("2c02abc6-bf89-444f-a2b6-aedbe99969f1") },
                    { new Guid("6ffe939d-efed-4622-be49-17bf42ed46df"), new Guid("700601f6-02a4-47df-b61e-3c3b421132a0") },
                    { new Guid("20ccf720-2e0b-4793-86f1-2a429f358c5e"), new Guid("cccc7efd-1afd-48f7-bbb0-f455f27b218c") },
                    { new Guid("5ca5093a-7568-46b5-a260-8f29745c29e6"), new Guid("dfedb183-9faa-49a4-aca2-31e6c6b5fd92") },
                    { new Guid("28e3baea-b553-4817-af44-c6561d2a7546"), new Guid("f55c8197-90cf-4f51-8958-515f204e6ca4") }
                });
        }
    }
}
