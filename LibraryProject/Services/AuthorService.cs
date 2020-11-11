using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using LibraryProject.Dtos;
using LibraryProject.Entities;
using LibraryProject.Repositories;

namespace LibraryProject.Services
{
    public class AuthorService : IAuthorService
    {
        private readonly IAuthorRepository authorRepository;

        private readonly IMapper mapper;

        public AuthorService(IAuthorRepository authorRepository, IMapper mapper)
        {
            this.authorRepository = authorRepository ?? throw new ArgumentNullException(nameof(authorRepository));

            this.mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }
        public Author AddAuthor(AuthorDto authorDto)
        {
            Author finalAuthor = mapper.Map<Author>(authorDto);

            authorRepository.AddAuthor(finalAuthor);
            var save = authorRepository.Save();

            return finalAuthor;
        }

        public AuthorDto GetAuthor(int authorId)
        {
            var author = authorRepository.GetAuthor(authorId);


            return mapper.Map<AuthorDto>(author);
        }

        public AuthorDto GetAuthorByLastName(string name)
        {
            var author = authorRepository.GetAuthorByLastName(name);

            return mapper.Map<AuthorDto>(author);
        }

        public IEnumerable<AuthorDto> GetAuthors()
        {
            var authorEntities = authorRepository.GetAuthors();

            return mapper.Map<IEnumerable<AuthorDto>>(authorEntities);
        }

        public bool Save()
        {
            return authorRepository.Save();
        }
    }
}
