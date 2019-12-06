using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UniComparer.Migrations
{
    public partial class GradeOffers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "GradeCategories");

            migrationBuilder.CreateTable(
                name: "AcademicPeriodCategories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    ModifiedAt = table.Column<DateTime>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AcademicPeriodCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Universities",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    ModifiedAt = table.Column<DateTime>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    ImageUrl = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Universities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GradeOffers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    ModifiedAt = table.Column<DateTime>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    CreditNumbers = table.Column<int>(nullable: false),
                    AcademicPeriodNumber = table.Column<int>(nullable: false),
                    Cost = table.Column<decimal>(nullable: false),
                    GradeId = table.Column<int>(nullable: false),
                    AcademicPeriodCategoryId = table.Column<int>(nullable: true),
                    UniversityId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GradeOffers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GradeOffers_AcademicPeriodCategories_AcademicPeriodCategoryId",
                        column: x => x.AcademicPeriodCategoryId,
                        principalTable: "AcademicPeriodCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GradeOffers_Grades_GradeId",
                        column: x => x.GradeId,
                        principalTable: "Grades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GradeOffers_Universities_UniversityId",
                        column: x => x.UniversityId,
                        principalTable: "Universities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GradeOffers_AcademicPeriodCategoryId",
                table: "GradeOffers",
                column: "AcademicPeriodCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_GradeOffers_GradeId",
                table: "GradeOffers",
                column: "GradeId");

            migrationBuilder.CreateIndex(
                name: "IX_GradeOffers_UniversityId",
                table: "GradeOffers",
                column: "UniversityId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GradeOffers");

            migrationBuilder.DropTable(
                name: "AcademicPeriodCategories");

            migrationBuilder.DropTable(
                name: "Universities");

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "GradeCategories",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
