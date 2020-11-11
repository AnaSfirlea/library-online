using LibraryProject.Dtos;
using LibraryProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryProject.Services
{
    public interface IGenreService
    {
        IEnumerable<GenreDto> GetGenres();

        GenreDto GetGenre(int genreId);

        GenreDto GetGenreByName(string name);
    }
}
