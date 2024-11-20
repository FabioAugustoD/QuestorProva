using Microsoft.EntityFrameworkCore;
using Questor.Domain.Entities;
using Questor.Infra.Context;
using Questor.Infra.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questor.Infra.Repositories
{
    public class BancoRepository : IBancoRepository
    {
        private readonly AppDbContext _context;
        public BancoRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task<Banco> Create(Banco banco)
        {
            _context.Bancos.Add(banco);
            await _context.SaveChangesAsync();
            return banco;
        }
        public async Task<List<Banco>> GetAll()
        {
            var query = from b in _context.Bancos
                        select b;

            return await query.ToListAsync();
        }

        public async Task<Banco> GetByCode(string codigo)
        {
            var banco = await _context.Bancos
                                  .FirstOrDefaultAsync(c => c.Codigo == codigo);

            if (banco != null)
            {
                return banco;
            }
            else
            {
                return null;
            }
        }
    }
}
