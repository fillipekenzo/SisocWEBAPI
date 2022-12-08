using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SISOC.Data.Migrations
{
    public partial class AtualizarSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 1,
                columns: new[] { "DataHoraCadastro", "NavegarURL" },
                values: new object[] { new DateTime(2022, 12, 7, 19, 26, 11, 136, DateTimeKind.Local).AddTicks(8178), "/menu" });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 2,
                columns: new[] { "DataHoraCadastro", "NavegarURL" },
                values: new object[] { new DateTime(2022, 12, 7, 19, 26, 11, 136, DateTimeKind.Local).AddTicks(8179), "/setor" });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 3,
                columns: new[] { "DataHoraCadastro", "NavegarURL" },
                values: new object[] { new DateTime(2022, 12, 7, 19, 26, 11, 136, DateTimeKind.Local).AddTicks(8181), "/permissao" });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 4,
                columns: new[] { "DataHoraCadastro", "NavegarURL" },
                values: new object[] { new DateTime(2022, 12, 7, 19, 26, 11, 136, DateTimeKind.Local).AddTicks(8182), "/tipo-ocorrencia" });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 5,
                columns: new[] { "DataHoraCadastro", "NavegarURL" },
                values: new object[] { new DateTime(2022, 12, 7, 19, 26, 11, 136, DateTimeKind.Local).AddTicks(8183), "/tipo-usuario" });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 6,
                columns: new[] { "DataHoraCadastro", "NavegarURL" },
                values: new object[] { new DateTime(2022, 12, 7, 19, 26, 11, 136, DateTimeKind.Local).AddTicks(8184), "/usuario" });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 7,
                columns: new[] { "DataHoraCadastro", "NavegarURL" },
                values: new object[] { new DateTime(2022, 12, 7, 19, 26, 11, 136, DateTimeKind.Local).AddTicks(8185), "/ocorrencia" });

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
                table: "Setor",
                keyColumn: "SetorID",
                keyValue: 1,
                column: "DataHoraCadastro",
                value: new DateTime(2022, 12, 7, 19, 26, 11, 136, DateTimeKind.Local).AddTicks(8041));

            migrationBuilder.UpdateData(
                table: "Setor",
                keyColumn: "SetorID",
                keyValue: 2,
                column: "DataHoraCadastro",
                value: new DateTime(2022, 12, 7, 19, 26, 11, 136, DateTimeKind.Local).AddTicks(8049));

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
                columns: new[] { "DataHoraCadastro", "NavegarURL" },
                values: new object[] { new DateTime(2022, 12, 7, 19, 26, 11, 136, DateTimeKind.Local).AddTicks(8200), "/cadastrar" });

            migrationBuilder.UpdateData(
                table: "Submenu",
                keyColumn: "SubmenuID",
                keyValue: 2,
                columns: new[] { "DataHoraCadastro", "NavegarURL" },
                values: new object[] { new DateTime(2022, 12, 7, 19, 26, 11, 136, DateTimeKind.Local).AddTicks(8201), "/consultar" });

            migrationBuilder.UpdateData(
                table: "TipoOcorrencia",
                keyColumn: "TipoOcorrenciaID",
                keyValue: 1,
                column: "DataHoraCadastro",
                value: new DateTime(2022, 12, 7, 19, 26, 11, 136, DateTimeKind.Local).AddTicks(8155));

            migrationBuilder.UpdateData(
                table: "TipoOcorrencia",
                keyColumn: "TipoOcorrenciaID",
                keyValue: 2,
                column: "DataHoraCadastro",
                value: new DateTime(2022, 12, 7, 19, 26, 11, 136, DateTimeKind.Local).AddTicks(8155));

            migrationBuilder.UpdateData(
                table: "TipoOcorrencia",
                keyColumn: "TipoOcorrenciaID",
                keyValue: 3,
                column: "DataHoraCadastro",
                value: new DateTime(2022, 12, 7, 19, 26, 11, 136, DateTimeKind.Local).AddTicks(8156));

            migrationBuilder.UpdateData(
                table: "TipoOcorrencia",
                keyColumn: "TipoOcorrenciaID",
                keyValue: 4,
                column: "DataHoraCadastro",
                value: new DateTime(2022, 12, 7, 19, 26, 11, 136, DateTimeKind.Local).AddTicks(8157));

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

            migrationBuilder.InsertData(
                table: "TipoUsuario",
                columns: new[] { "TipoUsuarioID", "DataHoraAlteracao", "DataHoraCadastro", "Descricao", "Nome" },
                values: new object[,]
                {
                    { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 7, 19, 26, 11, 136, DateTimeKind.Local).AddTicks(8137), "Usuário responsável por atender as Ocorrências", "ATENDIMENTO" },
                    { 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 7, 19, 26, 11, 136, DateTimeKind.Local).AddTicks(8138), "Usuário com permissões para criar usuários", "SUPORTE" }
                });

            migrationBuilder.UpdateData(
                table: "Usuario",
                keyColumn: "UsuarioID",
                keyValue: 1,
                column: "Senha",
                value: "AGoQMmPjiAe4Oe0DQXFKevtwC8AQDcelnfwlbH1w2fYHz/bN8Zbp5qLyspug8FQ8ZA==");

            migrationBuilder.InsertData(
                table: "Permissao",
                columns: new[] { "PermissaoID", "Cadastrar", "Consultar", "DataHoraAlteracao", "DataHoraCadastro", "Editar", "Excluir", "MenuID", "SubmenuID", "TipoUsuarioID" },
                values: new object[] { 10, true, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 7, 19, 26, 11, 136, DateTimeKind.Local).AddTicks(8223), true, false, 7, 1, 4 });

            migrationBuilder.InsertData(
                table: "Permissao",
                columns: new[] { "PermissaoID", "Cadastrar", "Consultar", "DataHoraAlteracao", "DataHoraCadastro", "Editar", "Excluir", "MenuID", "SubmenuID", "TipoUsuarioID" },
                values: new object[] { 11, true, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 7, 19, 26, 11, 136, DateTimeKind.Local).AddTicks(8224), true, false, 6, 1, 5 });

            migrationBuilder.InsertData(
                table: "Permissao",
                columns: new[] { "PermissaoID", "Cadastrar", "Consultar", "DataHoraAlteracao", "DataHoraCadastro", "Editar", "Excluir", "MenuID", "SubmenuID", "TipoUsuarioID" },
                values: new object[] { 12, true, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 7, 19, 26, 11, 136, DateTimeKind.Local).AddTicks(8225), true, false, 7, 1, 5 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Permissao",
                keyColumn: "PermissaoID",
                keyValue: 10);

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
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "TipoUsuario",
                keyColumn: "TipoUsuarioID",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 1,
                columns: new[] { "DataHoraCadastro", "NavegarURL" },
                values: new object[] { new DateTime(2022, 11, 27, 1, 52, 21, 240, DateTimeKind.Local).AddTicks(8269), "menu" });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 2,
                columns: new[] { "DataHoraCadastro", "NavegarURL" },
                values: new object[] { new DateTime(2022, 11, 27, 1, 52, 21, 240, DateTimeKind.Local).AddTicks(8272), "setor" });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 3,
                columns: new[] { "DataHoraCadastro", "NavegarURL" },
                values: new object[] { new DateTime(2022, 11, 27, 1, 52, 21, 240, DateTimeKind.Local).AddTicks(8273), "permissao" });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 4,
                columns: new[] { "DataHoraCadastro", "NavegarURL" },
                values: new object[] { new DateTime(2022, 11, 27, 1, 52, 21, 240, DateTimeKind.Local).AddTicks(8274), "tipo-ocorrencia" });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 5,
                columns: new[] { "DataHoraCadastro", "NavegarURL" },
                values: new object[] { new DateTime(2022, 11, 27, 1, 52, 21, 240, DateTimeKind.Local).AddTicks(8276), "tipo-usuario" });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 6,
                columns: new[] { "DataHoraCadastro", "NavegarURL" },
                values: new object[] { new DateTime(2022, 11, 27, 1, 52, 21, 240, DateTimeKind.Local).AddTicks(8277), "usuario" });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 7,
                columns: new[] { "DataHoraCadastro", "NavegarURL" },
                values: new object[] { new DateTime(2022, 11, 27, 1, 52, 21, 240, DateTimeKind.Local).AddTicks(8278), "ocorrencia" });

            migrationBuilder.UpdateData(
                table: "Permissao",
                keyColumn: "PermissaoID",
                keyValue: 1,
                column: "DataHoraCadastro",
                value: new DateTime(2022, 11, 27, 1, 52, 21, 240, DateTimeKind.Local).AddTicks(8307));

            migrationBuilder.UpdateData(
                table: "Permissao",
                keyColumn: "PermissaoID",
                keyValue: 2,
                column: "DataHoraCadastro",
                value: new DateTime(2022, 11, 27, 1, 52, 21, 240, DateTimeKind.Local).AddTicks(8309));

            migrationBuilder.UpdateData(
                table: "Permissao",
                keyColumn: "PermissaoID",
                keyValue: 3,
                column: "DataHoraCadastro",
                value: new DateTime(2022, 11, 27, 1, 52, 21, 240, DateTimeKind.Local).AddTicks(8310));

            migrationBuilder.UpdateData(
                table: "Permissao",
                keyColumn: "PermissaoID",
                keyValue: 4,
                column: "DataHoraCadastro",
                value: new DateTime(2022, 11, 27, 1, 52, 21, 240, DateTimeKind.Local).AddTicks(8311));

            migrationBuilder.UpdateData(
                table: "Permissao",
                keyColumn: "PermissaoID",
                keyValue: 5,
                column: "DataHoraCadastro",
                value: new DateTime(2022, 11, 27, 1, 52, 21, 240, DateTimeKind.Local).AddTicks(8312));

            migrationBuilder.UpdateData(
                table: "Permissao",
                keyColumn: "PermissaoID",
                keyValue: 6,
                column: "DataHoraCadastro",
                value: new DateTime(2022, 11, 27, 1, 52, 21, 240, DateTimeKind.Local).AddTicks(8313));

            migrationBuilder.UpdateData(
                table: "Permissao",
                keyColumn: "PermissaoID",
                keyValue: 7,
                column: "DataHoraCadastro",
                value: new DateTime(2022, 11, 27, 1, 52, 21, 240, DateTimeKind.Local).AddTicks(8314));

            migrationBuilder.UpdateData(
                table: "Permissao",
                keyColumn: "PermissaoID",
                keyValue: 8,
                column: "DataHoraCadastro",
                value: new DateTime(2022, 11, 27, 1, 52, 21, 240, DateTimeKind.Local).AddTicks(8315));

            migrationBuilder.UpdateData(
                table: "Permissao",
                keyColumn: "PermissaoID",
                keyValue: 9,
                column: "DataHoraCadastro",
                value: new DateTime(2022, 11, 27, 1, 52, 21, 240, DateTimeKind.Local).AddTicks(8316));

            migrationBuilder.UpdateData(
                table: "Setor",
                keyColumn: "SetorID",
                keyValue: 1,
                column: "DataHoraCadastro",
                value: new DateTime(2022, 11, 27, 1, 52, 21, 240, DateTimeKind.Local).AddTicks(8142));

            migrationBuilder.UpdateData(
                table: "Setor",
                keyColumn: "SetorID",
                keyValue: 2,
                column: "DataHoraCadastro",
                value: new DateTime(2022, 11, 27, 1, 52, 21, 240, DateTimeKind.Local).AddTicks(8150));

            migrationBuilder.UpdateData(
                table: "Setor",
                keyColumn: "SetorID",
                keyValue: 3,
                column: "DataHoraCadastro",
                value: new DateTime(2022, 11, 27, 1, 52, 21, 240, DateTimeKind.Local).AddTicks(8151));

            migrationBuilder.UpdateData(
                table: "Submenu",
                keyColumn: "SubmenuID",
                keyValue: 1,
                columns: new[] { "DataHoraCadastro", "NavegarURL" },
                values: new object[] { new DateTime(2022, 11, 27, 1, 52, 21, 240, DateTimeKind.Local).AddTicks(8293), "cadastrar" });

            migrationBuilder.UpdateData(
                table: "Submenu",
                keyColumn: "SubmenuID",
                keyValue: 2,
                columns: new[] { "DataHoraCadastro", "NavegarURL" },
                values: new object[] { new DateTime(2022, 11, 27, 1, 52, 21, 240, DateTimeKind.Local).AddTicks(8294), "consultar" });

            migrationBuilder.UpdateData(
                table: "TipoOcorrencia",
                keyColumn: "TipoOcorrenciaID",
                keyValue: 1,
                column: "DataHoraCadastro",
                value: new DateTime(2022, 11, 27, 1, 52, 21, 240, DateTimeKind.Local).AddTicks(8251));

            migrationBuilder.UpdateData(
                table: "TipoOcorrencia",
                keyColumn: "TipoOcorrenciaID",
                keyValue: 2,
                column: "DataHoraCadastro",
                value: new DateTime(2022, 11, 27, 1, 52, 21, 240, DateTimeKind.Local).AddTicks(8252));

            migrationBuilder.UpdateData(
                table: "TipoOcorrencia",
                keyColumn: "TipoOcorrenciaID",
                keyValue: 3,
                column: "DataHoraCadastro",
                value: new DateTime(2022, 11, 27, 1, 52, 21, 240, DateTimeKind.Local).AddTicks(8253));

            migrationBuilder.UpdateData(
                table: "TipoOcorrencia",
                keyColumn: "TipoOcorrenciaID",
                keyValue: 4,
                column: "DataHoraCadastro",
                value: new DateTime(2022, 11, 27, 1, 52, 21, 240, DateTimeKind.Local).AddTicks(8253));

            migrationBuilder.UpdateData(
                table: "TipoUsuario",
                keyColumn: "TipoUsuarioID",
                keyValue: 1,
                column: "DataHoraCadastro",
                value: new DateTime(2022, 11, 27, 1, 52, 21, 240, DateTimeKind.Local).AddTicks(8233));

            migrationBuilder.UpdateData(
                table: "TipoUsuario",
                keyColumn: "TipoUsuarioID",
                keyValue: 2,
                column: "DataHoraCadastro",
                value: new DateTime(2022, 11, 27, 1, 52, 21, 240, DateTimeKind.Local).AddTicks(8234));

            migrationBuilder.UpdateData(
                table: "TipoUsuario",
                keyColumn: "TipoUsuarioID",
                keyValue: 3,
                column: "DataHoraCadastro",
                value: new DateTime(2022, 11, 27, 1, 52, 21, 240, DateTimeKind.Local).AddTicks(8235));

            migrationBuilder.UpdateData(
                table: "Usuario",
                keyColumn: "UsuarioID",
                keyValue: 1,
                column: "Senha",
                value: "ADLDNon2r1ImCafG93LaSZVP1ReC9COfo81feIgF3XeNGT8/nfT1aq8ayOO3YKOgTg==");
        }
    }
}
