using Microsoft.EntityFrameworkCore.Migrations;

namespace Sem.Migrations
{
    public partial class AddSchemeImage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SchemeImage",
                table: "Immovables",
                type: "text",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SchemeImage",
                table: "Immovables");
        }
    }
}
