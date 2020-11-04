using AutoMapper;
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using LibraryProject.Repositories;
using LibraryProject.Dtos;

namespace LibraryProject.Controllers
{
    [ApiController]
    [Route("api/genres")]
    public class GenreController : ControllerBase
    {
        private readonly IGenreRepository genreRepository;
        private readonly IMapper mapper;

        public GenreController(IGenreRepository genreRepository, IMapper mapper)
        {
            this.genreRepository = genreRepository ??
                throw new ArgumentNullException(nameof(genreRepository));
            this.mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        [HttpGet]
        public IActionResult GetGenres()
        {
            var genreEntities = genreRepository.GetGenres();

            return Ok(mapper.Map<IEnumerable<GenreDto>>(genreEntities));
        }

        [HttpGet("{id}")]
        public IActionResult GetGenre(int id)
        {
            var genre = genreRepository.GetGenre(id);

            if (genre == null)
            {
                return NotFound();
            }

            return Ok(mapper.Map<GenreDto>(genre));
        }

        [HttpGet("name/{name}")]
        public IActionResult GetGenreByName(string name)
        {
            var genre = genreRepository.GetGenreByName(name);

            if (genre == null)
            {
                return NotFound();
            }

            return Ok(mapper.Map<GenreDto>(genre));
        }
    }
}
