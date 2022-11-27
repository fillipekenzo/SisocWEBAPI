using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SISOC.Data.Migrations
{
    public partial class nullablerelacionamentoanexo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "OcorrenciaID",
                table: "Anexo",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "InteracaoOcorrenciaID",
                table: "Anexo",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "DataHoraCadastro",
                value: new DateTime(2022, 11, 27, 1, 52, 21, 240, DateTimeKind.Local).AddTicks(8269));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "DataHoraCadastro",
                value: new DateTime(2022, 11, 27, 1, 52, 21, 240, DateTimeKind.Local).AddTicks(8272));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "DataHoraCadastro",
                value: new DateTime(2022, 11, 27, 1, 52, 21, 240, DateTimeKind.Local).AddTicks(8273));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "DataHoraCadastro",
                value: new DateTime(2022, 11, 27, 1, 52, 21, 240, DateTimeKind.Local).AddTicks(8274));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "DataHoraCadastro",
                value: new DateTime(2022, 11, 27, 1, 52, 21, 240, DateTimeKind.Local).AddTicks(8276));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "DataHoraCadastro",
                value: new DateTime(2022, 11, 27, 1, 52, 21, 240, DateTimeKind.Local).AddTicks(8277));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "DataHoraCadastro",
                value: new DateTime(2022, 11, 27, 1, 52, 21, 240, DateTimeKind.Local).AddTicks(8278));

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
                column: "DataHoraCadastro",
                value: new DateTime(2022, 11, 27, 1, 52, 21, 240, DateTimeKind.Local).AddTicks(8293));

            migrationBuilder.UpdateData(
                table: "Submenu",
                keyColumn: "SubmenuID",
                keyValue: 2,
                column: "DataHoraCadastro",
                value: new DateTime(2022, 11, 27, 1, 52, 21, 240, DateTimeKind.Local).AddTicks(8294));

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "OcorrenciaID",
                table: "Anexo",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "InteracaoOcorrenciaID",
                table: "Anexo",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

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
    }
}
