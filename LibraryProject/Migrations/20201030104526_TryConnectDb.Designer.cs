﻿// <auto-generated />
using LibraryProject.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LibraryProject.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20201030104526_TryConnectDb")]
    partial class TryConnectDb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("LibraryProject.Entities.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DebutYear");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int>("Ranking");

                    b.HasKey("Id");

                    b.ToTable("Authors");

                    b.HasData(
                        new { Id = 1, DebutYear = 1990, Name = "Nicholas Sparks", Ranking = 10 },
                        new { Id = 2, DebutYear = 1890, Name = "J.R.R Tolkien", Ranking = 4 },
                        new { Id = 3, DebutYear = 2000, Name = "Delia Owens", Ranking = 7 },
                        new { Id = 4, DebutYear = 2007, Name = "Ryan Holiday", Ranking = 32 },
                        new { Id = 5, DebutYear = 1970, Name = "Charles Duhigg", Ranking = 15 },
                        new { Id = 6, DebutYear = 2006, Name = "Andy Weir", Ranking = 2 }
                    );
                });

            modelBuilder.Entity("LibraryProject.Entities.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AuthorId");

                    b.Property<int>("GenreId");

                    b.Property<string>("Publication")
                        .HasMaxLength(50);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int>("Year")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.HasIndex("GenreId");

                    b.ToTable("Books");

                    b.HasData(
                        new { Id = 1, AuthorId = 1, GenreId = 1, Publication = "Grand Central Publishing", Title = "The Notebook", Year = 2014 },
                        new { Id = 2, AuthorId = 1, GenreId = 1, Publication = "RAO", Title = "The Longest Ride", Year = 2018 },
                        new { Id = 3, AuthorId = 2, GenreId = 3, Publication = "Allen & Unwin ", Title = "The Hobbit", Year = 2012 },
                        new { Id = 4, AuthorId = 3, GenreId = 4, Publication = "Arthur", Title = "Where the Crawdads sing", Year = 2016 },
                        new { Id = 5, AuthorId = 3, GenreId = 4, Publication = "Arthur", Title = "Where the Crawdads sing", Year = 2016 },
                        new { Id = 6, AuthorId = 4, GenreId = 5, Publication = "Nautilus English Books", Title = "Ego is the enemy", Year = 2013 },
                        new { Id = 7, AuthorId = 5, GenreId = 5, Publication = "Wired", Title = "The power of habit", Year = 2015 }
                    );
                });

            modelBuilder.Entity("LibraryProject.Entities.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Genres");

                    b.HasData(
                        new { Id = 1, Name = "Romance" },
                        new { Id = 2, Name = "Adventure" },
                        new { Id = 3, Name = "Fantasy" },
                        new { Id = 4, Name = "Fiction" },
                        new { Id = 5, Name = "Personal Growth" },
                        new { Id = 6, Name = "Science-fiction" }
                    );
                });

            modelBuilder.Entity("LibraryProject.Entities.Book", b =>
                {
                    b.HasOne("LibraryProject.Entities.Author", "Author")
                        .WithMany()
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("LibraryProject.Entities.Genre", "Genre")
                        .WithMany()
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
