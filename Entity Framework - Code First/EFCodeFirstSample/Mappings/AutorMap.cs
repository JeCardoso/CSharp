using EFCodeFirstSample.Model;
using System.Data.Entity.ModelConfiguration;

namespace EFCodeFirstSample.Mappings
{
    public class AutorMap : EntityTypeConfiguration<Autor>
    {
        public AutorMap()
        {
            /* Mapear a tabela autor */
            ToTable("Autor");

            /* Que tenha o ID */
            HasKey(x => x.Id);

            /* Define valor obrigatório para nome */
            Property(x => x.Nome).HasMaxLength(80).IsRequired();

            /* relacionamento N para N com tabela livros */
            HasMany(x => x.Livros)
                .WithMany(x => x.Autores)
                .Map(x => x.ToTable("LivroAutor"));
        }
    }
}
