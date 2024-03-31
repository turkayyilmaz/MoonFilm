using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MoonFilm.Migrations
{
    /// <inheritdoc />
    public partial class alksdm : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DirectorDescription",
                table: "Directors",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DirectorImage",
                table: "Directors",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DirectorDescription",
                table: "Directors");

            migrationBuilder.DropColumn(
                name: "DirectorImage",
                table: "Directors");
        }
    }
}
