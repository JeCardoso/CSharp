using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace DVC_MvcCodeFirst.Models
{
    public class BancoContexto : DbContext
    {
        // Passa o banco de dados que deve conectar
        public BancoContexto():base("ConnDB"){
            
        }

        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Professor> Professores { get; set; }
        public DbSet<Topico> Topicos { get; set; }

        

    }
}