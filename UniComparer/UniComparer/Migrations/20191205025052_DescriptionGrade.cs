using Microsoft.EntityFrameworkCore.Migrations;

namespace UniComparer.Migrations
{
    public partial class DescriptionGrade : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Grades_GradeCategories_GradeCategoryId",
                table: "Grades");

            migrationBuilder.AlterColumn<int>(
                name: "GradeCategoryId",
                table: "Grades",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Grades",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Grades_GradeCategories_GradeCategoryId",
                table: "Grades",
                column: "GradeCategoryId",
                principalTable: "GradeCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Grades_GradeCategories_GradeCategoryId",
                table: "Grades");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Grades");

            migrationBuilder.AlterColumn<int>(
                name: "GradeCategoryId",
                table: "Grades",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Grades_GradeCategories_GradeCategoryId",
                table: "Grades",
                column: "GradeCategoryId",
                principalTable: "GradeCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
