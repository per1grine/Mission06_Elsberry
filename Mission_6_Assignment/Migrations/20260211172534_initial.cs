using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mission_6_Assignment.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MovieCatalog",
                columns: table => new
                {
                    MovieID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    MovieCategory = table.Column<string>(type: "TEXT", nullable: false),
                    MovieTitle = table.Column<string>(type: "TEXT", nullable: false),
                    MovieYear = table.Column<int>(type: "INTEGER", nullable: false),
                    MovieDirector = table.Column<string>(type: "TEXT", nullable: false),
                    MovieRating = table.Column<string>(type: "TEXT", nullable: false),
                    MovieEdited = table.Column<bool>(type: "INTEGER", nullable: false),
                    MovieLentTo = table.Column<string>(type: "TEXT", nullable: false),
                    MovieNotes = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieCatalog", x => x.MovieID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MovieCatalog");
        }
    }
}
