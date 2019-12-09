using Microsoft.EntityFrameworkCore.Migrations;

namespace UniComparer.Migrations
{
    public partial class PensumUrl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PensumUrl",
                table: "GradeOffers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PensumUrl",
                table: "GradeOffers");
        }
    }
}
