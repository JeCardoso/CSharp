// Programar em C# #36 - Propriedades

using System;

namespace Base {
    class Propriedades {
        private string primeiroNome = string.Empty, ultimoNome = string.Empty;
        // public int variavel { get; set; }
        private int idade = 21;

        public string PrimeiroNome {
            set {
                if (value != string.Empty)
                    primeiroNome = value;
                else
                    Console.WriteLine("A string referente ao primeiro nome não pode estar vazia!");
            }
        }

        public string UltimoNome {
            set {
                if (value != string.Empty)
                    ultimoNome = value;
                else
                    Console.WriteLine("A string referente ao último nome não pode estar vazia!");
            }
        }

        public int Idade {
            get {
                return idade;
            }
        }

        public void Informacao() {
            Console.WriteLine($"Nome: {primeiroNome} {ultimoNome}");
        }
    }
}