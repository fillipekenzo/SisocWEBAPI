using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SISOC.Data.Migrations
{
    public partial class Iniciomodelagem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Modulo",
                columns: table => new
                {
                    ModuloID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "varchar(100)", nullable: false),
                    NavegarURL = table.Column<string>(type: "varchar(100)", nullable: false),
                    Ativo = table.Column<bool>(type: "bit", nullable: false),
                    PossuiMenu = table.Column<bool>(type: "bit", nullable: false),
                    DataHoraCadastro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataHoraAlteracao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UsuarioCadastro = table.Column<string>(type: "varchar(100)", nullable: false),
                    UsuarioAlteracao = table.Column<string>(type: "varchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Modulo", x => x.ModuloID);
                });

            migrationBuilder.CreateTable(
                name: "Setor",
                columns: table => new
                {
                    SetorID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "varchar(100)", nullable: false),
                    Sigla = table.Column<string>(type: "varchar(100)", nullable: false),
                    DataHoraCadastro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataHoraAlteracao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UsuarioCadastro = table.Column<string>(type: "varchar(100)", nullable: false),
                    UsuarioAlteracao = table.Column<string>(type: "varchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Setor", x => x.SetorID);
                });

            migrationBuilder.CreateTable(
                name: "TipoOcorrencia",
                columns: table => new
                {
                    TipoOcorrenciaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "varchar(100)", nullable: false),
                    Descricao = table.Column<string>(type: "varchar(100)", nullable: false),
                    DataHoraCadastro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataHoraAlteracao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UsuarioCadastro = table.Column<string>(type: "varchar(100)", nullable: false),
                    UsuarioAlteracao = table.Column<string>(type: "varchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoOcorrencia", x => x.TipoOcorrenciaID);
                });

            migrationBuilder.CreateTable(
                name: "TipoUsuario",
                columns: table => new
                {
                    TipoUsuarioID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "varchar(100)", nullable: false),
                    Descricao = table.Column<string>(type: "varchar(100)", nullable: false),
                    DataHoraCadastro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataHoraAlteracao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UsuarioCadastro = table.Column<string>(type: "varchar(100)", nullable: false),
                    UsuarioAlteracao = table.Column<string>(type: "varchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoUsuario", x => x.TipoUsuarioID);
                });

            migrationBuilder.CreateTable(
                name: "Permissao",
                columns: table => new
                {
                    PermissaoID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModuloID = table.Column<int>(type: "int", nullable: false),
                    TipoUsuarioID = table.Column<int>(type: "int", nullable: false),
                    Consultar = table.Column<bool>(type: "bit", nullable: false),
                    Cadastrar = table.Column<bool>(type: "bit", nullable: false),
                    Editar = table.Column<bool>(type: "bit", nullable: false),
                    Excluir = table.Column<bool>(type: "bit", nullable: false),
                    DataHoraCadastro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataHoraAlteracao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UsuarioCadastro = table.Column<string>(type: "varchar(100)", nullable: false),
                    UsuarioAlteracao = table.Column<string>(type: "varchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permissao", x => x.PermissaoID);
                    table.ForeignKey(
                        name: "FK_Permissao_Modulo_ModuloID",
                        column: x => x.ModuloID,
                        principalTable: "Modulo",
                        principalColumn: "ModuloID");
                    table.ForeignKey(
                        name: "FK_Permissao_TipoUsuario_TipoUsuarioID",
                        column: x => x.TipoUsuarioID,
                        principalTable: "TipoUsuario",
                        principalColumn: "TipoUsuarioID");
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    UsuarioID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "varchar(100)", nullable: false),
                    Email = table.Column<string>(type: "varchar(100)", nullable: false),
                    Senha = table.Column<string>(type: "varchar(100)", nullable: false),
                    TipoUsuarioID = table.Column<int>(type: "int", nullable: false),
                    SetorID = table.Column<int>(type: "int", nullable: false),
                    DataHoraCadastro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataHoraAlteracao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UsuarioCadastro = table.Column<string>(type: "varchar(100)", nullable: false),
                    UsuarioAlteracao = table.Column<string>(type: "varchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.UsuarioID);
                    table.ForeignKey(
                        name: "FK_Usuario_Setor_SetorID",
                        column: x => x.SetorID,
                        principalTable: "Setor",
                        principalColumn: "SetorID");
                    table.ForeignKey(
                        name: "FK_Usuario_TipoUsuario_TipoUsuarioID",
                        column: x => x.TipoUsuarioID,
                        principalTable: "TipoUsuario",
                        principalColumn: "TipoUsuarioID");
                });

            migrationBuilder.CreateTable(
                name: "Ocorrencia",
                columns: table => new
                {
                    OcorrenciaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Assunto = table.Column<string>(type: "varchar(100)", nullable: false),
                    Descricao = table.Column<string>(type: "varchar(100)", nullable: false),
                    UrgenciaENUM = table.Column<string>(type: "varchar(100)", nullable: false),
                    SituacaoENUM = table.Column<string>(type: "varchar(100)", nullable: false),
                    Resolucao = table.Column<string>(type: "varchar(100)", nullable: false),
                    UsuarioAtribuidoID = table.Column<int>(type: "int", nullable: false),
                    UsuarioCadastroID = table.Column<int>(type: "int", nullable: false),
                    TipoOcorrenciaID = table.Column<int>(type: "int", nullable: false),
                    SetorID = table.Column<int>(type: "int", nullable: false),
                    DataHoraCadastro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataHoraAlteracao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UsuarioCadastro = table.Column<string>(type: "varchar(100)", nullable: false),
                    UsuarioAlteracao = table.Column<string>(type: "varchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ocorrencia", x => x.OcorrenciaID);
                    table.ForeignKey(
                        name: "FK_Ocorrencia_Setor_SetorID",
                        column: x => x.SetorID,
                        principalTable: "Setor",
                        principalColumn: "SetorID");
                    table.ForeignKey(
                        name: "FK_Ocorrencia_TipoOcorrencia_TipoOcorrenciaID",
                        column: x => x.TipoOcorrenciaID,
                        principalTable: "TipoOcorrencia",
                        principalColumn: "TipoOcorrenciaID");
                    table.ForeignKey(
                        name: "FK_Ocorrencia_Usuario_UsuarioAtribuidoID",
                        column: x => x.UsuarioAtribuidoID,
                        principalTable: "Usuario",
                        principalColumn: "UsuarioID");
                    table.ForeignKey(
                        name: "FK_Ocorrencia_Usuario_UsuarioCadastroID",
                        column: x => x.UsuarioCadastroID,
                        principalTable: "Usuario",
                        principalColumn: "UsuarioID");
                });

            migrationBuilder.CreateTable(
                name: "Interacao",
                columns: table => new
                {
                    InteracaoID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Assunto = table.Column<string>(type: "varchar(100)", nullable: false),
                    Descricao = table.Column<string>(type: "varchar(100)", nullable: false),
                    UsuarioID = table.Column<int>(type: "int", nullable: false),
                    OcorrenciaID = table.Column<int>(type: "int", nullable: false),
                    DataHoraCadastro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataHoraAlteracao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UsuarioCadastro = table.Column<string>(type: "varchar(100)", nullable: false),
                    UsuarioAlteracao = table.Column<string>(type: "varchar(100)", nullable: false)
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

            migrationBuilder.CreateTable(
                name: "Anexo",
                columns: table => new
                {
                    AnexoID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "varchar(100)", nullable: false),
                    TipoAnexo = table.Column<string>(type: "varchar(100)", nullable: false),
                    ArquivoURL = table.Column<string>(type: "varchar(100)", nullable: false),
                    InteracaoID = table.Column<int>(type: "int", nullable: false),
                    OcorrenciaID = table.Column<int>(type: "int", nullable: false),
                    DataHoraCadastro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataHoraAlteracao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UsuarioCadastro = table.Column<string>(type: "varchar(100)", nullable: false),
                    UsuarioAlteracao = table.Column<string>(type: "varchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Anexo", x => x.AnexoID);
                    table.ForeignKey(
                        name: "FK_Anexo_Interacao_InteracaoID",
                        column: x => x.InteracaoID,
                        principalTable: "Interacao",
                        principalColumn: "InteracaoID");
                    table.ForeignKey(
                        name: "FK_Anexo_Ocorrencia_OcorrenciaID",
                        column: x => x.OcorrenciaID,
                        principalTable: "Ocorrencia",
                        principalColumn: "OcorrenciaID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Anexo_InteracaoID",
                table: "Anexo",
                column: "InteracaoID");

            migrationBuilder.CreateIndex(
                name: "IX_Anexo_OcorrenciaID",
                table: "Anexo",
                column: "OcorrenciaID");

            migrationBuilder.CreateIndex(
                name: "IX_Interacao_OcorrenciaID",
                table: "Interacao",
                column: "OcorrenciaID");

            migrationBuilder.CreateIndex(
                name: "IX_Interacao_UsuarioID",
                table: "Interacao",
                column: "UsuarioID");

            migrationBuilder.CreateIndex(
                name: "IX_Ocorrencia_SetorID",
                table: "Ocorrencia",
                column: "SetorID");

            migrationBuilder.CreateIndex(
                name: "IX_Ocorrencia_TipoOcorrenciaID",
                table: "Ocorrencia",
                column: "TipoOcorrenciaID");

            migrationBuilder.CreateIndex(
                name: "IX_Ocorrencia_UsuarioAtribuidoID",
                table: "Ocorrencia",
                column: "UsuarioAtribuidoID");

            migrationBuilder.CreateIndex(
                name: "IX_Ocorrencia_UsuarioCadastroID",
                table: "Ocorrencia",
                column: "UsuarioCadastroID");

            migrationBuilder.CreateIndex(
                name: "IX_Permissao_ModuloID",
                table: "Permissao",
                column: "ModuloID");

            migrationBuilder.CreateIndex(
                name: "IX_Permissao_TipoUsuarioID",
                table: "Permissao",
                column: "TipoUsuarioID");

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_SetorID",
                table: "Usuario",
                column: "SetorID");

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_TipoUsuarioID",
                table: "Usuario",
                column: "TipoUsuarioID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Anexo");

            migrationBuilder.DropTable(
                name: "Permissao");

            migrationBuilder.DropTable(
                name: "Interacao");

            migrationBuilder.DropTable(
                name: "Modulo");

            migrationBuilder.DropTable(
                name: "Ocorrencia");

            migrationBuilder.DropTable(
                name: "TipoOcorrencia");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropTable(
                name: "Setor");

            migrationBuilder.DropTable(
                name: "TipoUsuario");
        }
    }
}
