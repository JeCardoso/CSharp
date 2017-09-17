// Programar em C# #61 - Métodos III

using System;

namespace Base {
    class MetodosIII {
        private string abecedario = "ABCDEFGHIJKLMNOPQRSTUVXWYZ", nome = "Nelson | Silva";

        public void Run() {
            // Remove()
            Console.WriteLine($"Abecedário até à letra N: {abecedario.Remove(14)}");

            var indiceX = nome.IndexOf(' ');
            var indiceY = nome.IndexOf(' ', indiceX + 1);
            Console.WriteLine($"Nome: {nome.Remove(indiceX, indiceY - indiceX)}");

            // Replace()
            var lingProgPreferida = "A minha linguagem de programação preferida já foi o C#!";
            Console.WriteLine(lingProgPreferida.Replace("já foi", "é"));
        }
    }
}