using Mini.Classes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini.Console
{
    public static class Program
    {
        static void Main(string[] args)
        {
            System.Console.Out.WriteLine("Minimizando...");

            Minificador.Executar(args);

            System.Console.ReadKey();
        }
    }
}
