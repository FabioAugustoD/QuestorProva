using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Questor.Infra.Migrations
{
    public partial class UpdateMappingLatest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tb_boleto_Bancos_BancoId",
                table: "tb_boleto");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Bancos",
                table: "Bancos");

            migrationBuilder.RenameTable(
                name: "Bancos",
                newName: "tb_banco");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "tb_banco",
                newName: "nome");

            migrationBuilder.RenameColumn(
                name: "Juros",
                table: "tb_banco",
                newName: "juros");

            migrationBuilder.RenameColumn(
                name: "Codigo",
                table: "tb_banco",
                newName: "codigo");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "tb_banco",
                newName: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tb_banco",
                table: "tb_banco",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_tb_boleto_tb_banco_BancoId",
                table: "tb_boleto",
                column: "BancoId",
                principalTable: "tb_banco",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tb_boleto_tb_banco_BancoId",
                table: "tb_boleto");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tb_banco",
                table: "tb_banco");

            migrationBuilder.RenameTable(
                name: "tb_banco",
                newName: "Bancos");

            migrationBuilder.RenameColumn(
                name: "nome",
                table: "Bancos",
                newName: "Nome");

            migrationBuilder.RenameColumn(
                name: "juros",
                table: "Bancos",
                newName: "Juros");

            migrationBuilder.RenameColumn(
                name: "codigo",
                table: "Bancos",
                newName: "Codigo");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Bancos",
                newName: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Bancos",
                table: "Bancos",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_tb_boleto_Bancos_BancoId",
                table: "tb_boleto",
                column: "BancoId",
                principalTable: "Bancos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
