using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryProject.Entities
{
    public class Author
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }


        [Required(ErrorMessage = "A first name for the author should be specified.")]
        [MaxLength(50)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "A last name for the author should be specified.")]
        [MaxLength(50)]
        public string LastName { get; set; }

    
        public int DebutYear { get; set; }

        public int Ranking { get; set; }

        public IEnumerable<Book> Books { get; set; }
    }

}
