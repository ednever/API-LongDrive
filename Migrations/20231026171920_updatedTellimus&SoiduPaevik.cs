using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LongDrive.Migrations
{
    /// <inheritdoc />
    public partial class updatedTellimusSoiduPaevik : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SoiduPaevikud_Tellimused_TellimusId",
                table: "SoiduPaevikud");

            migrationBuilder.DropIndex(
                name: "IX_SoiduPaevikud_TellimusId",
                table: "SoiduPaevikud");

            migrationBuilder.DropColumn(
                name: "TellimusId",
                table: "SoiduPaevikud");

            migrationBuilder.AddColumn<int>(
                name: "SoiduPaevikId",
                table: "Tellimused",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Tellimused_SoiduPaevikId",
                table: "Tellimused",
                column: "SoiduPaevikId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tellimused_SoiduPaevikud_SoiduPaevikId",
                table: "Tellimused",
                column: "SoiduPaevikId",
                principalTable: "SoiduPaevikud",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tellimused_SoiduPaevikud_SoiduPaevikId",
                table: "Tellimused");

            migrationBuilder.DropIndex(
                name: "IX_Tellimused_SoiduPaevikId",
                table: "Tellimused");

            migrationBuilder.DropColumn(
                name: "SoiduPaevikId",
                table: "Tellimused");

            migrationBuilder.AddColumn<int>(
                name: "TellimusId",
                table: "SoiduPaevikud",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_SoiduPaevikud_TellimusId",
                table: "SoiduPaevikud",
                column: "TellimusId");

            migrationBuilder.AddForeignKey(
                name: "FK_SoiduPaevikud_Tellimused_TellimusId",
                table: "SoiduPaevikud",
                column: "TellimusId",
                principalTable: "Tellimused",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
