using Questor.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questor.Infra.Interfaces
{
    public interface IBoletoService
    {
        Task<Boleto> Create(Boleto boleto);        
        Task<Boleto> GetById(int id);
    }
}
