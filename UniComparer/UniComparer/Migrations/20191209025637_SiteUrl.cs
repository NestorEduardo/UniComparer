using Microsoft.EntityFrameworkCore.Migrations;

namespace UniComparer.Migrations
{
    public partial class SiteUrl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SiteUrl",
                table: "Universities",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SiteUrl",
                table: "Universities");
        }
    }
}
