using Questor.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questor.Infra.Interfaces
{
    public interface IBancoRepository
    {
        Task<Banco> Create(Banco banco);
        Task<List<Banco>> GetAll();
        Task<Banco> GetByCode(string code);        
    }
}
