﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mission4.Models;

namespace Mission4.Migrations
{
    [DbContext(typeof(MovieContext))]
    [Migration("20220126191404_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.22");

            modelBuilder.Entity("Mission4.Models.Movie", b =>
                {
                    b.Property<int>("MovieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Edited")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LentTo")
                        .HasColumnType("TEXT");

                    b.Property<string>("Notes")
                        .HasColumnType("TEXT")
                        .HasMaxLength(25);

                    b.Property<string>("Rating")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Year")
                        .HasColumnType("INTEGER");

                    b.HasKey("MovieId");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            MovieId = 1,
                            Category = "Comedy/Drama",
                            Director = "Nancy Meyers",
                            Edited = false,
                            Rating = "PG13",
                            Title = "The Intern",
                            Year = 2015
                        },
                        new
                        {
                            MovieId = 2,
                            Category = "Fantasy",
                            Director = "David Yates",
                            Edited = false,
                            Rating = "PG13",
                            Title = "Harry Potter and the Deathly Hallows: Part 2",
                            Year = 2011
                        },
                        new
                        {
                            MovieId = 3,
                            Category = "Family/Comedy",
                            Director = "John Pasquin",
                            Edited = false,
                            Rating = "PG",
                            Title = "The Santa Clause",
                            Year = 1994
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
