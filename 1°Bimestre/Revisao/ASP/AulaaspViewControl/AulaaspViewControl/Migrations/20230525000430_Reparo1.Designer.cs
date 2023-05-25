﻿// <auto-generated />
using AulaaspViewControl.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace AulaaspViewControl.Migrations
{
    [DbContext(typeof(AulaaspViewControlContext))]
    [Migration("20230525000430_Reparo1")]
    partial class Reparo1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("AulaaspViewControl.Models.Animal", b =>
                {
                    b.Property<int>("Id_animal")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id_animal"));

                    b.Property<string>("DataNascimento")
                        .HasColumnType("text")
                        .HasColumnName("data_nascimento");

                    b.Property<string>("Especie")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("especie");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("nome");

                    b.HasKey("Id_animal");

                    b.ToTable("Animal");
                });
#pragma warning restore 612, 618
        }
    }
}
