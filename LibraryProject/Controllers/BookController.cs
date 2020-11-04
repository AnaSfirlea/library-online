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
        //private readonly IBookRepository bookRepository;

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
            //var bookEntities = bookRepository.GetBooks();

            //return Ok(mapper.Map<IEnumerable<BookDto>>(bookEntities));

            return Ok(bookService.GetBooks());

        }

        [HttpGet("{id}")]
        public IActionResult GetBook(int id)
        {
            //var book = bookRepository.GetBook(id);

            //if (book == null)
            //{
            //    return NotFound();
            //}

            //return Ok(mapper.Map<BookDto>(book));

            return Ok(bookService.GetBook(id));
        }

        [HttpGet("title/{title}")]
        public IActionResult GetBookByTitle(string title) {

            //var book = bookRepository.GetBookByTitle(title);

            //if (book == null)
            //{
            //    return NotFound();
            //}

            //return Ok(mapper.Map<BookDto>(book));

            return Ok(bookService.GetBookByTitle(title));

        }

        [HttpPost]
        public IActionResult CreateBook([FromBody] BookDto bookDto)
        {
            try
            {
                //Book finalBook = mapper.Map<Book>(bookDto);

                //bookRepository.AddBook(finalBook);
                //var save = bookRepository.Save();

                //return Ok(finalBook);

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
                //Book finalBook = mapper.Map<Book>(bookDto);

                //bookRepository.UpdateBook(finalBook);
                //var save = bookRepository.Save();

                //return Ok(finalBook);

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
            //Book bookEntity = bookRepository.GetBook(id);
            //if (bookEntity == null)
            //{
            //    return NotFound();
            //}
            //bookRepository.DeleteBook(bookEntity);
            //bookRepository.Save();

            //return Ok("true");

            return Ok(bookService.DeleteBook(id));

        }

    }
}
