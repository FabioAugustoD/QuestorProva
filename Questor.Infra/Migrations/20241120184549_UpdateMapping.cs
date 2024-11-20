using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Questor.Infra.Migrations
{
    public partial class UpdateMapping : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Boletos_Bancos_BancoId",
                table: "Boletos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Boletos",
                table: "Boletos");

            migrationBuilder.RenameTable(
                name: "Boletos",
                newName: "tb_boleto");

            migrationBuilder.RenameColumn(
                name: "Valor",
                table: "tb_boleto",
                newName: "valor");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "tb_boleto",
                newName: "nome");

            migrationBuilder.RenameColumn(
                name: "CPF",
                table: "tb_boleto",
                newName: "cpf");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "tb_boleto",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "NomeBeneficiario",
                table: "tb_boleto",
                newName: "nome_beneficiario");

            migrationBuilder.RenameColumn(
                name: "IdBanco",
                table: "tb_boleto",
                newName: "id_banco");

            migrationBuilder.RenameColumn(
                name: "DataVencimento",
                table: "tb_boleto",
                newName: "vencimento");

            migrationBuilder.RenameColumn(
                name: "CPFBeneficiario",
                table: "tb_boleto",
                newName: "cpf_beneficiario");

            migrationBuilder.RenameIndex(
                name: "IX_Boletos_BancoId",
                table: "tb_boleto",
                newName: "IX_tb_boleto_BancoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tb_boleto",
                table: "tb_boleto",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_tb_boleto_Bancos_BancoId",
                table: "tb_boleto",
                column: "BancoId",
                principalTable: "Bancos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tb_boleto_Bancos_BancoId",
                table: "tb_boleto");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tb_boleto",
                table: "tb_boleto");

            migrationBuilder.RenameTable(
                name: "tb_boleto",
                newName: "Boletos");

            migrationBuilder.RenameColumn(
                name: "valor",
                table: "Boletos",
                newName: "Valor");

            migrationBuilder.RenameColumn(
                name: "nome",
                table: "Boletos",
                newName: "Nome");

            migrationBuilder.RenameColumn(
                name: "cpf",
                table: "Boletos",
                newName: "CPF");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Boletos",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "vencimento",
                table: "Boletos",
                newName: "DataVencimento");

            migrationBuilder.RenameColumn(
                name: "nome_beneficiario",
                table: "Boletos",
                newName: "NomeBeneficiario");

            migrationBuilder.RenameColumn(
                name: "id_banco",
                table: "Boletos",
                newName: "IdBanco");

            migrationBuilder.RenameColumn(
                name: "cpf_beneficiario",
                table: "Boletos",
                newName: "CPFBeneficiario");

            migrationBuilder.RenameIndex(
                name: "IX_tb_boleto_BancoId",
                table: "Boletos",
                newName: "IX_Boletos_BancoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Boletos",
                table: "Boletos",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Boletos_Bancos_BancoId",
                table: "Boletos",
                column: "BancoId",
                principalTable: "Bancos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
