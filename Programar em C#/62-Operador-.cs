// Programar em C# #62 - Operador ??

using System;

namespace Base {
    class OperadorCoalescenciaNula {
        private string nome;

        public string Nome {
            get {
                return nome ?? "O conteúdo é simplesmente nulo!";
            }

            set {
                nome = value;
            }
        }

        public void Run() {
            Console.WriteLine(Nome);

            Nome = "Nelson Silva";
            Console.WriteLine($"Nome: {Nome}");

            Nome = null;
            Console.WriteLine(Nome);

            VerificarTamanho(null);
            VerificarTamanho("Coalescência");
        }

        private void VerificarTamanho(string palavra) {
            if (palavra?.Length > 5)
                Console.WriteLine($"\"{palavra}\": Esta palavra tem mais de 5 carateres!");
        }
    }
}