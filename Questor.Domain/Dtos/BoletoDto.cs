using Questor.Domain.Entities;

namespace Questor.Domain.Dtos
{
    public class BoletoDto
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string NomeBeneficiario { get; set; }
        public string CPFBeneficiario { get; set; }
        public double Valor { get; set; }
        public DateTime DataVencimento { get; set; }
        public int BancoId { get; set; }        
    }
}
