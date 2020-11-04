using AutoMapper;
using LibraryProject.Dtos;
using LibraryProject.Entities;
using LibraryProject.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace LibraryProject.Controllers
{
    [ApiController]
    [Route("api/authors")]
    public class AuthorController : ControllerBase
    {
        private readonly IAuthorRepository authorRepository;

        private readonly IMapper mapper;

        public AuthorController(IAuthorRepository authorRepository, IMapper mapper)
        {
            this.authorRepository = authorRepository ??
                throw new ArgumentNullException(nameof(authorRepository));

            this.mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }


        [HttpGet]
        public IActionResult GetAuthors()
        {
            var authorEntities = authorRepository.GetAuthors();

            return Ok(mapper.Map<IEnumerable<AuthorDto>>(authorEntities));
        }

        [HttpGet("{id}")]
        public IActionResult GetAuthor(int id)
        {
            var author = authorRepository.GetAuthor(id);

            if (author == null)
            {
                return NotFound();
            }

            return Ok(mapper.Map<AuthorDto>(author));
        }

        [HttpGet("name/{name}")]
        public IActionResult GetAuthorByLastName(string name)
        {
            var author = authorRepository.GetAuthorByLastName(name);

            if (author == null)
            {
                return NotFound();
            }

            return Ok(mapper.Map<AuthorDto>(author));
        }

        [HttpPost]
        public IActionResult CreateAuthor([FromBody] AuthorDto authorDto)
        {
            try
            {
                Author finalAuthor = mapper.Map<Author>(authorDto);

                authorRepository.AddAuthor(finalAuthor);
                var save = authorRepository.Save();

                return Ok(finalAuthor);
            }
            catch (Exception e)
            {

                return Ok();
            }
        }

 

    }
}
