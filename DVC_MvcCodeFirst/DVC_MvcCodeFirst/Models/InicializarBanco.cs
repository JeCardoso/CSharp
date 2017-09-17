using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace DVC_MvcCodeFirst.Models
{
    // Recria o banco toda vez que inicializar
    public class InicializarBanco : DropCreateDatabaseAlways<BancoContexto>
    {
        // Alimenta o banco de dados
        protected override void Seed(BancoContexto context) {
            new List<Professor>
            {
                new Professor {
                    Nome ="Renato Hadada" ,
                    Materia = "ASP.NET MVC",
                    Salario = 4000,
                    Telefone = "45986325",
                    TwitterBlog = "http://asp.net/renatohaddad",
                    Disponivel = true,
                    Admissao = new DateTime(2012, 05, 01),
                    Alunos = new List<Aluno> {
                        new Aluno
                        {
                            NomeAluno = "Bruno",
                            Email = "bruno@msn.com",
                            Aprovado = false,
                            Ano = 2013,
                            Inscricao = new DateTime(2014, 03, 01)
                        },
                        new Aluno
                        {
                            NomeAluno = "Rafael",
                            Email = "rafael@msn.com",
                            Aprovado = false,
                            Ano = 2014,
                            Inscricao = new DateTime(2014, 03, 23)
                        }
                    },
                    Topicos = new List<Topico> {
                        new Topico {Descricao = "topico 1" },
                        new Topico {Descricao = "topico 2" }
                    }
                },
                new Professor {
                    Nome ="Gui Castro" ,
                    Materia = "C# basico",
                    Salario = 3100,
                    Telefone = "459854515",
                    TwitterBlog = "http://asp.net/guicastro",
                    Disponivel = true,
                    Admissao = new DateTime(2015, 07, 01),
                    Alunos = new List<Aluno> {
                        new Aluno
                        {
                            NomeAluno = "Abel",
                            Email = "abel@msn.com",
                            Aprovado = true,
                            Ano = 2015,
                            Inscricao = new DateTime(2015, 10, 01)
                        },
                        new Aluno
                        {
                            NomeAluno = "Caim",
                            Email = "caim@msn.com",
                            Aprovado = false,
                            Ano = 2016,
                            Inscricao = new DateTime(2016, 12, 01)
                        }
                    },
                    Topicos = new List<Topico> {
                        new Topico {Descricao = "topico 3" },
                        new Topico {Descricao = "topico 4" }
                    }
                }
            }.ForEach(p => context.Professores.Add(p)); // Adiciona cada elemento ao banco de dados

            base.Seed(context);
        }
    }
}