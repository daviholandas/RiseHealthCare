using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RiseHealthCare.Infrastructure.Data.Migrations
{
    public partial class First : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Insurances",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    RegisterDate = table.Column<DateTime>(nullable: false),
                    LastModified = table.Column<DateTime>(nullable: true),
                    Code = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(150)", nullable: true),
                    DiscountType = table.Column<string>(type: "varchar(20)", nullable: false),
                    Discount = table.Column<decimal>(type: "decimal(15,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Insurances", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Professionals",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    RegisterDate = table.Column<DateTime>(nullable: false),
                    LastModified = table.Column<DateTime>(nullable: true),
                    Code = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "varchar(200)", nullable: false),
                    Photo = table.Column<string>(type: "varchar(100)", nullable: true),
                    HiringDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    FiringDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Council_Name = table.Column<string>(type: "varchar(100)", nullable: true),
                    Council_RegistrationCode = table.Column<string>(type: "varchar(50)", nullable: true),
                    Council_Estate = table.Column<string>(type: "varchar(15)", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Professionals", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Patients",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    RegisterDate = table.Column<DateTime>(nullable: false),
                    LastModified = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(type: "varchar(200)", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    Genre = table.Column<string>(type: "varchar(20)", nullable: false),
                    CPF = table.Column<string>(type: "varchar(14)", maxLength: 14, nullable: true),
                    RG = table.Column<string>(type: "varchar(25)", nullable: true),
                    Information = table.Column<string>(type: "varchar(200)", nullable: true),
                    Address_Street = table.Column<string>(type: "varchar(100)", nullable: true),
                    Address_Number = table.Column<string>(type: "varchar(100)", nullable: true),
                    Address_Neighborhood = table.Column<string>(type: "varchar(100)", nullable: true),
                    Address_City = table.Column<string>(type: "varchar(100)", nullable: true),
                    Address_Estate = table.Column<string>(type: "varchar(100)", nullable: true),
                    Address_ZipCode = table.Column<string>(type: "varchar(100)", nullable: true),
                    Address_Country = table.Column<string>(type: "varchar(100)", nullable: true),
                    Phone_NumberType = table.Column<int>(nullable: true),
                    Phone_Number = table.Column<string>(type: "varchar(100)", nullable: true),
                    Phone_IsWhatsapp = table.Column<bool>(nullable: true),
                    Photo = table.Column<string>(type: "varchar(100)", nullable: true),
                    InsuranceHealthId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patients", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Patients_Insurances_InsuranceHealthId",
                        column: x => x.InsuranceHealthId,
                        principalTable: "Insurances",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Procedure",
                columns: table => new
                {
                    ProfessionalId = table.Column<Guid>(nullable: false),
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "varchar(100)", nullable: true),
                    Description = table.Column<string>(type: "varchar(100)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(15,2)", nullable: false),
                    Deduction = table.Column<decimal>(type: "decimal(15,2)", nullable: false),
                    TypeDeduction = table.Column<string>(type: "varchar(20)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Procedure", x => new { x.ProfessionalId, x.Id });
                    table.ForeignKey(
                        name: "FK_Procedure_Professionals_ProfessionalId",
                        column: x => x.ProfessionalId,
                        principalTable: "Professionals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Professionals_Phones",
                columns: table => new
                {
                    ProfessionalId = table.Column<Guid>(nullable: false),
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumberType = table.Column<string>(type: "varchar(25)", nullable: false),
                    Number = table.Column<string>(type: "varchar(20)", nullable: true),
                    IsWhatsapp = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Professionals_Phones", x => new { x.ProfessionalId, x.Id });
                    table.ForeignKey(
                        name: "FK_Professionals_Phones_Professionals_ProfessionalId",
                        column: x => x.ProfessionalId,
                        principalTable: "Professionals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Patients_InsuranceHealthId",
                table: "Patients",
                column: "InsuranceHealthId");

            migrationBuilder.CreateIndex(
                name: "IX_Patients_CPF",
                table: "Patients",
                column: "CPF",
                unique: true,
                filter: "[CPF] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Professionals_Code",
                table: "Professionals",
                column: "Code",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Patients");

            migrationBuilder.DropTable(
                name: "Procedure");

            migrationBuilder.DropTable(
                name: "Professionals_Phones");

            migrationBuilder.DropTable(
                name: "Insurances");

            migrationBuilder.DropTable(
                name: "Professionals");
        }
    }
}
