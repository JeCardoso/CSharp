// Programar em C# #48 - Classe File

using System;
using System.IO;

namespace Base {
    class ClasseFile {
        public void Run() {
            // File.Create("File-Create.txt");
            // File.Copy("File-Create.txt", "File-Copy.txt", true);
            File.Delete("File-Move.txt");
            // File.Move("File-Create.txt", "File-Move.txt");

            if (File.Exists("File-Move.txt"))
                Console.WriteLine("O ficheiro \"File-Move.txt\" existe!");
            else
                Console.WriteLine("O ficheiro \"File-Move.txt\" não existe!");
        }
    }
}