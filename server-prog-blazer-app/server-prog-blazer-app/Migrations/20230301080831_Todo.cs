using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace server_prog_blazer_app.Migrations
{
    /// <inheritdoc />
    public partial class Todo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Todos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserEmailId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TodoTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StackSize = table.Column<int>(type: "int", nullable: false),
                    price = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Todos", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Todos");
        }
    }
}
