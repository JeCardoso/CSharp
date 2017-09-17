using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            var pessoa = new Pessoa() {Nome = "João", Idade = 20 };
            var equipamento = new Equipamento() { Descricao = "Chave de Fenda", Marca = "F20", Modelo = "Tramontina" };
            var livro = new Livro() {Titulo="Harry Potter", Lancamento = new DateTime(2004,10,27) };

            Console.WriteLine(Log(pessoa));
            Console.WriteLine(Log(equipamento));
            Console.WriteLine(Log(livro));
     
            Console.ReadKey();
        }

        public static string Log(object obj)
        {
            var tipo = obj.GetType();

            var builder = new StringBuilder();
            builder.AppendLine("Data do log: " + DateTime.Now);
            builder.AppendLine(tipo.ToString());

            foreach (var p in tipo.GetProperties())
            {
                builder.AppendLine(p.Name + ": "+ p.GetValue(obj));
            }
            return builder.ToString();
        } 

    }

    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
    }

    public class Equipamento
    {
        public string Descricao { get; set; }
        public string Modelo { get; set; }
        public string Marca { get; set; }
    }

    public class Livro
    {
        public string Titulo { get; set; }
        public DateTime Lancamento { get; set; }
    }
}
