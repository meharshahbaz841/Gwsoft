using Microsoft.EntityFrameworkCore.Migrations;

namespace Task_111.Migrations
{
    public partial class AddLavelAttribute : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Lavel",
                table: "GL_CONTROL_ACCOUNTs",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Lavel",
                table: "GL_CONTROL_ACCOUNTs");
        }
    }
}
