using System;
using System.Configuration;
using System.IO;

namespace Mini.Classes
{
    public static class Minificador
    {
        public static string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["principal"].ConnectionString;
        }

        public static void Executar(string[] args)
        {
            var origem = string.Empty;
            var destino = string.Empty;

            for (int i = 0; i < args.Length; i++)
            {
                if (args[i].StartsWith("/o="))
                {
                    origem = args[i].Split('=')[1];
                }
                else if (args[i].StartsWith("/d="))
                {
                    destino = args[i].Split('=')[1];
                }
            }

            var dadosOrigem = File.ReadAllText(origem);
            var dadosDestino = dadosOrigem.Replace(Environment.NewLine, "");
            dadosDestino = string.Join(" ", dadosDestino.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries));

            File.WriteAllText(destino, dadosDestino);
        }
    }
}
