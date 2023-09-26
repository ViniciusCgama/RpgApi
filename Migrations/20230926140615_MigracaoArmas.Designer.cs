﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RpgApi.Data;

#nullable disable

namespace RpgApi.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230926140615_MigracaoArmas")]
    partial class MigracaoArmas
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("RpgApi.Models.Armas", b =>
                {
                    b.Property<int>("IdF")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdF"));

                    b.Property<int>("DanoF")
                        .HasColumnType("int");

                    b.Property<string>("NomeF")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdF");

                    b.ToTable("TB_ARMAS", (string)null);

                    b.HasData(
                        new
                        {
                            IdF = 1,
                            DanoF = 50,
                            NomeF = "Espada de cria demoniaca"
                        },
                        new
                        {
                            IdF = 2,
                            DanoF = 45,
                            NomeF = "Faca envenenada"
                        },
                        new
                        {
                            IdF = 3,
                            DanoF = 75,
                            NomeF = "Arco da fenda do vazio"
                        },
                        new
                        {
                            IdF = 4,
                            DanoF = 69,
                            NomeF = "Machado do Cleyton"
                        },
                        new
                        {
                            IdF = 5,
                            DanoF = 35,
                            NomeF = "Chicote do Desejo"
                        },
                        new
                        {
                            IdF = 6,
                            DanoF = 42,
                            NomeF = "Baseball BAT"
                        },
                        new
                        {
                            IdF = 7,
                            DanoF = 50,
                            NomeF = "Manopla do grande roxo"
                        });
                });

            modelBuilder.Entity("RpgApi.Models.Personagem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Classe")
                        .HasColumnType("int");

                    b.Property<int>("Defesa")
                        .HasColumnType("int");

                    b.Property<int>("Forca")
                        .HasColumnType("int");

                    b.Property<int>("Inteligencia")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PontosVida")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("TB_PERSONAGENS");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Classe = 1,
                            Defesa = 23,
                            Forca = 17,
                            Inteligencia = 33,
                            Nome = "Frodo",
                            PontosVida = 100
                        },
                        new
                        {
                            Id = 2,
                            Classe = 1,
                            Defesa = 25,
                            Forca = 15,
                            Inteligencia = 30,
                            Nome = "Sam",
                            PontosVida = 100
                        },
                        new
                        {
                            Id = 3,
                            Classe = 3,
                            Defesa = 21,
                            Forca = 18,
                            Inteligencia = 35,
                            Nome = "Galadriel",
                            PontosVida = 100
                        },
                        new
                        {
                            Id = 4,
                            Classe = 2,
                            Defesa = 18,
                            Forca = 18,
                            Inteligencia = 37,
                            Nome = "Gandalf",
                            PontosVida = 110
                        },
                        new
                        {
                            Id = 5,
                            Classe = 1,
                            Defesa = 17,
                            Forca = 20,
                            Inteligencia = 31,
                            Nome = "Hobbit",
                            PontosVida = 110
                        },
                        new
                        {
                            Id = 6,
                            Classe = 3,
                            Defesa = 13,
                            Forca = 21,
                            Inteligencia = 34,
                            Nome = "Celeborn",
                            PontosVida = 100
                        },
                        new
                        {
                            Id = 7,
                            Classe = 2,
                            Defesa = 11,
                            Forca = 25,
                            Inteligencia = 35,
                            Nome = "Radagast",
                            PontosVida = 100
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
