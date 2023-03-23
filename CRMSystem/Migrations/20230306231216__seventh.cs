using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CRMSystem.Migrations
{
    public partial class _seventh : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ChatMessages",
                columns: table => new
                {
                    RequestId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    UserId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    SendingTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Value = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7c9d381a-f2bc-4a7e-967f-a5c17bed883c",
                column: "ConcurrencyStamp",
                value: "f452de45-d1ca-41fd-affa-e760e13af470");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a815df5a-a254-4076-aaf3-5c9f7d58f408",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3125c97e-8f42-4679-813d-6d9f557b7f3e", "AQAAAAEAACcQAAAAEOfClDwooD9grXYXnn+ekPBHFFIpYBL06WhpIz1oMHYtkleZiI+foPIJHIxgYVt9CQ==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChatMessages");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7c9d381a-f2bc-4a7e-967f-a5c17bed883c",
                column: "ConcurrencyStamp",
                value: "06bd1e53-98c7-4180-81b7-c036e4d7ca76");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a815df5a-a254-4076-aaf3-5c9f7d58f408",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4b122b78-2f9b-4b58-97eb-1b800d12989b", "AQAAAAEAACcQAAAAEBMHqLwT6a0BeMDmTeZM5eD7jtuEGiS28lbAL9IcSYsI8exNFRlT4NLG/x3/DrROxg==" });
        }
    }
}
