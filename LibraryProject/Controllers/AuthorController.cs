using AutoMapper;
using LibraryProject.Dtos;
using LibraryProject.Entities;
using LibraryProject.Repositories;
using LibraryProject.Services;
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
        private readonly IAuthorService authorService;

        private readonly IMapper mapper;

        public AuthorController(IAuthorService authorService, IMapper mapper)
        {
            this.authorService = authorService ??
                throw new ArgumentNullException(nameof(authorService));

            this.mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }


        [HttpGet]
        public IActionResult GetAuthors()
        {
            return Ok(authorService.GetAuthors());
        }

        [HttpGet("{id}")]
        public IActionResult GetAuthor(int id)
        {
            return Ok(authorService.GetAuthor(id));
        }

        [HttpGet("name/{name}")]
        public IActionResult GetAuthorByLastName(string name)
        {
            return Ok(authorService.GetAuthorByLastName(name));
        }

        [HttpPost]
        public IActionResult CreateAuthor([FromBody] AuthorDto authorDto)
        {
            try
            {
                return Ok(authorService.AddAuthor(authorDto));
            }
            catch (Exception e)
            {

                return Ok();
            }
        }

 

    }
}
