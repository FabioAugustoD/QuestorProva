using Questor.Domain.Entities;
using Questor.Infra.Interfaces;

namespace Questor.API.Services
{
    public class BancoService : IBancoService
    {
        private readonly IBancoRepository _repository;

        public BancoService(IBancoRepository repository)
        {
            _repository = repository;
        }
        public async Task<Banco> Create(Banco banco)
        {
            return await _repository.Create(banco);
        }

        public async Task<List<Banco>> GetAll()
        {
            return await _repository.GetAll();
        }
        public async Task<Banco> GetByCode(string code)
        {
            return await _repository.GetByCode(code);
        }
    }
}
