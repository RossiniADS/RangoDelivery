using Microsoft.EntityFrameworkCore.Migrations;

namespace RangoDelivery.Repositorio.Migrations
{
    public partial class AdicionarColunaAdminCliente : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "EhAdministrador",
                table: "Clientes",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EhAdministrador",
                table: "Clientes");
        }
    }
}
