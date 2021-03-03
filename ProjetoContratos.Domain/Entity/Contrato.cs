using System;
using System.Collections.Generic;

namespace ProjetoContratos.Domain.Entity
{
    public class Contrato
    {

        public long Id { get; set; }
        public DateTime DataContratacao { get; set; }
        public int QuantidadeParcelas { get; set; }
        public double ValorFinanciado { get; set; }

        public ICollection<Prestacao> Prestacoes { get; set; }

    }
}
