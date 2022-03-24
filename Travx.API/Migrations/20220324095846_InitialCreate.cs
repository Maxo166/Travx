using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Travx.API.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "JobCalegories",
                columns: table => new
                {
                    JobCalegoryId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CategoryName = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobCalegories", x => x.JobCalegoryId);
                });

            migrationBuilder.CreateTable(
                name: "Jobs",
                columns: table => new
                {
                    JobId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    JobTitle = table.Column<string>(type: "varchar(100)", nullable: false),
                    Dscription = table.Column<string>(type: "varchar(1000)", nullable: false),
                    BusnessName = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    MaxSalary = table.Column<double>(type: "REAL", nullable: false),
                    MinSalary = table.Column<double>(type: "REAL", nullable: false),
                    WorkLoation = table.Column<string>(type: "TEXT", nullable: false),
                    DatePosted = table.Column<DateTime>(type: "TEXT", nullable: false),
                    IsOpenForApplications = table.Column<bool>(type: "INTEGER", nullable: false),
                    SalaryType = table.Column<int>(type: "INTEGER", nullable: false),
                    JobType = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jobs", x => x.JobId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "JobCalegories");

            migrationBuilder.DropTable(
                name: "Jobs");
        }
    }
}
