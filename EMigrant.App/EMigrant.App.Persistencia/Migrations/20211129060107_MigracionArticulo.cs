using Microsoft.EntityFrameworkCore.Migrations;

namespace EMigrant.App.Persistencia.Migrations
{
    public partial class MigracionArticulo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Articulos",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    activor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tituloArticulo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    fechaNovedad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    diasArticulo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    textoArticulo = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Articulos", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Articulos");
        }
    }
}
