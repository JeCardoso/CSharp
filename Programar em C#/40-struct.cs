// Programar em C# #40 - struct

using System;

namespace Base {
    class Struct {
        public void Run() {
            var estrutura = new Estrutura();
            estrutura.Numero = 200;
        }

        struct Estrutura : IEstrutura {
            private int numero;

            public int Numero {
                set {
                    if (value >= 0 && value <= 100) {
                        numero = value;
                        ImprimirNumero();
                    }
                    else
                        Console.WriteLine("O número precisa de ser >= 0 e <= 100!");
                }
            }

            public void ImprimirNumero() {
                Console.WriteLine($"Número: {numero}");
            }
        }

        interface IEstrutura {
            void ImprimirNumero();
        }
    }
}