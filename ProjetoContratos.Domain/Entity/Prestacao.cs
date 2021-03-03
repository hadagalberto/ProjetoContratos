using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ProjetoContratos.Domain.Entity
{
    public class Prestacao
    {

        public long Id { get; set; }
        public DateTime DataVencimento { get; set; }
        public DateTime? DataPagamento { get; set; }
        public double Valor { get; set; }

        public long IdContrato { get; set; }
        [JsonIgnore]
        public virtual Contrato Contrato { get; set; }

    }
}
