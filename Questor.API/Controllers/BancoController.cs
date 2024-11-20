using Microsoft.AspNetCore.Mvc;
using Questor.Domain.Dtos;
using Questor.Domain.Entities;
using Questor.Infra.Interfaces;

namespace Questor.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BancoController : ControllerBase
    {
        private readonly IBancoService _service;

        public BancoController(IBancoService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<ActionResult<Banco>> Create([FromBody] BancoDto dto)
        {
            var colaborador = new Banco
            {
                Nome = dto.Nome,
                Codigo = dto.Codigo,
                Juros = dto.Juros                
            };

            await _service.Create(colaborador);
            return Ok(colaborador);
        }


        [HttpGet]
        public async Task<ActionResult<IEnumerable<Banco>>> GetAll()
        {
            var result = await _service.GetAll();

            return Ok(result);
        }
    }
}