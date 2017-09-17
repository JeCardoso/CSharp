// Programar em C# #18 - Ciclo while e do while

using System;

namespace Base {
    class CicloWhileEDoWhile {
        public void Run() {
            int contador = 1;

            while (contador <= 10) {
                Console.WriteLine($"[while] Contador: {contador}");
                contador++;
            }

            contador = 1;

            do {
                Console.WriteLine($"[do while] Contador: {contador}");
                contador++;
            } while (contador <= 10);
        }
    }
}