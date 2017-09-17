using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Impostos.Impostos
{
    public class CalculaImposto
    {

        public double CalcularOrcamento(Orcamento orcamento, IImpostos imposto) {
            return imposto.calculoImposto(orcamento);
        }

    }
}
