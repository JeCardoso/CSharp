// Programar em C# #27 - Erros Comuns

using System;

namespace Base {
    class ErrosComuns {
        public void Run() {
            // Erro de compilação
            Console.WriteLine("Eu sou uma string!");

            // Erro de tempo de execução
            int x = 10, y = 0;
            Console.WriteLine($"Resultado da divisão: {x / y}");

            // Erro de lógica
            string primeiroNome = string.Empty, ultimoNome = string.Empty;

            Console.Write("Insere o teu último nome: ");
            ultimoNome = Console.ReadLine();

            Console.WriteLine($"Nome: {primeiroNome} {ultimoNome}");
        }
    }
}