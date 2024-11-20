using Questor.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questor.Domain.Entities
{
    public class Banco : BaseModel
    {
        public string Nome {  get; set; }
        public string Codigo { get; set; }
        public string Juros { get; set; }
    }
}