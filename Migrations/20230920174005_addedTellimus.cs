using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LongDrive.Migrations
{
    /// <inheritdoc />
    public partial class addedTellimus : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Soiduautod",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Pikkus = table.Column<double>(type: "float", nullable: false),
                    Mass = table.Column<int>(type: "int", nullable: false),
                    Mark = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tee = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Soiduautod", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tellimused",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nimi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Vahemaa = table.Column<int>(type: "int", nullable: false),
                    Kirjeldus = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tellimused", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Veoautod",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Pikkus = table.Column<double>(type: "float", nullable: false),
                    Mass = table.Column<int>(type: "int", nullable: false),
                    Mark = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tee = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Veoautod", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Soiduautod");

            migrationBuilder.DropTable(
                name: "Tellimused");

            migrationBuilder.DropTable(
                name: "Veoautod");
        }
    }
}
