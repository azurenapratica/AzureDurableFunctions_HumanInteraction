using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DurableFunction_Exemplos.Model
{
    public class DescontoRequest
    {
        public string CodigoProduto { get; set; }
        public decimal ValorProduto { get; set; }
        public decimal ValorDesconto { get; set; }
        public string SolicitadoPor { get; set; }
    }
}
