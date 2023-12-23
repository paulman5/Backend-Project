using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DB_Layer1_Draftflex.Migrations
{
    /// <inheritdoc />
    public partial class Company_DataType_Update : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.DropColumn(
                name: "LicenseId",
                table: "Companies");

            migrationBuilder.AddColumn<int>(
                name: "LicenseId_New",
                table: "Companies");

            migrationBuilder.RenameColumn(
                name: "LicenseId_New",
                table: "Companies",
                newName: "LicenseId");
        }
        
        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
