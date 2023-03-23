using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CRMSystem.Migrations
{
    public partial class _second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "Requests");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "Requests",
                newName: "RequestInformationId");

            migrationBuilder.RenameColumn(
                name: "ClientId",
                table: "Requests",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Requests",
                newName: "RequestId");

            migrationBuilder.CreateTable(
                name: "Beneficiaries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    RequestId = table.Column<int>(type: "int", nullable: true),
                    LastName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FirstName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    MiddleName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Gender = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PercentShare = table.Column<double>(type: "double", nullable: true),
                    INN = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SNILS = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IsPublicOfficialPerson = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    IsPublicOfficialPersonOrRelative = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    BirthDate = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    BirthPlace = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Nationality = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PassportSeries = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PassportNumber = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ExtraditionPassportDate = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    DepartmentCode = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    WhoGivesPassport = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RegistrationAdress = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Beneficiaries", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ExecutiveDepartments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    RequestId = table.Column<int>(type: "int", nullable: true),
                    LastName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FirstName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    MiddleName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Gender = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Position = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PercentShare = table.Column<double>(type: "double", nullable: true),
                    INN = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SNILS = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IsPublicOfficialPerson = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    IsPublicOfficialPersonRelative = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    BirthDate = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    BirthPlace = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Nationality = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PassportSeries = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PassportNumber = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ExtraditionPassportDate = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    DepartmentCode = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    WhoGivesPassport = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RegistrationAdress = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExecutiveDepartments", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "OrganizationFounders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    RequestId = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    INN = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IsResident = table.Column<bool>(type: "tinyint(1)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrganizationFounders", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Requesters",
                columns: table => new
                {
                    RequesterId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    INN = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    KPP = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ContactPerson = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ContactPhone = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    COntactEmail = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    WebsiteExistence = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    Website = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PaymentAccountNumber = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    BIK = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    BankName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CorrespondentBankAccount = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LegalAdress = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ActualAdress = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    HasLicence = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    IsStraregicEnterprise = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    hasDebtFiles = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    hasFederalDebt = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    hasSalaryDebt = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    InLicvidationProcess = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    hasCreditProducts = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    EmployeesNumber = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Requesters", x => x.RequesterId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "RequestInformation",
                columns: table => new
                {
                    RequestId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    RequestCode = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    AmountOfMoney = table.Column<double>(type: "double", nullable: true),
                    DateOfIssue = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    StartMaxPrice = table.Column<double>(type: "double", nullable: true),
                    IsPrepayment = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    SigningContractDate = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    ContractObject = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EntityOfRussia = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RegionOfWork = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequestInformation", x => x.RequestId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "RequestTypes",
                columns: table => new
                {
                    RequestTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequestTypes", x => x.RequestTypeId);
                })
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Beneficiaries");

            migrationBuilder.DropTable(
                name: "ExecutiveDepartments");

            migrationBuilder.DropTable(
                name: "OrganizationFounders");

            migrationBuilder.DropTable(
                name: "Requesters");

            migrationBuilder.DropTable(
                name: "RequestInformation");

            migrationBuilder.DropTable(
                name: "RequestTypes");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Requests",
                newName: "ClientId");

            migrationBuilder.RenameColumn(
                name: "RequestInformationId",
                table: "Requests",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "RequestId",
                table: "Requests",
                newName: "Id");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "Requests",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7c9d381a-f2bc-4a7e-967f-a5c17bed883c",
                column: "ConcurrencyStamp",
                value: "d2565c64-a009-47e0-a5c4-24d68e842226");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a815df5a-a254-4076-aaf3-5c9f7d58f408",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2a1a575b-4e11-4070-adf4-6ce376c44930", "AQAAAAEAACcQAAAAEPLyXB9D55FFI0LqW/8WtgcTHRhVg4Ns+O6DoZMO5CZmx0/3+17DhmnQvLYlBOkggg==" });
        }
    }
}
