using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Questor.Infra.Migrations
{
    public partial class UpdateMappingIdBancoFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdBanco",
                table: "tb_boleto");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdBanco",
                table: "tb_boleto",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
