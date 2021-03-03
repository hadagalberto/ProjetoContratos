using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using ProjetoContratos.Domain.DTO;
using ProjetoContratos.Domain.Entity;
using ProjetoContratos.Domain.Interface.Repository;
using ProjetoContratos.Domain.Interface.Service;
using ProjetoContratos.Domain.Service;
using ProjetoContratos.Infra.Data.Repository;
using System;

namespace ProjetoContratos.Infra.IoC
{
    public class BootStrapper
    {

        public static void Register(IServiceCollection services)
        {

            // Service
            services.AddScoped<IContratoService, ContratoService>();
            services.AddScoped<IPrestacaoService, PrestacaoService>();

            // Repository
            services.AddScoped<IContratoRepository, ContratoRepository>();
            services.AddScoped<IPrestacaoRepository, PrestacaoRepository>();

            // AutoMapper

            var mapperConfig = new MapperConfiguration(mapperConfig =>
            {
                mapperConfig.CreateMap<Contrato, ContratoDto>()
                    .ReverseMap();
                mapperConfig.CreateMap<CreateContratoDto, ContratoDto>()
                    .ForMember(dest => dest.Id, src => src.Ignore())
                    .ForMember(dest => dest.Prestacoes, src => src.Ignore());
                mapperConfig.CreateMap<Prestacao, PrestacaoDto>()
                    .ForMember(dest => dest.Status, src => src.Ignore())
                    .ReverseMap();
            });

            IMapper mapper = mapperConfig.CreateMapper();

            services.AddSingleton(mapper);
        }
    }

}