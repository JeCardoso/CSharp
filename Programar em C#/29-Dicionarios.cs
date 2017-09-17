// Programar em C# #29 - Dicionários

using System;
using System.Collections.Generic;

namespace Base {
    class Dicionarios {
        public void Run() {
            Dictionary<string, int> pessoas = new Dictionary<string, int>() {
                { "Nelson Silva", 21 },
                { "Maria Celeste", 37 }
            };

            pessoas.Add("Pedro Henrique", 52);
            pessoas.Add("Raquel Soares", 68);

            pessoas["Pedro Henrique"] = 100;
            pessoas.Remove("Maria Celeste");
            pessoas.Clear();

            Console.WriteLine($"Número de pessoas: {pessoas.Count}\n");

            foreach (KeyValuePair<string, int> pessoa in pessoas) {
                Console.WriteLine($"Nome: {pessoa.Key}");
                Console.WriteLine($"Idade: {pessoa.Value}");
            }
        }
    }
}