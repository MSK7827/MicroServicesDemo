using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SorApi.Migrations
{
    public partial class intial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sors",
                columns: table => new
                {
                    SorId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    InstitutionId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EnvironMentId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SorName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SorDescription = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sors", x => x.SorId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sors");
        }
    }
}
