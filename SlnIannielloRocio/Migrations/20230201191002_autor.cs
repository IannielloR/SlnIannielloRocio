using Microsoft.EntityFrameworkCore.Migrations;

namespace SlnIannielloRocio.Migrations
{
    public partial class autor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AutorNombre",
                table: "Recetas",
                newName: "Autor");

            migrationBuilder.RenameColumn(
                name: "AutorApellido",
                table: "Recetas",
                newName: "Apellido");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Autor",
                table: "Recetas",
                newName: "AutorNombre");

            migrationBuilder.RenameColumn(
                name: "Apellido",
                table: "Recetas",
                newName: "AutorApellido");
        }
    }
}
