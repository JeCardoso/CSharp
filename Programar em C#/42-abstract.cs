// Programar em C# #42 - abstract

using System;
using System.Collections.Generic;

namespace Base {
    class Abstract {
        public void Run() {
            // ClasseX.InformacaoX();
            var classe = new ClasseY();
            classe.InformacaoY();
        }
    }

    abstract class ClasseX {
        public static string organizacao = "Caffeine Algorithm";
        public static List<string> paises = new List<string>() {
            "Portugal",
            "Brasil",
            "Espanha",
            "França",
            "Itália",
            "Austrália",
            "Índia"
        };

        public static void InformacaoX() {
            foreach (var carater in organizacao)
                Console.WriteLine($"Carater: {carater}");
        }

        public abstract void InformacaoY();
    }

    class ClasseY : ClasseX {
        public override void InformacaoY() {
            foreach (var pais in paises)
                Console.WriteLine($"País: {pais}");
        }
    }
}