using Microsoft.EntityFrameworkCore.Migrations;

namespace MovieCatalogue.Data.Migrations
{
    public partial class AddGenre : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MovieId",
                table: "Genres",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MovieId",
                table: "Genres");
        }
    }
}
