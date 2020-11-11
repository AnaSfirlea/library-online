using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using LibraryProject.Dtos;
using LibraryProject.Entities;
using LibraryProject.Repositories;

namespace LibraryProject.Services
{
    public class GenreService : IGenreService
    {
        private readonly IGenreRepository genreRepository;

        private readonly IMapper mapper;

        public GenreService(IGenreRepository genreRepository, IMapper mapper)
        {
            this.genreRepository = genreRepository
                ?? throw new ArgumentNullException(nameof(genreRepository));

            this.mapper = mapper;
        }
        public GenreDto GetGenre(int genreId)
        {
            var genre = genreRepository.GetGenre(genreId);

            return mapper.Map<GenreDto>(genre);
        }

        public GenreDto GetGenreByName(string name)
        {
            var genre = genreRepository.GetGenreByName(name);

            return mapper.Map<GenreDto>(genre);
        }

        public IEnumerable<GenreDto> GetGenres()
        {
            var genreEntities = genreRepository.GetGenres();

            return mapper.Map<IEnumerable<GenreDto>>(genreEntities);
        }
    }
}
