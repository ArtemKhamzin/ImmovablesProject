using Microsoft.EntityFrameworkCore.Migrations;

namespace Sem.Migrations
{
    public partial class DeleteRequared : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sales_Immovables_ImmovableId",
                table: "Sales");

            migrationBuilder.AlterColumn<int>(
                name: "ImmovableId",
                table: "Sales",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<string>(
                name: "TypeOfImmovable",
                table: "Immovables",
                type: "varchar(30)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(30)");

            migrationBuilder.AlterColumn<string>(
                name: "RoomArea",
                table: "Immovables",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "Photo",
                table: "Immovables",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Immovables",
                type: "varchar(200)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(200)");

            migrationBuilder.AddForeignKey(
                name: "FK_Sales_Immovables_ImmovableId",
                table: "Sales",
                column: "ImmovableId",
                principalTable: "Immovables",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sales_Immovables_ImmovableId",
                table: "Sales");

            migrationBuilder.AlterColumn<int>(
                name: "ImmovableId",
                table: "Sales",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TypeOfImmovable",
                table: "Immovables",
                type: "varchar(30)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "varchar(30)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "RoomArea",
                table: "Immovables",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Photo",
                table: "Immovables",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Immovables",
                type: "varchar(200)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "varchar(200)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Sales_Immovables_ImmovableId",
                table: "Sales",
                column: "ImmovableId",
                principalTable: "Immovables",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
