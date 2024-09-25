using AutoMapper;
using FilmesApi.Application.Dtos;
using FilmesApi.Domain.Models;

namespace FilmesApi.Application.Profiles
{
    public class FilmeProfile : Profile
    {
        public FilmeProfile()
        {
            CreateMap<CreateFilmeDto, Filme>();
        }
    }
}
