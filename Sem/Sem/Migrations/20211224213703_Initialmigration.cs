using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Sem.Migrations
{
    public partial class Initialmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Immovables",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    SaleOrRent = table.Column<int>(type: "integer", nullable: false),
                    Address = table.Column<string>(type: "varchar(200)", nullable: false),
                    NumberOfRooms = table.Column<byte>(type: "smallint", nullable: false),
                    TypeOfImmovable = table.Column<string>(type: "varchar(30)", nullable: false),
                    RoomArea = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Immovables", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Status = table.Column<byte>(type: "smallint", nullable: false),
                    Email = table.Column<string>(type: "varchar(30)", nullable: false),
                    Name = table.Column<string>(type: "varchar(30)", nullable: true),
                    Surname = table.Column<string>(type: "varchar(50)", nullable: true),
                    HashedPassword = table.Column<string>(type: "varchar(32)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "varchar(20)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Mortgages",
                columns: table => new
                {
                    MortgageId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<int>(type: "integer", nullable: true),
                    Bank = table.Column<string>(type: "text", nullable: true),
                    MortgageRate = table.Column<int>(type: "integer", nullable: false),
                    MonthlyPayment = table.Column<int>(type: "integer", nullable: false),
                    Term = table.Column<byte>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mortgages", x => x.MortgageId);
                    table.ForeignKey(
                        name: "FK_Mortgages_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Rents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ImmovableId = table.Column<int>(type: "integer", nullable: true),
                    UserId = table.Column<int>(type: "integer", nullable: true),
                    Price = table.Column<int>(type: "integer", nullable: false),
                    RentBegin = table.Column<DateTime>(type: "date", nullable: false),
                    RentEnd = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rents_Immovables_ImmovableId",
                        column: x => x.ImmovableId,
                        principalTable: "Immovables",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Rents_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Sales",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ImmovableId = table.Column<int>(type: "integer", nullable: false),
                    UserId = table.Column<int>(type: "integer", nullable: true),
                    Price = table.Column<int>(type: "integer", nullable: false),
                    PostingDate = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sales", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sales_Immovables_ImmovableId",
                        column: x => x.ImmovableId,
                        principalTable: "Immovables",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Sales_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Mortgages_UserId",
                table: "Mortgages",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Rents_ImmovableId",
                table: "Rents",
                column: "ImmovableId");

            migrationBuilder.CreateIndex(
                name: "IX_Rents_UserId",
                table: "Rents",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Sales_ImmovableId",
                table: "Sales",
                column: "ImmovableId");

            migrationBuilder.CreateIndex(
                name: "IX_Sales_UserId",
                table: "Sales",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Mortgages");

            migrationBuilder.DropTable(
                name: "Rents");

            migrationBuilder.DropTable(
                name: "Sales");

            migrationBuilder.DropTable(
                name: "Immovables");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
