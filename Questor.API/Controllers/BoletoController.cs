using AutoMapper;
using Microsoft.AspNetCore.Authorization;
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
        private readonly IMapper _mapper;

        public BoletoController(IBoletoService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpPost]
        [Authorize]
        public async Task<ActionResult<Boleto>> Create([FromBody] BoletoDto dto)
        {
            var boleto = _mapper.Map<Boleto>(dto);

            await _service.Create(boleto);
            return Ok(boleto);
        }

        [HttpGet("{id}")]
        [Authorize]
        public async Task<IActionResult> GetById(int id)
        {
            try
            {
                // Busca o boleto pelo serviço
                var boleto = await _service.GetById(id);

                if (boleto != null)
                {                    
                    var boletoDTO = _mapper.Map<BoletoDto>(boleto);
                    return Ok(boletoDTO);
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