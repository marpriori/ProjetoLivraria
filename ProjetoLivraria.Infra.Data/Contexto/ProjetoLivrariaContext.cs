using ProjetoLivraria.Business.Entities;
using ProjetoLivraria.Infra.Data.EntityConfig;
using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;

namespace ProjetoLivraria.Infra.Data.Contexto
{
    public class ProjetoLivrariaContext : DbContext
    {

        public ProjetoLivrariaContext()
            : base("ProjetoLivraria")
        {
            var instance = System.Data.Entity.SqlServer.SqlProviderServices.Instance;
        }

        public IDbSet<Autor> Autores { get; set; }
        public IDbSet<Editora> Editoras { get; set; }
        public IDbSet<Livro> Livros { get; set; }
        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Database.SetInitializer<ProjetoModeloContext>(null);

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties()
                .Where(p => p.Name == p.ReflectedType.Name + "Id")
                .Configure(p => p.IsKey());

            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));

            modelBuilder.Properties<string>()
                .Configure(p => p.HasMaxLength(250));

            modelBuilder.Configurations.Add(new AutorConfiguration());
            modelBuilder.Configurations.Add(new EditoraConfiguration());
            modelBuilder.Configurations.Add(new LivroConfiguration());
            
            base.OnModelCreating(modelBuilder);
        }

        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("DataCadastro") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("DataCadastro").CurrentValue = DateTime.Now;
                }

                if (entry.State == EntityState.Modified)
                {
                    entry.Property("DataCadastro").IsModified = false;
                }
            }
            return base.SaveChanges();
        }

    }

}
