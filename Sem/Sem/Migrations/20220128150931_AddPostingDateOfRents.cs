using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Sem.Migrations
{
    public partial class AddPostingDateOfRents : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "PostingDate",
                table: "Rents",
                type: "date",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PostingDate",
                table: "Rents");
        }
    }
}
