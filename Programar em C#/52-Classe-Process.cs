// Programar em C# #52 - Classe Process

using System;
using System.Diagnostics;
using System.Linq;

namespace Base {
    class ClasseProcess {
        // private Process processo;
        private Process[] processos;

        public void Run() {
            /* processo = Process.Start("notepad.exe");
            processo.Kill(); */

            /* Console.Write("Pesquisar por: ");
            var pesquisa = Console.ReadLine();
            PesquisarNoGoogle(pesquisa); */

            processos = Process.GetProcessesByName("chrome");
            Console.WriteLine($"Número de processos: {processos.Count()}");

            foreach (var processo in processos)
                Console.WriteLine($"Nome do processo: {processo.ProcessName}");
        }

        private void PesquisarNoGoogle(string pesquisa) {
            Process.Start($"https://www.google.com/search?q={pesquisa}");
        }
    }
}