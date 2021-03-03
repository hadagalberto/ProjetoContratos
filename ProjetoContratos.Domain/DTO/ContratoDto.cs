using System;
using System.Collections.Generic;

namespace ProjetoContratos.Domain.DTO
{
    public class ContratoDto
    {

        public long Id { get; set; }
        public DateTime DataContratacao { get; set; }
        public int QuantidadeParcelas { get; set; }
        public double ValorFinanciado { get; set; }

        public ICollection<PrestacaoDto> Prestacoes { get; set; }

    }
}
