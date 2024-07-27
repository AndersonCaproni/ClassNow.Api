﻿// <auto-generated />
using ClassNow.Api.Repositorio.Contexto;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ClassNow.Api.Repositorio.Migrations
{
    [DbContext(typeof(ClassNowContexto))]
    partial class ClassNowContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ClassNow.Api.Dominio.Entidades.Aluno", b =>
                {
                    b.Property<int>("AlunoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("AlunoID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AlunoID"));

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit")
                        .HasColumnName("Ativo");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)")
                        .HasColumnName("Email");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("Nome");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)")
                        .HasColumnName("Senha");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)")
                        .HasColumnName("Telefone");

                    b.HasKey("AlunoID");

                    b.ToTable("Aluno", (string)null);
                });

            modelBuilder.Entity("ClassNow.Api.Dominio.Entidades.Aula", b =>
                {
                    b.Property<int>("AulaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("AulaID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AulaID"));

                    b.Property<int>("AlunoID")
                        .HasColumnType("int")
                        .HasColumnName("AlunoID");

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit")
                        .HasColumnName("Ativo");

                    b.Property<int>("CursoID")
                        .HasColumnType("int")
                        .HasColumnName("CursoID");

                    b.HasKey("AulaID");

                    b.HasIndex("AlunoID");

                    b.HasIndex("CursoID");

                    b.ToTable("Aula", (string)null);
                });

            modelBuilder.Entity("ClassNow.Api.Dominio.Entidades.Curso", b =>
                {
                    b.Property<int>("CursoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("CursoID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CursoID"));

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit")
                        .HasColumnName("Ativo");

                    b.Property<string>("Categoria")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Categoria");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(400)
                        .HasColumnType("nvarchar(400)")
                        .HasColumnName("Descricao");

                    b.Property<int>("ProfessorID")
                        .HasColumnType("int")
                        .HasColumnName("ProfessorID");

                    b.Property<decimal>("Valor")
                        .HasColumnType("decimal")
                        .HasColumnName("Valor");

                    b.HasKey("CursoID");

                    b.HasIndex("ProfessorID");

                    b.ToTable("Curso", (string)null);
                });

            modelBuilder.Entity("ClassNow.Api.Dominio.Entidades.Professor", b =>
                {
                    b.Property<int>("ProfessorID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ProfessorID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProfessorID"));

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit")
                        .HasColumnName("Ativo");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)")
                        .HasColumnName("Cidade");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)")
                        .HasColumnName("Email");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)")
                        .HasColumnName("Estado");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("Nome");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)")
                        .HasColumnName("Senha");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)")
                        .HasColumnName("Telefone");

                    b.HasKey("ProfessorID");

                    b.ToTable("Professor", (string)null);
                });

            modelBuilder.Entity("ClassNow.Api.Dominio.Entidades.Aula", b =>
                {
                    b.HasOne("ClassNow.Api.Dominio.Entidades.Aluno", "Aluno")
                        .WithMany("Aulas")
                        .HasForeignKey("AlunoID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("ClassNow.Api.Dominio.Entidades.Curso", "Curso")
                        .WithMany("Aulas")
                        .HasForeignKey("CursoID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Aluno");

                    b.Navigation("Curso");
                });

            modelBuilder.Entity("ClassNow.Api.Dominio.Entidades.Curso", b =>
                {
                    b.HasOne("ClassNow.Api.Dominio.Entidades.Professor", "Professor")
                        .WithMany("Cursos")
                        .HasForeignKey("ProfessorID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Professor");
                });

            modelBuilder.Entity("ClassNow.Api.Dominio.Entidades.Aluno", b =>
                {
                    b.Navigation("Aulas");
                });

            modelBuilder.Entity("ClassNow.Api.Dominio.Entidades.Curso", b =>
                {
                    b.Navigation("Aulas");
                });

            modelBuilder.Entity("ClassNow.Api.Dominio.Entidades.Professor", b =>
                {
                    b.Navigation("Cursos");
                });
#pragma warning restore 612, 618
        }
    }
}