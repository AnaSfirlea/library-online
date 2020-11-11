using AutoMapper;
using LibraryProject.Dtos;
using LibraryProject.Entities;
using LibraryProject.Repositories;
using LibraryProject.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace LibraryProject.Controllers
{
    [ApiController]
    [Route("api/books")]
    public class BookController : ControllerBase
    {
        private readonly IBookService bookService;

        private readonly IMapper mapper;

        public BookController(IBookService bookService, IMapper mapper)
        {
            this.bookService = bookService ??
                throw new ArgumentNullException(nameof(bookService));

            this.mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        [HttpGet]
        public IActionResult GetBooks()
        {
            return Ok(bookService.GetBooks());

        }

        [HttpGet("{id}")]
        public IActionResult GetBook(int id)
        {
            return Ok(bookService.GetBook(id));
        }

        [HttpGet("title/{title}")]
        public IActionResult GetBookByTitle(string title)
        {
            return Ok(bookService.GetBookByTitle(title));
        }

        [HttpPost]
        public IActionResult CreateBook([FromBody] BookDto bookDto)
        {
            try
            {
                return Ok(bookService.AddBook(bookDto));
            }
            catch (Exception e)
            {
                return Ok();
            }
        }

        [HttpPut("{id}")]
        public IActionResult UpdateBook([FromBody] BookDto bookDto)
        {
            try
            {
                return Ok(bookService.UpdateBook(bookDto));
            }
            catch (Exception e)
            {
                return Ok();
            }
        }


        [HttpDelete("{id}")]
        public IActionResult DeleteBook(int id)
        {
            return Ok(bookService.DeleteBook(id));
        }

    }
}
