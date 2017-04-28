using AutoMapper;
using ProjetoLivraria.Business.Entities;
using ProjetoLivraria.MVC.ViewModels;

namespace ProjetoLivraria.MVC.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {

        public DomainToViewModelMappingProfile()
        {
            CreateMap<AutorViewModel, Autor>();
            CreateMap<EditoraViewModel, Editora>();
            CreateMap<LivroViewModel, Livro>();
        }

        public override string ProfileName
        {
            get { return "ViewModelToDomainMappings"; }
        }

    }
}