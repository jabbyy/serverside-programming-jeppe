using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace server_prog_blazer_app.Migrations
{
    /// <inheritdoc />
    public partial class Todo2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "price",
                table: "Todos",
                newName: "Price");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Price",
                table: "Todos",
                newName: "price");
        }
    }
}
