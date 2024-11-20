﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Questor.Infra.Context;

#nullable disable

namespace Questor.Infra.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20241120190524_UpdateJuros")]
    partial class UpdateJuros
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.36")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Questor.Domain.Entities.Banco", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Codigo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("codigo");

                    b.Property<double>("Juros")
                        .HasColumnType("float")
                        .HasColumnName("juros");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("nome");

                    b.HasKey("Id");

                    b.ToTable("tb_banco", (string)null);
                });

            modelBuilder.Entity("Questor.Domain.Entities.Boleto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("BancoId")
                        .HasColumnType("int");

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("cpf");

                    b.Property<string>("CPFBeneficiario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("cpf_beneficiario");

                    b.Property<DateTime>("DataVencimento")
                        .HasColumnType("datetime2")
                        .HasColumnName("vencimento");

                    b.Property<int>("IdBanco")
                        .HasColumnType("int")
                        .HasColumnName("id_banco");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("nome");

                    b.Property<string>("NomeBeneficiario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("nome_beneficiario");

                    b.Property<double>("Valor")
                        .HasColumnType("float")
                        .HasColumnName("valor");

                    b.HasKey("Id");

                    b.HasIndex("BancoId");

                    b.ToTable("tb_boleto", (string)null);
                });

            modelBuilder.Entity("Questor.Domain.Entities.Boleto", b =>
                {
                    b.HasOne("Questor.Domain.Entities.Banco", "Banco")
                        .WithMany()
                        .HasForeignKey("BancoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Banco");
                });
#pragma warning restore 612, 618
        }
    }
}
