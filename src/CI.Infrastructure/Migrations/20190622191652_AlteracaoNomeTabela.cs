using Microsoft.EntityFrameworkCore.Migrations;

namespace CI.Infrastructure.Migrations
{
    public partial class AlteracaoNomeTabela : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Pessoa",
                table: "Pessoa");

            migrationBuilder.RenameTable(
                name: "Pessoa",
                newName: "Investidores");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Investidores",
                table: "Investidores",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Investidores",
                table: "Investidores");

            migrationBuilder.RenameTable(
                name: "Investidores",
                newName: "Pessoa");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pessoa",
                table: "Pessoa",
                column: "Id");
        }
    }
}
