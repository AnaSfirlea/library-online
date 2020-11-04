using LibraryProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryProject.Repositories
{
    public interface IBookRepository
    {
        IEnumerable<Book> GetBooks();

        Book GetBook(int bookId);

        IEnumerable<Book> GetBooksByGenre(int genreId);

        Book GetBookByTitle(string title);

        void AddBook(Book book);

        void DeleteBook(Book book);

        void UpdateBook(Book book);

        bool Save();

    }
}
