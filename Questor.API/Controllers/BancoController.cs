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
    public class BancoController : ControllerBase
    {
        private readonly IBancoService _service;
        private readonly IMapper _mapper;

        public BancoController(IBancoService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpPost]
        [Authorize]
        public async Task<ActionResult<Banco>> Create([FromBody] BancoDto dto)
        {            
            var banco = _mapper.Map<Banco>(dto);           
            await _service.Create(banco);            
            return Ok(banco);
        }

        [HttpGet]
        [Authorize]
        public async Task<ActionResult<IEnumerable<BancoDto>>> GetAll()
        {            
            var bancos = await _service.GetAll();            
            var bancoDTOs = _mapper.Map<IEnumerable<BancoDto>>(bancos);
            return Ok(bancoDTOs);
        }


        [HttpGet("{code}")]
        [Authorize]
        public async Task<IActionResult> GetByCode(string code)
        {
            try
            {
                var banco = await _service.GetByCode(code);

                if (banco != null)
                {
                    var bancoDTO = _mapper.Map<BancoDto>(banco);
                    return Ok(bancoDTO);
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