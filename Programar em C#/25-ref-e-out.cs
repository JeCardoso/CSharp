// Programar em C# #25 - ref e out

using System;

namespace Base {
    class RefEOut {
        public void Run() {
            int numero = 0;

            Console.WriteLine($"Número antes da função: {numero}");
            Out(out numero);
            Console.WriteLine($"Número depois da função: {numero}");
        }

        public void Normal(int numero) {
            numero = 1;
        }

        public void Ref(ref int numero) {
            numero = 2;
        }

        public void Out(out int numero) {
            numero = 3;
        }
    }
}