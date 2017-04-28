using System.Data.Entity.Migrations;

namespace ProjetoLivraria.Infra.Data.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<Contexto.ProjetoLivrariaContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Contexto.ProjetoLivrariaContext context)
        {
           
        }
    }
}
