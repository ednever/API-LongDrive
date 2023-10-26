using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LongDrive.Migrations
{
    /// <inheritdoc />
    public partial class deletedLiikuvAuto : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Tee",
                table: "Veoautod");

            migrationBuilder.DropColumn(
                name: "Tee",
                table: "Soiduautod");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Tee",
                table: "Veoautod",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Tee",
                table: "Soiduautod",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
