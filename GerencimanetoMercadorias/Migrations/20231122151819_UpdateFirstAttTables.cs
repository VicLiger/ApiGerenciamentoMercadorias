using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GerencimanetoMercadorias.Migrations
{
    /// <inheritdoc />
    public partial class UpdateFirstAttTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categorias",
                columns: table => new
                {
                    CategoriasId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorias", x => x.CategoriasId);
                });

            migrationBuilder.CreateTable(
                name: "Produtos",
                columns: table => new
                {
                    ProdutosId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    Estoque = table.Column<int>(type: "int", nullable: false),
                    Preco = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    UltimaAlteracao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CategoriaId = table.Column<int>(type: "int", nullable: false),
                    CategoriasId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produtos", x => x.ProdutosId);
                    table.ForeignKey(
                        name: "FK_Produtos_Categorias_CategoriasId",
                        column: x => x.CategoriasId,
                        principalTable: "Categorias",
                        principalColumn: "CategoriasId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Produtos_CategoriasId",
                table: "Produtos",
                column: "CategoriasId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Produtos");

            migrationBuilder.DropTable(
                name: "Categorias");
        }
    }
}
