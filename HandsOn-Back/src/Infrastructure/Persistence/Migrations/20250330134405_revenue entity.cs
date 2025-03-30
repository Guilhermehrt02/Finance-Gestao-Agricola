using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class revenueentity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "Revenues",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Description = table.Column<string>(type: "varchar(300)", maxLength: 300, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Source = table.Column<int>(type: "int", maxLength: 50, nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UserId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ReceiptUrl = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Revenues", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("0dd9bdd4-3cf4-4643-9f58-dab5798fa414"), "1cbdef94-b8f7-45ba-890e-6b93b9a32455", "Collaborator", "COLLABORATOR" },
                    { new Guid("240d28ea-5a5b-4787-afa9-1edc839ff664"), "40bba595-576b-4389-a333-efcfa9eddb35", "Consultant", "CONSULTANT" },
                    { new Guid("46e0844f-dc49-4e2b-887d-8980a3fbf9d7"), "5882c063-5373-4cc1-a274-61fd692e310d", "Owner", "OWNER" },
                    { new Guid("6cbc0f2e-d797-49f0-8fbb-c42abf6befea"), "8d5b058d-9aa2-4bc1-940e-d6222475368f", "Admin", "ADMIN" },
                    { new Guid("be0b823b-fa83-4421-b825-0ed842166bf3"), "68946a16-4f83-4dd3-8e63-17a8410a55d5", "Manager", "MANAGER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedAt", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Status", "TwoFactorEnabled", "UpdatedAt", "UserName" },
                values: new object[,]
                {
                    { new Guid("33c54e4d-1a66-4241-bb2a-173acf08a43c"), 0, "59a0983e-4499-421e-bd36-d5c97e178aa6", new DateTime(2025, 3, 30, 10, 44, 3, 210, DateTimeKind.Local).AddTicks(389), "example5@gmail.com", false, "Charlie", "Smith", false, null, "EXAMPLE5@GMAIL.COM", "CHARLIE", "$2a$11$XuTRnaO0OkHt9oOCxKt1gOJUj477/ywqJWmS1Ix3yMjpUDKgSQ/hy", "(99) 99999-9995", false, "e11578cc-416a-4c78-bece-b84a62925a10", 0, false, new DateTime(2025, 3, 30, 10, 44, 3, 210, DateTimeKind.Local).AddTicks(381), "charlie" },
                    { new Guid("4371a608-5090-48e9-922f-dd73f301af7b"), 0, "23b6850d-de23-47e6-b1ac-c6ca66ac0104", new DateTime(2025, 3, 30, 10, 44, 3, 210, DateTimeKind.Local).AddTicks(335), "example3@gmail.com", false, "Alice", "Anderson", false, null, "EXAMPLE3@GMAIL.COM", "ALICE", "$2a$11$EAFqRElS3NP1ZAi6P2bKSOzmf7WfNX78Y2z7/u5b7ucnHitTays/u", "(99) 99999-9993", false, "4e6b793a-ee0e-4be0-b0c6-89cfe558807a", 0, false, new DateTime(2025, 3, 30, 10, 44, 3, 210, DateTimeKind.Local).AddTicks(327), "alice" },
                    { new Guid("b05df9b0-c6bf-4db9-b281-bd219b45640c"), 0, "db04a3a4-7f40-4558-816c-cd3e5bffaf2b", new DateTime(2025, 3, 30, 10, 44, 3, 210, DateTimeKind.Local).AddTicks(324), "example2@gmail.com", false, "Jane", "Doe", false, null, "EXAMPLE2@GMAIL.COM", "JANE", "$2a$11$OsierzzB3DTuJ4J5x38s3OLrRzMWtM8bJ3XDxKbCOA0icGi6SHuJO", "(99) 99999-9992", false, "1c35862b-385b-4a47-9829-0f777c800be3", 0, false, new DateTime(2025, 3, 30, 10, 44, 3, 210, DateTimeKind.Local).AddTicks(279), "jane" },
                    { new Guid("dbac9f8f-9525-425f-af61-9e6176f9c20f"), 0, "d67fffd6-4769-4094-b9a7-3752ee2a2bbb", new DateTime(2025, 3, 30, 10, 44, 3, 210, DateTimeKind.Local).AddTicks(380), "example4@gmail.com", false, "Bob", "Anderson", false, null, "EXAMPLE4@GMAIL.COM", "BOB", "$2a$11$SzjdxdFOKtFfQ9RtSFnq/OMaaY8gaacIGimlA/5cG8I8jW6BMQbym", "(99) 99999-9994", false, "09103fa5-53e8-4cb3-88ec-f467e43786b9", 0, false, new DateTime(2025, 3, 30, 10, 44, 3, 210, DateTimeKind.Local).AddTicks(362), "bob" },
                    { new Guid("fab7976e-17b9-4e53-9b97-3122058f5677"), 0, "bd84ac41-13de-47f9-93ed-3f04c519e408", new DateTime(2025, 3, 30, 10, 44, 3, 209, DateTimeKind.Local).AddTicks(9699), "example1@gmail.com", false, "John", "Doe", false, null, "EXAMPLE1@GMAIL.COM", "JOHN", "$2a$11$JFcFd1zHhg9QTP95Wweib.Pwaowid8rY2wNJbRJqr5ZPqZsRboOPC", "(99) 99999-9991", false, "58d902a7-1ecf-453c-858a-25e2063f9748", 0, false, new DateTime(2025, 3, 30, 10, 44, 3, 209, DateTimeKind.Local).AddTicks(5453), "john" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("0dd9bdd4-3cf4-4643-9f58-dab5798fa414"), new Guid("33c54e4d-1a66-4241-bb2a-173acf08a43c") },
                    { new Guid("240d28ea-5a5b-4787-afa9-1edc839ff664"), new Guid("4371a608-5090-48e9-922f-dd73f301af7b") },
                    { new Guid("46e0844f-dc49-4e2b-887d-8980a3fbf9d7"), new Guid("b05df9b0-c6bf-4db9-b281-bd219b45640c") },
                    { new Guid("be0b823b-fa83-4421-b825-0ed842166bf3"), new Guid("dbac9f8f-9525-425f-af61-9e6176f9c20f") },
                    { new Guid("6cbc0f2e-d797-49f0-8fbb-c42abf6befea"), new Guid("fab7976e-17b9-4e53-9b97-3122058f5677") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Revenues");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("0dd9bdd4-3cf4-4643-9f58-dab5798fa414"), new Guid("33c54e4d-1a66-4241-bb2a-173acf08a43c") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("240d28ea-5a5b-4787-afa9-1edc839ff664"), new Guid("4371a608-5090-48e9-922f-dd73f301af7b") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("46e0844f-dc49-4e2b-887d-8980a3fbf9d7"), new Guid("b05df9b0-c6bf-4db9-b281-bd219b45640c") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("be0b823b-fa83-4421-b825-0ed842166bf3"), new Guid("dbac9f8f-9525-425f-af61-9e6176f9c20f") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("6cbc0f2e-d797-49f0-8fbb-c42abf6befea"), new Guid("fab7976e-17b9-4e53-9b97-3122058f5677") });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("0dd9bdd4-3cf4-4643-9f58-dab5798fa414"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("240d28ea-5a5b-4787-afa9-1edc839ff664"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("46e0844f-dc49-4e2b-887d-8980a3fbf9d7"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("6cbc0f2e-d797-49f0-8fbb-c42abf6befea"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("be0b823b-fa83-4421-b825-0ed842166bf3"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("33c54e4d-1a66-4241-bb2a-173acf08a43c"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4371a608-5090-48e9-922f-dd73f301af7b"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b05df9b0-c6bf-4db9-b281-bd219b45640c"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("dbac9f8f-9525-425f-af61-9e6176f9c20f"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("fab7976e-17b9-4e53-9b97-3122058f5677"));

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
    }
}
