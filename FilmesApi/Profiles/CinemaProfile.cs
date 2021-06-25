using AutoMapper;
using FilmesAPI.Data.Dtos;
using FilmesAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmesAPI.Profiles
{
    public class CinemaProfile : Profile
    {
        public CinemaProfile()
        {
            CreateMap<CreateCinemaDto, Cinema>();
            CreateMap<Cinema, ReadCinemaDto>()
                .ForMember(c => c.Endereco, opts => opts
                .MapFrom(c => new
                {
                    Id = c.Endereco.Id,
                    Logradouro = c.Endereco.Logradouro,
                    Bairro = c.Endereco.Bairro,
                    Numero = c.Endereco.Numero
                }));                ;
            CreateMap<UpdateCinemaDto, Cinema>();
        }
    }
}
