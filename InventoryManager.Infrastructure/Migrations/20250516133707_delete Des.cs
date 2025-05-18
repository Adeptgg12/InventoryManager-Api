using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InventoryManager.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class deleteDes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "ProductTb");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "ProductTb",
                type: "nvarchar(200)",
                nullable: false,
                defaultValue: "");
        }
    }
}
