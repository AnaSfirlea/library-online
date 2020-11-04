using LibraryProject.Dtos;
using LibraryProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryProject.Services
{
    public interface IBookService
    {
        IEnumerable<BookDto> GetBooks();

        BookDto GetBook(int bookId);

        BookDto GetBookByTitle(string title);

        Book AddBook(BookDto book);

        bool DeleteBook(int id);

        Book UpdateBook(BookDto book);

        bool Save();
    }
}
