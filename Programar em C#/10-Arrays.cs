// Programar em C# #10 - Arrays

using System;

namespace Base {
    class Arrays {
        public void Run() {
            /* string[] cores = new string[5];

            cores[0] = "Azul";
            cores[1] = "Verde";
            cores[2] = "Amarelo";
            cores[3] = "Vermelho";
            cores[4] = "Laranja"; */

            string[] cores = new string[] {
                "Azul",
                "Verde",
                "Amarelo",
                "Vermelho",
                "Laranja"
            };

            Console.WriteLine($"Número de cores: {cores.Length}");
            Console.WriteLine($"Primeira cor: {cores[0]}");
            Console.WriteLine($"Última cor: {cores[cores.Length - 1]}");
        }
    }
}