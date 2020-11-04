using LibraryProject.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace LibraryProject.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly AppDbContext context;

        public BookRepository(AppDbContext context)
        {
            this.context = context ?? throw new ArgumentNullException(nameof(context));
        }
        public Book GetBook(int bookId)
        {
            return context.Books.Where(b => b.Id == bookId).FirstOrDefault();
        }

        public IEnumerable<Book> GetBooks()
        {
            IEnumerable <Book> books = context.Books.Include(b => b.Author).Include(b => b.Genre).OrderBy(b => b.Title).ToList();
            foreach(Book book in books) {
                book.SetAuthorFirstName();
                book.SetAuthorLastName();
                book.SetGenreName();
            }
            return books;
        }

        public IEnumerable<Book> GetBooksByGenre(int genreId)
        {
            return context.Books.Where(b => b.GenreId == genreId)
                .OrderBy(b => b.Title).ToList();
        }

        public Book GetBookByTitle(string titleWithoutSpaces)
        {
            return context.Books
                .Include(b=> b.Author)
                .Include(b=>b.Genre)
                .Where(b => Regex.Replace(b.Title, @"\s+", "").ToLower() == titleWithoutSpaces.ToLower())
                .FirstOrDefault();
        }
        public void AddBook(Book book)
        {
            context.Books.Add(book);
            context.SaveChanges();
        }
        
        public void DeleteBook(Book book)
        {
            context.Books.Remove(book);
        }

        public void UpdateBook(Book book)
        {
            context.Books.Update(book);
            context.SaveChanges();
        }


        public bool Save()
        {
            return context.SaveChanges() >= 0;
        }

    }
}
