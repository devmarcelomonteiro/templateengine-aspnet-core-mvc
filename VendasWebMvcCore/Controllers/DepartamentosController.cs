using Microsoft.AspNetCore.Mvc;

namespace VendasWebMvcCore.Controllers
{
    public class DepartamentosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
