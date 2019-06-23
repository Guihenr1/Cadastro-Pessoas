using Microsoft.EntityFrameworkCore.Migrations;

namespace CI.Infrastructure.Migrations
{
    public partial class AlteracaoColunasBanco : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Investimento_Usuarios_usuarioId",
                table: "Investimento");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Investimento",
                table: "Investimento");

            migrationBuilder.RenameTable(
                name: "Investimento",
                newName: "Investimentos");

            migrationBuilder.RenameIndex(
                name: "IX_Investimento_usuarioId",
                table: "Investimentos",
                newName: "IX_Investimentos_usuarioId");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Usuarios",
                type: "varchar(100)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CPF",
                table: "Usuarios",
                type: "varchar(11)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Valor",
                table: "Investimentos",
                type: "varchar(10)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Tipo",
                table: "Investimentos",
                type: "varchar(20)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Investimentos",
                table: "Investimentos",
                column: "InvestimentoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Investimentos_Usuarios_usuarioId",
                table: "Investimentos",
                column: "usuarioId",
                principalTable: "Usuarios",
                principalColumn: "usuarioId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Investimentos_Usuarios_usuarioId",
                table: "Investimentos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Investimentos",
                table: "Investimentos");

            migrationBuilder.RenameTable(
                name: "Investimentos",
                newName: "Investimento");

            migrationBuilder.RenameIndex(
                name: "IX_Investimentos_usuarioId",
                table: "Investimento",
                newName: "IX_Investimento_usuarioId");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Usuarios",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(100)");

            migrationBuilder.AlterColumn<string>(
                name: "CPF",
                table: "Usuarios",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(11)");

            migrationBuilder.AlterColumn<string>(
                name: "Valor",
                table: "Investimento",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(10)");

            migrationBuilder.AlterColumn<string>(
                name: "Tipo",
                table: "Investimento",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(20)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Investimento",
                table: "Investimento",
                column: "InvestimentoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Investimento_Usuarios_usuarioId",
                table: "Investimento",
                column: "usuarioId",
                principalTable: "Usuarios",
                principalColumn: "usuarioId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
