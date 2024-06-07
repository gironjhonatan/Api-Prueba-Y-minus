﻿// <auto-generated />
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using WebAPIPrueba.Data;

#nullable disable

namespace WebAPIPrueba.Migrations
{
    [DbContext(typeof(ProductoDb))]
    partial class ProductoDbModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("WebAPIPrueba.Models.Producto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Codigo")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("FechaDeCreacion")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Imagen")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<List<int>>("ListaDePrecios")
                        .IsRequired()
                        .HasColumnType("integer[]");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<decimal>("PorcentajeIva")
                        .HasColumnType("numeric");

                    b.Property<bool>("ProductoParaLaVenta")
                        .HasColumnType("boolean");

                    b.HasKey("Id");

                    b.ToTable("Productos");
                });
#pragma warning restore 612, 618
        }
    }
}
