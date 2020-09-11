
using Microsoft.AspNetCore.Mvc;
using SaborDeCasa.Repositories;
using System.Linq;

namespace SaborrDeCasa.Components
{
    public class CategoriaMenu : ViewComponent
    {
        private readonly ICategoriaRepository _categoriaRepository;
        public CategoriaMenu(ICategoriaRepository categoriaRepository)
        {
            _categoriaRepository = categoriaRepository;
        }

        public IViewComponentResult Invoke()
        {
            var categorias = _categoriaRepository.Categorias.OrderBy(p => p.CategoriaNome);
            return View(categorias);
        }
    }
}
