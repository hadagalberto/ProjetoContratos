using ProjetoContratos.Domain.Enum;
using System;

namespace ProjetoContratos.Domain.DTO
{
    public class PrestacaoDto
    {

        public long Id { get; set; }
        public DateTime DataVencimento { get; set; }
        public DateTime? DataPagamento { get; set; }
        public double Valor { get; set; }

        public StatusPrestacao Status { get => DataPagamento != null ? StatusPrestacao.Baixada : DataVencimento < DateTime.Now ? StatusPrestacao.Atrasada : StatusPrestacao.Aberta; }

        public long IdContrato { get; set; }
        public ContratoDto Contrato { get; set; }

    }
}
