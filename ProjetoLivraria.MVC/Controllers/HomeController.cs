using AutoMapper;
using ProjetoLivraria.Business.Entities;
using ProjetoLivraria.Business.Interfaces.Services;
using ProjetoLivraria.MVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoLivraria.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILivroService _livroService;
        private readonly IAutorService _autorService;
        private readonly IEditoraService _editoraService;

        public HomeController(ILivroService livroService, IAutorService autorService, IEditoraService editoraService)
        {
            _livroService = livroService;
            _autorService = autorService;
            _editoraService = editoraService;
        }

        public ActionResult Index()
        {
            var model = new HomeViewModel();
            model.QuantidadeLivro = _livroService.GetAll().Count();
            model.QuantidadeAutor = _autorService.GetAll().Count();
            model.QuantidadeEditora = _editoraService.GetAll().Count();

            var livros = _livroService.BuscarUltimosLivrosCadastrados(3);
            model.UltimosLivros = Mapper.Map<IEnumerable<Livro>, IEnumerable<LivroViewModel>>(livros);

            var autores = _autorService.ListarPrincipais();
            model.PrincipaisAutores = Mapper.Map<IDictionary<Autor, int>, IDictionary<AutorViewModel, int>>(autores);

            return View(model);
        }

    }
}