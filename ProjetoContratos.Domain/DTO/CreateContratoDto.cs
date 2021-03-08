using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoContratos.Domain.DTO
{
    public class CreateContratoDto
    {
        [Required(ErrorMessage = "A data de contratação é obrigatória!")]
        public DateTime DataContratacao { get; set; }
        [Required(ErrorMessage = "A quantidade de parcelas é obrigatória!")]
        [Range(1, 12, ErrorMessage = "Você deve escolher entre {1} e {2} parcelas")]
        public int QuantidadeParcelas { get; set; }
        [Required(ErrorMessage = "O valor do financiamento é obrigatório!")]
        [Range(1, double.MaxValue, ErrorMessage = "O valor do financiamento deve ser maior ou igual que R$1")]
        public double ValorFinanciado { get; set; }

    }
}
