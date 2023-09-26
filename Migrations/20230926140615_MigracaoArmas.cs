using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RpgApi.Migrations
{
    /// <inheritdoc />
    public partial class MigracaoArmas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TB_ARMAS",
                columns: table => new
                {
                    IdF = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeF = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DanoF = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_ARMAS", x => x.IdF);
                });

            migrationBuilder.InsertData(
                table: "TB_ARMAS",
                columns: new[] { "IdF", "DanoF", "NomeF" },
                values: new object[,]
                {
                    { 1, 50, "Espada de cria demoniaca" },
                    { 2, 45, "Faca envenenada" },
                    { 3, 75, "Arco da fenda do vazio" },
                    { 4, 69, "Machado do Cleyton" },
                    { 5, 35, "Chicote do Desejo" },
                    { 6, 42, "Baseball BAT" },
                    { 7, 50, "Manopla do grande roxo" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TB_ARMAS");
        }
    }
}
