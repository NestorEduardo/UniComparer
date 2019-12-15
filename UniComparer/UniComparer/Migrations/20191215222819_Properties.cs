using Microsoft.EntityFrameworkCore.Migrations;

namespace UniComparer.Migrations
{
    public partial class Properties : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreditNumbers",
                table: "GradeOffers");

            migrationBuilder.AddColumn<int>(
                name: "CreditsNumber",
                table: "GradeOffers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "CreditsPrice",
                table: "GradeOffers",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreditsNumber",
                table: "GradeOffers");

            migrationBuilder.DropColumn(
                name: "CreditsPrice",
                table: "GradeOffers");

            migrationBuilder.AddColumn<int>(
                name: "CreditNumbers",
                table: "GradeOffers",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
