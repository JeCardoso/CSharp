// Programar em C# #07 - Mais sobre as Strings

using System;

namespace Base {
    class MaisSobreAsStrings {
        public void Run() {
            string primeiroNome = "Nelson";
            string ultimoNome = "Silva";
            int idade = 21;

            // Console.WriteLine("Nome: " + primeiroNome + " " + ultimoNome + "\nIdade: " + idade);
            // Console.WriteLine("Nome: {0} {1}\nIdade: {2}", primeiroNome, ultimoNome, idade);
            Console.WriteLine($"Nome: {primeiroNome} {ultimoNome}\nIdade: {idade}");
        }
    }
}