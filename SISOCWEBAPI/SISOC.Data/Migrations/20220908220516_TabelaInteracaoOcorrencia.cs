using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SISOC.Data.Migrations
{
    public partial class TabelaInteracaoOcorrencia : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Anexo_Interacao_InteracaoID",
                table: "Anexo");

            migrationBuilder.DropTable(
                name: "Interacao");

            migrationBuilder.RenameColumn(
                name: "InteracaoID",
                table: "Anexo",
                newName: "InteracaoOcorrenciaID");

            migrationBuilder.RenameIndex(
                name: "IX_Anexo_InteracaoID",
                table: "Anexo",
                newName: "IX_Anexo_InteracaoOcorrenciaID");

            migrationBuilder.CreateTable(
                name: "InteracaoOcorrencia",
                columns: table => new
                {
                    InteracaoOcorrenciaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Assunto = table.Column<string>(type: "nvarchar(500)", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(MAX)", nullable: false),
                    UsuarioID = table.Column<int>(type: "int", nullable: false),
                    OcorrenciaID = table.Column<int>(type: "int", nullable: false),
                    DataHoraCadastro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataHoraAlteracao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InteracaoOcorrencia", x => x.InteracaoOcorrenciaID);
                    table.ForeignKey(
                        name: "FK_InteracaoOcorrencia_Ocorrencia_OcorrenciaID",
                        column: x => x.OcorrenciaID,
                        principalTable: "Ocorrencia",
                        principalColumn: "OcorrenciaID");
                    table.ForeignKey(
                        name: "FK_InteracaoOcorrencia_Usuario_UsuarioID",
                        column: x => x.UsuarioID,
                        principalTable: "Usuario",
                        principalColumn: "UsuarioID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_InteracaoOcorrencia_OcorrenciaID",
                table: "InteracaoOcorrencia",
                column: "OcorrenciaID");

            migrationBuilder.CreateIndex(
                name: "IX_InteracaoOcorrencia_UsuarioID",
                table: "InteracaoOcorrencia",
                column: "UsuarioID");

            migrationBuilder.AddForeignKey(
                name: "FK_Anexo_InteracaoOcorrencia_InteracaoOcorrenciaID",
                table: "Anexo",
                column: "InteracaoOcorrenciaID",
                principalTable: "InteracaoOcorrencia",
                principalColumn: "InteracaoOcorrenciaID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Anexo_InteracaoOcorrencia_InteracaoOcorrenciaID",
                table: "Anexo");

            migrationBuilder.DropTable(
                name: "InteracaoOcorrencia");

            migrationBuilder.RenameColumn(
                name: "InteracaoOcorrenciaID",
                table: "Anexo",
                newName: "InteracaoID");

            migrationBuilder.RenameIndex(
                name: "IX_Anexo_InteracaoOcorrenciaID",
                table: "Anexo",
                newName: "IX_Anexo_InteracaoID");

            migrationBuilder.CreateTable(
                name: "Interacao",
                columns: table => new
                {
                    InteracaoID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OcorrenciaID = table.Column<int>(type: "int", nullable: false),
                    UsuarioID = table.Column<int>(type: "int", nullable: false),
                    Assunto = table.Column<string>(type: "nvarchar(500)", nullable: false),
                    DataHoraAlteracao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataHoraCadastro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(MAX)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Interacao", x => x.InteracaoID);
                    table.ForeignKey(
                        name: "FK_Interacao_Ocorrencia_OcorrenciaID",
                        column: x => x.OcorrenciaID,
                        principalTable: "Ocorrencia",
                        principalColumn: "OcorrenciaID");
                    table.ForeignKey(
                        name: "FK_Interacao_Usuario_UsuarioID",
                        column: x => x.UsuarioID,
                        principalTable: "Usuario",
                        principalColumn: "UsuarioID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Interacao_OcorrenciaID",
                table: "Interacao",
                column: "OcorrenciaID");

            migrationBuilder.CreateIndex(
                name: "IX_Interacao_UsuarioID",
                table: "Interacao",
                column: "UsuarioID");

            migrationBuilder.AddForeignKey(
                name: "FK_Anexo_Interacao_InteracaoID",
                table: "Anexo",
                column: "InteracaoID",
                principalTable: "Interacao",
                principalColumn: "InteracaoID");
        }
    }
}
