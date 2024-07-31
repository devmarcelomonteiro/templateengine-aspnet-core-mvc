using Application.DTOs;
using Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace VendasWebMvcCore.Controllers
{
    public class DepartamentoController : Controller
    {
        private readonly IDepartamentoService _departamentoService;

        public DepartamentoController(IDepartamentoService departamentoService)
        {
            _departamentoService = departamentoService;
        }

        public async Task<IActionResult> Index()
        {
            var departamentos = await _departamentoService.GetAllAsync();
            return View(departamentos);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(DepartamentoDto departamentoDto)
        {
            if (ModelState.IsValid)
            {
                await _departamentoService.AddAsync(departamentoDto);
                return RedirectToAction(nameof(Index));
            }
            return View(departamentoDto);
        }

    }
}
