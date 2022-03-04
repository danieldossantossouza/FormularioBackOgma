﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using QuetionarioData.Context;

namespace QuetionarioData.Migrations
{
    [DbContext(typeof(MeuDbContext))]
    partial class MeuDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.14")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("QuestionarioBisiness.Models.Formulario", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataExclucao")
                        .HasColumnType("datetime2");

                    b.Property<string>("Pergunta")
                        .IsRequired()
                        .HasColumnType("varchar(5000)");

                    b.Property<string>("Resposta")
                        .IsRequired()
                        .HasColumnType("varchar(5000)");

                    b.Property<int>("TipoFormulario")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Formularios");
                });
#pragma warning restore 612, 618
        }
    }
}
