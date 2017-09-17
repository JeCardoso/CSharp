// Programar em C# #51 - Classe Path

using System;
using System.IO;

namespace Base {
    class ClassePath {
        private const string Ficheiro = "Ficheiro.txt";

        public void Run() {
            Console.WriteLine($"Nome do ficheiro com a extensão: {Path.GetFileName(Ficheiro)}");
            Console.WriteLine($"Nome do ficheiro sem a extensão: {Path.GetFileNameWithoutExtension(Ficheiro)}");
            Console.WriteLine($"Extensão do ficheiro: {Path.GetExtension(Ficheiro)}");
            Console.WriteLine($"Caminho absoluto até ao ficheiro: {Path.GetFullPath(Ficheiro)}");
        }
    }
}