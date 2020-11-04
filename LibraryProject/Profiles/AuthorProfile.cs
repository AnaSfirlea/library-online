using AutoMapper;

namespace LibraryProject.Profiles
{
    public class AuthorProfile : Profile
    {
        public AuthorProfile()
        {
            CreateMap<Entities.Author, Dtos.AuthorDto>();
            CreateMap<Dtos.AuthorDto, Entities.Author>().ReverseMap();

        }
    }
}
