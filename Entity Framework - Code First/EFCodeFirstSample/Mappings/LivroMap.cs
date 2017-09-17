using EFCodeFirstSample.Model;
using System.Data.Entity.ModelConfiguration;

namespace EFCodeFirstSample.Mappings
{
    public class LivroMap : EntityTypeConfiguration<Livro>
    {
        public LivroMap()
        {
            ToTable("Livro");

            HasKey(x => x.Id);

            Property(x => x.Titulo)
                .HasMaxLength(80)
                .IsRequired();

            /* 1 para N */
            HasMany(x => x.Autores);
            /* Obrigatória uma categoria */
            HasRequired(x => x.Categoria);
        }
    }
}
