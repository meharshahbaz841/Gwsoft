using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Task_111.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GL_CONTROL_ACCOUNTs",
                columns: table => new
                {
                    CHART_OF_ACCOUNT_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CHART_OF_ACCOUNT_CODE = table.Column<string>(maxLength: 50, nullable: false),
                    DESCRIPTION = table.Column<string>(maxLength: 200, nullable: false),
                    PARENT_CONTROL_ACCOUNT_ID = table.Column<int>(nullable: true),
                    CREATED_BY = table.Column<int>(nullable: false),
                    CREATION_DATE = table.Column<DateTime>(nullable: false),
                    LAST_UPDATED_BY = table.Column<int>(nullable: true),
                    LAST_UPDATE_DATE = table.Column<DateTime>(nullable: true),
                    SEGMENT1 = table.Column<string>(maxLength: 250, nullable: true),
                    FOR_COST_CENTER = table.Column<string>(maxLength: 50, nullable: true),
                    SUB_ACCOUNT_CODE = table.Column<string>(maxLength: 50, nullable: true),
                    FOR_PROJECTS = table.Column<string>(maxLength: 50, nullable: true),
                    NOTES = table.Column<int>(maxLength: 16, nullable: true),
                    BS_DR_ACC_ID = table.Column<int>(maxLength: 16, nullable: true),
                    BS_CR_ACC_ID = table.Column<int>(maxLength: 16, nullable: true),
                    IN_ACTIVE = table.Column<int>(maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GL_CONTROL_ACCOUNTs", x => x.CHART_OF_ACCOUNT_ID);
                });

            migrationBuilder.CreateTable(
                name: "GL_CHART_OF_ACCOUNTs",
                columns: table => new
                {
                    CONTROL_ACCOUNT_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CONTROL_ACCOUNT_CODE = table.Column<string>(maxLength: 20, nullable: false),
                    DESCRIPTION = table.Column<string>(maxLength: 100, nullable: false),
                    PARENT_CONTROL_ACCOUNT_ID = table.Column<int>(nullable: true),
                    CREATED_BY = table.Column<int>(maxLength: 8, nullable: false),
                    CREATION_DATE = table.Column<DateTime>(nullable: false),
                    LAST_UPDATED_BY = table.Column<int>(maxLength: 8, nullable: true),
                    LAST_UPDATE_DATE = table.Column<DateTime>(nullable: true),
                    RECORD_LEVEL = table.Column<int>(maxLength: 1, nullable: true),
                    GL_C_ACCOUNT_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GL_CHART_OF_ACCOUNTs", x => x.CONTROL_ACCOUNT_ID);
                    table.ForeignKey(
                        name: "FK_GL_CHART_OF_ACCOUNTs_GL_CONTROL_ACCOUNTs_GL_C_ACCOUNT_id",
                        column: x => x.GL_C_ACCOUNT_id,
                        principalTable: "GL_CONTROL_ACCOUNTs",
                        principalColumn: "CHART_OF_ACCOUNT_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GL_CHART_OF_ACCOUNTs_GL_C_ACCOUNT_id",
                table: "GL_CHART_OF_ACCOUNTs",
                column: "GL_C_ACCOUNT_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GL_CHART_OF_ACCOUNTs");

            migrationBuilder.DropTable(
                name: "GL_CONTROL_ACCOUNTs");
        }
    }
}
