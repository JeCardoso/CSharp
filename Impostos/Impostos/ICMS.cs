using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Impostos.Impostos
{
    public class ICMS : IImpostos
    {
        public double calculoImposto(Orcamento orcamento)
        {
            return orcamento.Valor * 0.7;
        }
    }
}
