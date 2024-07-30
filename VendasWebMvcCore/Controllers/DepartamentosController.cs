using Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace VendasWebMvcCore.Controllers
{
    public class DepartamentosController : Controller
    {

        private readonly IDepartamentoService _departamentoService;

        public DepartamentosController(IDepartamentoService departamentoService)
        {
            _departamentoService = departamentoService;
        }

        public async Task<IActionResult> Index()
        {
            var produtos = await _departamentoService.GetAllAsync();
            return View(produtos);
        }
    }
}
