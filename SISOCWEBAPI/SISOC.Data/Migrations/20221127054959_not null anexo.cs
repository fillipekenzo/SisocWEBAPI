using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SISOC.Data.Migrations
{
    public partial class notnullanexo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "AnexoURL",
                table: "Anexo",
                type: "nvarchar(255)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)");

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "DataHoraCadastro",
                value: new DateTime(2022, 11, 27, 1, 49, 59, 219, DateTimeKind.Local).AddTicks(554));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "DataHoraCadastro",
                value: new DateTime(2022, 11, 27, 1, 49, 59, 219, DateTimeKind.Local).AddTicks(556));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "DataHoraCadastro",
                value: new DateTime(2022, 11, 27, 1, 49, 59, 219, DateTimeKind.Local).AddTicks(558));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "DataHoraCadastro",
                value: new DateTime(2022, 11, 27, 1, 49, 59, 219, DateTimeKind.Local).AddTicks(559));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "DataHoraCadastro",
                value: new DateTime(2022, 11, 27, 1, 49, 59, 219, DateTimeKind.Local).AddTicks(560));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "DataHoraCadastro",
                value: new DateTime(2022, 11, 27, 1, 49, 59, 219, DateTimeKind.Local).AddTicks(561));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "DataHoraCadastro",
                value: new DateTime(2022, 11, 27, 1, 49, 59, 219, DateTimeKind.Local).AddTicks(562));

            migrationBuilder.UpdateData(
                table: "Permissao",
                keyColumn: "PermissaoID",
                keyValue: 1,
                column: "DataHoraCadastro",
                value: new DateTime(2022, 11, 27, 1, 49, 59, 219, DateTimeKind.Local).AddTicks(594));

            migrationBuilder.UpdateData(
                table: "Permissao",
                keyColumn: "PermissaoID",
                keyValue: 2,
                column: "DataHoraCadastro",
                value: new DateTime(2022, 11, 27, 1, 49, 59, 219, DateTimeKind.Local).AddTicks(596));

            migrationBuilder.UpdateData(
                table: "Permissao",
                keyColumn: "PermissaoID",
                keyValue: 3,
                column: "DataHoraCadastro",
                value: new DateTime(2022, 11, 27, 1, 49, 59, 219, DateTimeKind.Local).AddTicks(598));

            migrationBuilder.UpdateData(
                table: "Permissao",
                keyColumn: "PermissaoID",
                keyValue: 4,
                column: "DataHoraCadastro",
                value: new DateTime(2022, 11, 27, 1, 49, 59, 219, DateTimeKind.Local).AddTicks(599));

            migrationBuilder.UpdateData(
                table: "Permissao",
                keyColumn: "PermissaoID",
                keyValue: 5,
                column: "DataHoraCadastro",
                value: new DateTime(2022, 11, 27, 1, 49, 59, 219, DateTimeKind.Local).AddTicks(600));

            migrationBuilder.UpdateData(
                table: "Permissao",
                keyColumn: "PermissaoID",
                keyValue: 6,
                column: "DataHoraCadastro",
                value: new DateTime(2022, 11, 27, 1, 49, 59, 219, DateTimeKind.Local).AddTicks(602));

            migrationBuilder.UpdateData(
                table: "Permissao",
                keyColumn: "PermissaoID",
                keyValue: 7,
                column: "DataHoraCadastro",
                value: new DateTime(2022, 11, 27, 1, 49, 59, 219, DateTimeKind.Local).AddTicks(603));

            migrationBuilder.UpdateData(
                table: "Permissao",
                keyColumn: "PermissaoID",
                keyValue: 8,
                column: "DataHoraCadastro",
                value: new DateTime(2022, 11, 27, 1, 49, 59, 219, DateTimeKind.Local).AddTicks(604));

            migrationBuilder.UpdateData(
                table: "Permissao",
                keyColumn: "PermissaoID",
                keyValue: 9,
                column: "DataHoraCadastro",
                value: new DateTime(2022, 11, 27, 1, 49, 59, 219, DateTimeKind.Local).AddTicks(605));

            migrationBuilder.UpdateData(
                table: "Setor",
                keyColumn: "SetorID",
                keyValue: 1,
                column: "DataHoraCadastro",
                value: new DateTime(2022, 11, 27, 1, 49, 59, 219, DateTimeKind.Local).AddTicks(416));

            migrationBuilder.UpdateData(
                table: "Setor",
                keyColumn: "SetorID",
                keyValue: 2,
                column: "DataHoraCadastro",
                value: new DateTime(2022, 11, 27, 1, 49, 59, 219, DateTimeKind.Local).AddTicks(423));

            migrationBuilder.UpdateData(
                table: "Setor",
                keyColumn: "SetorID",
                keyValue: 3,
                column: "DataHoraCadastro",
                value: new DateTime(2022, 11, 27, 1, 49, 59, 219, DateTimeKind.Local).AddTicks(424));

            migrationBuilder.UpdateData(
                table: "Submenu",
                keyColumn: "SubmenuID",
                keyValue: 1,
                column: "DataHoraCadastro",
                value: new DateTime(2022, 11, 27, 1, 49, 59, 219, DateTimeKind.Local).AddTicks(578));

            migrationBuilder.UpdateData(
                table: "Submenu",
                keyColumn: "SubmenuID",
                keyValue: 2,
                column: "DataHoraCadastro",
                value: new DateTime(2022, 11, 27, 1, 49, 59, 219, DateTimeKind.Local).AddTicks(580));

            migrationBuilder.UpdateData(
                table: "TipoOcorrencia",
                keyColumn: "TipoOcorrenciaID",
                keyValue: 1,
                column: "DataHoraCadastro",
                value: new DateTime(2022, 11, 27, 1, 49, 59, 219, DateTimeKind.Local).AddTicks(534));

            migrationBuilder.UpdateData(
                table: "TipoOcorrencia",
                keyColumn: "TipoOcorrenciaID",
                keyValue: 2,
                column: "DataHoraCadastro",
                value: new DateTime(2022, 11, 27, 1, 49, 59, 219, DateTimeKind.Local).AddTicks(535));

            migrationBuilder.UpdateData(
                table: "TipoOcorrencia",
                keyColumn: "TipoOcorrenciaID",
                keyValue: 3,
                column: "DataHoraCadastro",
                value: new DateTime(2022, 11, 27, 1, 49, 59, 219, DateTimeKind.Local).AddTicks(536));

            migrationBuilder.UpdateData(
                table: "TipoOcorrencia",
                keyColumn: "TipoOcorrenciaID",
                keyValue: 4,
                column: "DataHoraCadastro",
                value: new DateTime(2022, 11, 27, 1, 49, 59, 219, DateTimeKind.Local).AddTicks(536));

            migrationBuilder.UpdateData(
                table: "TipoUsuario",
                keyColumn: "TipoUsuarioID",
                keyValue: 1,
                column: "DataHoraCadastro",
                value: new DateTime(2022, 11, 27, 1, 49, 59, 219, DateTimeKind.Local).AddTicks(514));

            migrationBuilder.UpdateData(
                table: "TipoUsuario",
                keyColumn: "TipoUsuarioID",
                keyValue: 2,
                column: "DataHoraCadastro",
                value: new DateTime(2022, 11, 27, 1, 49, 59, 219, DateTimeKind.Local).AddTicks(515));

            migrationBuilder.UpdateData(
                table: "TipoUsuario",
                keyColumn: "TipoUsuarioID",
                keyValue: 3,
                column: "DataHoraCadastro",
                value: new DateTime(2022, 11, 27, 1, 49, 59, 219, DateTimeKind.Local).AddTicks(516));

            migrationBuilder.UpdateData(
                table: "Usuario",
                keyColumn: "UsuarioID",
                keyValue: 1,
                column: "Senha",
                value: "AGqgZvugXqsrWMXkq9m3JnPICeWo2NI/gQQAR53oGET93t2s9V4ZsyP34HH+6FWi0w==");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "AnexoURL",
                table: "Anexo",
                type: "nvarchar(255)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldNullable: true);

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
    }
}
