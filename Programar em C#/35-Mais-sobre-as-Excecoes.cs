// Programar em C# #35 - Mais sobre as Exceções

using System;

namespace Base {
    class MaisSobreAsExcecoes {
        private Exception stringVazia = new Exception("Não se pode verificar uma string que esteja vazia!");

        public void Run() {
            try {
                VerificarString("");
            }
            catch (Exception exception) {
                Console.WriteLine(exception);
            }
        }

        private void VerificarString(string _string) {
            if (_string == string.Empty)
                throw stringVazia;
        }
    }
}