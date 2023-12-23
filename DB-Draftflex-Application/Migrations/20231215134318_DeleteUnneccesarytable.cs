using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DB_Layer1_Draftflex.Migrations
{
    /// <inheritdoc />
    public partial class DeleteUnneccesarytable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Mongooltjes");

            migrationBuilder.AddColumn<string>(
                name: "Role1",
                table: "Users",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Role1",
                table: "Users");

            migrationBuilder.CreateTable(
                name: "Mongooltjes",
                columns: table => new
                {
                    mongool = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mongooltjes", x => x.mongool);
                });
        }
    }
}
