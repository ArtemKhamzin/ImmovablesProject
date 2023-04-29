using Microsoft.EntityFrameworkCore.Migrations;

namespace Sem.Migrations
{
    public partial class DeleteRentOrSale : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SaleOrRent",
                table: "Immovables");

            migrationBuilder.AlterColumn<string>(
                name: "RoomArea",
                table: "Immovables",
                type: "text",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "RoomArea",
                table: "Immovables",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SaleOrRent",
                table: "Immovables",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }
    }
}
