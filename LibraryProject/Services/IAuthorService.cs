using LibraryProject.Dtos;
using LibraryProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryProject.Services
{
    public interface IAuthorService
    {
        IEnumerable<AuthorDto> GetAuthors();

        AuthorDto GetAuthor(int authorId);

        AuthorDto GetAuthorByLastName(string name);

        Author AddAuthor(AuthorDto author);

        bool Save();
    }
}
