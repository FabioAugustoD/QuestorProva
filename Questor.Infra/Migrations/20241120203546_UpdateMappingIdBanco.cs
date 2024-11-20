using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Questor.Infra.Migrations
{
    public partial class UpdateMappingIdBanco : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "id_banco",
                table: "tb_boleto",
                newName: "IdBanco");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IdBanco",
                table: "tb_boleto",
                newName: "id_banco");
        }
    }
}
