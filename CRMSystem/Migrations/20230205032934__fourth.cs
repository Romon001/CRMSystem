using Microsoft.EntityFrameworkCore.Migrations;

namespace CRMSystem.Migrations
{
    public partial class _fourth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsPublicOfficialPerson",
                table: "Beneficiaries");

            migrationBuilder.AddColumn<string>(
                name: "PurchaseNumber",
                table: "RequestInformation",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PurchaseNumber",
                table: "RequestInformation");

            migrationBuilder.AddColumn<bool>(
                name: "IsPublicOfficialPerson",
                table: "Beneficiaries",
                type: "tinyint(1)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7c9d381a-f2bc-4a7e-967f-a5c17bed883c",
                column: "ConcurrencyStamp",
                value: "7bd0ae82-3c8c-455a-acdd-3a23f085f586");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a815df5a-a254-4076-aaf3-5c9f7d58f408",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7f944139-a4dd-4f80-a0d6-e3845a4f1f4e", "AQAAAAEAACcQAAAAECfVPmzumYLDjlH6YAJLAKt6Sl0+f3nn6UwdJKmDe/juKjLpK5COpEfx2Ud2+O5RBQ==" });
        }
    }
}
