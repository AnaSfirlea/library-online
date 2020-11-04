using AutoMapper;

namespace LibraryProject.Profiles
{
    public class BookProfile : Profile
    {
        public BookProfile()
        {
            CreateMap<Entities.Book, Dtos.BookDto>();
            CreateMap<Dtos.BookDto, Entities.Book>().ReverseMap();

            //CreateMap<Dtos.BookForCreationDto, Entities.Book>().ReverseMap();

        }
    }
}
