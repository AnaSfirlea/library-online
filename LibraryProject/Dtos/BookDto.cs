using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryProject.Dtos
{
    public class BookDto
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public string AuthorFirstName { get; set; }

        public string AuthorLastName { get; set; }

        public String GenreName { get; set; }

        public string Publication { get; set; }

        public int Year { get; set; }

        public int GenreId { get; set; }

        public int AuthorId { get; set; }

        public AuthorDto Author { get; set; }

        public GenreDto Genre { get; set; }

    }
}
