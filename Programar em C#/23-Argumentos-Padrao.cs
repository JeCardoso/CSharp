// Programar em C# #23 - Argumentos Padrão

using System;

namespace Base {
    class ArgumentosPadrao {
        public void Run() {
            EstadoDaPorta(false);
        }

        public void EstadoDaPorta(bool estado = true) {
            if (estado)
                Console.WriteLine("A porta está aberta!");
            else
                Console.WriteLine("A porta está fechada!");
        }
    }
}