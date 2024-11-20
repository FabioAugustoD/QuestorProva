using Questor.Domain.Entities;


namespace Questor.Infra.Interfaces
{
    public interface IBoletoRepository
    {
        Task<Boleto> Create(Boleto boleto);        
        Task<Boleto> GetById(int id);
    }
}
