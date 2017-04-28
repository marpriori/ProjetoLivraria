using ProjetoLivraria.Business.Entities;
using System.Data.Entity.ModelConfiguration;

namespace ProjetoLivraria.Infra.Data.EntityConfig
{
    public class AutorConfiguration : EntityTypeConfiguration<Autor>
    {
        public AutorConfiguration()
        {
            HasKey(e => e.AutorId);

            Property(e => e.Nome)
                .IsRequired();
        }
    }
}
