// Programar em C# #06 - Operadores de Atribuição

using System;

namespace Base {
    class OperadoresDeAtribuicao {
        public void Run() {
            int x = 2;

            Console.WriteLine("x = x + 3: " + (x += 3));
            Console.WriteLine("x = x - 2: " + (x -= 2));
            Console.WriteLine("x = x * 2: " + (x *= 2));
            Console.WriteLine("x = x / 2: " + (x /= 2));
            Console.WriteLine("x = x % 3: " + (x %= 3));
        }
    }
}