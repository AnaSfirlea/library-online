using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryProject.Profiles
{
    public class GenreProfile : Profile
    {
        public GenreProfile()
        {
            CreateMap<Entities.Genre, Dtos.GenreDto>();
            CreateMap<Entities.Genre, Dtos.GenreDto>();
        }
    }
}
