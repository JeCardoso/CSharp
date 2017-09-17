// Programar em C# #37 - Herança

using System;

namespace Base {
    class Heranca {
        public void Run() {
            var pessoa = new Filho();
            pessoa.Informacao();
            pessoa.ComidaPreferida();
        }
    }

    class Pai {
        protected string ultimoNome = "Silva";

        public void ComidaPreferida() {
            Console.WriteLine("A minha comida preferida é arroz de marisco!");
        }
    }

    class Filho : Pai {
        private string primeiroNome = "Nelson";
        private int idade = 21;

        public void Informacao() {
            Console.WriteLine($"Nome: {primeiroNome} {ultimoNome}");
            Console.WriteLine($"Idade: {idade}");
        }
    }
}