using AutoMapper;
using ProjetoLivraria.Business.Entities;
using ProjetoLivraria.MVC.ViewModels;

namespace ProjetoLivraria.MVC.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<Autor, AutorViewModel>();
            CreateMap<Editora, EditoraViewModel>();
            CreateMap<Livro, LivroViewModel>();
        }

        public override string ProfileName
        {
            get { return "DomainToViewModelMappings"; }
        }
    }
}