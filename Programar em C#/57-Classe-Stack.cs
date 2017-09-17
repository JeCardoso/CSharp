﻿// Programar em C# #57 - Classe Stack

using System;
using System.Collections.Generic;

namespace Base {
    class ClasseStack {
        private Stack<int> pilha = new Stack<int>();
        private const int Multiplicador = 10;
        private int numero = 1;

        public void Run() {
            for (int indice = 1; indice <= 5; indice++) {
                pilha.Push(numero);
                numero *= Multiplicador;
            }

            ImprimirPilha();

            Console.WriteLine($"\nA remover o número {pilha.Pop()} da pilha com o método Pop()!\n");

            ImprimirPilha();

            Console.WriteLine($"\nO número que se encontra na parte superior da pilha é o {pilha.Peek()}!");
        }

        private void ImprimirPilha() {
            foreach (var numero in pilha)
                Console.WriteLine(numero);
        }
    }
}