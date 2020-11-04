using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryProject.Dtos
{
    public class BookForCreationDto
    {
        public string Title { get; set; }

        public string Publication { get; set; }
        
        public int Year { get; set; }
    }
}
