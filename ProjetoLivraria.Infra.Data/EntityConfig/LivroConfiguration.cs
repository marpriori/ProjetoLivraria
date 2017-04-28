using ProjetoLivraria.Business.Entities;
using System.Data.Entity.ModelConfiguration;

namespace ProjetoLivraria.Infra.Data.EntityConfig
{
    public class LivroConfiguration : EntityTypeConfiguration<Livro>
    {
        public LivroConfiguration()
        {
            HasKey(e => e.LivroId);

            Property(e => e.Titulo)
                .IsRequired();

            Property(e => e.Ano)
                .IsRequired();
            
            HasRequired(e => e.Autor)
                .WithMany()
                .HasForeignKey(e => e.AutorId);

            HasRequired(e => e.Editora)
                .WithMany()
                .HasForeignKey(e => e.EditoraId);

        }
    }
}
