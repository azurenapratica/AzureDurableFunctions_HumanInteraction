using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DurableFunction_Exemplos.Model
{
    public class DescontoModeracaoRequest
    {
        public DescontoRequest DescontoRequest { get; set; }
        public string ApproveRequestUrl { get; set; }
        public string DeclineRequestUrl { get; set; }
    }
}
