using Microsoft.EntityFrameworkCore.Migrations;

namespace EMigrant.App.Persistencia.Migrations
{
    public partial class MigraCol : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "nombrec",
                table: "Colaboradores",
                newName: "telefono");

            migrationBuilder.AddColumn<string>(
                name: "ciudad",
                table: "Colaboradores",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "direcion",
                table: "Colaboradores",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "email",
                table: "Colaboradores",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "nit",
                table: "Colaboradores",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "paginaweb",
                table: "Colaboradores",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "razonsocial",
                table: "Colaboradores",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "sector",
                table: "Colaboradores",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "servicio",
                table: "Colaboradores",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ciudad",
                table: "Colaboradores");

            migrationBuilder.DropColumn(
                name: "direcion",
                table: "Colaboradores");

            migrationBuilder.DropColumn(
                name: "email",
                table: "Colaboradores");

            migrationBuilder.DropColumn(
                name: "nit",
                table: "Colaboradores");

            migrationBuilder.DropColumn(
                name: "paginaweb",
                table: "Colaboradores");

            migrationBuilder.DropColumn(
                name: "razonsocial",
                table: "Colaboradores");

            migrationBuilder.DropColumn(
                name: "sector",
                table: "Colaboradores");

            migrationBuilder.DropColumn(
                name: "servicio",
                table: "Colaboradores");

            migrationBuilder.RenameColumn(
                name: "telefono",
                table: "Colaboradores",
                newName: "nombrec");
        }
    }
}
