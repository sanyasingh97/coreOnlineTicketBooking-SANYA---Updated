using Microsoft.EntityFrameworkCore.Migrations;

namespace coreMovieTicketAdminPortal.Migrations
{
    public partial class initialdbss : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MovieDescription",
                table: "Movies",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MovieDescription",
                table: "Movies");
        }
    }
}
