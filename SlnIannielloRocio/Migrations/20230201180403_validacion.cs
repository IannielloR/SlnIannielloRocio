using Microsoft.EntityFrameworkCore.Migrations;

namespace SlnIannielloRocio.Migrations
{
    public partial class validacion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Categoria",
                table: "Recetas",
                type: "varchar(50)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Titulo",
                table: "Recetas",
                type: "varchar(2000)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Categoria",
                table: "Recetas");

            migrationBuilder.DropColumn(
                name: "Titulo",
                table: "Recetas");
        }
    }
}
