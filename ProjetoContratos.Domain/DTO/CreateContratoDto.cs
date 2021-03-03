using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoContratos.Domain.DTO
{
    public class CreateContratoDto
    {

        public DateTime DataContratacao { get; set; }
        public int QuantidadeParcelas { get; set; }
        public double ValorFinanciado { get; set; }

    }
}
