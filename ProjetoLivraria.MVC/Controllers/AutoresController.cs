using AutoMapper;
using ProjetoLivraria.Business.Entities;
using ProjetoLivraria.Business.Interfaces.Services;
using ProjetoLivraria.MVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoLivraria.MVC.Controllers
{
    public class AutoresController : Controller
    {
        private readonly IAutorService _autorService;

        public AutoresController(IAutorService autorService)
        {
            _autorService = autorService;
        }

        // GET: Autores
        public ActionResult Index()
        {
            var autorViewModel = Mapper.Map<IEnumerable<Autor>, IEnumerable<AutorViewModel>>(_autorService.GetAll());
            return View(autorViewModel);
        }

        // GET: Autores/Details/5
        public ActionResult Details(int id)
        {
            var autor = _autorService.GetById(id);
            var autorViewModel = Mapper.Map<Autor, AutorViewModel>(autor);

            return View(autorViewModel);
        }

        // GET: Autores/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Autores/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(AutorViewModel autor)
        {
            if (!ModelState.IsValid) return View(autor);

            var autorBusiness = Mapper.Map<AutorViewModel, Autor>(autor);
            _autorService.Add(autorBusiness);

            return RedirectToAction("Index");
        }

        // GET: Autores/Edit/5
        public ActionResult Edit(int id)
        {
            var autor = _autorService.GetById(id);
            var autorViewModel = Mapper.Map<Autor, AutorViewModel>(autor);

            return View(autorViewModel);
        }

        // POST: Autores/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(AutorViewModel autor)
        {
            if (!ModelState.IsValid) return View(autor);

            var autorBusiness = Mapper.Map<AutorViewModel, Autor>(autor);
            _autorService.Update(autorBusiness);

            return RedirectToAction("Index");
        }

        // GET: Autores/Delete/5
        public ActionResult Delete(int id)
        {
            var autor = _autorService.GetById(id);
            var autorViewModel = Mapper.Map<Autor, AutorViewModel>(autor);

            return View(autorViewModel);
        }

        // POST: Autores/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var autor = _autorService.GetById(id);
            try
            {
                _autorService.Remove(autor);
            }
            catch (Exception ex)
            {
                if (((SqlException)ex.InnerException.InnerException).Number == 547)
                    ViewBag.Error = "Não foi possível excluir o registro, ele possui vinculo com outra tabela.";

                var autorViewModel = Mapper.Map<Autor, AutorViewModel>(autor);
                return View(autorViewModel);
            }
            return RedirectToAction("Index");
        }
    }
}
