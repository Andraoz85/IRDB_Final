using Microsoft.EntityFrameworkCore;

namespace IRDb.Database
{
    public class MovieDbContext : DbContext
    {
        public MovieDbContext(DbContextOptions<MovieDbContext> options) : base(options)
        {

        }

        public DbSet<Movie> Movies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed data
            modelBuilder.Entity<Movie>().HasData(new Movie()
            {
                Id = 1,
                Title = "Matrix",
                Year = 1999,
                Genre = "Action, Sci-Fi",
                Rating = Math.Round(7.8, 1),
                Director = "Lilly Wachowski, Lana Wachowski",
                Duration = 136
            },
            new Movie
            {
                Id = 2,
                Title = "The Silence of the Lambs",
                Year = 1991,
                Genre = "Crime, Drama, Thriller",
                Rating = Math.Round(8.6, 1),
                Director = "Jonathan Demme",
                Duration = 118
            },
            new Movie
            {
                Id = 3,
                Title = "One Flew Over the Cuckoo's Nest",
                Year = 1975,
                Genre = "Drama",
                Rating = Math.Round(8.7, 1),
                Director = "Milos Forman",
                Duration = 133
            },
            new Movie
            {
                Id = 4,
                Title = "Pulp Fiction",
                Year = 1994,
                Genre = "Crime, Drama",
                Rating = Math.Round(8.9, 1),
                Director = "Quentin Tarantino",
                Duration = 154
            },
            new Movie
            {
                Id = 5,
                Title = "Exorcisten",
                Year = 1973,
                Genre = "Horror",
                Rating = Math.Round(8.1, 1),
                Director = "William Friedkin",
                Duration = 122
            },
            new Movie
            {
                Id = 6,
                Title = "The Shawshank Redemption",
                Year = 1994,
                Genre = "Drama",
                Rating = Math.Round(9.3, 1),
                Director = "Frank Darabont",
                Duration = 142
            },
            new Movie
            {
                Id = 7,
                Title = "Interstellar",
                Year = 2014,
                Genre = "Action, Drama, Sci-Fi",
                Rating = Math.Round(8.7, 1),
                Director = "Christopher Nolan",
                Duration = 169
            },
            new Movie
            {
                Id = 8,
                Title = "The Lord of the Rings: The Fellowship of the Ring",
                Year = 2001,
                Genre = "Action, Adventure, Drama",
                Rating = Math.Round(8.8, 1),
                Director = "Peter Jackson",
                Duration = 178
            },
            new Movie
            {
                Id = 9,
                Title = "Forrest Gump",
                Year = 1994,
                Genre = "Drama, Romance",
                Rating = Math.Round(8.8, 1),
                Director = "Robert Zemeckis",
                Duration = 142
            },
            new Movie
            {
                Id = 10,
                Title = "Inception",
                Year = 2010,
                Genre = "Action, Adventure, Sci-Fi",
                Rating = Math.Round(8.8, 1),
                Director = "Christopher Nolan",
                Duration = 148
            });
        }
    }
}