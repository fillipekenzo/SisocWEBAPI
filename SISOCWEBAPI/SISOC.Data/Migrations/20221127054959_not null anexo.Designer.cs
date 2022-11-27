﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SISOC.Data.Context;

#nullable disable

namespace SISOC.Data.Migrations
{
    [DbContext(typeof(SisocDbContext))]
    [Migration("20221127054959_not null anexo")]
    partial class notnullanexo
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("SISOC.Business.Models.Anexo", b =>
                {
                    b.Property<int>("AnexoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AnexoID"), 1L, 1);

                    b.Property<byte[]>("AnexoDados")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("AnexoURL")
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime>("DataHoraAlteracao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataHoraCadastro")
                        .HasColumnType("datetime2");

                    b.Property<int?>("InteracaoOcorrenciaID")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)");

                    b.Property<int?>("OcorrenciaID")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("TipoAnexo")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("AnexoID");

                    b.HasIndex("InteracaoOcorrenciaID");

                    b.HasIndex("OcorrenciaID");

                    b.ToTable("Anexo");
                });

            modelBuilder.Entity("SISOC.Business.Models.InteracaoOcorrencia", b =>
                {
                    b.Property<int>("InteracaoOcorrenciaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("InteracaoOcorrenciaID"), 1L, 1);

                    b.Property<string>("Assunto")
                        .IsRequired()
                        .HasColumnType("nvarchar(500)");

                    b.Property<DateTime>("DataHoraAlteracao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataHoraCadastro")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(MAX)");

                    b.Property<int>("OcorrenciaID")
                        .HasColumnType("int");

                    b.Property<int>("UsuarioID")
                        .HasColumnType("int");

                    b.HasKey("InteracaoOcorrenciaID");

                    b.HasIndex("OcorrenciaID");

                    b.HasIndex("UsuarioID");

                    b.ToTable("InteracaoOcorrencia");
                });

            modelBuilder.Entity("SISOC.Business.Models.Menu", b =>
                {
                    b.Property<int>("MenuID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MenuID"), 1L, 1);

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit");

                    b.Property<DateTime>("DataHoraAlteracao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataHoraCadastro")
                        .HasColumnType("datetime2");

                    b.Property<string>("NavegarURL")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("Ordem")
                        .HasColumnType("int");

                    b.HasKey("MenuID");

                    b.ToTable("Menu");

                    b.HasData(
                        new
                        {
                            MenuID = 1,
                            Ativo = true,
                            DataHoraAlteracao = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataHoraCadastro = new DateTime(2022, 11, 27, 1, 49, 59, 219, DateTimeKind.Local).AddTicks(554),
                            NavegarURL = "menu",
                            Nome = "Menu",
                            Ordem = 1
                        },
                        new
                        {
                            MenuID = 2,
                            Ativo = true,
                            DataHoraAlteracao = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataHoraCadastro = new DateTime(2022, 11, 27, 1, 49, 59, 219, DateTimeKind.Local).AddTicks(556),
                            NavegarURL = "setor",
                            Nome = "Setor",
                            Ordem = 2
                        },
                        new
                        {
                            MenuID = 3,
                            Ativo = true,
                            DataHoraAlteracao = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataHoraCadastro = new DateTime(2022, 11, 27, 1, 49, 59, 219, DateTimeKind.Local).AddTicks(558),
                            NavegarURL = "permissao",
                            Nome = "Permissão",
                            Ordem = 3
                        },
                        new
                        {
                            MenuID = 4,
                            Ativo = true,
                            DataHoraAlteracao = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataHoraCadastro = new DateTime(2022, 11, 27, 1, 49, 59, 219, DateTimeKind.Local).AddTicks(559),
                            NavegarURL = "tipo-ocorrencia",
                            Nome = "Tipo Ocorrência",
                            Ordem = 4
                        },
                        new
                        {
                            MenuID = 5,
                            Ativo = true,
                            DataHoraAlteracao = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataHoraCadastro = new DateTime(2022, 11, 27, 1, 49, 59, 219, DateTimeKind.Local).AddTicks(560),
                            NavegarURL = "tipo-usuario",
                            Nome = "Tipo Usuário",
                            Ordem = 5
                        },
                        new
                        {
                            MenuID = 6,
                            Ativo = true,
                            DataHoraAlteracao = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataHoraCadastro = new DateTime(2022, 11, 27, 1, 49, 59, 219, DateTimeKind.Local).AddTicks(561),
                            NavegarURL = "usuario",
                            Nome = "Usuário",
                            Ordem = 6
                        },
                        new
                        {
                            MenuID = 7,
                            Ativo = true,
                            DataHoraAlteracao = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataHoraCadastro = new DateTime(2022, 11, 27, 1, 49, 59, 219, DateTimeKind.Local).AddTicks(562),
                            NavegarURL = "ocorrencia",
                            Nome = "Ocorrência",
                            Ordem = 7
                        });
                });

            modelBuilder.Entity("SISOC.Business.Models.Ocorrencia", b =>
                {
                    b.Property<int>("OcorrenciaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OcorrenciaID"), 1L, 1);

                    b.Property<string>("Assunto")
                        .IsRequired()
                        .HasColumnType("nvarchar(500)");

                    b.Property<DateTime>("DataHoraAlteracao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataHoraCadastro")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(MAX)");

                    b.Property<string>("Resolucao")
                        .HasColumnType("nvarchar(MAX)");

                    b.Property<int>("SetorID")
                        .HasColumnType("int");

                    b.Property<string>("SituacaoENUM")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("TipoOcorrenciaID")
                        .HasColumnType("int");

                    b.Property<string>("UrgenciaENUM")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)");

                    b.Property<int?>("UsuarioAtribuidoID")
                        .HasColumnType("int");

                    b.Property<int>("UsuarioCadastroID")
                        .HasColumnType("int");

                    b.HasKey("OcorrenciaID");

                    b.HasIndex("SetorID");

                    b.HasIndex("TipoOcorrenciaID");

                    b.HasIndex("UsuarioAtribuidoID");

                    b.HasIndex("UsuarioCadastroID");

                    b.ToTable("Ocorrencia");
                });

            modelBuilder.Entity("SISOC.Business.Models.Permissao", b =>
                {
                    b.Property<int>("PermissaoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PermissaoID"), 1L, 1);

                    b.Property<bool>("Cadastrar")
                        .HasColumnType("bit");

                    b.Property<bool>("Consultar")
                        .HasColumnType("bit");

                    b.Property<DateTime>("DataHoraAlteracao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataHoraCadastro")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Editar")
                        .HasColumnType("bit");

                    b.Property<bool>("Excluir")
                        .HasColumnType("bit");

                    b.Property<int?>("MenuID")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("SubmenuID")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int>("TipoUsuarioID")
                        .HasColumnType("int");

                    b.HasKey("PermissaoID");

                    b.HasIndex("MenuID");

                    b.HasIndex("SubmenuID");

                    b.HasIndex("TipoUsuarioID");

                    b.ToTable("Permissao");

                    b.HasData(
                        new
                        {
                            PermissaoID = 1,
                            Cadastrar = true,
                            Consultar = true,
                            DataHoraAlteracao = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataHoraCadastro = new DateTime(2022, 11, 27, 1, 49, 59, 219, DateTimeKind.Local).AddTicks(594),
                            Editar = true,
                            Excluir = true,
                            MenuID = 1,
                            SubmenuID = 1,
                            TipoUsuarioID = 1
                        },
                        new
                        {
                            PermissaoID = 2,
                            Cadastrar = true,
                            Consultar = true,
                            DataHoraAlteracao = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataHoraCadastro = new DateTime(2022, 11, 27, 1, 49, 59, 219, DateTimeKind.Local).AddTicks(596),
                            Editar = true,
                            Excluir = true,
                            MenuID = 2,
                            SubmenuID = 1,
                            TipoUsuarioID = 1
                        },
                        new
                        {
                            PermissaoID = 3,
                            Cadastrar = true,
                            Consultar = true,
                            DataHoraAlteracao = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataHoraCadastro = new DateTime(2022, 11, 27, 1, 49, 59, 219, DateTimeKind.Local).AddTicks(598),
                            Editar = true,
                            Excluir = true,
                            MenuID = 3,
                            SubmenuID = 1,
                            TipoUsuarioID = 1
                        },
                        new
                        {
                            PermissaoID = 4,
                            Cadastrar = true,
                            Consultar = true,
                            DataHoraAlteracao = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataHoraCadastro = new DateTime(2022, 11, 27, 1, 49, 59, 219, DateTimeKind.Local).AddTicks(599),
                            Editar = true,
                            Excluir = true,
                            MenuID = 4,
                            SubmenuID = 1,
                            TipoUsuarioID = 1
                        },
                        new
                        {
                            PermissaoID = 5,
                            Cadastrar = true,
                            Consultar = true,
                            DataHoraAlteracao = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataHoraCadastro = new DateTime(2022, 11, 27, 1, 49, 59, 219, DateTimeKind.Local).AddTicks(600),
                            Editar = true,
                            Excluir = true,
                            MenuID = 5,
                            SubmenuID = 1,
                            TipoUsuarioID = 1
                        },
                        new
                        {
                            PermissaoID = 6,
                            Cadastrar = true,
                            Consultar = true,
                            DataHoraAlteracao = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataHoraCadastro = new DateTime(2022, 11, 27, 1, 49, 59, 219, DateTimeKind.Local).AddTicks(602),
                            Editar = true,
                            Excluir = true,
                            MenuID = 6,
                            SubmenuID = 1,
                            TipoUsuarioID = 1
                        },
                        new
                        {
                            PermissaoID = 7,
                            Cadastrar = true,
                            Consultar = true,
                            DataHoraAlteracao = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataHoraCadastro = new DateTime(2022, 11, 27, 1, 49, 59, 219, DateTimeKind.Local).AddTicks(603),
                            Editar = true,
                            Excluir = true,
                            MenuID = 7,
                            SubmenuID = 1,
                            TipoUsuarioID = 1
                        },
                        new
                        {
                            PermissaoID = 8,
                            Cadastrar = true,
                            Consultar = true,
                            DataHoraAlteracao = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataHoraCadastro = new DateTime(2022, 11, 27, 1, 49, 59, 219, DateTimeKind.Local).AddTicks(604),
                            Editar = true,
                            Excluir = false,
                            MenuID = 7,
                            SubmenuID = 1,
                            TipoUsuarioID = 2
                        },
                        new
                        {
                            PermissaoID = 9,
                            Cadastrar = true,
                            Consultar = true,
                            DataHoraAlteracao = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataHoraCadastro = new DateTime(2022, 11, 27, 1, 49, 59, 219, DateTimeKind.Local).AddTicks(605),
                            Editar = true,
                            Excluir = false,
                            MenuID = 7,
                            SubmenuID = 1,
                            TipoUsuarioID = 3
                        });
                });

            modelBuilder.Entity("SISOC.Business.Models.Setor", b =>
                {
                    b.Property<int>("SetorID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SetorID"), 1L, 1);

                    b.Property<DateTime>("DataHoraAlteracao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataHoraCadastro")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Sigla")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("SetorID");

                    b.ToTable("Setor");

                    b.HasData(
                        new
                        {
                            SetorID = 1,
                            DataHoraAlteracao = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataHoraCadastro = new DateTime(2022, 11, 27, 1, 49, 59, 219, DateTimeKind.Local).AddTicks(416),
                            Nome = "Conselho Superior",
                            Sigla = "COSUP"
                        },
                        new
                        {
                            SetorID = 2,
                            DataHoraAlteracao = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataHoraCadastro = new DateTime(2022, 11, 27, 1, 49, 59, 219, DateTimeKind.Local).AddTicks(423),
                            Nome = "Reitoria",
                            Sigla = "RTRIA"
                        },
                        new
                        {
                            SetorID = 3,
                            DataHoraAlteracao = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataHoraCadastro = new DateTime(2022, 11, 27, 1, 49, 59, 219, DateTimeKind.Local).AddTicks(424),
                            Nome = "Diretoria de Ensino",
                            Sigla = "DIREN"
                        });
                });

            modelBuilder.Entity("SISOC.Business.Models.Submenu", b =>
                {
                    b.Property<int>("SubmenuID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SubmenuID"), 1L, 1);

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit");

                    b.Property<DateTime>("DataHoraAlteracao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataHoraCadastro")
                        .HasColumnType("datetime2");

                    b.Property<int>("MenuID")
                        .HasColumnType("int");

                    b.Property<string>("NavegarURL")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("Ordem")
                        .HasColumnType("int");

                    b.HasKey("SubmenuID");

                    b.HasIndex("MenuID");

                    b.ToTable("Submenu");

                    b.HasData(
                        new
                        {
                            SubmenuID = 1,
                            Ativo = true,
                            DataHoraAlteracao = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataHoraCadastro = new DateTime(2022, 11, 27, 1, 49, 59, 219, DateTimeKind.Local).AddTicks(578),
                            MenuID = 7,
                            NavegarURL = "cadastrar",
                            Nome = "Cadastrar",
                            Ordem = 1
                        },
                        new
                        {
                            SubmenuID = 2,
                            Ativo = true,
                            DataHoraAlteracao = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataHoraCadastro = new DateTime(2022, 11, 27, 1, 49, 59, 219, DateTimeKind.Local).AddTicks(580),
                            MenuID = 7,
                            NavegarURL = "consultar",
                            Nome = "Consultar",
                            Ordem = 2
                        });
                });

            modelBuilder.Entity("SISOC.Business.Models.TipoOcorrencia", b =>
                {
                    b.Property<int>("TipoOcorrenciaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TipoOcorrenciaID"), 1L, 1);

                    b.Property<DateTime>("DataHoraAlteracao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataHoraCadastro")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("TipoOcorrenciaID");

                    b.ToTable("TipoOcorrencia");

                    b.HasData(
                        new
                        {
                            TipoOcorrenciaID = 1,
                            DataHoraAlteracao = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataHoraCadastro = new DateTime(2022, 11, 27, 1, 49, 59, 219, DateTimeKind.Local).AddTicks(534),
                            Descricao = "Incidentes com Alunos",
                            Nome = "Aluno"
                        },
                        new
                        {
                            TipoOcorrenciaID = 2,
                            DataHoraAlteracao = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataHoraCadastro = new DateTime(2022, 11, 27, 1, 49, 59, 219, DateTimeKind.Local).AddTicks(535),
                            Descricao = "Incidentes com o Câmpus",
                            Nome = "Campus"
                        },
                        new
                        {
                            TipoOcorrenciaID = 3,
                            DataHoraAlteracao = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataHoraCadastro = new DateTime(2022, 11, 27, 1, 49, 59, 219, DateTimeKind.Local).AddTicks(536),
                            Descricao = "Incidentes dentro da Sala de Aula",
                            Nome = "Sala de Aula"
                        },
                        new
                        {
                            TipoOcorrenciaID = 4,
                            DataHoraAlteracao = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataHoraCadastro = new DateTime(2022, 11, 27, 1, 49, 59, 219, DateTimeKind.Local).AddTicks(536),
                            Descricao = "Incidentes com Docente",
                            Nome = "Docente"
                        });
                });

            modelBuilder.Entity("SISOC.Business.Models.TipoUsuario", b =>
                {
                    b.Property<int>("TipoUsuarioID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TipoUsuarioID"), 1L, 1);

                    b.Property<DateTime>("DataHoraAlteracao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataHoraCadastro")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("TipoUsuarioID");

                    b.ToTable("TipoUsuario");

                    b.HasData(
                        new
                        {
                            TipoUsuarioID = 1,
                            DataHoraAlteracao = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataHoraCadastro = new DateTime(2022, 11, 27, 1, 49, 59, 219, DateTimeKind.Local).AddTicks(514),
                            Descricao = "Usuário Admnistrador",
                            Nome = "ADMIN"
                        },
                        new
                        {
                            TipoUsuarioID = 2,
                            DataHoraAlteracao = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataHoraCadastro = new DateTime(2022, 11, 27, 1, 49, 59, 219, DateTimeKind.Local).AddTicks(515),
                            Descricao = "Usuário Estudante",
                            Nome = "ESTUDANTE"
                        },
                        new
                        {
                            TipoUsuarioID = 3,
                            DataHoraAlteracao = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataHoraCadastro = new DateTime(2022, 11, 27, 1, 49, 59, 219, DateTimeKind.Local).AddTicks(516),
                            Descricao = "Usuário Docente",
                            Nome = "DOCENTE"
                        });
                });

            modelBuilder.Entity("SISOC.Business.Models.Usuario", b =>
                {
                    b.Property<int>("UsuarioID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UsuarioID"), 1L, 1);

                    b.Property<DateTime>("DataHoraAlteracao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataHoraCadastro")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("RA_SIAPE")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("nvarchar(500)");

                    b.Property<int?>("SetorID")
                        .HasColumnType("int");

                    b.Property<int?>("TipoUsuarioID")
                        .IsRequired()
                        .HasColumnType("int");

                    b.HasKey("UsuarioID");

                    b.HasIndex("SetorID");

                    b.HasIndex("TipoUsuarioID");

                    b.ToTable("Usuario");

                    b.HasData(
                        new
                        {
                            UsuarioID = 1,
                            DataHoraAlteracao = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataHoraCadastro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "admin@email.com",
                            Nome = "ADMIN",
                            RA_SIAPE = "123",
                            Senha = "AGqgZvugXqsrWMXkq9m3JnPICeWo2NI/gQQAR53oGET93t2s9V4ZsyP34HH+6FWi0w==",
                            SetorID = 1,
                            TipoUsuarioID = 1
                        });
                });

            modelBuilder.Entity("SISOC.Business.Models.Anexo", b =>
                {
                    b.HasOne("SISOC.Business.Models.InteracaoOcorrencia", "InteracaoOcorrenciaNavigation")
                        .WithMany("Anexos")
                        .HasForeignKey("InteracaoOcorrenciaID")
                        .IsRequired();

                    b.HasOne("SISOC.Business.Models.Ocorrencia", "OcorrenciaNavigation")
                        .WithMany("Anexos")
                        .HasForeignKey("OcorrenciaID")
                        .IsRequired();

                    b.Navigation("InteracaoOcorrenciaNavigation");

                    b.Navigation("OcorrenciaNavigation");
                });

            modelBuilder.Entity("SISOC.Business.Models.InteracaoOcorrencia", b =>
                {
                    b.HasOne("SISOC.Business.Models.Ocorrencia", "OcorrenciaNavigation")
                        .WithMany("InteracaoOcorrencias")
                        .HasForeignKey("OcorrenciaID")
                        .IsRequired();

                    b.HasOne("SISOC.Business.Models.Usuario", "UsuarioNavigation")
                        .WithMany("InteracaoOcorrencias")
                        .HasForeignKey("UsuarioID")
                        .IsRequired();

                    b.Navigation("OcorrenciaNavigation");

                    b.Navigation("UsuarioNavigation");
                });

            modelBuilder.Entity("SISOC.Business.Models.Ocorrencia", b =>
                {
                    b.HasOne("SISOC.Business.Models.Setor", "SetorNavigation")
                        .WithMany("Ocorrencias")
                        .HasForeignKey("SetorID")
                        .IsRequired();

                    b.HasOne("SISOC.Business.Models.TipoOcorrencia", "TipoOcorrenciaNavigation")
                        .WithMany("Ocorrencias")
                        .HasForeignKey("TipoOcorrenciaID")
                        .IsRequired();

                    b.HasOne("SISOC.Business.Models.Usuario", "UsuarioAtribuidoNavigation")
                        .WithMany("OcorrenciasAtribuido")
                        .HasForeignKey("UsuarioAtribuidoID");

                    b.HasOne("SISOC.Business.Models.Usuario", "UsuarioCadastroNavigation")
                        .WithMany("OcorrenciasCadastro")
                        .HasForeignKey("UsuarioCadastroID")
                        .IsRequired();

                    b.Navigation("SetorNavigation");

                    b.Navigation("TipoOcorrenciaNavigation");

                    b.Navigation("UsuarioAtribuidoNavigation");

                    b.Navigation("UsuarioCadastroNavigation");
                });

            modelBuilder.Entity("SISOC.Business.Models.Permissao", b =>
                {
                    b.HasOne("SISOC.Business.Models.Menu", "MenuNavigation")
                        .WithMany("Permissoes")
                        .HasForeignKey("MenuID")
                        .IsRequired();

                    b.HasOne("SISOC.Business.Models.Submenu", "SubmenuNavigation")
                        .WithMany("Permissoes")
                        .HasForeignKey("SubmenuID")
                        .IsRequired();

                    b.HasOne("SISOC.Business.Models.TipoUsuario", "TipoUsuarioNavigation")
                        .WithMany("Permissaos")
                        .HasForeignKey("TipoUsuarioID")
                        .IsRequired();

                    b.Navigation("MenuNavigation");

                    b.Navigation("SubmenuNavigation");

                    b.Navigation("TipoUsuarioNavigation");
                });

            modelBuilder.Entity("SISOC.Business.Models.Submenu", b =>
                {
                    b.HasOne("SISOC.Business.Models.Menu", "MenuNavigation")
                        .WithMany("Submenus")
                        .HasForeignKey("MenuID")
                        .IsRequired();

                    b.Navigation("MenuNavigation");
                });

            modelBuilder.Entity("SISOC.Business.Models.Usuario", b =>
                {
                    b.HasOne("SISOC.Business.Models.Setor", "SetorNavigation")
                        .WithMany("Usuarios")
                        .HasForeignKey("SetorID");

                    b.HasOne("SISOC.Business.Models.TipoUsuario", "TipoUsuarioNavigation")
                        .WithMany("Usuarios")
                        .HasForeignKey("TipoUsuarioID")
                        .IsRequired();

                    b.Navigation("SetorNavigation");

                    b.Navigation("TipoUsuarioNavigation");
                });

            modelBuilder.Entity("SISOC.Business.Models.InteracaoOcorrencia", b =>
                {
                    b.Navigation("Anexos");
                });

            modelBuilder.Entity("SISOC.Business.Models.Menu", b =>
                {
                    b.Navigation("Permissoes");

                    b.Navigation("Submenus");
                });

            modelBuilder.Entity("SISOC.Business.Models.Ocorrencia", b =>
                {
                    b.Navigation("Anexos");

                    b.Navigation("InteracaoOcorrencias");
                });

            modelBuilder.Entity("SISOC.Business.Models.Setor", b =>
                {
                    b.Navigation("Ocorrencias");

                    b.Navigation("Usuarios");
                });

            modelBuilder.Entity("SISOC.Business.Models.Submenu", b =>
                {
                    b.Navigation("Permissoes");
                });

            modelBuilder.Entity("SISOC.Business.Models.TipoOcorrencia", b =>
                {
                    b.Navigation("Ocorrencias");
                });

            modelBuilder.Entity("SISOC.Business.Models.TipoUsuario", b =>
                {
                    b.Navigation("Permissaos");

                    b.Navigation("Usuarios");
                });

            modelBuilder.Entity("SISOC.Business.Models.Usuario", b =>
                {
                    b.Navigation("InteracaoOcorrencias");

                    b.Navigation("OcorrenciasAtribuido");

                    b.Navigation("OcorrenciasCadastro");
                });
#pragma warning restore 612, 618
        }
    }
}
