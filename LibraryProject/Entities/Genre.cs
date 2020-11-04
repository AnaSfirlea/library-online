using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace LibraryProject.Entities
{
    public class Genre
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "A name for the genre should be specified.")]
        [MaxLength(50)]
        public string Name { get; set; }

        public IEnumerable<Book> Books { get; set; }

    }
}
