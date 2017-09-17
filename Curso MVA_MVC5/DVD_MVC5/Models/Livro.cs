using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DVD_MVC5.Models
{
    public class Livro
    {

        [Key]
        public int IDLivro { get; set; }
        [Required(ErrorMessage ="Digite o título do livro")]
        [StringLength(100, ErrorMessage = "O tamanho máximo de caractere é {1}.", MinimumLength = 6)]
        public string Titulo { get; set; }
        [Required(ErrorMessage = "Digite o autor do livro")]
        public string Autor { get; set; }
        public decimal Preco { get; set; }
        public int Estoque { get; set; }
        public bool Disponivel { get; set; }



    }
}