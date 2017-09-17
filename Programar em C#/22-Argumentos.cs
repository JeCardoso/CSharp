// Programar em C# #22 - Argumentos

using System;

namespace Base {
    class Argumentos {
        public void Run() {
            DadosPessoais("Maria Celeste", 37, "Inglesa");
        }

        public void DadosPessoais(string nome, int idade, string nacionalidade) {
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Idade: {idade}");
            Console.WriteLine($"Nacionalidade: {nacionalidade}");
        }
    }
}