using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LongDrive.Migrations
{
    /// <inheritdoc />
    public partial class updatedTellimus : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Tellimused",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Tellimused");
        }
    }
}
