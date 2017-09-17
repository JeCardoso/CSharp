// Programar em C# #46 - Classe Math

using System;

namespace Base {
    class ClasseMath {
        public void Run() {
            Console.WriteLine($"Resultado do método Sin(): {Math.Sin(10.5)}");
            Console.WriteLine($"Resultado do método Cos(): {Math.Cos(10.5)}");
            Console.WriteLine($"Resultado do método Tan(): {Math.Tan(10.5)}");
            Console.WriteLine($"Resultado do método Floor(): {Math.Floor(10.5)}");
            Console.WriteLine($"Resultado do método Ceiling(): {Math.Ceiling(10.5)}");
            Console.WriteLine($"Resultado do método Abs(): {Math.Abs(-10.5)}");
            Console.WriteLine($"Resultado do método Sqrt(): {Math.Sqrt(10.5)}");
            Console.WriteLine($"Resultado do método Pow(): {Math.Pow(2, 5)}"); // 2 * 2 * 2 * 2 * 2
        }
    }
}