// Programar em C# #28 - Arrays Multidimensionais

using System;

namespace Base {
    class ArraysMultidimensionais {
        public void Run() {
            // [número de linhas, número de colunas]
            int[,] arrayMultidimensional = new int[5, 4] {
                { 1, 2, 3, 4 },
                { 1, 1, 1, 1 },
                { 2, 2, 2, 2 },
                { 3, 3, 3, 3 },
                { 4, 4, 4, 4 }
            };

            for (int i = 0; i < arrayMultidimensional.GetLength(0); i++) {
                for (int j = 0; j < arrayMultidimensional.GetLength(1); j++)
                    Console.Write($"{arrayMultidimensional[i, j]}\t");

                Console.WriteLine();
            }
        }
    }
}