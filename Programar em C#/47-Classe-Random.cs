// Programar em C# #47 - Classe Random

using System;

namespace Base {
    class ClasseRandom {
        private Random aleatorio = new Random();

        public void Run() {
            Console.WriteLine($"Número aleatório até 20: {aleatorio.Next(21)}");
            Console.WriteLine($"Número aleatório entre 20 e 40: {aleatorio.Next(20, 41)}");

            for (int indice = 1; indice <= 10; indice++)
                Console.WriteLine($"Número aleatório #{indice}: {aleatorio.Next()}");
        }
    }
}