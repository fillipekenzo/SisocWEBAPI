using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SISOC.Data.Migrations
{
    public partial class Anexodados : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ArquivoURL",
                table: "Anexo",
                newName: "AnexoURL");

            migrationBuilder.AddColumn<byte[]>(
                name: "AnexoDados",
                table: "Anexo",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "DataHoraCadastro",
                value: new DateTime(2022, 11, 27, 1, 42, 58, 4, DateTimeKind.Local).AddTicks(8264));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "DataHoraCadastro",
                value: new DateTime(2022, 11, 27, 1, 42, 58, 4, DateTimeKind.Local).AddTicks(8302));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "DataHoraCadastro",
                value: new DateTime(2022, 11, 27, 1, 42, 58, 4, DateTimeKind.Local).AddTicks(8303));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "DataHoraCadastro",
                value: new DateTime(2022, 11, 27, 1, 42, 58, 4, DateTimeKind.Local).AddTicks(8305));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "DataHoraCadastro",
                value: new DateTime(2022, 11, 27, 1, 42, 58, 4, DateTimeKind.Local).AddTicks(8306));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "DataHoraCadastro",
                value: new DateTime(2022, 11, 27, 1, 42, 58, 4, DateTimeKind.Local).AddTicks(8307));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "DataHoraCadastro",
                value: new DateTime(2022, 11, 27, 1, 42, 58, 4, DateTimeKind.Local).AddTicks(8309));

            migrationBuilder.UpdateData(
                table: "Permissao",
                keyColumn: "PermissaoID",
                keyValue: 1,
                column: "DataHoraCadastro",
                value: new DateTime(2022, 11, 27, 1, 42, 58, 4, DateTimeKind.Local).AddTicks(8347));

            migrationBuilder.UpdateData(
                table: "Permissao",
                keyColumn: "PermissaoID",
                keyValue: 2,
                column: "DataHoraCadastro",
                value: new DateTime(2022, 11, 27, 1, 42, 58, 4, DateTimeKind.Local).AddTicks(8349));

            migrationBuilder.UpdateData(
                table: "Permissao",
                keyColumn: "PermissaoID",
                keyValue: 3,
                column: "DataHoraCadastro",
                value: new DateTime(2022, 11, 27, 1, 42, 58, 4, DateTimeKind.Local).AddTicks(8350));

            migrationBuilder.UpdateData(
                table: "Permissao",
                keyColumn: "PermissaoID",
                keyValue: 4,
                column: "DataHoraCadastro",
                value: new DateTime(2022, 11, 27, 1, 42, 58, 4, DateTimeKind.Local).AddTicks(8351));

            migrationBuilder.UpdateData(
                table: "Permissao",
                keyColumn: "PermissaoID",
                keyValue: 5,
                column: "DataHoraCadastro",
                value: new DateTime(2022, 11, 27, 1, 42, 58, 4, DateTimeKind.Local).AddTicks(8352));

            migrationBuilder.UpdateData(
                table: "Permissao",
                keyColumn: "PermissaoID",
                keyValue: 6,
                column: "DataHoraCadastro",
                value: new DateTime(2022, 11, 27, 1, 42, 58, 4, DateTimeKind.Local).AddTicks(8353));

            migrationBuilder.UpdateData(
                table: "Permissao",
                keyColumn: "PermissaoID",
                keyValue: 7,
                column: "DataHoraCadastro",
                value: new DateTime(2022, 11, 27, 1, 42, 58, 4, DateTimeKind.Local).AddTicks(8354));

            migrationBuilder.UpdateData(
                table: "Permissao",
                keyColumn: "PermissaoID",
                keyValue: 8,
                column: "DataHoraCadastro",
                value: new DateTime(2022, 11, 27, 1, 42, 58, 4, DateTimeKind.Local).AddTicks(8356));

            migrationBuilder.UpdateData(
                table: "Permissao",
                keyColumn: "PermissaoID",
                keyValue: 9,
                column: "DataHoraCadastro",
                value: new DateTime(2022, 11, 27, 1, 42, 58, 4, DateTimeKind.Local).AddTicks(8357));

            migrationBuilder.UpdateData(
                table: "Setor",
                keyColumn: "SetorID",
                keyValue: 1,
                column: "DataHoraCadastro",
                value: new DateTime(2022, 11, 27, 1, 42, 58, 4, DateTimeKind.Local).AddTicks(8111));

            migrationBuilder.UpdateData(
                table: "Setor",
                keyColumn: "SetorID",
                keyValue: 2,
                column: "DataHoraCadastro",
                value: new DateTime(2022, 11, 27, 1, 42, 58, 4, DateTimeKind.Local).AddTicks(8121));

            migrationBuilder.UpdateData(
                table: "Setor",
                keyColumn: "SetorID",
                keyValue: 3,
                column: "DataHoraCadastro",
                value: new DateTime(2022, 11, 27, 1, 42, 58, 4, DateTimeKind.Local).AddTicks(8122));

            migrationBuilder.UpdateData(
                table: "Submenu",
                keyColumn: "SubmenuID",
                keyValue: 1,
                column: "DataHoraCadastro",
                value: new DateTime(2022, 11, 27, 1, 42, 58, 4, DateTimeKind.Local).AddTicks(8328));

            migrationBuilder.UpdateData(
                table: "Submenu",
                keyColumn: "SubmenuID",
                keyValue: 2,
                column: "DataHoraCadastro",
                value: new DateTime(2022, 11, 27, 1, 42, 58, 4, DateTimeKind.Local).AddTicks(8329));

            migrationBuilder.UpdateData(
                table: "TipoOcorrencia",
                keyColumn: "TipoOcorrenciaID",
                keyValue: 1,
                column: "DataHoraCadastro",
                value: new DateTime(2022, 11, 27, 1, 42, 58, 4, DateTimeKind.Local).AddTicks(8242));

            migrationBuilder.UpdateData(
                table: "TipoOcorrencia",
                keyColumn: "TipoOcorrenciaID",
                keyValue: 2,
                column: "DataHoraCadastro",
                value: new DateTime(2022, 11, 27, 1, 42, 58, 4, DateTimeKind.Local).AddTicks(8243));

            migrationBuilder.UpdateData(
                table: "TipoOcorrencia",
                keyColumn: "TipoOcorrenciaID",
                keyValue: 3,
                column: "DataHoraCadastro",
                value: new DateTime(2022, 11, 27, 1, 42, 58, 4, DateTimeKind.Local).AddTicks(8243));

            migrationBuilder.UpdateData(
                table: "TipoOcorrencia",
                keyColumn: "TipoOcorrenciaID",
                keyValue: 4,
                column: "DataHoraCadastro",
                value: new DateTime(2022, 11, 27, 1, 42, 58, 4, DateTimeKind.Local).AddTicks(8244));

            migrationBuilder.UpdateData(
                table: "TipoUsuario",
                keyColumn: "TipoUsuarioID",
                keyValue: 1,
                column: "DataHoraCadastro",
                value: new DateTime(2022, 11, 27, 1, 42, 58, 4, DateTimeKind.Local).AddTicks(8223));

            migrationBuilder.UpdateData(
                table: "TipoUsuario",
                keyColumn: "TipoUsuarioID",
                keyValue: 2,
                column: "DataHoraCadastro",
                value: new DateTime(2022, 11, 27, 1, 42, 58, 4, DateTimeKind.Local).AddTicks(8224));

            migrationBuilder.UpdateData(
                table: "TipoUsuario",
                keyColumn: "TipoUsuarioID",
                keyValue: 3,
                column: "DataHoraCadastro",
                value: new DateTime(2022, 11, 27, 1, 42, 58, 4, DateTimeKind.Local).AddTicks(8226));

            migrationBuilder.UpdateData(
                table: "Usuario",
                keyColumn: "UsuarioID",
                keyValue: 1,
                column: "Senha",
                value: "ALE29bg3K6xZ7bRZRZmpFM7QcA4P/bKcYa2xoY25mXJj6E/ldskt33Z9mtita7hG3w==");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AnexoDados",
                table: "Anexo");

            migrationBuilder.RenameColumn(
                name: "AnexoURL",
                table: "Anexo",
                newName: "ArquivoURL");

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "DataHoraCadastro",
                value: new DateTime(2022, 10, 24, 23, 19, 40, 262, DateTimeKind.Local).AddTicks(802));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "DataHoraCadastro",
                value: new DateTime(2022, 10, 24, 23, 19, 40, 262, DateTimeKind.Local).AddTicks(804));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "DataHoraCadastro",
                value: new DateTime(2022, 10, 24, 23, 19, 40, 262, DateTimeKind.Local).AddTicks(805));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "DataHoraCadastro",
                value: new DateTime(2022, 10, 24, 23, 19, 40, 262, DateTimeKind.Local).AddTicks(807));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "DataHoraCadastro",
                value: new DateTime(2022, 10, 24, 23, 19, 40, 262, DateTimeKind.Local).AddTicks(808));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "DataHoraCadastro",
                value: new DateTime(2022, 10, 24, 23, 19, 40, 262, DateTimeKind.Local).AddTicks(809));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "DataHoraCadastro",
                value: new DateTime(2022, 10, 24, 23, 19, 40, 262, DateTimeKind.Local).AddTicks(838));

            migrationBuilder.UpdateData(
                table: "Permissao",
                keyColumn: "PermissaoID",
                keyValue: 1,
                column: "DataHoraCadastro",
                value: new DateTime(2022, 10, 24, 23, 19, 40, 262, DateTimeKind.Local).AddTicks(871));

            migrationBuilder.UpdateData(
                table: "Permissao",
                keyColumn: "PermissaoID",
                keyValue: 2,
                column: "DataHoraCadastro",
                value: new DateTime(2022, 10, 24, 23, 19, 40, 262, DateTimeKind.Local).AddTicks(872));

            migrationBuilder.UpdateData(
                table: "Permissao",
                keyColumn: "PermissaoID",
                keyValue: 3,
                column: "DataHoraCadastro",
                value: new DateTime(2022, 10, 24, 23, 19, 40, 262, DateTimeKind.Local).AddTicks(873));

            migrationBuilder.UpdateData(
                table: "Permissao",
                keyColumn: "PermissaoID",
                keyValue: 4,
                column: "DataHoraCadastro",
                value: new DateTime(2022, 10, 24, 23, 19, 40, 262, DateTimeKind.Local).AddTicks(875));

            migrationBuilder.UpdateData(
                table: "Permissao",
                keyColumn: "PermissaoID",
                keyValue: 5,
                column: "DataHoraCadastro",
                value: new DateTime(2022, 10, 24, 23, 19, 40, 262, DateTimeKind.Local).AddTicks(876));

            migrationBuilder.UpdateData(
                table: "Permissao",
                keyColumn: "PermissaoID",
                keyValue: 6,
                column: "DataHoraCadastro",
                value: new DateTime(2022, 10, 24, 23, 19, 40, 262, DateTimeKind.Local).AddTicks(877));

            migrationBuilder.UpdateData(
                table: "Permissao",
                keyColumn: "PermissaoID",
                keyValue: 7,
                column: "DataHoraCadastro",
                value: new DateTime(2022, 10, 24, 23, 19, 40, 262, DateTimeKind.Local).AddTicks(878));

            migrationBuilder.UpdateData(
                table: "Permissao",
                keyColumn: "PermissaoID",
                keyValue: 8,
                column: "DataHoraCadastro",
                value: new DateTime(2022, 10, 24, 23, 19, 40, 262, DateTimeKind.Local).AddTicks(879));

            migrationBuilder.UpdateData(
                table: "Permissao",
                keyColumn: "PermissaoID",
                keyValue: 9,
                column: "DataHoraCadastro",
                value: new DateTime(2022, 10, 24, 23, 19, 40, 262, DateTimeKind.Local).AddTicks(880));

            migrationBuilder.UpdateData(
                table: "Setor",
                keyColumn: "SetorID",
                keyValue: 1,
                column: "DataHoraCadastro",
                value: new DateTime(2022, 10, 24, 23, 19, 40, 262, DateTimeKind.Local).AddTicks(674));

            migrationBuilder.UpdateData(
                table: "Setor",
                keyColumn: "SetorID",
                keyValue: 2,
                column: "DataHoraCadastro",
                value: new DateTime(2022, 10, 24, 23, 19, 40, 262, DateTimeKind.Local).AddTicks(683));

            migrationBuilder.UpdateData(
                table: "Setor",
                keyColumn: "SetorID",
                keyValue: 3,
                column: "DataHoraCadastro",
                value: new DateTime(2022, 10, 24, 23, 19, 40, 262, DateTimeKind.Local).AddTicks(684));

            migrationBuilder.UpdateData(
                table: "Submenu",
                keyColumn: "SubmenuID",
                keyValue: 1,
                column: "DataHoraCadastro",
                value: new DateTime(2022, 10, 24, 23, 19, 40, 262, DateTimeKind.Local).AddTicks(855));

            migrationBuilder.UpdateData(
                table: "Submenu",
                keyColumn: "SubmenuID",
                keyValue: 2,
                column: "DataHoraCadastro",
                value: new DateTime(2022, 10, 24, 23, 19, 40, 262, DateTimeKind.Local).AddTicks(856));

            migrationBuilder.UpdateData(
                table: "TipoOcorrencia",
                keyColumn: "TipoOcorrenciaID",
                keyValue: 1,
                column: "DataHoraCadastro",
                value: new DateTime(2022, 10, 24, 23, 19, 40, 262, DateTimeKind.Local).AddTicks(782));

            migrationBuilder.UpdateData(
                table: "TipoOcorrencia",
                keyColumn: "TipoOcorrenciaID",
                keyValue: 2,
                column: "DataHoraCadastro",
                value: new DateTime(2022, 10, 24, 23, 19, 40, 262, DateTimeKind.Local).AddTicks(783));

            migrationBuilder.UpdateData(
                table: "TipoOcorrencia",
                keyColumn: "TipoOcorrenciaID",
                keyValue: 3,
                column: "DataHoraCadastro",
                value: new DateTime(2022, 10, 24, 23, 19, 40, 262, DateTimeKind.Local).AddTicks(784));

            migrationBuilder.UpdateData(
                table: "TipoOcorrencia",
                keyColumn: "TipoOcorrenciaID",
                keyValue: 4,
                column: "DataHoraCadastro",
                value: new DateTime(2022, 10, 24, 23, 19, 40, 262, DateTimeKind.Local).AddTicks(785));

            migrationBuilder.UpdateData(
                table: "TipoUsuario",
                keyColumn: "TipoUsuarioID",
                keyValue: 1,
                column: "DataHoraCadastro",
                value: new DateTime(2022, 10, 24, 23, 19, 40, 262, DateTimeKind.Local).AddTicks(767));

            migrationBuilder.UpdateData(
                table: "TipoUsuario",
                keyColumn: "TipoUsuarioID",
                keyValue: 2,
                column: "DataHoraCadastro",
                value: new DateTime(2022, 10, 24, 23, 19, 40, 262, DateTimeKind.Local).AddTicks(768));

            migrationBuilder.UpdateData(
                table: "TipoUsuario",
                keyColumn: "TipoUsuarioID",
                keyValue: 3,
                column: "DataHoraCadastro",
                value: new DateTime(2022, 10, 24, 23, 19, 40, 262, DateTimeKind.Local).AddTicks(769));

            migrationBuilder.UpdateData(
                table: "Usuario",
                keyColumn: "UsuarioID",
                keyValue: 1,
                column: "Senha",
                value: "AJXuxI6QmxNLR5fHeHAkTTsJbpHQJlxwOJNCmYScfUPJEru1ezmHyrIOGkFMcZZ1Ng==");
        }
    }
}
