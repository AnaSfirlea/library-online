using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryProject.Entities;

namespace LibraryProject.Repositories
{
    public class AuthorRepository : IAuthorRepository
    {
        private readonly AppDbContext context;

        public AuthorRepository(AppDbContext context)
        {
            this.context = context ?? throw new ArgumentNullException(nameof(context));
        }
        public Author GetAuthor(int authorId)
        {
            return context.Authors.Where(a => a.Id == authorId).FirstOrDefault();
        }

        public IEnumerable<Author> GetAuthors()
        {
            return context.Authors.OrderBy(a => a.LastName).ToList();
        }

        public void AddAuthor(Author author)
        {
            context.Authors.Add(author);
            context.SaveChanges();
        }

        public Author GetAuthorByLastName(string name) {
            return context.Authors.Where(a => a.LastName == name).FirstOrDefault();
        }
        public bool Save()
        {
            return context.SaveChanges() >= 0;
        }
    }
}
