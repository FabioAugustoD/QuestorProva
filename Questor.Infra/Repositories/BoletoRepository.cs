using Microsoft.EntityFrameworkCore;
using Questor.Domain.Entities;
using Questor.Infra.Context;
using Questor.Infra.Interfaces;


namespace Questor.Infra.Repositories
{
    public class BoletoRepository : IBoletoRepository
    {
        private readonly AppDbContext _context;
        public BoletoRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task<Boleto> Create(Boleto boleto)
        {
            _context.Boletos.Add(boleto);
            await _context.SaveChangesAsync();
            return boleto;
        }

        public async Task<Boleto> GetById(int id)
        {
            var boleto = await _context.Boletos
                                  .Include(b => b.Banco)
                                  .FirstOrDefaultAsync(c => c.Id == id);

            if (boleto != null)
            {
                return boleto;
            }
            else
            {
                return null;
            }
        }
    }
}
