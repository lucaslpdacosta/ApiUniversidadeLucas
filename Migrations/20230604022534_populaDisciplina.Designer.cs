﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using apiUniversidade.Context;

#nullable disable

namespace apiUniversidade.Migrations
{
    [DbContext(typeof(ApiUniversidadeContext))]
    [Migration("20230604022534_populaDisciplina")]
    partial class populaDisciplina
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("apiUniversidade.Model.Aluno", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Cpf")
                        .HasColumnType("text")
                        .HasColumnName("cpf");

                    b.Property<int>("CursoId")
                        .HasColumnType("integer")
                        .HasColumnName("cursoid");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("datanascimento");

                    b.Property<string>("Nome")
                        .HasColumnType("text")
                        .HasColumnName("nome");

                    b.HasKey("Id");

                    b.HasIndex("CursoId");

                    b.ToTable("alunos");
                });

            modelBuilder.Entity("apiUniversidade.Model.Curso", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Area")
                        .HasColumnType("text")
                        .HasColumnName("area");

                    b.Property<int>("Duracao")
                        .HasColumnType("integer")
                        .HasColumnName("duracao");

                    b.Property<string>("Nome")
                        .HasColumnType("text")
                        .HasColumnName("nome");

                    b.HasKey("Id");

                    b.ToTable("cursos");
                });

            modelBuilder.Entity("apiUniversidade.Model.Disciplina", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("CargaHoraria")
                        .HasColumnType("integer")
                        .HasColumnName("cargahoraria");

                    b.Property<int>("CursoId")
                        .HasColumnType("integer")
                        .HasColumnName("cursoid");

                    b.Property<string>("Nome")
                        .HasColumnType("text")
                        .HasColumnName("nome");

                    b.Property<int>("Semestre")
                        .HasColumnType("integer")
                        .HasColumnName("semestre");

                    b.HasKey("Id");

                    b.HasIndex("CursoId");

                    b.ToTable("disciplinas");
                });

            modelBuilder.Entity("apiUniversidade.Model.Aluno", b =>
                {
                    b.HasOne("apiUniversidade.Model.Curso", null)
                        .WithMany("Alunos")
                        .HasForeignKey("CursoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("apiUniversidade.Model.Disciplina", b =>
                {
                    b.HasOne("apiUniversidade.Model.Curso", null)
                        .WithMany("Disciplinas")
                        .HasForeignKey("CursoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("apiUniversidade.Model.Curso", b =>
                {
                    b.Navigation("Alunos");

                    b.Navigation("Disciplinas");
                });
#pragma warning restore 612, 618
        }
    }
}
