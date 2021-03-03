using Microsoft.AspNetCore.Mvc;
using ProjetoContratos.Domain.DTO;
using ProjetoContratos.Domain.Interface.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProjetoContratos.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PrestacoesController : ControllerBase
    {

        private readonly IPrestacaoService _prestacaoService;

        public PrestacoesController(IPrestacaoService prestacaoService)
        {
            _prestacaoService = prestacaoService;
        }

        // GET: api/<PrestacoesController>
        [HttpGet("{idContrato}")]
        public async Task<IEnumerable<PrestacaoDto>> Get(long idContrato)
        {
            return await _prestacaoService.ListByContratoAsync(idContrato);
        }
    }
}
