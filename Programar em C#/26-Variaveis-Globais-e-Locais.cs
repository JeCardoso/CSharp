// Programar em C# #26 - Variáveis Globais e Locais

using System;

namespace Base {
    class VariaveisGlobaisELocais {
        string acesso = "Global";

        public void Run() {
            MudarAcesso();
            Console.WriteLine($"Acesso no exterior da função: {acesso}");
        }

        public void MudarAcesso() {
            string acesso = "Local";
            Console.WriteLine($"Acesso no interior da função: {acesso}");
        }
    }
}