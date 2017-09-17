using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DVC_MvcCodeFirst.Models
{
    public class Professor
    {
        [Key, Column(Order = 0)]
        public int IDProfessor { get; set; }

        [Required(ErrorMessage ="Digite o nome do professor."), Column(Order =1)]
        [MinLength(8, ErrorMessage ="Digite um nome com no mínimo 8 caracteres.")]
        public string Nome { get; set; }

        public string Telefone { get; set; }

        [DisplayFormat(DataFormatString ="{0:n2}",ApplyFormatInEditMode =true, NullDisplayText ="sem remuneração")]
        [Range(1200, 25000, ErrorMessage ="O salário deverá ser entre 1200 e 25000")]
        public decimal? Salario { get; set; }

        [Display(Name ="Twitter/Blog")]
        [Column("ContatoDigital", Order =5)]
        public string TwitterBlog { get; set; }

        public string Materia { get; set; }

        public bool Disponivel { get; set; }

        [DisplayFormat(DataFormatString ="{0:dd/MM/yyyy}")]
        public DateTime? Admissao { get; set; }

        // Chave estrangeira
        public List<Aluno> Alunos { get; set; }

        public List<Topico> Topicos { get; set; }

    }
}