using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class expensestable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AlterColumn<string>(
                name: "ReceiptUrl",
                table: "Expenses",
                type: "varchar(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "PaymentMethod",
                table: "Expenses",
                type: "varchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Expenses",
                type: "varchar(300)",
                maxLength: 300,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Category",
                table: "Expenses",
                type: "varchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<decimal>(
                name: "Amount",
                table: "Expenses",
                type: "decimal(65,30)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("29651126-abd8-4d3e-a7cd-17b048afce14"), "f24f08c5-0d3c-4213-b97c-32019c286d4f", "Admin", "ADMIN" },
                    { new Guid("29e36733-6a06-4227-b4f4-d7ba9dac4948"), "92eb3f49-b91a-47d7-81c0-da867d86a5a0", "Collaborator", "COLLABORATOR" },
                    { new Guid("7f9c486a-3ad0-4767-bbfe-e07e1abb261c"), "e9da1ae4-b990-4dfd-9b15-af52e1f41a4d", "Consultant", "CONSULTANT" },
                    { new Guid("e7e9fb45-d3e7-4168-8c40-9cf32c3a94fd"), "67989dcf-0583-4f4f-bbd9-70d3df62d64f", "Manager", "MANAGER" },
                    { new Guid("f29997f7-9012-4911-ba5e-b9ff340d4744"), "e61378c3-180d-4ac4-84c2-4a4a68d6d936", "Owner", "OWNER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedAt", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Status", "TwoFactorEnabled", "UpdatedAt", "UserName" },
                values: new object[,]
                {
                    { new Guid("520c70e2-b23a-4bf9-9010-09f39bef75af"), 0, "c3432570-a8fe-4e14-a5e6-7f3246141cfe", new DateTime(2025, 3, 26, 18, 12, 39, 769, DateTimeKind.Local).AddTicks(2588), "example4@gmail.com", false, "Bob", "Anderson", false, null, "EXAMPLE4@GMAIL.COM", "BOB", "$2a$11$WmMZe8Ms4GTbfElNJZPTn.nYL0jlQm7cZXZrSKTYvMdwPUwzkm3Zy", "(99) 99999-9994", false, "750bbd56-047e-4c06-81f7-1153f9722b57", 0, false, new DateTime(2025, 3, 26, 18, 12, 39, 769, DateTimeKind.Local).AddTicks(2580), "bob" },
                    { new Guid("53c96ae5-918e-4b76-a0aa-c20b5f39d37f"), 0, "0a6a9c5b-8e4d-473d-a384-45dd24e167e0", new DateTime(2025, 3, 26, 18, 12, 39, 769, DateTimeKind.Local).AddTicks(2111), "example1@gmail.com", false, "John", "Doe", false, null, "EXAMPLE1@GMAIL.COM", "JOHN", "$2a$11$3Bd30jkivY/JWqeeO1LQCuIac3am9Gz.f0EIF91ShSzqWpC.YS01i", "(99) 99999-9991", false, "328ce069-7de9-4992-bfd1-5b157961cb45", 0, false, new DateTime(2025, 3, 26, 18, 12, 39, 768, DateTimeKind.Local).AddTicks(9064), "john" },
                    { new Guid("8041f724-0581-4015-9608-25f1a77a25b1"), 0, "fca254a4-4062-4d33-8630-a59581d4ac56", new DateTime(2025, 3, 26, 18, 12, 39, 769, DateTimeKind.Local).AddTicks(2597), "example5@gmail.com", false, "Charlie", "Smith", false, null, "EXAMPLE5@GMAIL.COM", "CHARLIE", "$2a$11$Vrlkhejwwgi9YKEQKpggU.gybXVLTCjpzqJf4cj9.pl28eGO.Ie1S", "(99) 99999-9995", false, "9eab1ca8-016e-491e-bee6-3ccc1270c460", 0, false, new DateTime(2025, 3, 26, 18, 12, 39, 769, DateTimeKind.Local).AddTicks(2590), "charlie" },
                    { new Guid("90493017-40ce-442d-995e-5fbe0d7924d7"), 0, "2471ba6a-5890-4c37-8e5f-b2931dc28531", new DateTime(2025, 3, 26, 18, 12, 39, 769, DateTimeKind.Local).AddTicks(2578), "example3@gmail.com", false, "Alice", "Anderson", false, null, "EXAMPLE3@GMAIL.COM", "ALICE", "$2a$11$/q0p36/QNtB1Iu77YYEKTudCOglRF.DkUrGErKXlzXISJ.McEONye", "(99) 99999-9993", false, "c0416f2b-834f-4093-aa84-f16b1e98b0ae", 0, false, new DateTime(2025, 3, 26, 18, 12, 39, 769, DateTimeKind.Local).AddTicks(2568), "alice" },
                    { new Guid("f0e8f00b-a064-48f9-baf2-e829c6c0c160"), 0, "5c0e1491-370a-481d-8b3a-09d32c20b785", new DateTime(2025, 3, 26, 18, 12, 39, 769, DateTimeKind.Local).AddTicks(2564), "example2@gmail.com", false, "Jane", "Doe", false, null, "EXAMPLE2@GMAIL.COM", "JANE", "$2a$11$3zYfbbaMPGX/1GP1fjV4se45.vlk.CUmVtftZOPRYTb4AdqaXBAyS", "(99) 99999-9992", false, "f727dade-3ef1-4da8-986c-42fc3398b126", 0, false, new DateTime(2025, 3, 26, 18, 12, 39, 769, DateTimeKind.Local).AddTicks(2510), "jane" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("e7e9fb45-d3e7-4168-8c40-9cf32c3a94fd"), new Guid("520c70e2-b23a-4bf9-9010-09f39bef75af") },
                    { new Guid("29651126-abd8-4d3e-a7cd-17b048afce14"), new Guid("53c96ae5-918e-4b76-a0aa-c20b5f39d37f") },
                    { new Guid("29e36733-6a06-4227-b4f4-d7ba9dac4948"), new Guid("8041f724-0581-4015-9608-25f1a77a25b1") },
                    { new Guid("7f9c486a-3ad0-4767-bbfe-e07e1abb261c"), new Guid("90493017-40ce-442d-995e-5fbe0d7924d7") },
                    { new Guid("f29997f7-9012-4911-ba5e-b9ff340d4744"), new Guid("f0e8f00b-a064-48f9-baf2-e829c6c0c160") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("e7e9fb45-d3e7-4168-8c40-9cf32c3a94fd"), new Guid("520c70e2-b23a-4bf9-9010-09f39bef75af") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("29651126-abd8-4d3e-a7cd-17b048afce14"), new Guid("53c96ae5-918e-4b76-a0aa-c20b5f39d37f") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("29e36733-6a06-4227-b4f4-d7ba9dac4948"), new Guid("8041f724-0581-4015-9608-25f1a77a25b1") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("7f9c486a-3ad0-4767-bbfe-e07e1abb261c"), new Guid("90493017-40ce-442d-995e-5fbe0d7924d7") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("f29997f7-9012-4911-ba5e-b9ff340d4744"), new Guid("f0e8f00b-a064-48f9-baf2-e829c6c0c160") });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("29651126-abd8-4d3e-a7cd-17b048afce14"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("29e36733-6a06-4227-b4f4-d7ba9dac4948"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("7f9c486a-3ad0-4767-bbfe-e07e1abb261c"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("e7e9fb45-d3e7-4168-8c40-9cf32c3a94fd"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("f29997f7-9012-4911-ba5e-b9ff340d4744"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("520c70e2-b23a-4bf9-9010-09f39bef75af"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("53c96ae5-918e-4b76-a0aa-c20b5f39d37f"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8041f724-0581-4015-9608-25f1a77a25b1"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("90493017-40ce-442d-995e-5fbe0d7924d7"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f0e8f00b-a064-48f9-baf2-e829c6c0c160"));

            migrationBuilder.AlterColumn<string>(
                name: "ReceiptUrl",
                table: "Expenses",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(500)",
                oldMaxLength: 500,
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "PaymentMethod",
                table: "Expenses",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldMaxLength: 50,
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Description",
                keyValue: null,
                column: "Description",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Expenses",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(300)",
                oldMaxLength: 300,
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Category",
                table: "Expenses",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldMaxLength: 50)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<decimal>(
                name: "Amount",
                table: "Expenses",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(65,30)");

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
        }
    }
}
