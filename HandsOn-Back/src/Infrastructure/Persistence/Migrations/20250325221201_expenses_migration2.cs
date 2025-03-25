using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class expenses_migration2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("bc682e45-ddc0-41cd-81b0-b62f0d7f9f98"), new Guid("2679a06c-fcba-4481-ac9a-36471c9e0e40") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("95b614ae-bed8-44c0-80a5-8eacd9086e06"), new Guid("4be2d102-fed7-4f6a-b3af-1ca0972d4a97") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("24a89079-3731-4573-9894-d804961bad38"), new Guid("4c376a57-0ce3-4f94-9820-34251e15068e") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("2eec17cc-3f4e-4cd2-a4bd-31cf18d0ea6d"), new Guid("4ec12886-c392-4de3-b4db-346618f7d528") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("953a2c1a-040d-4ac8-a91e-82b446765262"), new Guid("ee75e57c-4a21-433c-97e0-cf9eca546a46") });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("24a89079-3731-4573-9894-d804961bad38"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("2eec17cc-3f4e-4cd2-a4bd-31cf18d0ea6d"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("953a2c1a-040d-4ac8-a91e-82b446765262"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("95b614ae-bed8-44c0-80a5-8eacd9086e06"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("bc682e45-ddc0-41cd-81b0-b62f0d7f9f98"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2679a06c-fcba-4481-ac9a-36471c9e0e40"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4be2d102-fed7-4f6a-b3af-1ca0972d4a97"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4c376a57-0ce3-4f94-9820-34251e15068e"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4ec12886-c392-4de3-b4db-346618f7d528"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ee75e57c-4a21-433c-97e0-cf9eca546a46"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("24a89079-3731-4573-9894-d804961bad38"), "3b6cf153-2326-4fef-8a53-cadf94f4a392", "Collaborator", "COLLABORATOR" },
                    { new Guid("2eec17cc-3f4e-4cd2-a4bd-31cf18d0ea6d"), "7c4398cd-8b1e-4945-9d42-1d4ec5a07a19", "Owner", "OWNER" },
                    { new Guid("953a2c1a-040d-4ac8-a91e-82b446765262"), "eacdabc3-bad3-4e51-8d30-7240995f5efe", "Consultant", "CONSULTANT" },
                    { new Guid("95b614ae-bed8-44c0-80a5-8eacd9086e06"), "40e9d428-4fc3-4e40-a866-ea952322ee57", "Admin", "ADMIN" },
                    { new Guid("bc682e45-ddc0-41cd-81b0-b62f0d7f9f98"), "33dba1a3-3cda-433b-9312-43f715c03faa", "Manager", "MANAGER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedAt", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Status", "TwoFactorEnabled", "UpdatedAt", "UserName" },
                values: new object[,]
                {
                    { new Guid("2679a06c-fcba-4481-ac9a-36471c9e0e40"), 0, "0ac4d428-c808-4ab3-a477-c9051f2117a5", new DateTime(2025, 3, 25, 19, 9, 37, 844, DateTimeKind.Local).AddTicks(1446), "example4@gmail.com", false, "Bob", "Anderson", false, null, "EXAMPLE4@GMAIL.COM", "BOB", "$2a$11$LGKLt8/fMZampqGk4aLETe9PVu9LMuB8cAeBsIKrnjzle4LfyDk02", "(99) 99999-9994", false, "bc09029c-e37b-4422-b3cb-c07825e3b1bb", 0, false, new DateTime(2025, 3, 25, 19, 9, 37, 844, DateTimeKind.Local).AddTicks(1442), "bob" },
                    { new Guid("4be2d102-fed7-4f6a-b3af-1ca0972d4a97"), 0, "562afbb7-cb2a-445b-9055-94b749d689b6", new DateTime(2025, 3, 25, 19, 9, 37, 844, DateTimeKind.Local).AddTicks(1139), "example1@gmail.com", false, "John", "Doe", false, null, "EXAMPLE1@GMAIL.COM", "JOHN", "$2a$11$IpcmJdczppmT3/FBJYLPTet.8jid.QMjS5N8YroyP3eAoLN.KLzt6", "(99) 99999-9991", false, "c253bb40-e585-409f-a013-9472ec8db20a", 0, false, new DateTime(2025, 3, 25, 19, 9, 37, 843, DateTimeKind.Local).AddTicks(8933), "john" },
                    { new Guid("4c376a57-0ce3-4f94-9820-34251e15068e"), 0, "0437fe72-f93f-457c-8b4f-76fa7104dac1", new DateTime(2025, 3, 25, 19, 9, 37, 844, DateTimeKind.Local).AddTicks(1451), "example5@gmail.com", false, "Charlie", "Smith", false, null, "EXAMPLE5@GMAIL.COM", "CHARLIE", "$2a$11$R0znRfdboZDnjOf4.M1AMeW0Hdm4D.TdoGZlJ61YIv38kL9zR6fD2", "(99) 99999-9995", false, "7ed1eb7b-4e93-4960-96ea-18a961b9f353", 0, false, new DateTime(2025, 3, 25, 19, 9, 37, 844, DateTimeKind.Local).AddTicks(1447), "charlie" },
                    { new Guid("4ec12886-c392-4de3-b4db-346618f7d528"), 0, "a745b05b-5e56-4640-8931-6990fa32327b", new DateTime(2025, 3, 25, 19, 9, 37, 844, DateTimeKind.Local).AddTicks(1431), "example2@gmail.com", false, "Jane", "Doe", false, null, "EXAMPLE2@GMAIL.COM", "JANE", "$2a$11$Q/Yxrxm7xg6ahgEeclMqquvTETyYQTLIilkNSSLM..E05EWA.zksi", "(99) 99999-9992", false, "1d93143b-197e-4b7f-8545-8ced1bb57068", 0, false, new DateTime(2025, 3, 25, 19, 9, 37, 844, DateTimeKind.Local).AddTicks(1411), "jane" },
                    { new Guid("ee75e57c-4a21-433c-97e0-cf9eca546a46"), 0, "b3c210a3-40da-4078-8afa-3effe2e98b15", new DateTime(2025, 3, 25, 19, 9, 37, 844, DateTimeKind.Local).AddTicks(1442), "example3@gmail.com", false, "Alice", "Anderson", false, null, "EXAMPLE3@GMAIL.COM", "ALICE", "$2a$11$ho/9Oisi2tlyNDqm.6EuHugnxHAy0kZzTZDuhU.LWW12U3nmW6aWG", "(99) 99999-9993", false, "a0c73fd9-8cf8-4aa1-837c-e01b19ed880d", 0, false, new DateTime(2025, 3, 25, 19, 9, 37, 844, DateTimeKind.Local).AddTicks(1432), "alice" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("bc682e45-ddc0-41cd-81b0-b62f0d7f9f98"), new Guid("2679a06c-fcba-4481-ac9a-36471c9e0e40") },
                    { new Guid("95b614ae-bed8-44c0-80a5-8eacd9086e06"), new Guid("4be2d102-fed7-4f6a-b3af-1ca0972d4a97") },
                    { new Guid("24a89079-3731-4573-9894-d804961bad38"), new Guid("4c376a57-0ce3-4f94-9820-34251e15068e") },
                    { new Guid("2eec17cc-3f4e-4cd2-a4bd-31cf18d0ea6d"), new Guid("4ec12886-c392-4de3-b4db-346618f7d528") },
                    { new Guid("953a2c1a-040d-4ac8-a91e-82b446765262"), new Guid("ee75e57c-4a21-433c-97e0-cf9eca546a46") }
                });
        }
    }
}
