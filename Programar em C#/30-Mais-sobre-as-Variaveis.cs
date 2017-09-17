// Programar em C# #30 - Mais sobre as Variáveis

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base {
    class MaisSobreAsVariaveis {
        public void Run() {
            /* byte _byte = 255;
            sbyte _sbyte = 127;
            decimal _decimal = 10.0M;
            float _float = 10.0F;
            uint _uint = 4000000000;
            long _long = 9000000000000000000;
            ulong _ulong = 18000000000000000000;
            short _short = 32000;
            ushort _ushort = 65000; */

            var variavel = "Eu sou uma string!";

            // variavel = "Eu sou uma string!";
            Console.WriteLine($"Conteúdo inicial: {variavel}");

            variavel = "Eu continuo a ser uma string!";
            Console.WriteLine($"Conteúdo final: {variavel}");
        }
    }
}