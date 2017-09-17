// Programar em C# #65 - Operadores Bit a Bit

using System;

namespace Base {
    class OperadoresBitABit {
        private int x = 60; // 00111100 < 01111000 < 11110000 | 00111100 > 00011110 > 00001111
        private int y = 13; // 00001101 

        public void Run() {
            Console.WriteLine($"Resultado do operador &: {x & y}"); // 12 -> 00001100
            Console.WriteLine($"Resultado do operador |: {x | y}"); // 61 -> 00111101
            Console.WriteLine($"Resultado do operador <<: {x << 2}"); // 240 -> 11110000
            Console.WriteLine($"Resultado do operador >>: {x >> 2}"); // 15 -> 00001111
        }
    }
}