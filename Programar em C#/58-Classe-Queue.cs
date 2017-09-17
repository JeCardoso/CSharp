// Programar em C# #58 - Classe Queue

using System;
using System.Collections.Generic;

namespace Base {
    class ClasseQueue {
        private Queue<int> fila = new Queue<int>();
        private const int Multiplicador = 10;
        private int numero = 1;

        public void Run() {
            for (int indice = 1; indice <= 5; indice++) {
                fila.Enqueue(numero);
                numero *= Multiplicador;
            }

            ImprimirFila();

            Console.WriteLine($"\nA remover o número {fila.Dequeue()} da fila com o método Dequeue()!\n");

            ImprimirFila();

            Console.WriteLine($"\nO número que se encontra na frente da fila é o {fila.Peek()}!");
        }

        private void ImprimirFila() {
            foreach (var numero in fila)
                Console.WriteLine(numero);
        }
    }
}