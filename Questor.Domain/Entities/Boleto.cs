using Questor.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questor.Domain.Entities
{
    public class Boleto : BaseModel
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string NomeBeneficiario { get; set; }
        public string CPFBeneficiario { get; set; }
        public double Valor { get; set; }
        public DateTime DataVencimento { get; set; }
        public int BancoId { get; set; }
        public Banco Banco { get; set; }
    }
}