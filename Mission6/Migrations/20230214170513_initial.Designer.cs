﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mission6.Models;

namespace Mission6.Migrations
{
    [DbContext(typeof(MovieSubmissionContext))]
    [Migration("20230214170513_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.32");

            modelBuilder.Entity("Mission6.Models.ApplicationResponse", b =>
                {
                    b.Property<int>("MovieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Director")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Edited")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LentTo")
                        .HasColumnType("TEXT");

                    b.Property<string>("Notes")
                        .HasColumnType("TEXT");

                    b.Property<string>("Rating")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.Property<int>("Year")
                        .HasColumnType("INTEGER");

                    b.HasKey("MovieId");

                    b.ToTable("Responses");

                    b.HasData(
                        new
                        {
                            MovieId = 1,
                            Director = "Christopher Nolan",
                            Edited = false,
                            LentTo = "Bill Nye",
                            Notes = "",
                            Rating = "PG-13",
                            Title = "The Dark Knight",
                            Year = 2008
                        },
                        new
                        {
                            MovieId = 2,
                            Director = "Jon Favreau",
                            Edited = true,
                            LentTo = "",
                            Notes = "Super awesome movie",
                            Rating = "PG-13",
                            Title = "Iron Man",
                            Year = 2008
                        },
                        new
                        {
                            MovieId = 3,
                            Director = "Steven Soderbergh",
                            Edited = false,
                            LentTo = "",
                            Notes = "",
                            Rating = "PG-13",
                            Title = "Ocean's Eleven",
                            Year = 2001
                        });
                });
#pragma warning restore 612, 618
        }
    }
}