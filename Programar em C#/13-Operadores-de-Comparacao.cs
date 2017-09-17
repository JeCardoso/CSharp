// Programar em C# #13 - Operadores de Comparação

using System;

namespace Base {
    class OperadoresDeComparacao {
        public void Run() {
            int x = 10;
            int y = 20;

            if (x <= y || x == y)
                Console.WriteLine("Esta condição é verdadeira!");
            else
                Console.WriteLine("Esta condição é falsa!");
        }
    }
}