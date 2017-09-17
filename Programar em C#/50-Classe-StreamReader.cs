// Programar em C# #50 - Classe StreamReader

using System;
using System.IO;

namespace Base {
    class ClasseStreamReader {
        private StreamReader lerFicheiro;

        public void Run() {
            using (lerFicheiro = new StreamReader("Ficheiro.txt")) {
                var linha = string.Empty;

                /* while ((linha = lerFicheiro.ReadLine()) != null)
                    Console.WriteLine(linha); */

                Console.WriteLine(lerFicheiro.ReadToEnd());
            }
        }
    }
}