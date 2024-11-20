using Microsoft.AspNetCore.Mvc;
using Questor.Domain.Dtos;
using Questor.Domain.Entities;
using Questor.Infra.Interfaces;

namespace Questor.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BoletoController : ControllerBase
    {
        private readonly IBoletoService _service;

        public BoletoController(IBoletoService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<ActionResult<Banco>> Create([FromBody] BoletoDto dto)
        {
            var boleto = new Boleto
            {
                Nome = dto.Nome,
                CPF = dto.CPF,
                NomeBeneficiario = dto.NomeBeneficiario,
                CPFBeneficiario = dto.CPFBeneficiario,
                Valor = dto.Valor,
                DataVencimento = dto.DataVencimento,
                BancoId = dto.BancoId
            };

            await _service.Create(boleto);
            return Ok(boleto);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            try
            {
                var boleto = await _service.GetById(id);

                if (boleto != null)
                {
                    return Ok(boleto);
                }
                else
                {
                    return NotFound($"Boleto com o id {id} não encontrado");
                }
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro ao buscar o boleto: {ex.Message}");
            }
        }
    }
}