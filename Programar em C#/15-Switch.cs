// Programar em C# #15 - Switch

using System;

namespace Base {
    class Switch {
        public void Run() {
            char caso = 'D';

            switch (caso) {
                case 'A':
                    Console.WriteLine("O caso A existe!");
                    break;
                case 'B':
                    Console.WriteLine("O caso B existe!");
                    break;
                case 'C':
                    Console.WriteLine("O caso C existe!");
                    break;
                default:
                    Console.WriteLine($"O caso {caso} não existe!");
                    break;
            }
        }
    }
}