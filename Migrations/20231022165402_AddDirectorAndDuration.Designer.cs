﻿// <auto-generated />
using IRDb.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace IRDb.Migrations
{
    [DbContext(typeof(MovieDbContext))]
    [Migration("20231022165402_AddDirectorAndDuration")]
    partial class AddDirectorAndDuration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("IRDb.Models.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Duration")
                        .HasColumnType("int");

                    b.Property<string>("Genre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Rating")
                        .HasColumnType("decimal(3, 1)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Director = "Lilly Wachowski, Lana Wachowski",
                            Duration = 136,
                            Genre = "Action, Sci-Fi",
                            Rating = 7.8m,
                            Title = "Matrix",
                            Year = 1999
                        },
                        new
                        {
                            Id = 2,
                            Director = "Jonathan Demme",
                            Duration = 118,
                            Genre = "Crime, Drama, Thriller",
                            Rating = 8.6m,
                            Title = "The Silence of the Lambs",
                            Year = 1991
                        },
                        new
                        {
                            Id = 3,
                            Director = "Milos Forman",
                            Duration = 133,
                            Genre = "Drama",
                            Rating = 8.7m,
                            Title = "One Flew Over the Cuckoo's Nest",
                            Year = 1975
                        },
                        new
                        {
                            Id = 4,
                            Director = "Quentin Tarantino",
                            Duration = 154,
                            Genre = "Crime, Drama",
                            Rating = 8.9m,
                            Title = "Pulp Fiction",
                            Year = 1994
                        },
                        new
                        {
                            Id = 5,
                            Director = "William Friedkin",
                            Duration = 122,
                            Genre = "Horror",
                            Rating = 8.1m,
                            Title = "Exorcisten",
                            Year = 1973
                        },
                        new
                        {
                            Id = 6,
                            Director = "Frank Darabont",
                            Duration = 142,
                            Genre = "Drama",
                            Rating = 9.3m,
                            Title = "The Shawshank Redemption",
                            Year = 1994
                        },
                        new
                        {
                            Id = 7,
                            Director = "Christopher Nolan",
                            Duration = 169,
                            Genre = "Action, Drama, Sci-Fi",
                            Rating = 8.7m,
                            Title = "Interstellar",
                            Year = 2014
                        },
                        new
                        {
                            Id = 8,
                            Director = "Peter Jackson",
                            Duration = 178,
                            Genre = "Action, Adventure, Drama",
                            Rating = 8.8m,
                            Title = "The Lord of the Rings: The Fellowship of the Ring",
                            Year = 2001
                        },
                        new
                        {
                            Id = 9,
                            Director = "Robert Zemeckis",
                            Duration = 142,
                            Genre = "Drama, Romance",
                            Rating = 8.8m,
                            Title = "Forrest Gump",
                            Year = 1994
                        },
                        new
                        {
                            Id = 10,
                            Director = "Christopher Nolan",
                            Duration = 148,
                            Genre = "Action, Adventure, Sci-Fi",
                            Rating = 8.8m,
                            Title = "Inception",
                            Year = 2010
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
