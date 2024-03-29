﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TetaCritic.Models;

namespace TetaCritic.Migrations
{
    [DbContext(typeof(TetaCriticContext))]
    [Migration("20211219230540_FilmAdiEklendi")]
    partial class FilmAdiEklendi
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TetaCritic.Models.Film", b =>
                {
                    b.Property<int>("FilmId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FilmAdi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("KategoriId")
                        .HasColumnType("int");

                    b.Property<string>("Ozet")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VizyonTarihi")
                        .HasColumnType("int");

                    b.Property<string>("Yonetmen")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FilmId");

                    b.HasIndex("KategoriId");

                    b.ToTable("Filmler");
                });

            modelBuilder.Entity("TetaCritic.Models.Kategori", b =>
                {
                    b.Property<int>("KategoriId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("KategoriAdi")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("KategoriId");

                    b.ToTable("Kategoriler");
                });

            modelBuilder.Entity("TetaCritic.Models.Film", b =>
                {
                    b.HasOne("TetaCritic.Models.Kategori", "Ktg")
                        .WithMany()
                        .HasForeignKey("KategoriId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ktg");
                });
#pragma warning restore 612, 618
        }
    }
}
