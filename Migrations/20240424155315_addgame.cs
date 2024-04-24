using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mist452FinalProject.Migrations
{
    /// <inheritdoc />
    public partial class addgame : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    GameID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    gameDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    opponent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    score = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    posessionStat = table.Column<int>(type: "int", nullable: false),
                    shotsStat = table.Column<int>(type: "int", nullable: false),
                    SavesStat = table.Column<int>(type: "int", nullable: false),
                    foulsStat = table.Column<int>(type: "int", nullable: false),
                    filmURL = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.GameID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Games");
        }
    }
}
