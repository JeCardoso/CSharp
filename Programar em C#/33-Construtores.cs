// Programar em C# #33 - Construtores

using System;

namespace Base {
    class Construtores {
        string primeiroNome = string.Empty, ultimoNome = string.Empty;
        int idade = 0;

        public Construtores(string primeiroNome, string ultimoNome, int idade) {
            this.primeiroNome = primeiroNome;
            this.ultimoNome = ultimoNome;
            this.idade = idade;
        }

        public void Informacao() {
            Console.WriteLine($"Nome: {primeiroNome} {ultimoNome}");
            Console.WriteLine($"Idade: {idade}");
        }

        public void VerificarEntrada() {
            if (idade >= 18)
                Console.WriteLine("Esta pessoa pode entrar no local porque tem mais de 18 anos!");
            else
                Console.WriteLine("Esta pessoa não pode entrar no local porque tem menos de 18 anos!");
        }
    }
}