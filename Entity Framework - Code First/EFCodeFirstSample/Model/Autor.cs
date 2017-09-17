using System.Collections.Generic;

namespace EFCodeFirstSample.Model
{
    public class Autor
    {
        public Autor()
        {
            this.Livros = new List<Livro>();
        }

        public int Id { get; set; }
        public string Nome { get; set; }

        /* Tem uma lista de livros */
        public virtual ICollection<Livro> Livros { get; set; }
    }
}
