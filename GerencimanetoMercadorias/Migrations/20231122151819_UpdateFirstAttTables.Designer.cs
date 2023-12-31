﻿// <auto-generated />
using System;
using GerencimanetoMercadorias.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GerencimanetoMercadorias.Migrations
{
    [DbContext(typeof(MercadoriaContext))]
    [Migration("20231122151819_UpdateFirstAttTables")]
    partial class UpdateFirstAttTables
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("GerencimanetoMercadorias.Models.Categorias", b =>
                {
                    b.Property<int>("CategoriasId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoriasId"));

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("CategoriasId");

                    b.ToTable("Categorias");
                });

            modelBuilder.Entity("GerencimanetoMercadorias.Models.Produtos", b =>
                {
                    b.Property<int>("ProdutosId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProdutosId"));

                    b.Property<int>("CategoriaId")
                        .HasColumnType("int");

                    b.Property<int>("CategoriasId")
                        .HasColumnType("int");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<int>("Estoque")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal>("Preco")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("UltimaAlteracao")
                        .HasColumnType("datetime2");

                    b.HasKey("ProdutosId");

                    b.HasIndex("CategoriasId");

                    b.ToTable("Produtos");
                });

            modelBuilder.Entity("GerencimanetoMercadorias.Models.Produtos", b =>
                {
                    b.HasOne("GerencimanetoMercadorias.Models.Categorias", "Categorias")
                        .WithMany("Produtos")
                        .HasForeignKey("CategoriasId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categorias");
                });

            modelBuilder.Entity("GerencimanetoMercadorias.Models.Categorias", b =>
                {
                    b.Navigation("Produtos");
                });
#pragma warning restore 612, 618
        }
    }
}
