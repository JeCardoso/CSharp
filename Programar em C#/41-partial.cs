// Programar em C# #41 - partial

using System;

namespace Base {
    class Partial {
        public void Run() {
            var classe = new Classe();
            classe.Informacao();
        }

        partial class Classe {
            private string primeiroNome = "Nelson";
            partial void _Informacao();

            public void Informacao() {
                _Informacao();
            }
        }

        partial class Classe {
            private string ultimoNome = "Silva";
            private int idade = 21;

            partial void _Informacao() {
                Console.WriteLine($"Nome: {primeiroNome} {ultimoNome}");
                Console.WriteLine($"Idade: {idade}");
            }
        }
    }
}