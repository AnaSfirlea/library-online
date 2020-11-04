using LibraryProject.Entities;
using System.Collections.Generic;


namespace LibraryProject.Repositories
{
    public interface IGenreRepository
    {

        IEnumerable<Genre> GetGenres();

        Genre GetGenre(int genreId);

        Genre GetGenreByName(string name);

    }
}
