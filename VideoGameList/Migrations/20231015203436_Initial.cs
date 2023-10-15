using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace VideoGameList.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "videoGames",
                columns: table => new
                {
                    videoGameId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    favoriteCharacter = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    wouldPlayAgain = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_videoGames", x => x.videoGameId);
                });

            migrationBuilder.InsertData(
                table: "videoGames",
                columns: new[] { "videoGameId", "favoriteCharacter", "name", "wouldPlayAgain" },
                values: new object[,]
                {
                    { 1, "alucard", "Castlevania Symphony of the Night", true },
                    { 2, "Protagonist", "Factorio", null },
                    { 3, "Protagonist", "satisfactory", false }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "videoGames");
        }
    }
}
