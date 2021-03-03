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

        public StatusPrestacao Status { get => DataPagamento != null ? StatusPrestacao.Baixada : DataVencimento.Date >= DateTime.Now.Date ? StatusPrestacao.Aberta : StatusPrestacao.Atrasada; }

        public long IdContrato { get; set; }
        public ContratoDto Contrato { get; set; }

    }
}
