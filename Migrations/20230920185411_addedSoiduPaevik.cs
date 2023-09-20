using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LongDrive.Migrations
{
    /// <inheritdoc />
    public partial class addedSoiduPaevik : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SoiduPaevikId",
                table: "Veoautod",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "SoiduPaevikud",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TellimusId = table.Column<int>(type: "int", nullable: false),
                    Algus = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Lopp = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SoiduPaevikud", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SoiduPaevikud_Tellimused_TellimusId",
                        column: x => x.TellimusId,
                        principalTable: "Tellimused",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Veoautod_SoiduPaevikId",
                table: "Veoautod",
                column: "SoiduPaevikId");

            migrationBuilder.CreateIndex(
                name: "IX_SoiduPaevikud_TellimusId",
                table: "SoiduPaevikud",
                column: "TellimusId");

            migrationBuilder.AddForeignKey(
                name: "FK_Veoautod_SoiduPaevikud_SoiduPaevikId",
                table: "Veoautod",
                column: "SoiduPaevikId",
                principalTable: "SoiduPaevikud",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Veoautod_SoiduPaevikud_SoiduPaevikId",
                table: "Veoautod");

            migrationBuilder.DropTable(
                name: "SoiduPaevikud");

            migrationBuilder.DropIndex(
                name: "IX_Veoautod_SoiduPaevikId",
                table: "Veoautod");

            migrationBuilder.DropColumn(
                name: "SoiduPaevikId",
                table: "Veoautod");
        }
    }
}
