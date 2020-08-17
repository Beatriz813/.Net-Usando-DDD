﻿// <auto-generated />
using System;
using Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Application.Migrations
{
    [DbContext(typeof(PetshopContext))]
    partial class PetshopContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("PetshopDB")
                .HasAnnotation("ProductVersion", "3.1.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Domain.Model.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnName("DataNascimento")
                        .HasColumnType("datetime");

                    b.Property<int>("LojaId")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnName("Nome")
                        .HasColumnType("varchar(60)")
                        .HasMaxLength(60);

                    b.Property<char>("Sexo")
                        .HasColumnType("int");

                    b.HasKey("Id")
                        .HasName("Id");

                    b.HasIndex("LojaId");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("Domain.Model.Loja", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id")
                        .HasColumnType("int");

                    b.Property<string>("Descricao")
                        .HasColumnName("Descricao")
                        .HasColumnType("varchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnName("Nome")
                        .HasColumnType("varchar(80)")
                        .HasMaxLength(80);

                    b.HasKey("Id")
                        .HasName("Id");

                    b.ToTable("Loja");
                });

            modelBuilder.Entity("Domain.Model.Pet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id")
                        .HasColumnType("int");

                    b.Property<int>("ClienteId")
                        .HasColumnType("int");

                    b.Property<string>("Especie")
                        .IsRequired()
                        .HasColumnName("Especie")
                        .HasColumnType("varchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnName("Nome")
                        .HasColumnType("varchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("Raca")
                        .IsRequired()
                        .HasColumnName("Raca")
                        .HasColumnType("varchar(20)")
                        .HasMaxLength(20);

                    b.HasKey("Id")
                        .HasName("Id");

                    b.HasIndex("ClienteId");

                    b.ToTable("Pet");
                });

            modelBuilder.Entity("Domain.Model.Cliente", b =>
                {
                    b.HasOne("Domain.Model.Loja", "loja")
                        .WithMany("Clientes")
                        .HasForeignKey("LojaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Model.Pet", b =>
                {
                    b.HasOne("Domain.Model.Cliente", "Cliente")
                        .WithMany("Pets")
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
