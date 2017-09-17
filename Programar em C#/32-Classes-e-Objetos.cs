// Programar em C# #32 - Classes e Objetos

using System;

namespace Base {
    class ClassesEObjetos {
        int vidas = 5;

        public void Ataque() {
            Console.WriteLine("Eu fui atacado e perdi uma vida!");
            vidas -= 1;
        }

        public void VerificarVida() {
            if (vidas <= 0)
                Console.WriteLine("Eu estou morto porque não tenho mais vidas!");
            else
                Console.WriteLine($"Eu ainda estou em combate e tenho {vidas} vidas!");
        }
    }
}