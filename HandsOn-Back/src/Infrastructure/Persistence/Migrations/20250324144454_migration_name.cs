using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class migration_name : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("bebd57ca-374a-4b9a-a4eb-e4666386b606"), new Guid("3d333144-c00a-490f-970c-aa995da67100") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("001496cf-cac1-4343-815c-c929c4b75dc8"), new Guid("51c53d94-1842-47eb-b73c-75b89ec20ff8") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("95fafd63-7c4a-4fc4-89ba-bcc8e6f88dc9"), new Guid("6171d456-d6c7-4914-8b4f-6e76b3782d31") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("3f2027ec-7d81-4bdb-8e2e-b751b69ce66f"), new Guid("875a2dc0-8078-4501-8089-a01a9bcfc850") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("aad68f57-f451-4c3f-9d11-3c8f751e0691"), new Guid("9b133a03-3800-4248-b129-4d74a60d8395") });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("001496cf-cac1-4343-815c-c929c4b75dc8"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("3f2027ec-7d81-4bdb-8e2e-b751b69ce66f"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("95fafd63-7c4a-4fc4-89ba-bcc8e6f88dc9"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("aad68f57-f451-4c3f-9d11-3c8f751e0691"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("bebd57ca-374a-4b9a-a4eb-e4666386b606"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3d333144-c00a-490f-970c-aa995da67100"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("51c53d94-1842-47eb-b73c-75b89ec20ff8"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6171d456-d6c7-4914-8b4f-6e76b3782d31"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("875a2dc0-8078-4501-8089-a01a9bcfc850"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9b133a03-3800-4248-b129-4d74a60d8395"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { new Guid("001496cf-cac1-4343-815c-c929c4b75dc8"), "aa23e890-96a6-4557-82a2-eae8ebade3cb", "Consultant", "CONSULTANT" },
                    { new Guid("3f2027ec-7d81-4bdb-8e2e-b751b69ce66f"), "a06d95f3-9c52-4a39-ad2a-4085ec83e764", "Manager", "MANAGER" },
                    { new Guid("95fafd63-7c4a-4fc4-89ba-bcc8e6f88dc9"), "3d58d68b-3852-40d9-9c40-e0f0565ec68e", "Collaborator", "COLLABORATOR" },
                    { new Guid("aad68f57-f451-4c3f-9d11-3c8f751e0691"), "dbfcf47c-59be-4b08-a9ca-fbbdb18bd6d9", "Owner", "OWNER" },
                    { new Guid("bebd57ca-374a-4b9a-a4eb-e4666386b606"), "431e73e6-5238-4024-8141-5355c5e91d52", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedAt", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Status", "TwoFactorEnabled", "UpdatedAt", "UserName" },
                values: new object[,]
                {
                    { new Guid("3d333144-c00a-490f-970c-aa995da67100"), 0, "db52f37f-924e-42af-ab5f-1bca57412bbd", new DateTime(2025, 3, 14, 13, 58, 51, 117, DateTimeKind.Local).AddTicks(2569), "example1@gmail.com", false, "John", "Doe", false, null, "EXAMPLE1@GMAIL.COM", "JOHN", "$2a$11$.fY72scmAdUZ2leBi5.O/Op2XbpJnFMh2n.LdeoY246Pa6Rt/uDO2", "(99) 99999-9991", false, "7841ebd5-6212-48f6-a6b2-aa472f01ccc2", 0, false, new DateTime(2025, 3, 14, 13, 58, 51, 116, DateTimeKind.Local).AddTicks(9351), "john" },
                    { new Guid("51c53d94-1842-47eb-b73c-75b89ec20ff8"), 0, "5fe5ed19-8167-4b69-b38c-9d8f6a076012", new DateTime(2025, 3, 14, 13, 58, 51, 117, DateTimeKind.Local).AddTicks(3065), "example3@gmail.com", false, "Alice", "Anderson", false, null, "EXAMPLE3@GMAIL.COM", "ALICE", "$2a$11$/e8R1TfwYfT6XsB7Zddmo.KynrAEY.TIrbpjigDGW5FQgvyBM2ptS", "(99) 99999-9993", false, "546d828d-a70e-4012-a6e9-8beac0552599", 0, false, new DateTime(2025, 3, 14, 13, 58, 51, 117, DateTimeKind.Local).AddTicks(3056), "alice" },
                    { new Guid("6171d456-d6c7-4914-8b4f-6e76b3782d31"), 0, "650cce00-1734-4585-bc30-a25474e282a8", new DateTime(2025, 3, 14, 13, 58, 51, 117, DateTimeKind.Local).AddTicks(3087), "example5@gmail.com", false, "Charlie", "Smith", false, null, "EXAMPLE5@GMAIL.COM", "CHARLIE", "$2a$11$B/ngxiWj0FCSa/osLPYBAez8k6ntJjUhNbyAjGcGFUNmr0ak.W8Vm", "(99) 99999-9995", false, "553b8b44-52e4-4f09-99f8-d225f03d3433", 0, false, new DateTime(2025, 3, 14, 13, 58, 51, 117, DateTimeKind.Local).AddTicks(3079), "charlie" },
                    { new Guid("875a2dc0-8078-4501-8089-a01a9bcfc850"), 0, "020c0d83-b132-45e0-bc26-a5b64941d899", new DateTime(2025, 3, 14, 13, 58, 51, 117, DateTimeKind.Local).AddTicks(3075), "example4@gmail.com", false, "Bob", "Anderson", false, null, "EXAMPLE4@GMAIL.COM", "BOB", "$2a$11$27zZAGL4qvzhThokBox8ieggp7l8UGPEu9YpM/4giov2rM33bLA8a", "(99) 99999-9994", false, "b89df511-3e8d-404a-9e1e-e7f7ce66d508", 0, false, new DateTime(2025, 3, 14, 13, 58, 51, 117, DateTimeKind.Local).AddTicks(3067), "bob" },
                    { new Guid("9b133a03-3800-4248-b129-4d74a60d8395"), 0, "3b863f86-88cf-4e75-b081-2ef902a1dadd", new DateTime(2025, 3, 14, 13, 58, 51, 117, DateTimeKind.Local).AddTicks(3052), "example2@gmail.com", false, "Jane", "Doe", false, null, "EXAMPLE2@GMAIL.COM", "JANE", "$2a$11$ioHWq/EohvquKoiZlGW2SeUthdzBRHxRavz64jPADk2wAj5cTgv9O", "(99) 99999-9992", false, "8847620b-0885-4b56-8a87-68e9f0548727", 0, false, new DateTime(2025, 3, 14, 13, 58, 51, 117, DateTimeKind.Local).AddTicks(2994), "jane" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("bebd57ca-374a-4b9a-a4eb-e4666386b606"), new Guid("3d333144-c00a-490f-970c-aa995da67100") },
                    { new Guid("001496cf-cac1-4343-815c-c929c4b75dc8"), new Guid("51c53d94-1842-47eb-b73c-75b89ec20ff8") },
                    { new Guid("95fafd63-7c4a-4fc4-89ba-bcc8e6f88dc9"), new Guid("6171d456-d6c7-4914-8b4f-6e76b3782d31") },
                    { new Guid("3f2027ec-7d81-4bdb-8e2e-b751b69ce66f"), new Guid("875a2dc0-8078-4501-8089-a01a9bcfc850") },
                    { new Guid("aad68f57-f451-4c3f-9d11-3c8f751e0691"), new Guid("9b133a03-3800-4248-b129-4d74a60d8395") }
                });
        }
    }
}
