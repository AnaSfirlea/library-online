using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryProject.Entities
{
    public class Book
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "A title for the book should be specified.")]
        [MaxLength(50)]
        public string Title { get; set; }

        public int AuthorId { get; set; }

        [ForeignKey("AuthorId")]
        public Author Author { get; set; }


        [MaxLength(50)]
        public string Publication { get; set; }

        [MaxLength(50)]
        public int Year { get; set; }


        public int GenreId { get; set; }

        [ForeignKey("GenreId")]
        public Genre Genre { get; set; }

        public string AuthorFirstName { get; set; }

        public string AuthorLastName { get; set; }


        public string GenreName { get; set; }

        public void SetAuthorFirstName() {
            AuthorFirstName = Author.FirstName;
        }


        public void SetAuthorLastName()
        {
            AuthorLastName = Author.LastName;
        }

        public void SetGenreName() {
            GenreName = Genre.Name;
        }

    }
}

