using Microsoft.EntityFrameworkCore.Migrations;

namespace CRMSystem.Migrations
{
    public partial class _sixth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "RequestInformation",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "RequestInformation");

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
    }
}
