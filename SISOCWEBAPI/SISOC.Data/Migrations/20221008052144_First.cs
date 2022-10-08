using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SISOC.Data.Migrations
{
    public partial class First : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Menu",
                columns: table => new
                {
                    MenuID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    NavegarURL = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Ativo = table.Column<bool>(type: "bit", nullable: false),
                    Ordem = table.Column<int>(type: "int", nullable: true),
                    DataHoraCadastro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataHoraAlteracao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menu", x => x.MenuID);
                });

            migrationBuilder.CreateTable(
                name: "Setor",
                columns: table => new
                {
                    SetorID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(255)", nullable: false),
                    Sigla = table.Column<string>(type: "nvarchar(255)", nullable: false),
                    DataHoraCadastro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataHoraAlteracao = table.Column<DateTime>(type: "datetime2", nullable: false)
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
                    Nome = table.Column<string>(type: "nvarchar(255)", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(255)", nullable: false),
                    DataHoraCadastro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataHoraAlteracao = table.Column<DateTime>(type: "datetime2", nullable: false)
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
                    Nome = table.Column<string>(type: "nvarchar(255)", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(255)", nullable: false),
                    DataHoraCadastro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataHoraAlteracao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoUsuario", x => x.TipoUsuarioID);
                });

            migrationBuilder.CreateTable(
                name: "Submenu",
                columns: table => new
                {
                    SubmenuID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    NavegarURL = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Ativo = table.Column<bool>(type: "bit", nullable: false),
                    Ordem = table.Column<int>(type: "int", nullable: true),
                    MenuID = table.Column<int>(type: "int", nullable: false),
                    DataHoraCadastro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataHoraAlteracao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Submenu", x => x.SubmenuID);
                    table.ForeignKey(
                        name: "FK_Submenu_Menu_MenuID",
                        column: x => x.MenuID,
                        principalTable: "Menu",
                        principalColumn: "MenuID");
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    UsuarioID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(255)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(255)", nullable: false),
                    Senha = table.Column<string>(type: "nvarchar(500)", nullable: false),
                    RA_SIAPE = table.Column<string>(type: "nvarchar(255)", nullable: false),
                    TipoUsuarioID = table.Column<int>(type: "int", nullable: false),
                    SetorID = table.Column<int>(type: "int", nullable: true),
                    DataHoraCadastro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataHoraAlteracao = table.Column<DateTime>(type: "datetime2", nullable: false)
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
                name: "Permissao",
                columns: table => new
                {
                    PermissaoID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoUsuarioID = table.Column<int>(type: "int", nullable: false),
                    Consultar = table.Column<bool>(type: "bit", nullable: false),
                    Cadastrar = table.Column<bool>(type: "bit", nullable: false),
                    Editar = table.Column<bool>(type: "bit", nullable: false),
                    Excluir = table.Column<bool>(type: "bit", nullable: false),
                    MenuID = table.Column<int>(type: "int", nullable: false),
                    SubmenuID = table.Column<int>(type: "int", nullable: false),
                    DataHoraCadastro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataHoraAlteracao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permissao", x => x.PermissaoID);
                    table.ForeignKey(
                        name: "FK_Permissao_Menu_MenuID",
                        column: x => x.MenuID,
                        principalTable: "Menu",
                        principalColumn: "MenuID");
                    table.ForeignKey(
                        name: "FK_Permissao_Submenu_SubmenuID",
                        column: x => x.SubmenuID,
                        principalTable: "Submenu",
                        principalColumn: "SubmenuID");
                    table.ForeignKey(
                        name: "FK_Permissao_TipoUsuario_TipoUsuarioID",
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
                    Assunto = table.Column<string>(type: "nvarchar(500)", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(MAX)", nullable: false),
                    UrgenciaENUM = table.Column<string>(type: "nvarchar(255)", nullable: false),
                    SituacaoENUM = table.Column<string>(type: "nvarchar(255)", nullable: false),
                    Resolucao = table.Column<string>(type: "nvarchar(MAX)", nullable: true),
                    UsuarioAtribuidoID = table.Column<int>(type: "int", nullable: true),
                    UsuarioCadastroID = table.Column<int>(type: "int", nullable: false),
                    TipoOcorrenciaID = table.Column<int>(type: "int", nullable: false),
                    SetorID = table.Column<int>(type: "int", nullable: false),
                    DataHoraCadastro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataHoraAlteracao = table.Column<DateTime>(type: "datetime2", nullable: false)
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

            migrationBuilder.CreateTable(
                name: "Anexo",
                columns: table => new
                {
                    AnexoID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(255)", nullable: false),
                    TipoAnexo = table.Column<string>(type: "nvarchar(255)", nullable: false),
                    ArquivoURL = table.Column<string>(type: "nvarchar(255)", nullable: false),
                    InteracaoOcorrenciaID = table.Column<int>(type: "int", nullable: false),
                    OcorrenciaID = table.Column<int>(type: "int", nullable: false),
                    DataHoraCadastro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataHoraAlteracao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Anexo", x => x.AnexoID);
                    table.ForeignKey(
                        name: "FK_Anexo_InteracaoOcorrencia_InteracaoOcorrenciaID",
                        column: x => x.InteracaoOcorrenciaID,
                        principalTable: "InteracaoOcorrencia",
                        principalColumn: "InteracaoOcorrenciaID");
                    table.ForeignKey(
                        name: "FK_Anexo_Ocorrencia_OcorrenciaID",
                        column: x => x.OcorrenciaID,
                        principalTable: "Ocorrencia",
                        principalColumn: "OcorrenciaID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Anexo_InteracaoOcorrenciaID",
                table: "Anexo",
                column: "InteracaoOcorrenciaID");

            migrationBuilder.CreateIndex(
                name: "IX_Anexo_OcorrenciaID",
                table: "Anexo",
                column: "OcorrenciaID");

            migrationBuilder.CreateIndex(
                name: "IX_InteracaoOcorrencia_OcorrenciaID",
                table: "InteracaoOcorrencia",
                column: "OcorrenciaID");

            migrationBuilder.CreateIndex(
                name: "IX_InteracaoOcorrencia_UsuarioID",
                table: "InteracaoOcorrencia",
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
                name: "IX_Permissao_MenuID",
                table: "Permissao",
                column: "MenuID");

            migrationBuilder.CreateIndex(
                name: "IX_Permissao_SubmenuID",
                table: "Permissao",
                column: "SubmenuID");

            migrationBuilder.CreateIndex(
                name: "IX_Permissao_TipoUsuarioID",
                table: "Permissao",
                column: "TipoUsuarioID");

            migrationBuilder.CreateIndex(
                name: "IX_Submenu_MenuID",
                table: "Submenu",
                column: "MenuID");

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
                name: "InteracaoOcorrencia");

            migrationBuilder.DropTable(
                name: "Submenu");

            migrationBuilder.DropTable(
                name: "Ocorrencia");

            migrationBuilder.DropTable(
                name: "Menu");

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
