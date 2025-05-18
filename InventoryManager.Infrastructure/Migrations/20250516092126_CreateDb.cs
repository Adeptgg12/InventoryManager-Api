using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InventoryManager.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class CreateDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProductTb",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(200)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", nullable: false),
                    Unit = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductTb", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "StockTransactionTb",
                columns: table => new
                {
                    StockTransactionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    TransactionType = table.Column<string>(type: "nvarchar(10)", nullable: false),
                    TransactionDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockTransactionTb", x => x.StockTransactionId);
                    table.ForeignKey(
                        name: "FK_StockTransactionTb_ProductTb_ProductId",
                        column: x => x.ProductId,
                        principalTable: "ProductTb",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_StockTransactionTb_ProductId",
                table: "StockTransactionTb",
                column: "ProductId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StockTransactionTb");

            migrationBuilder.DropTable(
                name: "ProductTb");
        }
    }
}
