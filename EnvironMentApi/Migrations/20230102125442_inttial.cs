using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EnvironMentApi.Migrations
{
    public partial class inttial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Enviornments",
                columns: table => new
                {
                    EnvironMentId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    InstitutionId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EnvironMentName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enviornments", x => x.EnvironMentId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Enviornments");
        }
    }
}
