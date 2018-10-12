using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Vidly.Dtos;
using Vidly.Models;
using GenreDto = Vidly.Dtos.GenreDto;

namespace Vidly.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Domain to Dto
            Mapper.CreateMap<Customer, CustomerDto>();
            Mapper.CreateMap<MembershipType, MembershipTypeDto>();
            Mapper.CreateMap<Movie, MovieDto>();
            Mapper.CreateMap<GenreDto, GenreDto>();

            // Dto to domain
            Mapper.CreateMap<CustomerDto, Customer>();
            Mapper.CreateMap<MovieDto, Movie>();

        }
    }
}