using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LongDrive.Migrations
{
    /// <inheritdoc />
    public partial class updatedSoiduauto : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Pilt",
                table: "Soiduautod",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Pilt",
                table: "Soiduautod");
        }
    }
}
