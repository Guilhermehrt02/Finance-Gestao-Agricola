using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class paymentMethodandCategoryenums : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Expenses_AspNetUsers_UserId",
                table: "Expenses");

            migrationBuilder.DropIndex(
                name: "IX_Expenses_UserId",
                table: "Expenses");

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

            migrationBuilder.AlterColumn<int>(
                name: "PaymentMethod",
                table: "Expenses",
                type: "int",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldMaxLength: 50,
                oldNullable: true)
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<int>(
                name: "Category",
                table: "Expenses",
                type: "int",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldMaxLength: 50)
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("1d930f45-539a-4764-820b-427cf50bafd0"), "b18aac69-3df6-41ea-967b-23cddf88b5b7", "Manager", "MANAGER" },
                    { new Guid("4edb9b61-471d-45e2-8865-12bd7a291513"), "27dd8d0a-f6b4-41b0-9bd0-f8f50c9a4c57", "Owner", "OWNER" },
                    { new Guid("7e704e1c-a5f7-49a5-bdee-db1a0bf1d661"), "2e290e25-fd72-4bd1-bdbb-4bda4a0ed836", "Consultant", "CONSULTANT" },
                    { new Guid("88d61c10-e5fb-4a05-a790-b365946de6e1"), "8bb76b25-8370-428b-bf65-7adb67570a72", "Admin", "ADMIN" },
                    { new Guid("fd66f286-e9f4-4362-9679-c848e36a9b63"), "f835dbd5-4ffd-41a6-a4a0-19eb1be8462e", "Collaborator", "COLLABORATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedAt", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Status", "TwoFactorEnabled", "UpdatedAt", "UserName" },
                values: new object[,]
                {
                    { new Guid("061eb600-8942-4d6a-a4dd-ea84d42fa6c2"), 0, "b0815b4f-5822-4f3d-be1a-9a7fd5c1dbe4", new DateTime(2025, 3, 28, 18, 6, 45, 252, DateTimeKind.Local).AddTicks(5427), "example2@gmail.com", false, "Jane", "Doe", false, null, "EXAMPLE2@GMAIL.COM", "JANE", "$2a$11$v6JXZ1AXLrB6g86hyAyyiuMPFQwEOH/cPJXN5TGk/UUEZArJg3TMy", "(99) 99999-9992", false, "99dde7fa-9bfe-4859-b5a6-5b13422b56a8", 0, false, new DateTime(2025, 3, 28, 18, 6, 45, 252, DateTimeKind.Local).AddTicks(5395), "jane" },
                    { new Guid("26f64765-865a-436c-bb9c-acf4505e68bf"), 0, "3f8e35fe-76db-4f9c-ad94-5b762958ba32", new DateTime(2025, 3, 28, 18, 6, 45, 252, DateTimeKind.Local).AddTicks(5437), "example4@gmail.com", false, "Bob", "Anderson", false, null, "EXAMPLE4@GMAIL.COM", "BOB", "$2a$11$4562nSpWQP1YDaYRJUnmxOhWeijJTGcr798RnawqMW0CvkHEUDKeO", "(99) 99999-9994", false, "0045340b-c076-4039-af89-355eb7b8cff9", 0, false, new DateTime(2025, 3, 28, 18, 6, 45, 252, DateTimeKind.Local).AddTicks(5433), "bob" },
                    { new Guid("2b152d6a-ade7-4afb-b282-6e8d2e647de6"), 0, "c01cb6e0-9fc2-4ea5-96c2-64d0f12f4213", new DateTime(2025, 3, 28, 18, 6, 45, 252, DateTimeKind.Local).AddTicks(5433), "example3@gmail.com", false, "Alice", "Anderson", false, null, "EXAMPLE3@GMAIL.COM", "ALICE", "$2a$11$mTUR1XQ/uHyK.sPdKDR3lu7gwcelCGh6l0VSjDyoNqBDB..ENdWvK", "(99) 99999-9993", false, "c0ee7b10-3809-468a-a9d2-1d0895855f9c", 0, false, new DateTime(2025, 3, 28, 18, 6, 45, 252, DateTimeKind.Local).AddTicks(5428), "alice" },
                    { new Guid("3a2a84d3-1930-4a70-aec1-09ed70813485"), 0, "2d9eaca9-29ca-4a21-b239-e8a66f4d32b3", new DateTime(2025, 3, 28, 18, 6, 45, 252, DateTimeKind.Local).AddTicks(5442), "example5@gmail.com", false, "Charlie", "Smith", false, null, "EXAMPLE5@GMAIL.COM", "CHARLIE", "$2a$11$FI4AGAH0R0N9E6nkd3y8iulABINxZ45bOuNMKJkyt05NoLnbXnSiS", "(99) 99999-9995", false, "9c1154da-c371-43fe-a1db-1a50abaefa0b", 0, false, new DateTime(2025, 3, 28, 18, 6, 45, 252, DateTimeKind.Local).AddTicks(5438), "charlie" },
                    { new Guid("de443162-d021-4990-b1d6-23cb648ff26a"), 0, "b5e9d03f-68d6-48df-9b6d-2bb58b7e13ad", new DateTime(2025, 3, 28, 18, 6, 45, 252, DateTimeKind.Local).AddTicks(5120), "example1@gmail.com", false, "John", "Doe", false, null, "EXAMPLE1@GMAIL.COM", "JOHN", "$2a$11$2KB8K4VmfnLSohxpq9cYw.wxOPxlZflNZCl175XHsPvZINv0iUuZG", "(99) 99999-9991", false, "36c8b701-38d5-4954-ab37-624fa6dae1dc", 0, false, new DateTime(2025, 3, 28, 18, 6, 45, 252, DateTimeKind.Local).AddTicks(3072), "john" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("4edb9b61-471d-45e2-8865-12bd7a291513"), new Guid("061eb600-8942-4d6a-a4dd-ea84d42fa6c2") },
                    { new Guid("1d930f45-539a-4764-820b-427cf50bafd0"), new Guid("26f64765-865a-436c-bb9c-acf4505e68bf") },
                    { new Guid("7e704e1c-a5f7-49a5-bdee-db1a0bf1d661"), new Guid("2b152d6a-ade7-4afb-b282-6e8d2e647de6") },
                    { new Guid("fd66f286-e9f4-4362-9679-c848e36a9b63"), new Guid("3a2a84d3-1930-4a70-aec1-09ed70813485") },
                    { new Guid("88d61c10-e5fb-4a05-a790-b365946de6e1"), new Guid("de443162-d021-4990-b1d6-23cb648ff26a") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("4edb9b61-471d-45e2-8865-12bd7a291513"), new Guid("061eb600-8942-4d6a-a4dd-ea84d42fa6c2") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("1d930f45-539a-4764-820b-427cf50bafd0"), new Guid("26f64765-865a-436c-bb9c-acf4505e68bf") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("7e704e1c-a5f7-49a5-bdee-db1a0bf1d661"), new Guid("2b152d6a-ade7-4afb-b282-6e8d2e647de6") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("fd66f286-e9f4-4362-9679-c848e36a9b63"), new Guid("3a2a84d3-1930-4a70-aec1-09ed70813485") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("88d61c10-e5fb-4a05-a790-b365946de6e1"), new Guid("de443162-d021-4990-b1d6-23cb648ff26a") });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("1d930f45-539a-4764-820b-427cf50bafd0"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("4edb9b61-471d-45e2-8865-12bd7a291513"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("7e704e1c-a5f7-49a5-bdee-db1a0bf1d661"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("88d61c10-e5fb-4a05-a790-b365946de6e1"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("fd66f286-e9f4-4362-9679-c848e36a9b63"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("061eb600-8942-4d6a-a4dd-ea84d42fa6c2"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("26f64765-865a-436c-bb9c-acf4505e68bf"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2b152d6a-ade7-4afb-b282-6e8d2e647de6"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3a2a84d3-1930-4a70-aec1-09ed70813485"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("de443162-d021-4990-b1d6-23cb648ff26a"));

            migrationBuilder.AlterColumn<string>(
                name: "PaymentMethod",
                table: "Expenses",
                type: "varchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 50,
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Category",
                table: "Expenses",
                type: "varchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 50)
                .Annotation("MySql:CharSet", "utf8mb4");

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

            migrationBuilder.CreateIndex(
                name: "IX_Expenses_UserId",
                table: "Expenses",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Expenses_AspNetUsers_UserId",
                table: "Expenses",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
