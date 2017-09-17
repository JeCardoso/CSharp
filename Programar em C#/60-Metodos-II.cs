// Programar em C# #60 - Métodos II

using System;

namespace Base {
    class MetodosII {
        private string loremIpsum = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum consectetur.";

        public void Run() {
            // IndexOf() - Indice da letra
            var indice = 0;

            while ((indice = loremIpsum.IndexOf('i', indice)) != -1) {
                Console.WriteLine(loremIpsum.Substring(indice));
                indice++;
            }

            // Trim() - Retira espaços
            Console.Write("Insere o teu primeiro nome: ");
            var primeiroNome = Console.ReadLine();

            Console.Write("Insere o teu último nome: ");
            var ultimoNome = Console.ReadLine();

            Console.WriteLine($"Nome (sem o uso do método Trim()): {primeiroNome} {ultimoNome}");
            Console.WriteLine($"Nome (com o uso do método Trim()): {primeiroNome.Trim()} {ultimoNome.Trim()}");
        }
    }
}