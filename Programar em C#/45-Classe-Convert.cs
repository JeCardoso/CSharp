// Programar em C# #45 - Classe Convert

using System;

namespace Base {
    class ClasseConvert {
        private string letra = "N", anoAtual = "2016";
        private char _letra = ' ';
        private int _anoAtual = 0;

        public void Run() {
            try {
                _letra = Convert.ToChar(letra);
                _anoAtual = Convert.ToInt32(anoAtual);
            }
            catch (Exception excecao) {
                Console.WriteLine(excecao);
            }
            finally {
                if (_letra != ' ')
                    Console.WriteLine($"Letra: {_letra}");

                if (_anoAtual != 0)
                    Console.WriteLine($"Ano atual: {_anoAtual}");
            }
        }
    }
}