﻿// <auto-generated />
using LongDrive.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LongDrive.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230920174005_addedTellimus")]
    partial class addedTellimus
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("LongDrive.Models.Soiduauto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Mark")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Mass")
                        .HasColumnType("int");

                    b.Property<double>("Pikkus")
                        .HasColumnType("float");

                    b.Property<int>("Tee")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Soiduautod");
                });

            modelBuilder.Entity("LongDrive.Models.Tellimus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Kirjeldus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nimi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Vahemaa")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Tellimused");
                });

            modelBuilder.Entity("LongDrive.Models.Veoauto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Mark")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Mass")
                        .HasColumnType("int");

                    b.Property<double>("Pikkus")
                        .HasColumnType("float");

                    b.Property<int>("Tee")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Veoautod");
                });
#pragma warning restore 612, 618
        }
    }
}
