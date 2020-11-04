using LibraryProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryProject.Repositories
{
    public interface IAuthorRepository
    {
        IEnumerable<Author> GetAuthors();

        Author GetAuthor(int authorId);

        Author GetAuthorByLastName(string name);

        void AddAuthor(Author author);

        bool Save();

    }
}
