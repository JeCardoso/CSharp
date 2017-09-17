// Programar em C# #16 - Ciclo for

using System;

namespace Base {
    class CicloFor {
        public void Run() {
            string[] materialEscolar = new string[6] {
                "Mochila", // 0
                "Estojo", // 1
                "Lápis", // 2
                "Borracha", // 3
                "Afia", // 4
                "Tesoura" // 5
            };

            /* Console.WriteLine(materialEscolar[0]);
            Console.WriteLine(materialEscolar[1]); */

            for (int indice = 0; indice < materialEscolar.Length; indice++)
                Console.WriteLine($"materialEscolar[{indice}]: {materialEscolar[indice]}");
        }
    }
}