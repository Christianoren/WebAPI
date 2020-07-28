﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebAPI.Models;

namespace WebAPI.Migrations
{
    [DbContext(typeof(CurriculumDBcontext))]
    [Migration("20200727122243_fckin")]
    partial class fckin
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebAPI.Models.Adresse", b =>
                {
                    b.Property<int>("AdresseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("gateadresse")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("husnummer")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("postnummer")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("sted")
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("AdresseId");

                    b.ToTable("Adresse");
                });

            modelBuilder.Entity("WebAPI.Models.CCandidate", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AdresseId")
                        .HasColumnType("int");

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("fullName")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("mobilenumber")
                        .HasColumnType("nvarchar(16)");

                    b.Property<string>("stilling")
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("id");

                    b.HasIndex("AdresseId");

                    b.ToTable("CCandidates");
                });

            modelBuilder.Entity("WebAPI.Models.CCandidate", b =>
                {
                    b.HasOne("WebAPI.Models.Adresse", "Adresse")
                        .WithMany("CCandidates")
                        .HasForeignKey("AdresseId");
                });
#pragma warning restore 612, 618
        }
    }
}
