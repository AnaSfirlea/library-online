using AutoMapper;
using LibraryProject.Dtos;
using LibraryProject.Entities;
using LibraryProject.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryProject.Services
{
    public class BookService : IBookService
    {

        private readonly IBookRepository bookRepository;

        private readonly IMapper mapper;

        public BookService(IBookRepository bookRepository, IMapper mapper)
        {
            this.bookRepository = bookRepository 
                ?? throw new ArgumentNullException(nameof(bookRepository));

            this.mapper = mapper;
        }

        public IEnumerable<BookDto> GetBooks()
        {
            var bookEntities = bookRepository.GetBooks();

            return mapper.Map<IEnumerable<BookDto>>(bookEntities);
        }

        public BookDto GetBook(int bookId)
        {
            var book = bookRepository.GetBook(bookId);

            return mapper.Map<BookDto>(book);
        }

        public BookDto GetBookByTitle(string title)
        {
            var book = bookRepository.GetBookByTitle(title);

            return mapper.Map<BookDto>(book);
        }

        public Book AddBook(BookDto bookDto)
        {
            Book finalBook = mapper.Map<Book>(bookDto);

            bookRepository.AddBook(finalBook);
            var save = bookRepository.Save();

            return finalBook;
        }

        public Book UpdateBook(BookDto bookDto)
        {

            Book finalBook = mapper.Map<Book>(bookDto);

            bookRepository.UpdateBook(finalBook);
            var save = bookRepository.Save();

            return finalBook;
        }

        public bool DeleteBook(int id)
        {
            Book bookEntity = bookRepository.GetBook(id);
           
            bookRepository.DeleteBook(bookEntity);
            bookRepository.Save();

            return true;
        }

        public bool Save()
        {
            return bookRepository.Save();
        }


    }
}
