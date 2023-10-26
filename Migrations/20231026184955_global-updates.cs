using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LongDrive.Migrations
{
    /// <inheritdoc />
    public partial class globalupdates : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tellimused_SoiduPaevikud_SoiduPaevikId",
                table: "Tellimused");

            migrationBuilder.DropForeignKey(
                name: "FK_Veoautod_SoiduPaevikud_SoiduPaevikId",
                table: "Veoautod");

            migrationBuilder.DropIndex(
                name: "IX_Veoautod_SoiduPaevikId",
                table: "Veoautod");

            migrationBuilder.DropIndex(
                name: "IX_Tellimused_SoiduPaevikId",
                table: "Tellimused");

            migrationBuilder.DropColumn(
                name: "SoiduPaevikId",
                table: "Veoautod");

            migrationBuilder.DropColumn(
                name: "SoiduPaevikId",
                table: "Tellimused");

            migrationBuilder.DropColumn(
                name: "Algus",
                table: "SoiduPaevikud");

            migrationBuilder.RenameColumn(
                name: "Lopp",
                table: "SoiduPaevikud",
                newName: "Aeg");

            migrationBuilder.AddColumn<DateTime>(
                name: "Algus",
                table: "Veoautod",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "Lopp",
                table: "Veoautod",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "TellimusId",
                table: "SoiduPaevikud",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "VeoautoId",
                table: "SoiduPaevikud",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_SoiduPaevikud_TellimusId",
                table: "SoiduPaevikud",
                column: "TellimusId");

            migrationBuilder.CreateIndex(
                name: "IX_SoiduPaevikud_VeoautoId",
                table: "SoiduPaevikud",
                column: "VeoautoId");

            migrationBuilder.AddForeignKey(
                name: "FK_SoiduPaevikud_Tellimused_TellimusId",
                table: "SoiduPaevikud",
                column: "TellimusId",
                principalTable: "Tellimused",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SoiduPaevikud_Veoautod_VeoautoId",
                table: "SoiduPaevikud",
                column: "VeoautoId",
                principalTable: "Veoautod",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SoiduPaevikud_Tellimused_TellimusId",
                table: "SoiduPaevikud");

            migrationBuilder.DropForeignKey(
                name: "FK_SoiduPaevikud_Veoautod_VeoautoId",
                table: "SoiduPaevikud");

            migrationBuilder.DropIndex(
                name: "IX_SoiduPaevikud_TellimusId",
                table: "SoiduPaevikud");

            migrationBuilder.DropIndex(
                name: "IX_SoiduPaevikud_VeoautoId",
                table: "SoiduPaevikud");

            migrationBuilder.DropColumn(
                name: "Algus",
                table: "Veoautod");

            migrationBuilder.DropColumn(
                name: "Lopp",
                table: "Veoautod");

            migrationBuilder.DropColumn(
                name: "TellimusId",
                table: "SoiduPaevikud");

            migrationBuilder.DropColumn(
                name: "VeoautoId",
                table: "SoiduPaevikud");

            migrationBuilder.RenameColumn(
                name: "Aeg",
                table: "SoiduPaevikud",
                newName: "Lopp");

            migrationBuilder.AddColumn<int>(
                name: "SoiduPaevikId",
                table: "Veoautod",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SoiduPaevikId",
                table: "Tellimused",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "Algus",
                table: "SoiduPaevikud",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateIndex(
                name: "IX_Veoautod_SoiduPaevikId",
                table: "Veoautod",
                column: "SoiduPaevikId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Veoautod_SoiduPaevikud_SoiduPaevikId",
                table: "Veoautod",
                column: "SoiduPaevikId",
                principalTable: "SoiduPaevikud",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
