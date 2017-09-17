// Programar em C# #19 - break e continue

using System;
using System.Collections.Generic;

namespace Base {
    class BreakEContinue {
        public void Run() {
            int contador = 0;
            List<string> animais = new List<string>() {
                "Cão",
                "Gato",
                "Galinha",
                "Coelho",
                "Leão"
            };

            foreach (string animal in animais) {
                Console.WriteLine($"Animal: {animal}");

                if (animal == "Galinha")
                    break;
            }

            while (contador < 10) {
                contador++;

                if (contador == 5)
                    continue;

                Console.WriteLine($"Contador: {contador}");
            }
        }
    }
}