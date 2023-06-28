using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetoHotelSerranoSenac.Migrations
{
    /// <inheritdoc />
    public partial class criarViewProduto : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "HotelId",
                table: "Produtos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "Quantidade",
                table: "Produtos",
                type: "double",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.CreateIndex(
                name: "IX_Produtos_HotelId",
                table: "Produtos",
                column: "HotelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Produtos_Hoteis_HotelId",
                table: "Produtos",
                column: "HotelId",
                principalTable: "Hoteis",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produtos_Hoteis_HotelId",
                table: "Produtos");

            migrationBuilder.DropIndex(
                name: "IX_Produtos_HotelId",
                table: "Produtos");

            migrationBuilder.DropColumn(
                name: "HotelId",
                table: "Produtos");

            migrationBuilder.DropColumn(
                name: "Quantidade",
                table: "Produtos");
        }
    }
}
