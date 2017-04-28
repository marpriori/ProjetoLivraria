using System.Data.Entity.ModelConfiguration;
using ProjetoLivraria.Business.Entities;

namespace ProjetoLivraria.Infra.Data.EntityConfig
{
    public class EditoraConfiguration : EntityTypeConfiguration<Editora>
    {
        public EditoraConfiguration()
        {
            HasKey(u => u.EditoraId);

            Property(u => u.Nome)
                .IsRequired();
        }
    }
}
