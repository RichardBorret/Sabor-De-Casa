﻿
using Microsoft.AspNetCore.Mvc;
using SaborDeCasa.Models;
using SaborDeCasa.Repositories;
using SaborDeCasa.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SaborDeCasa.Controllers
{
    public class LancheController : Controller
    {
        private ICategoriaRepository _categoriaRepository { get; }
        private readonly ILancheRepository _lancheRepository;

        public LancheController(ICategoriaRepository categoriaRepository, ILancheRepository lancheRepository)
        {
            _categoriaRepository = categoriaRepository;
            _lancheRepository = lancheRepository;
        }

        public IActionResult List(string categoria)
        {
            //ViewBag.Categoria1 = "Categoria 1";
            //ViewData["Categoria2"] = "Categoria 2";

            //LancheListViewModel vm = new LancheListViewModel();
            //vm.Lanches = _lancheRepository.Lanches;
            //vm.CategoriaAtual = "Categoria do Lanche";

            //return View(vm);

            string _categoria = categoria;
            IEnumerable<Lanche> lanches;
            string categoriaAtual = string.Empty;

            if (string.IsNullOrEmpty(categoria))
            {
                lanches = _lancheRepository.Lanches.OrderBy(p => p.LancheId);
                categoriaAtual = "Todos os lanches";
            }
            else
            {
                if (string.Equals("Normal", _categoria, StringComparison.OrdinalIgnoreCase))
                    lanches = _lancheRepository.Lanches.Where(p => p.Categoria.CategoriaNome.Equals("Normal")).OrderBy(p => p.Nome);
                else
                    lanches = _lancheRepository.Lanches.Where(p => p.Categoria.CategoriaNome.Equals("Natural")).OrderBy(p => p.Nome);

                categoriaAtual = _categoria;
            }

            var lancheListViewModel= new LancheListViewModel
            {
                Lanches = lanches,
                CategoriaAtual = categoriaAtual
            };

            return View(lancheListViewModel);
        }

        public ViewResult Search(string searchString)
        {
            string _searchString = searchString;
            IEnumerable<Lanche> lanches;
            string currentCategory = string.Empty;

            if (string.IsNullOrEmpty(_searchString))
            {
                lanches = _lancheRepository.Lanches.OrderBy(p => p.LancheId);
            }
            else
            {
                lanches = _lancheRepository.Lanches.Where(p => p.Nome.ToLower().Contains(_searchString.ToLower()));
            }

            return View("~/Views/Lanche/List.cshtml", new LancheListViewModel { Lanches = lanches, CategoriaAtual = "Todos os lanches" });
        }

        public ViewResult Details(int lancheId)
        {
            var lanche = _lancheRepository.Lanches.FirstOrDefault(d => d.LancheId == lancheId);
            if (lanche == null)
            {
                return View("~/Views/Error/Error.cshtml");
            }
            return View(lanche);
        }
    }
}