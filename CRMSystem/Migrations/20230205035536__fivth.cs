using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CRMSystem.Migrations
{
    public partial class _fivth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<Guid>(
                name: "RequestId",
                table: "Requests",
                type: "char(36)",
                nullable: false,
                collation: "ascii_general_ci",
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<Guid>(
                name: "RequestId",
                table: "RequestInformation",
                type: "char(36)",
                nullable: false,
                collation: "ascii_general_ci",
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<Guid>(
                name: "RequestId",
                table: "Requesters",
                type: "char(36)",
                nullable: false,
                collation: "ascii_general_ci",
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<Guid>(
                name: "RequesterId",
                table: "Requesters",
                type: "char(36)",
                nullable: false,
                collation: "ascii_general_ci",
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<Guid>(
                name: "RequestId",
                table: "OrganizationFounders",
                type: "char(36)",
                nullable: true,
                collation: "ascii_general_ci",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "RequestId",
                table: "ExecutiveDepartments",
                type: "char(36)",
                nullable: true,
                collation: "ascii_general_ci",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "RequestId",
                table: "Beneficiaries",
                type: "char(36)",
                nullable: true,
                collation: "ascii_general_ci",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7c9d381a-f2bc-4a7e-967f-a5c17bed883c",
                column: "ConcurrencyStamp",
                value: "002a8022-dd8b-4b41-8594-b5d5f148caa5");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a815df5a-a254-4076-aaf3-5c9f7d58f408",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b42f9c21-4499-4de7-803a-fec1acedf329", "AQAAAAEAACcQAAAAENmgDGbFWvFxMRtynpw1zkxxF1trqfJ6LapPK6XsATechaCs8SrFBTGHywysyubXVw==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "RequestId",
                table: "Requests",
                type: "int",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "char(36)")
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .OldAnnotation("Relational:Collation", "ascii_general_ci");

            migrationBuilder.AlterColumn<int>(
                name: "RequestId",
                table: "RequestInformation",
                type: "int",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "char(36)")
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .OldAnnotation("Relational:Collation", "ascii_general_ci");

            migrationBuilder.AlterColumn<int>(
                name: "RequestId",
                table: "Requesters",
                type: "int",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "char(36)")
                .OldAnnotation("Relational:Collation", "ascii_general_ci");

            migrationBuilder.AlterColumn<int>(
                name: "RequesterId",
                table: "Requesters",
                type: "int",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "char(36)")
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .OldAnnotation("Relational:Collation", "ascii_general_ci");

            migrationBuilder.AlterColumn<int>(
                name: "RequestId",
                table: "OrganizationFounders",
                type: "int",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "char(36)",
                oldNullable: true)
                .OldAnnotation("Relational:Collation", "ascii_general_ci");

            migrationBuilder.AlterColumn<int>(
                name: "RequestId",
                table: "ExecutiveDepartments",
                type: "int",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "char(36)",
                oldNullable: true)
                .OldAnnotation("Relational:Collation", "ascii_general_ci");

            migrationBuilder.AlterColumn<int>(
                name: "RequestId",
                table: "Beneficiaries",
                type: "int",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "char(36)",
                oldNullable: true)
                .OldAnnotation("Relational:Collation", "ascii_general_ci");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7c9d381a-f2bc-4a7e-967f-a5c17bed883c",
                column: "ConcurrencyStamp",
                value: "17ee7c22-8bc0-434b-b067-d99405d44701");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a815df5a-a254-4076-aaf3-5c9f7d58f408",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "df3a1dc1-1f5e-44aa-86b7-70d96ae69c8d", "AQAAAAEAACcQAAAAEHamR5RquR5UEDkj0XjwxkIQteFondCX2ATOmKxvwf6e/JJuUWhANQFKuJ8G3Ie5JA==" });
        }
    }
}
