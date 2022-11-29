using Microsoft.EntityFrameworkCore.Migrations;

namespace API_Copa.Migrations
{
    public partial class JogoAlterado : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Jogos_Selecoes_SelecaoAId",
                table: "Jogos");

            migrationBuilder.DropForeignKey(
                name: "FK_Jogos_Selecoes_SelecaoBId",
                table: "Jogos");

            migrationBuilder.RenameColumn(
                name: "SelecaoBId",
                table: "Jogos",
                newName: "selecaoBId");

            migrationBuilder.RenameColumn(
                name: "SelecaoAId",
                table: "Jogos",
                newName: "selecaoAId");

            migrationBuilder.RenameIndex(
                name: "IX_Jogos_SelecaoBId",
                table: "Jogos",
                newName: "IX_Jogos_selecaoBId");

            migrationBuilder.RenameIndex(
                name: "IX_Jogos_SelecaoAId",
                table: "Jogos",
                newName: "IX_Jogos_selecaoAId");

            migrationBuilder.AlterColumn<int>(
                name: "selecaoBId",
                table: "Jogos",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "selecaoAId",
                table: "Jogos",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "placarA",
                table: "Jogos",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "placarB",
                table: "Jogos",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Jogos_Selecoes_selecaoAId",
                table: "Jogos",
                column: "selecaoAId",
                principalTable: "Selecoes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Jogos_Selecoes_selecaoBId",
                table: "Jogos",
                column: "selecaoBId",
                principalTable: "Selecoes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Jogos_Selecoes_selecaoAId",
                table: "Jogos");

            migrationBuilder.DropForeignKey(
                name: "FK_Jogos_Selecoes_selecaoBId",
                table: "Jogos");

            migrationBuilder.DropColumn(
                name: "placarA",
                table: "Jogos");

            migrationBuilder.DropColumn(
                name: "placarB",
                table: "Jogos");

            migrationBuilder.RenameColumn(
                name: "selecaoBId",
                table: "Jogos",
                newName: "SelecaoBId");

            migrationBuilder.RenameColumn(
                name: "selecaoAId",
                table: "Jogos",
                newName: "SelecaoAId");

            migrationBuilder.RenameIndex(
                name: "IX_Jogos_selecaoBId",
                table: "Jogos",
                newName: "IX_Jogos_SelecaoBId");

            migrationBuilder.RenameIndex(
                name: "IX_Jogos_selecaoAId",
                table: "Jogos",
                newName: "IX_Jogos_SelecaoAId");

            migrationBuilder.AlterColumn<int>(
                name: "SelecaoBId",
                table: "Jogos",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<int>(
                name: "SelecaoAId",
                table: "Jogos",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddForeignKey(
                name: "FK_Jogos_Selecoes_SelecaoAId",
                table: "Jogos",
                column: "SelecaoAId",
                principalTable: "Selecoes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Jogos_Selecoes_SelecaoBId",
                table: "Jogos",
                column: "SelecaoBId",
                principalTable: "Selecoes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
