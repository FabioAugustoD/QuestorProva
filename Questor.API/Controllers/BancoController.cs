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
            var banco = new Banco
            {
                Nome = dto.Nome,
                Codigo = dto.Codigo,
                Juros = dto.Juros                
            };

            await _service.Create(banco);
            return Ok(banco);
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Banco>>> GetAll()
        {
            var result = await _service.GetAll();

            return Ok(result);
        }


        [HttpGet("{code}")]
        public async Task<IActionResult> GetByCode(string code)
        {
            try
            {
                var banco = await _service.GetByCode(code);

                if (banco != null)
                {
                    return Ok(banco);
                }
                else
                {
                    return NotFound($"Banco com o código {code} não encontrado");
                }
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro ao buscar o banco: {ex.Message}");
            }
        }
    }
}