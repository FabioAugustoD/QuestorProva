using Questor.Domain.Entities;
using Questor.Infra.Interfaces;

namespace Questor.API.Services
{
    public class BoletoService : IBoletoService
    {
        private IBoletoRepository _repository;

        public BoletoService(IBoletoRepository repository)
        {
            _repository = repository;
        }

        public async Task<Boleto> Create(Boleto boleto)
        {
            return await _repository.Create(boleto);
        }
        public async Task<Boleto> GetById(int id)
        {
            Boleto boleto = await _repository.GetById(id);

            if (DateTime.Now > boleto.DataVencimento)
            {
                var juros = (boleto.Valor) * (boleto.Banco.Juros);
                var valorTotal = boleto.Valor + juros;

                boleto.Valor = valorTotal;
            }
            
            return boleto;
        }
    }
}
