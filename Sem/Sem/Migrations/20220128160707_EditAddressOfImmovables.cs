using Microsoft.EntityFrameworkCore.Migrations;

namespace Sem.Migrations
{
    public partial class EditAddressOfImmovables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "Immovables");

            migrationBuilder.AddColumn<int>(
                name: "Apartment",
                table: "Immovables",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<byte>(
                name: "Building",
                table: "Immovables",
                type: "smallint",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Immovables",
                type: "varchar(20)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "House",
                table: "Immovables",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Street",
                table: "Immovables",
                type: "varchar(20)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Apartment",
                table: "Immovables");

            migrationBuilder.DropColumn(
                name: "Building",
                table: "Immovables");

            migrationBuilder.DropColumn(
                name: "City",
                table: "Immovables");

            migrationBuilder.DropColumn(
                name: "House",
                table: "Immovables");

            migrationBuilder.DropColumn(
                name: "Street",
                table: "Immovables");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Immovables",
                type: "varchar(200)",
                nullable: true);
        }
    }
}
