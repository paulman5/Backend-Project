using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DB_Layer1_Draftflex.Migrations
{
    /// <inheritdoc />
    public partial class Companies_Name : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CompanyName",
                table: "Companies",
                nullable: true); // You can adjust the column configuration as needed
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CompanyName",
                table: "Companies");
        }
    }
}
