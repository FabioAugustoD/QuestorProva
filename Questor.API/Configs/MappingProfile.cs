using AutoMapper;
using Questor.Domain.Dtos;
using Questor.Domain.Entities;

namespace Questor.API.Configs
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {            
            CreateMap<BancoDto, Banco>();
            CreateMap<Banco, BancoDto>();

            CreateMap<BoletoDto, Boleto>();
            CreateMap<Boleto, BoletoDto>();
        }
    }
}
