using Microsoft.EntityFrameworkCore.Migrations;

namespace SlnIannielloRocio.Migrations
{
    public partial class inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Recetas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ingredientes = table.Column<string>(type: "varchar(2000)", nullable: false),
                    Instrucciones = table.Column<string>(type: "varchar(2000)", nullable: false),
                    AutorNombre = table.Column<string>(type: "varchar(50)", nullable: false),
                    AutorApellido = table.Column<string>(type: "varchar(50)", nullable: false),
                    Edad = table.Column<int>(nullable: false),
                    Email = table.Column<string>(type: "varchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recetas", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Recetas");
        }
    }
}
