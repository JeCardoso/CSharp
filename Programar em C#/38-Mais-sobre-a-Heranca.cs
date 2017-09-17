// Programar em C# #38 - Mais sobre a Herança

using System;

namespace Base {
    class MaisSobreAHeranca {
        public void Run() {
            var pessoa = new _Filho();
            pessoa.Informacao();
            pessoa.ComidaPreferida();
        }
    }

    class _Pai {
        protected string ultimoNome = "Silva";

        public virtual void ComidaPreferida() {
            Console.WriteLine("A minha comida preferida é arroz de marisco!");
        }
    }

    class _Filho : _Pai {
        private string primeiroNome = "Nelson";
        private int idade = 21;

        public void Informacao() {
            Console.WriteLine($"Nome: {primeiroNome} {ultimoNome}");
            Console.WriteLine($"Idade: {idade}");
        }

        public override void ComidaPreferida() {
            Console.WriteLine("A minha comida preferida é lasanha!");
        }
    }
}