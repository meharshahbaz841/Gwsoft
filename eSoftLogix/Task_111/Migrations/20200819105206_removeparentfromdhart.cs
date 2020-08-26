using Microsoft.EntityFrameworkCore.Migrations;

namespace Task_111.Migrations
{
    public partial class removeparentfromdhart : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PARENT_CONTROL_ACCOUNT_ID",
                table: "GL_CHART_OF_ACCOUNTs");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PARENT_CONTROL_ACCOUNT_ID",
                table: "GL_CHART_OF_ACCOUNTs",
                nullable: true);
        }
    }
}
