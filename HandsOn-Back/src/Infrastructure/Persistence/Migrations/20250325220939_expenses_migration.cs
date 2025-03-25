using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class expenses_migration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5c993674-ce73-40b4-9d33-e85e9dd4f764"), new Guid("139c5a5b-5641-4cbe-8c14-9f013df653dd") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("16ccaa4e-932b-4d92-96f7-bb10f2ae9fd0"), new Guid("2b1fb1e2-acb7-4c05-9ebc-b05744b72671") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("d447f5cd-205d-4801-9ffb-af015e9efd50"), new Guid("c7fcf567-36d2-4543-9fdf-6d0a72c2bf44") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("64a97d03-122c-4ba3-8e77-f3c490ab3fa4"), new Guid("f4478a21-9d50-45b5-9925-c76be1d763b8") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("bcee080b-95a7-443a-be5f-c680f939fb1d"), new Guid("fe4ac4ea-6e24-42f9-9886-4c21229ec5ef") });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("16ccaa4e-932b-4d92-96f7-bb10f2ae9fd0"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("5c993674-ce73-40b4-9d33-e85e9dd4f764"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("64a97d03-122c-4ba3-8e77-f3c490ab3fa4"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("bcee080b-95a7-443a-be5f-c680f939fb1d"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("d447f5cd-205d-4801-9ffb-af015e9efd50"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("139c5a5b-5641-4cbe-8c14-9f013df653dd"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2b1fb1e2-acb7-4c05-9ebc-b05744b72671"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c7fcf567-36d2-4543-9fdf-6d0a72c2bf44"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f4478a21-9d50-45b5-9925-c76be1d763b8"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("fe4ac4ea-6e24-42f9-9886-4c21229ec5ef"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { new Guid("16ccaa4e-932b-4d92-96f7-bb10f2ae9fd0"), "105d8d19-fb87-4232-a2dc-86004880e7fc", "Owner", "OWNER" },
                    { new Guid("5c993674-ce73-40b4-9d33-e85e9dd4f764"), "8d720261-d5c0-4df7-b17f-4091b3a8f65f", "Collaborator", "COLLABORATOR" },
                    { new Guid("64a97d03-122c-4ba3-8e77-f3c490ab3fa4"), "a29cd558-57f6-41da-965a-056da59188b3", "Manager", "MANAGER" },
                    { new Guid("bcee080b-95a7-443a-be5f-c680f939fb1d"), "d0fbcdac-a223-459f-9e8f-ae08f28ec8bc", "Admin", "ADMIN" },
                    { new Guid("d447f5cd-205d-4801-9ffb-af015e9efd50"), "d7340f2c-8c80-4026-b275-ed48bf186fdf", "Consultant", "CONSULTANT" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedAt", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Status", "TwoFactorEnabled", "UpdatedAt", "UserName" },
                values: new object[,]
                {
                    { new Guid("139c5a5b-5641-4cbe-8c14-9f013df653dd"), 0, "6ce0dd6f-d085-485d-8909-9c7aa531f9a8", new DateTime(2025, 3, 24, 11, 44, 51, 656, DateTimeKind.Local).AddTicks(1714), "example5@gmail.com", false, "Charlie", "Smith", false, null, "EXAMPLE5@GMAIL.COM", "CHARLIE", "$2a$11$uS4SBHHEs.mCHgpyqyDj9ORdp4bb42FNzBKypezdy3Ktq2JVB90LO", "(99) 99999-9995", false, "21415a8f-db2a-43e3-aa55-f67cf280734b", 0, false, new DateTime(2025, 3, 24, 11, 44, 51, 656, DateTimeKind.Local).AddTicks(1706), "charlie" },
                    { new Guid("2b1fb1e2-acb7-4c05-9ebc-b05744b72671"), 0, "c68ad15e-798a-4c44-bcfb-2d0b304bce4e", new DateTime(2025, 3, 24, 11, 44, 51, 656, DateTimeKind.Local).AddTicks(1684), "example2@gmail.com", false, "Jane", "Doe", false, null, "EXAMPLE2@GMAIL.COM", "JANE", "$2a$11$TUjz14OFfYbLSlPn4dlEmuUpSqCohPDbwIcp.0SjKeWSK0Y1OEPJe", "(99) 99999-9992", false, "a8a34475-c4ba-42a2-ad87-fde3db958d8e", 0, false, new DateTime(2025, 3, 24, 11, 44, 51, 656, DateTimeKind.Local).AddTicks(1602), "jane" },
                    { new Guid("c7fcf567-36d2-4543-9fdf-6d0a72c2bf44"), 0, "00abc0c6-09fd-47bb-bd2d-874e0b81cd68", new DateTime(2025, 3, 24, 11, 44, 51, 656, DateTimeKind.Local).AddTicks(1695), "example3@gmail.com", false, "Alice", "Anderson", false, null, "EXAMPLE3@GMAIL.COM", "ALICE", "$2a$11$4QCcs9GZxARUwON7msVMJ.0fa7Tqo54ysylhBGPZdQufUh2oy8tu2", "(99) 99999-9993", false, "9af48dbd-1582-44ce-b2ca-0e3b82f33144", 0, false, new DateTime(2025, 3, 24, 11, 44, 51, 656, DateTimeKind.Local).AddTicks(1687), "alice" },
                    { new Guid("f4478a21-9d50-45b5-9925-c76be1d763b8"), 0, "cba041c2-4c06-4ea8-9e4d-8ae3edf43ef6", new DateTime(2025, 3, 24, 11, 44, 51, 656, DateTimeKind.Local).AddTicks(1705), "example4@gmail.com", false, "Bob", "Anderson", false, null, "EXAMPLE4@GMAIL.COM", "BOB", "$2a$11$3z8RTJXFwUTIc9mVLxylIuHRffTXBiiNOMHnh.c/82Uih3PDg4U6a", "(99) 99999-9994", false, "68c27bae-9f3e-4e03-aa91-5412b8d8f9c0", 0, false, new DateTime(2025, 3, 24, 11, 44, 51, 656, DateTimeKind.Local).AddTicks(1696), "bob" },
                    { new Guid("fe4ac4ea-6e24-42f9-9886-4c21229ec5ef"), 0, "322a5ed1-2ba8-4b08-848d-88b655fa1d08", new DateTime(2025, 3, 24, 11, 44, 51, 656, DateTimeKind.Local).AddTicks(726), "example1@gmail.com", false, "John", "Doe", false, null, "EXAMPLE1@GMAIL.COM", "JOHN", "$2a$11$W5JhktQybLMUGsXutHLuuun6.DVqHJiovxrzOnDfdawFUtFIj6nRe", "(99) 99999-9991", false, "cf09f701-5610-4448-bc5b-8cf87700b1ba", 0, false, new DateTime(2025, 3, 24, 11, 44, 51, 655, DateTimeKind.Local).AddTicks(6956), "john" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("5c993674-ce73-40b4-9d33-e85e9dd4f764"), new Guid("139c5a5b-5641-4cbe-8c14-9f013df653dd") },
                    { new Guid("16ccaa4e-932b-4d92-96f7-bb10f2ae9fd0"), new Guid("2b1fb1e2-acb7-4c05-9ebc-b05744b72671") },
                    { new Guid("d447f5cd-205d-4801-9ffb-af015e9efd50"), new Guid("c7fcf567-36d2-4543-9fdf-6d0a72c2bf44") },
                    { new Guid("64a97d03-122c-4ba3-8e77-f3c490ab3fa4"), new Guid("f4478a21-9d50-45b5-9925-c76be1d763b8") },
                    { new Guid("bcee080b-95a7-443a-be5f-c680f939fb1d"), new Guid("fe4ac4ea-6e24-42f9-9886-4c21229ec5ef") }
                });
        }
    }
}
