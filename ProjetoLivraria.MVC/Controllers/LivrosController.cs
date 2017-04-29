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
    public class LivrosController : Controller
    {
        private readonly ILivroService _livroService;
        private readonly IAutorService _autorService;
        private readonly IEditoraService _editoraService;

        public LivrosController(ILivroService livroService, IAutorService autorService, IEditoraService editoraService)
        {
            _livroService = livroService;
            _autorService = autorService;
            _editoraService = editoraService;
        }

        // GET: Livros
        public ActionResult Index()
        {
            var livroViewModel = Mapper.Map<IEnumerable<Livro>, IEnumerable<LivroViewModel>>(_livroService.GetAll());
            return View(livroViewModel);
        }

        // GET: Livros/Details/5
        public ActionResult Details(int id)
        {
            var livro = _livroService.GetById(id);
            var livroViewModel = Mapper.Map<Livro, LivroViewModel>(livro);

            return View(livroViewModel);
        }

        // GET: Livros/Create
        public ActionResult Create()
        {
            ViewBag.AutorId = new SelectList(_autorService.GetAll(), "AutorId", "Nome");
            ViewBag.EditoraId = new SelectList(_editoraService.GetAll(), "EditoraId", "Nome");
            return View();
        }

        // POST: Livros/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(LivroViewModel livro)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.AutorId = new SelectList(_autorService.GetAll(), "AutorId", "Nome", livro.AutorId);
                ViewBag.EditoraId = new SelectList(_editoraService.GetAll(), "EditoraId", "Nome", livro.EditoraId);
                return View(livro);
            }

            var livroBusiness = Mapper.Map<LivroViewModel, Livro>(livro);
            _livroService.Add(livroBusiness);

            return RedirectToAction("Index");
        }

        // GET: Livros/Edit/5
        public ActionResult Edit(int id)
        {
            var livro = _livroService.GetById(id);
            var livroViewModel = Mapper.Map<Livro, LivroViewModel>(livro);

            ViewBag.AutorId = new SelectList(_autorService.GetAll(), "AutorId", "Nome", livro.AutorId);
            ViewBag.EditoraId = new SelectList(_editoraService.GetAll(), "EditoraId", "Nome", livro.EditoraId);

            return View(livroViewModel);
        }

        // POST: Livros/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(LivroViewModel livro)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.AutorId = new SelectList(_autorService.GetAll(), "AutorId", "Nome", livro.AutorId);
                ViewBag.EditoraId = new SelectList(_editoraService.GetAll(), "EditoraId", "Nome", livro.EditoraId);

                return View(livro);
            }
            var livroBusiness = Mapper.Map<LivroViewModel, Livro>(livro);
            _livroService.Update(livroBusiness);

            return RedirectToAction("Index");
        }

        // GET: Livros/Delete/5
        public ActionResult Delete(int id)
        {
            var livro = _livroService.GetById(id);
            var livroViewModel = Mapper.Map<Livro, LivroViewModel>(livro);

            return View(livroViewModel);
        }

        // POST: Livros/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var livro = _livroService.GetById(id);
            _livroService.Remove(livro);
            return RedirectToAction("Index");
        }
    }
}
