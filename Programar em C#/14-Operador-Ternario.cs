// Programar em C# #14 - Operador Ternário

using System;

namespace Base {
    class OperadorTernario {
        // (condição) ? condição for verdadeira : condição for falsa;

        public void Run() {
            int idade = 21;
            // bool eMaiorDeIdade;

            /* if (idade >= 18)
                eMaiorDeIdade = true;
            else
                eMaiorDeIdade = false; */

            // eMaiorDeIdade = (idade >= 18) ? true : false;

            Console.WriteLine($"É maior de idade: {((idade >= 18) ? true : false)}");
        }
    }
}