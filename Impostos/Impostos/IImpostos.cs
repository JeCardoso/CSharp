using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Impostos.Impostos
{
    public interface IImpostos
    {
        double calculoImposto(Orcamento orcamento);
    }
}
