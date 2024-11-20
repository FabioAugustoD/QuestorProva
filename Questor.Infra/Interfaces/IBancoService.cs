using Questor.Domain.Entities;

namespace Questor.Infra.Interfaces
{
    public interface IBancoService
    {
        Task<Banco> Create(Banco banco);
        Task<List<Banco>> GetAll();      
        Task<Banco> GetByCode(string code);
        
    }
}
