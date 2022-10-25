using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SISOC.Data.Migrations
{
    public partial class seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Menu",
                columns: new[] { "MenuID", "Ativo", "DataHoraAlteracao", "DataHoraCadastro", "NavegarURL", "Nome", "Ordem" },
                values: new object[,]
                {
                    { 1, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 24, 23, 19, 40, 262, DateTimeKind.Local).AddTicks(802), "menu", "Menu", 1 },
                    { 2, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 24, 23, 19, 40, 262, DateTimeKind.Local).AddTicks(804), "setor", "Setor", 2 },
                    { 3, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 24, 23, 19, 40, 262, DateTimeKind.Local).AddTicks(805), "permissao", "Permissão", 3 },
                    { 4, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 24, 23, 19, 40, 262, DateTimeKind.Local).AddTicks(807), "tipo-ocorrencia", "Tipo Ocorrência", 4 },
                    { 5, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 24, 23, 19, 40, 262, DateTimeKind.Local).AddTicks(808), "tipo-usuario", "Tipo Usuário", 5 },
                    { 6, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 24, 23, 19, 40, 262, DateTimeKind.Local).AddTicks(809), "usuario", "Usuário", 6 },
                    { 7, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 24, 23, 19, 40, 262, DateTimeKind.Local).AddTicks(838), "ocorrencia", "Ocorrência", 7 }
                });

            migrationBuilder.InsertData(
                table: "Setor",
                columns: new[] { "SetorID", "DataHoraAlteracao", "DataHoraCadastro", "Nome", "Sigla" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 24, 23, 19, 40, 262, DateTimeKind.Local).AddTicks(674), "Conselho Superior", "COSUP" },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 24, 23, 19, 40, 262, DateTimeKind.Local).AddTicks(683), "Reitoria", "RTRIA" },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 24, 23, 19, 40, 262, DateTimeKind.Local).AddTicks(684), "Diretoria de Ensino", "DIREN" }
                });

            migrationBuilder.InsertData(
                table: "TipoOcorrencia",
                columns: new[] { "TipoOcorrenciaID", "DataHoraAlteracao", "DataHoraCadastro", "Descricao", "Nome" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 24, 23, 19, 40, 262, DateTimeKind.Local).AddTicks(782), "Incidentes com Alunos", "Aluno" },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 24, 23, 19, 40, 262, DateTimeKind.Local).AddTicks(783), "Incidentes com o Câmpus", "Campus" },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 24, 23, 19, 40, 262, DateTimeKind.Local).AddTicks(784), "Incidentes dentro da Sala de Aula", "Sala de Aula" },
                    { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 24, 23, 19, 40, 262, DateTimeKind.Local).AddTicks(785), "Incidentes com Docente", "Docente" }
                });

            migrationBuilder.InsertData(
                table: "TipoUsuario",
                columns: new[] { "TipoUsuarioID", "DataHoraAlteracao", "DataHoraCadastro", "Descricao", "Nome" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 24, 23, 19, 40, 262, DateTimeKind.Local).AddTicks(767), "Usuário Admnistrador", "ADMIN" },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 24, 23, 19, 40, 262, DateTimeKind.Local).AddTicks(768), "Usuário Estudante", "ESTUDANTE" },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 24, 23, 19, 40, 262, DateTimeKind.Local).AddTicks(769), "Usuário Docente", "DOCENTE" }
                });

            migrationBuilder.InsertData(
                table: "Submenu",
                columns: new[] { "SubmenuID", "Ativo", "DataHoraAlteracao", "DataHoraCadastro", "MenuID", "NavegarURL", "Nome", "Ordem" },
                values: new object[] { 1, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 24, 23, 19, 40, 262, DateTimeKind.Local).AddTicks(855), 7, "cadastrar", "Cadastrar", 1 });

            migrationBuilder.InsertData(
                table: "Submenu",
                columns: new[] { "SubmenuID", "Ativo", "DataHoraAlteracao", "DataHoraCadastro", "MenuID", "NavegarURL", "Nome", "Ordem" },
                values: new object[] { 2, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 24, 23, 19, 40, 262, DateTimeKind.Local).AddTicks(856), 7, "consultar", "Consultar", 2 });

            migrationBuilder.InsertData(
                table: "Usuario",
                columns: new[] { "UsuarioID", "DataHoraAlteracao", "DataHoraCadastro", "Email", "Nome", "RA_SIAPE", "Senha", "SetorID", "TipoUsuarioID" },
                values: new object[] { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@email.com", "ADMIN", "123", "AJXuxI6QmxNLR5fHeHAkTTsJbpHQJlxwOJNCmYScfUPJEru1ezmHyrIOGkFMcZZ1Ng==", 1, 1 });

            migrationBuilder.InsertData(
                table: "Permissao",
                columns: new[] { "PermissaoID", "Cadastrar", "Consultar", "DataHoraAlteracao", "DataHoraCadastro", "Editar", "Excluir", "MenuID", "SubmenuID", "TipoUsuarioID" },
                values: new object[,]
                {
                    { 1, true, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 24, 23, 19, 40, 262, DateTimeKind.Local).AddTicks(871), true, true, 1, 1, 1 },
                    { 2, true, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 24, 23, 19, 40, 262, DateTimeKind.Local).AddTicks(872), true, true, 2, 1, 1 },
                    { 3, true, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 24, 23, 19, 40, 262, DateTimeKind.Local).AddTicks(873), true, true, 3, 1, 1 },
                    { 4, true, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 24, 23, 19, 40, 262, DateTimeKind.Local).AddTicks(875), true, true, 4, 1, 1 },
                    { 5, true, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 24, 23, 19, 40, 262, DateTimeKind.Local).AddTicks(876), true, true, 5, 1, 1 },
                    { 6, true, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 24, 23, 19, 40, 262, DateTimeKind.Local).AddTicks(877), true, true, 6, 1, 1 },
                    { 7, true, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 24, 23, 19, 40, 262, DateTimeKind.Local).AddTicks(878), true, true, 7, 1, 1 },
                    { 8, true, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 24, 23, 19, 40, 262, DateTimeKind.Local).AddTicks(879), true, false, 7, 1, 2 },
                    { 9, true, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 24, 23, 19, 40, 262, DateTimeKind.Local).AddTicks(880), true, false, 7, 1, 3 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Permissao",
                keyColumn: "PermissaoID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Permissao",
                keyColumn: "PermissaoID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Permissao",
                keyColumn: "PermissaoID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Permissao",
                keyColumn: "PermissaoID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Permissao",
                keyColumn: "PermissaoID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Permissao",
                keyColumn: "PermissaoID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Permissao",
                keyColumn: "PermissaoID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Permissao",
                keyColumn: "PermissaoID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Permissao",
                keyColumn: "PermissaoID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Setor",
                keyColumn: "SetorID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Setor",
                keyColumn: "SetorID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Submenu",
                keyColumn: "SubmenuID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TipoOcorrencia",
                keyColumn: "TipoOcorrenciaID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TipoOcorrencia",
                keyColumn: "TipoOcorrenciaID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TipoOcorrencia",
                keyColumn: "TipoOcorrenciaID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TipoOcorrencia",
                keyColumn: "TipoOcorrenciaID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Usuario",
                keyColumn: "UsuarioID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Setor",
                keyColumn: "SetorID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Submenu",
                keyColumn: "SubmenuID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TipoUsuario",
                keyColumn: "TipoUsuarioID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TipoUsuario",
                keyColumn: "TipoUsuarioID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TipoUsuario",
                keyColumn: "TipoUsuarioID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 7);
        }
    }
}
