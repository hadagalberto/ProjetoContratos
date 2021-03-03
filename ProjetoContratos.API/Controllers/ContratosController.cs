using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
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
    public class ContratosController : ControllerBase
    {

        private readonly IContratoService _contratoService;
        private readonly IMemoryCache _cache;
        private static string Contratos { get { return "_Contratos"; } }

        public ContratosController(IContratoService contratoService)
        {
            _contratoService = contratoService;
            _cache = new MemoryCache(new MemoryCacheOptions());
        }

        // GET: api/<ContratosController>
        [HttpGet]
        public async Task<IEnumerable<ContratoDto>> Get()
        {
            return await _contratoService.ListAsync();
        }

        // GET api/<ContratosController>/5
        [HttpGet("{id}")]
        public async Task<ContratoDto> Get(long id)
        {
            ContratoDto contrato;
            if (!_cache.TryGetValue(Contratos, out contrato))
            {
                contrato = await _contratoService.GetAsync(id);

                _cache.Set(Contratos, contrato, DateTime.Now.Date.AddDays(1));
            }
            return contrato;
        }

        // POST api/<ContratosController>
        [HttpPost]
        public async Task Post([FromBody] CreateContratoDto contrato)
        {
            await _contratoService.CreateContratoAsync(contrato);
        }

        // PUT api/<ContratosController>/5
        [HttpPut]
        public async Task Put([FromBody] ContratoDto contrato)
        {
            await _contratoService.UpdateAsync(contrato);
        }

        // DELETE api/<ContratosController>/5
        [HttpDelete("{id}")]
        public async Task Delete([FromBody] ContratoDto contrato)
        {
            await _contratoService.DeleteAsync(contrato);
        }
    }
}
