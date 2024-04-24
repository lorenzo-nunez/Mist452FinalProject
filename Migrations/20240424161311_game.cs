using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Mist452FinalProject.Migrations
{
    /// <inheritdoc />
    public partial class game : Migration
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

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "GameID", "SavesStat", "filmURL", "foulsStat", "gameDate", "opponent", "posessionStat", "score", "shotsStat" },
                values: new object[,]
                {
                    { 1, 5, "http://example.com/game1film", 8, "2023-04-10", "Team A", 54, "2-1", 15 },
                    { 2, 7, "http://example.com/game2film", 11, "2023-04-17", "Team B", 60, "1-1", 20 },
                    { 3, 3, "http://example.com/game3film", 14, "2023-04-24", "Team C", 48, "0-3", 12 }
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
