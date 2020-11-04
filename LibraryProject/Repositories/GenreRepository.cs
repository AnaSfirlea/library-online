using LibraryProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace LibraryProject.Repositories
{
    public class GenreRepository : IGenreRepository
    {
        private readonly AppDbContext context;

        public GenreRepository(AppDbContext context)
        {
            this.context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public IEnumerable<Genre> GetGenres()
        {
            return context.Genres.OrderBy(g => g.Name).ToList();

        }

        public Genre GetGenre(int genreId)
        {
            return context.Genres.Where(g => g.Id == genreId).FirstOrDefault();
        }

        public Genre GetGenreByName(string name)
        {
            return context.Genres.Where(g => g.Name == name).FirstOrDefault();
        }

    }
}
