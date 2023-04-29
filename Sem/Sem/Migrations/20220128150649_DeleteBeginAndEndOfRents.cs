using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Sem.Migrations
{
    public partial class DeleteBeginAndEndOfRents : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RentBegin",
                table: "Rents");

            migrationBuilder.DropColumn(
                name: "RentEnd",
                table: "Rents");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "RentBegin",
                table: "Rents",
                type: "date",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "RentEnd",
                table: "Rents",
                type: "date",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
