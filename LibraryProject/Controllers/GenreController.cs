using AutoMapper;
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using LibraryProject.Repositories;
using LibraryProject.Dtos;
using LibraryProject.Services;

namespace LibraryProject.Controllers
{
    [ApiController]
    [Route("api/genres")]
    public class GenreController : ControllerBase
    {
        private readonly IGenreService genreService;
        private readonly IMapper mapper;

        public GenreController(IGenreService genreService, IMapper mapper)
        {
            this.genreService = genreService ??
                throw new ArgumentNullException(nameof(genreService));
            this.mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        [HttpGet]
        public IActionResult GetGenres()
        {
            return Ok(genreService.GetGenres());
        }

        [HttpGet("{id}")]
        public IActionResult GetGenre(int id)
        {
            return Ok(genreService.GetGenre(id));
        }

        [HttpGet("name/{name}")]
        public IActionResult GetGenreByName(string name)
        {
           return Ok(genreService.GetGenreByName(name));
        }
    }
}
