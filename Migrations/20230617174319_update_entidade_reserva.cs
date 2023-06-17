using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetoHotelSerranoSenac.Migrations
{
    /// <inheritdoc />
    public partial class update_entidade_reserva : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ReservaServico_Funcionarios_FuncionarioId",
                table: "ReservaServico");

            migrationBuilder.DropIndex(
                name: "IX_ReservaServico_FuncionarioId",
                table: "ReservaServico");

            migrationBuilder.DropColumn(
                name: "QuantidadeEstoque",
                table: "Produtos");

            migrationBuilder.RenameColumn(
                name: "FuncionarioId",
                table: "ReservaServico",
                newName: "Quantidade");

            migrationBuilder.AddColumn<DateTime>(
                name: "DataServico",
                table: "ReservaServico",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "Quantidade",
                table: "ReservaProduto",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "Role",
                table: "Funcionarios",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Senha",
                table: "Funcionarios",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataServico",
                table: "ReservaServico");

            migrationBuilder.DropColumn(
                name: "Quantidade",
                table: "ReservaProduto");

            migrationBuilder.DropColumn(
                name: "Senha",
                table: "Funcionarios");

            migrationBuilder.RenameColumn(
                name: "Quantidade",
                table: "ReservaServico",
                newName: "FuncionarioId");

            migrationBuilder.AddColumn<int>(
                name: "QuantidadeEstoque",
                table: "Produtos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Role",
                table: "Funcionarios",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_ReservaServico_FuncionarioId",
                table: "ReservaServico",
                column: "FuncionarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_ReservaServico_Funcionarios_FuncionarioId",
                table: "ReservaServico",
                column: "FuncionarioId",
                principalTable: "Funcionarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
