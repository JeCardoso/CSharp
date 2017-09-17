// Programar em C# #11 - Listas

using System;
using System.Collections.Generic;
using System.Linq;

namespace Base {
    class Listas {
        public void Run() {
            List<string> cores = new List<string>();

            cores.Add("Azul");
            cores.Add("Verde");
            cores.Add("Amarelo");
            cores.Add("Vermelho");
            cores.Add("Laranja");

            cores.Remove("Laranja");
            cores.Reverse();
            cores.Sort();
            cores.Clear();

            Console.WriteLine($"Número de cores: {cores.Count}");
            // Console.WriteLine($"Primeira cor: {cores.First()}");
            // Console.WriteLine($"Última cor: {cores.Last()}");
        }
    }
}