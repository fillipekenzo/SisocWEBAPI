using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SISOC.Data.Migrations
{
    public partial class AtualizacaoDataSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Permissao",
                keyColumn: "PermissaoID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Permissao",
                keyColumn: "PermissaoID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "TipoUsuario",
                keyColumn: "TipoUsuarioID",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "DataHoraCadastro",
                value: new DateTime(2022, 12, 20, 1, 34, 15, 721, DateTimeKind.Local).AddTicks(8510));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "DataHoraCadastro",
                value: new DateTime(2022, 12, 20, 1, 34, 15, 721, DateTimeKind.Local).AddTicks(8511));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "DataHoraCadastro",
                value: new DateTime(2022, 12, 20, 1, 34, 15, 721, DateTimeKind.Local).AddTicks(8513));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "DataHoraCadastro",
                value: new DateTime(2022, 12, 20, 1, 34, 15, 721, DateTimeKind.Local).AddTicks(8514));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "DataHoraCadastro",
                value: new DateTime(2022, 12, 20, 1, 34, 15, 721, DateTimeKind.Local).AddTicks(8515));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "DataHoraCadastro",
                value: new DateTime(2022, 12, 20, 1, 34, 15, 721, DateTimeKind.Local).AddTicks(8516));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "DataHoraCadastro",
                value: new DateTime(2022, 12, 20, 1, 34, 15, 721, DateTimeKind.Local).AddTicks(8544));

            migrationBuilder.UpdateData(
                table: "Permissao",
                keyColumn: "PermissaoID",
                keyValue: 1,
                column: "DataHoraCadastro",
                value: new DateTime(2022, 12, 20, 1, 34, 15, 721, DateTimeKind.Local).AddTicks(8577));

            migrationBuilder.UpdateData(
                table: "Permissao",
                keyColumn: "PermissaoID",
                keyValue: 2,
                column: "DataHoraCadastro",
                value: new DateTime(2022, 12, 20, 1, 34, 15, 721, DateTimeKind.Local).AddTicks(8578));

            migrationBuilder.UpdateData(
                table: "Permissao",
                keyColumn: "PermissaoID",
                keyValue: 3,
                column: "DataHoraCadastro",
                value: new DateTime(2022, 12, 20, 1, 34, 15, 721, DateTimeKind.Local).AddTicks(8579));

            migrationBuilder.UpdateData(
                table: "Permissao",
                keyColumn: "PermissaoID",
                keyValue: 4,
                column: "DataHoraCadastro",
                value: new DateTime(2022, 12, 20, 1, 34, 15, 721, DateTimeKind.Local).AddTicks(8580));

            migrationBuilder.UpdateData(
                table: "Permissao",
                keyColumn: "PermissaoID",
                keyValue: 5,
                column: "DataHoraCadastro",
                value: new DateTime(2022, 12, 20, 1, 34, 15, 721, DateTimeKind.Local).AddTicks(8581));

            migrationBuilder.UpdateData(
                table: "Permissao",
                keyColumn: "PermissaoID",
                keyValue: 6,
                column: "DataHoraCadastro",
                value: new DateTime(2022, 12, 20, 1, 34, 15, 721, DateTimeKind.Local).AddTicks(8582));

            migrationBuilder.UpdateData(
                table: "Permissao",
                keyColumn: "PermissaoID",
                keyValue: 7,
                column: "DataHoraCadastro",
                value: new DateTime(2022, 12, 20, 1, 34, 15, 721, DateTimeKind.Local).AddTicks(8583));

            migrationBuilder.UpdateData(
                table: "Permissao",
                keyColumn: "PermissaoID",
                keyValue: 8,
                column: "DataHoraCadastro",
                value: new DateTime(2022, 12, 20, 1, 34, 15, 721, DateTimeKind.Local).AddTicks(8584));

            migrationBuilder.UpdateData(
                table: "Permissao",
                keyColumn: "PermissaoID",
                keyValue: 9,
                column: "DataHoraCadastro",
                value: new DateTime(2022, 12, 20, 1, 34, 15, 721, DateTimeKind.Local).AddTicks(8585));

            migrationBuilder.UpdateData(
                table: "Permissao",
                keyColumn: "PermissaoID",
                keyValue: 10,
                column: "DataHoraCadastro",
                value: new DateTime(2022, 12, 20, 1, 34, 15, 721, DateTimeKind.Local).AddTicks(8586));

            migrationBuilder.UpdateData(
                table: "Setor",
                keyColumn: "SetorID",
                keyValue: 1,
                columns: new[] { "DataHoraCadastro", "Nome", "Sigla" },
                values: new object[] { new DateTime(2022, 12, 20, 1, 34, 15, 721, DateTimeKind.Local).AddTicks(8374), "Reitoria", "RTRIA" });

            migrationBuilder.UpdateData(
                table: "Setor",
                keyColumn: "SetorID",
                keyValue: 2,
                columns: new[] { "DataHoraCadastro", "Nome", "Sigla" },
                values: new object[] { new DateTime(2022, 12, 20, 1, 34, 15, 721, DateTimeKind.Local).AddTicks(8382), "Direção Geral", "DIRGE" });

            migrationBuilder.UpdateData(
                table: "Setor",
                keyColumn: "SetorID",
                keyValue: 3,
                column: "DataHoraCadastro",
                value: new DateTime(2022, 12, 20, 1, 34, 15, 721, DateTimeKind.Local).AddTicks(8383));

            migrationBuilder.InsertData(
                table: "Setor",
                columns: new[] { "SetorID", "DataHoraAlteracao", "DataHoraCadastro", "Nome", "Sigla" },
                values: new object[,]
                {
                    { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 20, 1, 34, 15, 721, DateTimeKind.Local).AddTicks(8383), "Diretoria de Pesquisa, Extensão e Relações Internacionais", "DIRER" },
                    { 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 20, 1, 34, 15, 721, DateTimeKind.Local).AddTicks(8384), "Diretoria de Administração", "DIRAD" }
                });

            migrationBuilder.UpdateData(
                table: "Submenu",
                keyColumn: "SubmenuID",
                keyValue: 1,
                column: "DataHoraCadastro",
                value: new DateTime(2022, 12, 20, 1, 34, 15, 721, DateTimeKind.Local).AddTicks(8559));

            migrationBuilder.UpdateData(
                table: "Submenu",
                keyColumn: "SubmenuID",
                keyValue: 2,
                column: "DataHoraCadastro",
                value: new DateTime(2022, 12, 20, 1, 34, 15, 721, DateTimeKind.Local).AddTicks(8561));

            migrationBuilder.InsertData(
                table: "Submenu",
                columns: new[] { "SubmenuID", "Ativo", "DataHoraAlteracao", "DataHoraCadastro", "MenuID", "NavegarURL", "Nome", "Ordem" },
                values: new object[] { 3, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 20, 1, 34, 15, 721, DateTimeKind.Local).AddTicks(8562), 7, "/painel", "Painel", 2 });

            migrationBuilder.UpdateData(
                table: "TipoOcorrencia",
                keyColumn: "TipoOcorrenciaID",
                keyValue: 1,
                columns: new[] { "DataHoraCadastro", "Descricao", "Nome" },
                values: new object[] { new DateTime(2022, 12, 20, 1, 34, 15, 721, DateTimeKind.Local).AddTicks(8485), "Incidentes dentro da Sala de Aula", "Sala de Aula" });

            migrationBuilder.UpdateData(
                table: "TipoOcorrencia",
                keyColumn: "TipoOcorrenciaID",
                keyValue: 2,
                columns: new[] { "DataHoraCadastro", "Descricao", "Nome" },
                values: new object[] { new DateTime(2022, 12, 20, 1, 34, 15, 721, DateTimeKind.Local).AddTicks(8486), "Incidentes com Alunos", "Aluno" });

            migrationBuilder.UpdateData(
                table: "TipoOcorrencia",
                keyColumn: "TipoOcorrenciaID",
                keyValue: 3,
                columns: new[] { "DataHoraCadastro", "Descricao", "Nome" },
                values: new object[] { new DateTime(2022, 12, 20, 1, 34, 15, 721, DateTimeKind.Local).AddTicks(8487), "Incidentes com Docente", "Docente" });

            migrationBuilder.UpdateData(
                table: "TipoOcorrencia",
                keyColumn: "TipoOcorrenciaID",
                keyValue: 4,
                columns: new[] { "DataHoraCadastro", "Descricao", "Nome" },
                values: new object[] { new DateTime(2022, 12, 20, 1, 34, 15, 721, DateTimeKind.Local).AddTicks(8488), "Incidentes dentro das extensões do Câmpus", "Câmpus" });

            migrationBuilder.InsertData(
                table: "TipoOcorrencia",
                columns: new[] { "TipoOcorrenciaID", "DataHoraAlteracao", "DataHoraCadastro", "Descricao", "Nome" },
                values: new object[,]
                {
                    { 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 20, 1, 34, 15, 721, DateTimeKind.Local).AddTicks(8488), "Incidentes fora das extensões do Câmpus", "Ambiente Externo" },
                    { 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 20, 1, 34, 15, 721, DateTimeKind.Local).AddTicks(8489), "Incidentes relacionados a infraestrutura do Câmpus", "Infraestrutura" }
                });

            migrationBuilder.UpdateData(
                table: "TipoUsuario",
                keyColumn: "TipoUsuarioID",
                keyValue: 1,
                column: "DataHoraCadastro",
                value: new DateTime(2022, 12, 20, 1, 34, 15, 721, DateTimeKind.Local).AddTicks(8470));

            migrationBuilder.UpdateData(
                table: "TipoUsuario",
                keyColumn: "TipoUsuarioID",
                keyValue: 2,
                column: "DataHoraCadastro",
                value: new DateTime(2022, 12, 20, 1, 34, 15, 721, DateTimeKind.Local).AddTicks(8471));

            migrationBuilder.UpdateData(
                table: "TipoUsuario",
                keyColumn: "TipoUsuarioID",
                keyValue: 3,
                column: "DataHoraCadastro",
                value: new DateTime(2022, 12, 20, 1, 34, 15, 721, DateTimeKind.Local).AddTicks(8472));

            migrationBuilder.UpdateData(
                table: "TipoUsuario",
                keyColumn: "TipoUsuarioID",
                keyValue: 4,
                column: "DataHoraCadastro",
                value: new DateTime(2022, 12, 20, 1, 34, 15, 721, DateTimeKind.Local).AddTicks(8472));

            migrationBuilder.UpdateData(
                table: "Usuario",
                keyColumn: "UsuarioID",
                keyValue: 1,
                column: "Senha",
                value: "AEJdUpz8dlbu3hyB5RwxolIAEZIcG/BIs8BnWQhqZzFFzid2khBf0li5LTwNp0aRpA==");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Setor",
                keyColumn: "SetorID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Setor",
                keyColumn: "SetorID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Submenu",
                keyColumn: "SubmenuID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TipoOcorrencia",
                keyColumn: "TipoOcorrenciaID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "TipoOcorrencia",
                keyColumn: "TipoOcorrenciaID",
                keyValue: 6);

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "DataHoraCadastro",
                value: new DateTime(2022, 12, 7, 19, 26, 11, 136, DateTimeKind.Local).AddTicks(8178));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "DataHoraCadastro",
                value: new DateTime(2022, 12, 7, 19, 26, 11, 136, DateTimeKind.Local).AddTicks(8179));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "DataHoraCadastro",
                value: new DateTime(2022, 12, 7, 19, 26, 11, 136, DateTimeKind.Local).AddTicks(8181));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "DataHoraCadastro",
                value: new DateTime(2022, 12, 7, 19, 26, 11, 136, DateTimeKind.Local).AddTicks(8182));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "DataHoraCadastro",
                value: new DateTime(2022, 12, 7, 19, 26, 11, 136, DateTimeKind.Local).AddTicks(8183));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "DataHoraCadastro",
                value: new DateTime(2022, 12, 7, 19, 26, 11, 136, DateTimeKind.Local).AddTicks(8184));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "DataHoraCadastro",
                value: new DateTime(2022, 12, 7, 19, 26, 11, 136, DateTimeKind.Local).AddTicks(8185));

            migrationBuilder.UpdateData(
                table: "Permissao",
                keyColumn: "PermissaoID",
                keyValue: 1,
                column: "DataHoraCadastro",
                value: new DateTime(2022, 12, 7, 19, 26, 11, 136, DateTimeKind.Local).AddTicks(8214));

            migrationBuilder.UpdateData(
                table: "Permissao",
                keyColumn: "PermissaoID",
                keyValue: 2,
                column: "DataHoraCadastro",
                value: new DateTime(2022, 12, 7, 19, 26, 11, 136, DateTimeKind.Local).AddTicks(8215));

            migrationBuilder.UpdateData(
                table: "Permissao",
                keyColumn: "PermissaoID",
                keyValue: 3,
                column: "DataHoraCadastro",
                value: new DateTime(2022, 12, 7, 19, 26, 11, 136, DateTimeKind.Local).AddTicks(8216));

            migrationBuilder.UpdateData(
                table: "Permissao",
                keyColumn: "PermissaoID",
                keyValue: 4,
                column: "DataHoraCadastro",
                value: new DateTime(2022, 12, 7, 19, 26, 11, 136, DateTimeKind.Local).AddTicks(8217));

            migrationBuilder.UpdateData(
                table: "Permissao",
                keyColumn: "PermissaoID",
                keyValue: 5,
                column: "DataHoraCadastro",
                value: new DateTime(2022, 12, 7, 19, 26, 11, 136, DateTimeKind.Local).AddTicks(8218));

            migrationBuilder.UpdateData(
                table: "Permissao",
                keyColumn: "PermissaoID",
                keyValue: 6,
                column: "DataHoraCadastro",
                value: new DateTime(2022, 12, 7, 19, 26, 11, 136, DateTimeKind.Local).AddTicks(8219));

            migrationBuilder.UpdateData(
                table: "Permissao",
                keyColumn: "PermissaoID",
                keyValue: 7,
                column: "DataHoraCadastro",
                value: new DateTime(2022, 12, 7, 19, 26, 11, 136, DateTimeKind.Local).AddTicks(8220));

            migrationBuilder.UpdateData(
                table: "Permissao",
                keyColumn: "PermissaoID",
                keyValue: 8,
                column: "DataHoraCadastro",
                value: new DateTime(2022, 12, 7, 19, 26, 11, 136, DateTimeKind.Local).AddTicks(8221));

            migrationBuilder.UpdateData(
                table: "Permissao",
                keyColumn: "PermissaoID",
                keyValue: 9,
                column: "DataHoraCadastro",
                value: new DateTime(2022, 12, 7, 19, 26, 11, 136, DateTimeKind.Local).AddTicks(8222));

            migrationBuilder.UpdateData(
                table: "Permissao",
                keyColumn: "PermissaoID",
                keyValue: 10,
                column: "DataHoraCadastro",
                value: new DateTime(2022, 12, 7, 19, 26, 11, 136, DateTimeKind.Local).AddTicks(8223));

            migrationBuilder.UpdateData(
                table: "Setor",
                keyColumn: "SetorID",
                keyValue: 1,
                columns: new[] { "DataHoraCadastro", "Nome", "Sigla" },
                values: new object[] { new DateTime(2022, 12, 7, 19, 26, 11, 136, DateTimeKind.Local).AddTicks(8041), "Conselho Superior", "COSUP" });

            migrationBuilder.UpdateData(
                table: "Setor",
                keyColumn: "SetorID",
                keyValue: 2,
                columns: new[] { "DataHoraCadastro", "Nome", "Sigla" },
                values: new object[] { new DateTime(2022, 12, 7, 19, 26, 11, 136, DateTimeKind.Local).AddTicks(8049), "Reitoria", "RTRIA" });

            migrationBuilder.UpdateData(
                table: "Setor",
                keyColumn: "SetorID",
                keyValue: 3,
                column: "DataHoraCadastro",
                value: new DateTime(2022, 12, 7, 19, 26, 11, 136, DateTimeKind.Local).AddTicks(8050));

            migrationBuilder.UpdateData(
                table: "Submenu",
                keyColumn: "SubmenuID",
                keyValue: 1,
                column: "DataHoraCadastro",
                value: new DateTime(2022, 12, 7, 19, 26, 11, 136, DateTimeKind.Local).AddTicks(8200));

            migrationBuilder.UpdateData(
                table: "Submenu",
                keyColumn: "SubmenuID",
                keyValue: 2,
                column: "DataHoraCadastro",
                value: new DateTime(2022, 12, 7, 19, 26, 11, 136, DateTimeKind.Local).AddTicks(8201));

            migrationBuilder.UpdateData(
                table: "TipoOcorrencia",
                keyColumn: "TipoOcorrenciaID",
                keyValue: 1,
                columns: new[] { "DataHoraCadastro", "Descricao", "Nome" },
                values: new object[] { new DateTime(2022, 12, 7, 19, 26, 11, 136, DateTimeKind.Local).AddTicks(8155), "Incidentes com Alunos", "Aluno" });

            migrationBuilder.UpdateData(
                table: "TipoOcorrencia",
                keyColumn: "TipoOcorrenciaID",
                keyValue: 2,
                columns: new[] { "DataHoraCadastro", "Descricao", "Nome" },
                values: new object[] { new DateTime(2022, 12, 7, 19, 26, 11, 136, DateTimeKind.Local).AddTicks(8155), "Incidentes com o Câmpus", "Campus" });

            migrationBuilder.UpdateData(
                table: "TipoOcorrencia",
                keyColumn: "TipoOcorrenciaID",
                keyValue: 3,
                columns: new[] { "DataHoraCadastro", "Descricao", "Nome" },
                values: new object[] { new DateTime(2022, 12, 7, 19, 26, 11, 136, DateTimeKind.Local).AddTicks(8156), "Incidentes dentro da Sala de Aula", "Sala de Aula" });

            migrationBuilder.UpdateData(
                table: "TipoOcorrencia",
                keyColumn: "TipoOcorrenciaID",
                keyValue: 4,
                columns: new[] { "DataHoraCadastro", "Descricao", "Nome" },
                values: new object[] { new DateTime(2022, 12, 7, 19, 26, 11, 136, DateTimeKind.Local).AddTicks(8157), "Incidentes com Docente", "Docente" });

            migrationBuilder.UpdateData(
                table: "TipoUsuario",
                keyColumn: "TipoUsuarioID",
                keyValue: 1,
                column: "DataHoraCadastro",
                value: new DateTime(2022, 12, 7, 19, 26, 11, 136, DateTimeKind.Local).AddTicks(8135));

            migrationBuilder.UpdateData(
                table: "TipoUsuario",
                keyColumn: "TipoUsuarioID",
                keyValue: 2,
                column: "DataHoraCadastro",
                value: new DateTime(2022, 12, 7, 19, 26, 11, 136, DateTimeKind.Local).AddTicks(8136));

            migrationBuilder.UpdateData(
                table: "TipoUsuario",
                keyColumn: "TipoUsuarioID",
                keyValue: 3,
                column: "DataHoraCadastro",
                value: new DateTime(2022, 12, 7, 19, 26, 11, 136, DateTimeKind.Local).AddTicks(8136));

            migrationBuilder.UpdateData(
                table: "TipoUsuario",
                keyColumn: "TipoUsuarioID",
                keyValue: 4,
                column: "DataHoraCadastro",
                value: new DateTime(2022, 12, 7, 19, 26, 11, 136, DateTimeKind.Local).AddTicks(8137));

            migrationBuilder.InsertData(
                table: "TipoUsuario",
                columns: new[] { "TipoUsuarioID", "DataHoraAlteracao", "DataHoraCadastro", "Descricao", "Nome" },
                values: new object[] { 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 7, 19, 26, 11, 136, DateTimeKind.Local).AddTicks(8138), "Usuário com permissões para criar usuários", "SUPORTE" });

            migrationBuilder.UpdateData(
                table: "Usuario",
                keyColumn: "UsuarioID",
                keyValue: 1,
                column: "Senha",
                value: "AGoQMmPjiAe4Oe0DQXFKevtwC8AQDcelnfwlbH1w2fYHz/bN8Zbp5qLyspug8FQ8ZA==");

            migrationBuilder.InsertData(
                table: "Permissao",
                columns: new[] { "PermissaoID", "Cadastrar", "Consultar", "DataHoraAlteracao", "DataHoraCadastro", "Editar", "Excluir", "MenuID", "SubmenuID", "TipoUsuarioID" },
                values: new object[] { 11, true, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 7, 19, 26, 11, 136, DateTimeKind.Local).AddTicks(8224), true, false, 6, 1, 5 });

            migrationBuilder.InsertData(
                table: "Permissao",
                columns: new[] { "PermissaoID", "Cadastrar", "Consultar", "DataHoraAlteracao", "DataHoraCadastro", "Editar", "Excluir", "MenuID", "SubmenuID", "TipoUsuarioID" },
                values: new object[] { 12, true, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 7, 19, 26, 11, 136, DateTimeKind.Local).AddTicks(8225), true, false, 7, 1, 5 });
        }
    }
}
