using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class expensescreationAt : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("1aa74cb7-43fd-4aa8-966c-e2ab26f73e8a"), "0b3709e0-06ee-42e7-84e0-4ec84c3b3879", "Admin", "ADMIN" },
                    { new Guid("3870e4e2-e52d-4e47-a2d5-3f8a9992667a"), "7999542a-f333-4039-9718-51375552153f", "Manager", "MANAGER" },
                    { new Guid("40a4f91f-1304-4a04-aa7c-16df2806050d"), "7e5bdd38-70c6-4154-8ac8-e5c4c8086e0c", "Owner", "OWNER" },
                    { new Guid("76fca261-75a0-4ea8-ada4-de02fe85931f"), "0e9f9e80-6896-4e12-8667-bbf401f46334", "Consultant", "CONSULTANT" },
                    { new Guid("ec8b2471-25e1-4e5d-ba6e-27ae25a74904"), "b7da69e9-351e-4b94-92c7-c86e716ffb92", "Collaborator", "COLLABORATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedAt", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Status", "TwoFactorEnabled", "UpdatedAt", "UserName" },
                values: new object[,]
                {
                    { new Guid("38616b28-2e10-43de-8b37-962fdb3bea82"), 0, "34104d4e-6227-4581-bffa-13ff8bc55201", new DateTime(2025, 3, 26, 18, 23, 41, 505, DateTimeKind.Local).AddTicks(9069), "example2@gmail.com", false, "Jane", "Doe", false, null, "EXAMPLE2@GMAIL.COM", "JANE", "$2a$11$MnX5txoeiqw9a2.ozSJeUO619eiBxRSRQZ4bl3NFrcnuWsc3zM2ym", "(99) 99999-9992", false, "7b250d26-b6b6-4868-9b68-ed7cb0cf8fd2", 0, false, new DateTime(2025, 3, 26, 18, 23, 41, 505, DateTimeKind.Local).AddTicks(9014), "jane" },
                    { new Guid("5992a59f-976a-4c4a-bce0-4ac54daa32dd"), 0, "1260284e-f1f1-4f2c-9063-13d55b0e361f", new DateTime(2025, 3, 26, 18, 23, 41, 505, DateTimeKind.Local).AddTicks(9128), "example5@gmail.com", false, "Charlie", "Smith", false, null, "EXAMPLE5@GMAIL.COM", "CHARLIE", "$2a$11$cc4dNd2or7pCGUA3XwO5/eFTaqOLZS/c88JpJ8NRM9ZtXnygU1vo.", "(99) 99999-9995", false, "67a3a6dd-1e7a-4405-9b23-bc19e35b2c31", 0, false, new DateTime(2025, 3, 26, 18, 23, 41, 505, DateTimeKind.Local).AddTicks(9111), "charlie" },
                    { new Guid("5e83c4a8-e8bb-42f5-afa2-9b38815ca7f8"), 0, "425879c8-c0f5-417a-8577-a0dfd960a4fd", new DateTime(2025, 3, 26, 18, 23, 41, 505, DateTimeKind.Local).AddTicks(9095), "example3@gmail.com", false, "Alice", "Anderson", false, null, "EXAMPLE3@GMAIL.COM", "ALICE", "$2a$11$JNkv4Gij/ImgTiilfSYt7uTH8/RcBaZdjPwnLhGWUilFJMc8Yycde", "(99) 99999-9993", false, "51c16769-c44d-48b8-9faa-fe7ec9209bcd", 0, false, new DateTime(2025, 3, 26, 18, 23, 41, 505, DateTimeKind.Local).AddTicks(9072), "alice" },
                    { new Guid("aab3ee7c-723b-4e10-8a81-0219c8fe9f6d"), 0, "c76989e1-8e9c-4f78-ad61-bdf0635dc136", new DateTime(2025, 3, 26, 18, 23, 41, 505, DateTimeKind.Local).AddTicks(9110), "example4@gmail.com", false, "Bob", "Anderson", false, null, "EXAMPLE4@GMAIL.COM", "BOB", "$2a$11$jQ8O24W6Gpl6QFR1SHxE.uLU.6bibDOjBo5SxLSz5x8nQi5oXL9ee", "(99) 99999-9994", false, "0a75da6e-b32f-4432-baed-16b0807b5a2b", 0, false, new DateTime(2025, 3, 26, 18, 23, 41, 505, DateTimeKind.Local).AddTicks(9096), "bob" },
                    { new Guid("d6a31c05-7e99-465d-b670-81d12e2c87fd"), 0, "97d40265-75db-4882-b954-74fc93e8c419", new DateTime(2025, 3, 26, 18, 23, 41, 505, DateTimeKind.Local).AddTicks(8526), "example1@gmail.com", false, "John", "Doe", false, null, "EXAMPLE1@GMAIL.COM", "JOHN", "$2a$11$AzronmdT/ScTP2IAiV.8Ue0d4xshde.3IGUXPxzywLfqZFBV9nZzK", "(99) 99999-9991", false, "e44fc5fb-43ae-4a49-9c1f-54796def7924", 0, false, new DateTime(2025, 3, 26, 18, 23, 41, 505, DateTimeKind.Local).AddTicks(4652), "john" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("40a4f91f-1304-4a04-aa7c-16df2806050d"), new Guid("38616b28-2e10-43de-8b37-962fdb3bea82") },
                    { new Guid("ec8b2471-25e1-4e5d-ba6e-27ae25a74904"), new Guid("5992a59f-976a-4c4a-bce0-4ac54daa32dd") },
                    { new Guid("76fca261-75a0-4ea8-ada4-de02fe85931f"), new Guid("5e83c4a8-e8bb-42f5-afa2-9b38815ca7f8") },
                    { new Guid("3870e4e2-e52d-4e47-a2d5-3f8a9992667a"), new Guid("aab3ee7c-723b-4e10-8a81-0219c8fe9f6d") },
                    { new Guid("1aa74cb7-43fd-4aa8-966c-e2ab26f73e8a"), new Guid("d6a31c05-7e99-465d-b670-81d12e2c87fd") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("40a4f91f-1304-4a04-aa7c-16df2806050d"), new Guid("38616b28-2e10-43de-8b37-962fdb3bea82") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("ec8b2471-25e1-4e5d-ba6e-27ae25a74904"), new Guid("5992a59f-976a-4c4a-bce0-4ac54daa32dd") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("76fca261-75a0-4ea8-ada4-de02fe85931f"), new Guid("5e83c4a8-e8bb-42f5-afa2-9b38815ca7f8") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("3870e4e2-e52d-4e47-a2d5-3f8a9992667a"), new Guid("aab3ee7c-723b-4e10-8a81-0219c8fe9f6d") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("1aa74cb7-43fd-4aa8-966c-e2ab26f73e8a"), new Guid("d6a31c05-7e99-465d-b670-81d12e2c87fd") });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("1aa74cb7-43fd-4aa8-966c-e2ab26f73e8a"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("3870e4e2-e52d-4e47-a2d5-3f8a9992667a"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("40a4f91f-1304-4a04-aa7c-16df2806050d"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("76fca261-75a0-4ea8-ada4-de02fe85931f"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("ec8b2471-25e1-4e5d-ba6e-27ae25a74904"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("38616b28-2e10-43de-8b37-962fdb3bea82"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("5992a59f-976a-4c4a-bce0-4ac54daa32dd"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("5e83c4a8-e8bb-42f5-afa2-9b38815ca7f8"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("aab3ee7c-723b-4e10-8a81-0219c8fe9f6d"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d6a31c05-7e99-465d-b670-81d12e2c87fd"));

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
    }
}
