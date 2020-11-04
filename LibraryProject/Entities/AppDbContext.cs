using Microsoft.EntityFrameworkCore;

namespace LibraryProject.Entities
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
          //  Database.EnsureCreated();
        }

        public DbSet<Genre> Genres { get; set; }

        public DbSet<Book> Books { get; set; }

        public DbSet<Author> Authors { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Genre>()
                .HasData(
                new Genre()
                {
                    Id = 1,
                    Name = "Romance"
                },
                new Genre()
                {
                    Id = 2,
                    Name = "Adventure"
                },
                new Genre()
                {
                    Id = 3,
                    Name = "Fantasy"
                },
                new Genre()
                {
                    Id = 4,
                    Name = "Fiction"
                },
                new Genre()
                {
                    Id = 5,
                    Name = "Personal Growth"
                },
                new Genre()
                {
                    Id = 6,
                    Name = "Science-fiction"
                }
                );
            modelBuilder.Entity<Author>()
               .HasData(
               new Author()
               {
                   Id = 1,
                   FirstName = "Nicholas",
                   LastName = "Sparks",
                   DebutYear = 1990,
                   Ranking = 10
               },
               new Author()
               {
                   Id = 2,
                   FirstName = "J.R.R",
                   LastName = "Tolkien",
                   DebutYear = 1890,
                   Ranking = 4
               },
               new Author()
               {
                   Id = 3,
                   FirstName = "Delia",
                   LastName = "Owens",
                   DebutYear = 2000,
                   Ranking = 7
               },
               new Author()
               {
                   Id = 4,
                   FirstName = "Ryan",
                   LastName = "Holiday",
                   DebutYear = 2007,
                   Ranking = 32
               },
               new Author()
               {
                   Id = 5,
                   FirstName = "Charles",
                   LastName = "Duhigg",
                   DebutYear = 1970,
                   Ranking = 15
               },
               new Author()
               {
                   Id = 6,
                   FirstName = "Andy",
                   LastName = "Weir",
                   DebutYear = 2006,
                   Ranking = 2
               }
               );

            modelBuilder.Entity<Book>()
                .HasData(
                new Book()
                {
                   Id = 1,
                   Title = "The Notebook",
                   AuthorId = 1,
                   Publication = "Grand Central Publishing",
                   Year = 2014,
                   GenreId = 1
                },
                new Book()
                {
                    Id = 2,
                    Title = "The Longest Ride",
                    AuthorId = 1,
                    Publication = "RAO",
                    Year = 2018,
                    GenreId = 1
                },
                new Book()
                {
                    Id = 3,
                    Title = "The Hobbit",
                    AuthorId = 2,
                    Publication = "Allen & Unwin ",
                    Year = 2012,
                    GenreId = 3
                },
                new Book()
                {
                    Id = 4,
                    Title = "Where the Crawdads sing",
                    AuthorId = 3,
                    Publication = "Arthur",
                    Year = 2016,
                    GenreId = 4
                },
                new Book()
                {
                    Id = 5,
                    Title = "Where the Crawdads sing",
                    AuthorId = 3,
                    Publication = "Arthur",
                    Year = 2016,
                    GenreId = 4
                },
                new Book()
                {
                    Id = 6,
                    Title = "Ego is the enemy",
                    AuthorId = 4,
                    Publication = "Nautilus English Books",
                    Year = 2013,
                    GenreId = 5
                },
                new Book()
                {
                    Id = 7,
                    Title = "The power of habit",
                    AuthorId = 5,
                    Publication = "Wired",
                    Year = 2015,
                    GenreId = 5
                }//,
                //new Book()
                //{
                //    Id = 8,
                //    Title = "Ego is the enemy",
                //    AuthorId = 5,
                //    Publication = "Nautilus English Books",
                //    Year = 2013,
                //    GenreId = 6
                //},
                //new Book()
                //{
                //    Id = 9,
                //    Title = "The martian",
                //    AuthorId = 6,
                //    Publication = "Nautilus English Books",
                //    Year = 2015,
                //    GenreId = 6
                //}
                );

            base.OnModelCreating(modelBuilder); 
        }
    }
}
