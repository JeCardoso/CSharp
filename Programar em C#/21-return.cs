// Programar em C# #21 - return

using System;

namespace Base {
    class Return {
        public void Run() {
            Console.WriteLine($"Resultado da adição: {Adicao()}");
        }

        public int Adicao() {
            int resultado = 0;

            for (int valor = 1; valor <= 10; valor++)
                resultado += valor;

            return resultado;
        }
    }
}