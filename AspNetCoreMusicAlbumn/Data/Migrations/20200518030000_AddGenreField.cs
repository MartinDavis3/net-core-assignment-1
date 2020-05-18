using Microsoft.EntityFrameworkCore.Migrations;

namespace AspNetCoreMusicAlbumn.Data.Migrations
{
    public partial class AddGenreField : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Genre",
                table: "Items",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Genre",
                table: "Items");
        }
    }
}
