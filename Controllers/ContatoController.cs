using Microsoft.AspNetCore.Mvc;

namespace SaborDeCasa.Controllers
{
    public class ContatoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}