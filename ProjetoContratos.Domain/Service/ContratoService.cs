using AutoMapper;
using ProjetoContratos.Domain.DTO;
using ProjetoContratos.Domain.Entity;
using ProjetoContratos.Domain.Interface.Repository;
using ProjetoContratos.Domain.Interface.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoContratos.Domain.Service
{
    public class ContratoService : BaseService<ContratoDto, Contrato>, IContratoService
    {

        private readonly IMapper _mapper;

        public ContratoService(IContratoRepository repository, IMapper mapper) : base(repository, mapper)
        {
            _mapper = mapper;
        }

        public async Task CreateContratoAsync(CreateContratoDto contrato)
        {
            var contratoDto = _mapper.Map<ContratoDto>(contrato);

            contratoDto.Prestacoes = new List<PrestacaoDto>(contrato.QuantidadeParcelas);

            for(var countParcela = 0; countParcela < contrato.QuantidadeParcelas; countParcela++)
            {
                contratoDto.Prestacoes.Add(new PrestacaoDto
                {
                    Valor = contrato.ValorFinanciado / contrato.QuantidadeParcelas,
                    DataVencimento = DateTime.Now.Date.AddMonths(countParcela + 1),
                });
            }

            await base.CreateAsync(contratoDto);
        }
    }
}
