// Programar em C# #56 - Classe Hashtable

using System;
using System.Collections;

namespace Base {
    class ClasseHashtable {
        private Hashtable pessoas = new Hashtable() {
            { "Nelson Silva", 21 },
            { "Maria Celeste", 37 }
        };

        public void Run() {
            pessoas.Add("Pedro Henrique", 52);
            pessoas.Add("Raquel Soares", 68);

            pessoas["Pedro Henrique"] = 100;
            pessoas.Remove("Maria Celeste");
            pessoas.Clear();

            Console.WriteLine($"Número de pessoas: {pessoas.Count}");

            foreach (DictionaryEntry pessoa in pessoas) {
                Console.WriteLine($"Nome: {pessoa.Key}");
                Console.WriteLine($"Idade: {pessoa.Value}");
            }
        }
    }
}