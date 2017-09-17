using System;
using Impostos.Impostos;

namespace Impostos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o imposto a ser digitado:");
            var calculo = new CalculaImposto().CalcularOrcamento(new Orcamento(10.0), new ICMS());
            Console.WriteLine(calculo);
            Console.ReadKey();
        }
    }
}
