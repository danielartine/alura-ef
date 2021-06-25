using AutoMapper;
using FilmesAPI.Data.Dtos;
using FilmesAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmesAPI.Profiles
{
    public class SessaoProfile : Profile
    {
        public SessaoProfile()
        {
            CreateMap<CreateSessaoDto, Sessao>();
            CreateMap<Sessao, ReadSessaoDto>()
                .ForMember(s => s.Cinema, opts => opts
                .MapFrom(s => new
                {
                    Id = s.Cinema.Id,
                    Nome = s.Cinema.Nome,
                    Endereco = s.Cinema.Endereco
                }))
                .ForMember(s => s.Filme, opts => opts
                .MapFrom(s => new
                {
                    Id = s.Filme.Id,
                    Titulo = s.Filme.Titulo,
                    Diretor = s.Filme.Diretor,
                    Genero = s.Filme.Genero,
                    Duracao = s.Filme.Duracao
                }))
                .ForMember(s => s.HorarioEncerramento, opts => opts
                .MapFrom(s => s.HorarioInicio.AddMinutes(s.Filme.Duracao)));
            CreateMap<UpdateSessaoDto, Sessao>();
        }
    }
}
