using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Travx.API.Migrations
{
    public partial class Add_LastModified_Field : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Dscription",
                table: "Jobs",
                newName: "Description");

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifie",
                table: "Jobs",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LastModifie",
                table: "Jobs");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Jobs",
                newName: "Dscription");
        }
    }
}
