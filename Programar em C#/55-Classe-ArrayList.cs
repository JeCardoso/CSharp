// Programar em C# #55 - Classe ArrayList

using System;
using System.Collections;

namespace Base {
    class ClasseArrayList {
        private ArrayList materiaisEscolares = new ArrayList() {
            "Mochila",
            "Estojo",
            "Lápis",
            "Borracha"
        };

        public void Run() {
            materiaisEscolares.Add("Afia");
            materiaisEscolares.Add("Tesoura");

            materiaisEscolares.Remove("Mochila");
            materiaisEscolares.Reverse();
            materiaisEscolares.Clear();

            Console.WriteLine($"Número de materiais escolares: {materiaisEscolares.Count}");

            foreach (var materialEscolar in materiaisEscolares)
                Console.WriteLine($"Material escolar: {materialEscolar}");
        }
    }
}