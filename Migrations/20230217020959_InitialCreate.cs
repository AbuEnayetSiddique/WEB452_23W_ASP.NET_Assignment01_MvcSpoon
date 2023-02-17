using Microsoft.EntityFrameworkCore.Migrations;

namespace MvcSpoon.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Spoon",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeOfSpoon = table.Column<string>(nullable: true),
                    Material = table.Column<string>(nullable: true),
                    Measurement = table.Column<decimal>(nullable: false),
                    Color = table.Column<string>(nullable: true),
                    Weight = table.Column<decimal>(nullable: false),
                    Price = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Spoon", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Spoon");
        }
    }
}
