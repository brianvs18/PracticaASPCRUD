using Microsoft.EntityFrameworkCore.Migrations;

namespace PracticaASPCRUD.Migrations
{
    public partial class cambiodenombre : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NombreEmpleado",
                table: "Empleados",
                newName: "Nombre");

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "Empleados",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Nombre",
                table: "Empleados",
                newName: "NombreEmpleado");

            migrationBuilder.AlterColumn<string>(
                name: "NombreEmpleado",
                table: "Empleados",
                type: "nvarchar(50)",
                nullable: false,
                oldClrType: typeof(string));
        }
    }
}
