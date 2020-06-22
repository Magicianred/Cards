using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Cards.Repository.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cards",
                columns: table => new
                {
                    CardID = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CustomerID = table.Column<Guid>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cards", x => x.CardID);
                });

            migrationBuilder.CreateTable(
                name: "CardItem",
                columns: table => new
                {
                    CardItemID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CardID = table.Column<long>(nullable: false),
                    CustomerID = table.Column<Guid>(nullable: false),
                    ProductID = table.Column<Guid>(nullable: false),
                    Quantity = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CardItem", x => x.CardItemID);
                    table.ForeignKey(
                        name: "FK_CardItem_Cards_CardID",
                        column: x => x.CardID,
                        principalTable: "Cards",
                        principalColumn: "CardID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CardItem_CardID",
                table: "CardItem",
                column: "CardID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CardItem");

            migrationBuilder.DropTable(
                name: "Cards");
        }
    }
}
