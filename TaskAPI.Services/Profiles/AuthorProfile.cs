using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskAPI.Models;
using TaskAPI.Services.Dtos;

namespace TaskAPI.Services.Profiles
{
    public class AuthorProfile : Profile
    {
        public AuthorProfile()
        {
            CreateMap<Author, AuthorDto>()
                .ForMember(dest => dest.Address,
                opt => opt.MapFrom(scr => $"{scr.AddressNo},{scr.Street},{scr.City}"));

            CreateMap<CreateAuthorDto, Author>();
        }

    }
}
