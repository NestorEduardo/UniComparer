using Microsoft.EntityFrameworkCore.Migrations;

namespace UniComparer.Migrations
{
    public partial class InscriptionPrice : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "InscriptionPrice",
                table: "GradeOffers",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "InscriptionPrice",
                table: "GradeOffers");
        }
    }
}
