// Programar em C# #31 - Exceções

using System;

namespace Base {
    class Excecoes {
        public void Run() {
            int[] numeros = new int[5] {
                1, 2, 3, 4, 5
            };

            try {
                Console.WriteLine($"Conteúdo do elemento: {numeros[5]}");
            }
            catch (Exception exception) {
                // Console.WriteLine("O código presente no try não está a funcionar corretamente!");
                Console.WriteLine(exception);
            }
            finally {
                Console.WriteLine("Eu faço parte do finally e sou executado caso haja alguma exceção ou não!");
            }
        }
    }
}