﻿using AutoMapper;
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
    public class EditorasController : Controller
    {
        private readonly IEditoraService _editoraService;

        public EditorasController(IEditoraService editoraService)
        {
            _editoraService = editoraService;
        }

        // GET: Editoraes
        public ActionResult Index()
        {
            var editoraViewModel = Mapper.Map<IEnumerable<Editora>, IEnumerable<EditoraViewModel>>(_editoraService.GetAll());
            return View(editoraViewModel);
        }

        // GET: Editoraes/Details/5
        public ActionResult Details(int id)
        {
            var editora = _editoraService.GetById(id);
            var editoraViewModel = Mapper.Map<Editora, EditoraViewModel>(editora);

            return View(editoraViewModel);
        }

        // GET: Editoraes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Editoraes/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(EditoraViewModel editora)
        {
            if (!ModelState.IsValid) return View(editora);

            var editoraBusiness = Mapper.Map<EditoraViewModel, Editora>(editora);
            _editoraService.Add(editoraBusiness);

            return RedirectToAction("Index");
        }

        // GET: Editoraes/Edit/5
        public ActionResult Edit(int id)
        {
            var editora = _editoraService.GetById(id);
            var editoraViewModel = Mapper.Map<Editora, EditoraViewModel>(editora);

            return View(editoraViewModel);
        }

        // POST: Editoraes/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(EditoraViewModel editora)
        {
            if (!ModelState.IsValid) return View(editora);

            var editoraBusiness = Mapper.Map<EditoraViewModel, Editora>(editora);
            _editoraService.Update(editoraBusiness);

            return RedirectToAction("Index");
        }

        // GET: Editoraes/Delete/5
        public ActionResult Delete(int id)
        {
            var editora = _editoraService.GetById(id);
            var editoraViewModel = Mapper.Map<Editora, EditoraViewModel>(editora);

            return View(editoraViewModel);
        }

        // POST: Editoraes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var editora = _editoraService.GetById(id);
            _editoraService.Remove(editora);
            return RedirectToAction("Index");
        }
    }
}
