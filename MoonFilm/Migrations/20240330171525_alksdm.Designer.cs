﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MoonFilm.Models;

#nullable disable

namespace MoonFilm.Migrations
{
    [DbContext(typeof(MoonFilmDbContext))]
    [Migration("20240330171525_alksdm")]
    partial class alksdm
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ActorFilm", b =>
                {
                    b.Property<int>("ActorsActorId")
                        .HasColumnType("int");

                    b.Property<int>("FilmsFilmId")
                        .HasColumnType("int");

                    b.HasKey("ActorsActorId", "FilmsFilmId");

                    b.HasIndex("FilmsFilmId");

                    b.ToTable("ActorFilms", (string)null);
                });

            modelBuilder.Entity("CategoryFilm", b =>
                {
                    b.Property<int>("CategoriesCategoryId")
                        .HasColumnType("int");

                    b.Property<int>("FilmsFilmId")
                        .HasColumnType("int");

                    b.HasKey("CategoriesCategoryId", "FilmsFilmId");

                    b.HasIndex("FilmsFilmId");

                    b.ToTable("CategoryFilms", (string)null);
                });

            modelBuilder.Entity("MoonFilm.Models.Actor", b =>
                {
                    b.Property<int>("ActorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ActorId"));

                    b.Property<string>("ActorDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ActorFullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ActorId");

                    b.HasIndex("CountryId");

                    b.ToTable("Actors");
                });

            modelBuilder.Entity("MoonFilm.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"));

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("MoonFilm.Models.Country", b =>
                {
                    b.Property<int>("CountryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CountryId"));

                    b.Property<string>("CountryImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CountryName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CountryId");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("MoonFilm.Models.Director", b =>
                {
                    b.Property<int>("DirectorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DirectorId"));

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("DirectorDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DirectorFullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DirectorImage")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DirectorId");

                    b.HasIndex("CountryId");

                    b.ToTable("Directors");
                });

            modelBuilder.Entity("MoonFilm.Models.Film", b =>
                {
                    b.Property<int>("FilmId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FilmId"));

                    b.Property<int>("CID")
                        .HasColumnType("int");

                    b.Property<string>("CoverImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DID")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FilmName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("IMDb")
                        .HasColumnType("real");

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(max)");

                    b.Property<short>("Year")
                        .HasColumnType("smallint");

                    b.HasKey("FilmId");

                    b.HasIndex("CID");

                    b.HasIndex("DID");

                    b.ToTable("Films");
                });

            modelBuilder.Entity("ActorFilm", b =>
                {
                    b.HasOne("MoonFilm.Models.Actor", null)
                        .WithMany()
                        .HasForeignKey("ActorsActorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MoonFilm.Models.Film", null)
                        .WithMany()
                        .HasForeignKey("FilmsFilmId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CategoryFilm", b =>
                {
                    b.HasOne("MoonFilm.Models.Category", null)
                        .WithMany()
                        .HasForeignKey("CategoriesCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MoonFilm.Models.Film", null)
                        .WithMany()
                        .HasForeignKey("FilmsFilmId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MoonFilm.Models.Actor", b =>
                {
                    b.HasOne("MoonFilm.Models.Country", "Country")
                        .WithMany("Actors")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("MoonFilm.Models.Director", b =>
                {
                    b.HasOne("MoonFilm.Models.Country", "Country")
                        .WithMany("Directors")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("MoonFilm.Models.Film", b =>
                {
                    b.HasOne("MoonFilm.Models.Country", "Country")
                        .WithMany("Films")
                        .HasForeignKey("CID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("MoonFilm.Models.Director", "Director")
                        .WithMany("Films")
                        .HasForeignKey("DID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Country");

                    b.Navigation("Director");
                });

            modelBuilder.Entity("MoonFilm.Models.Country", b =>
                {
                    b.Navigation("Actors");

                    b.Navigation("Directors");

                    b.Navigation("Films");
                });

            modelBuilder.Entity("MoonFilm.Models.Director", b =>
                {
                    b.Navigation("Films");
                });
#pragma warning restore 612, 618
        }
    }
}
