﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VideoGameList.Models;

#nullable disable

namespace VideoGameList.Migrations
{
    [DbContext(typeof(videoGameContext))]
    partial class videoGameContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("VideoGameList.Models.videoGame", b =>
                {
                    b.Property<int>("videoGameId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("videoGameId"));

                    b.Property<string>("favoriteCharacter")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("wouldPlayAgain")
                        .HasColumnType("bit");

                    b.HasKey("videoGameId");

                    b.ToTable("videoGames");

                    b.HasData(
                        new
                        {
                            videoGameId = 1,
                            favoriteCharacter = "alucard",
                            name = "Castlevania Symphony of the Night",
                            wouldPlayAgain = true
                        },
                        new
                        {
                            videoGameId = 2,
                            favoriteCharacter = "Protagonist",
                            name = "Factorio"
                        },
                        new
                        {
                            videoGameId = 3,
                            favoriteCharacter = "Protagonist",
                            name = "satisfactory",
                            wouldPlayAgain = false
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
