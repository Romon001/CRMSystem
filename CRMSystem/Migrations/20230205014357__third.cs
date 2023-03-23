using Microsoft.EntityFrameworkCore.Migrations;

namespace CRMSystem.Migrations
{
    public partial class _third : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Code",
                table: "Requests");

            migrationBuilder.DropColumn(
                name: "RequestInformationId",
                table: "Requests");

            migrationBuilder.AddColumn<int>(
                name: "RequestId",
                table: "Requesters",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RequestId",
                table: "Requesters");

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "Requests",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "RequestInformationId",
                table: "Requests",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7c9d381a-f2bc-4a7e-967f-a5c17bed883c",
                column: "ConcurrencyStamp",
                value: "765f8834-c6e2-4d56-be28-7435f8b496a6");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a815df5a-a254-4076-aaf3-5c9f7d58f408",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "274550da-310e-4c50-865b-dd2b5b683f48", "AQAAAAEAACcQAAAAELIu6y+9IxY8sJDfg12jVQT0FPD8EeSXTXOX4135ZgeEGh8RqvSfsBK9a645TJseWw==" });
        }
    }
}
