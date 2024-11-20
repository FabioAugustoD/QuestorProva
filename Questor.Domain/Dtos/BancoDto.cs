using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questor.Domain.Dtos
{
    public class BancoDto
    {        
        public string Nome { get; set; }
        public string Codigo { get; set; }
        public double Juros { get; set; }
    }
}
