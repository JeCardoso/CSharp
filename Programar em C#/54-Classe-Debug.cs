// Programar em C# #54 - Classe Debug

using System.Diagnostics;

namespace Base {
    class ClasseDebug {
        private string[] cores = new string[] {
            "Azul",
            "Verde",
            "Amarelo",
            "Vermelho",
            "Laranja"
        };

        public void Run() {
            for (int indice = 0; indice < cores.Length; indice++)
                Debug.WriteLine($"cores[{indice}]: {cores[indice]}");
        }
    }
}