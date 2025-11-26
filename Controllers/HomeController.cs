using DunkStore.Data;
using DunkStore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace DunkStore.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context; 

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index(string categoriaSelecionada)
        {
            // Busca produtos e inclui a categoria
            var produtos = from p in _context.Produtos.Include(c => c.Categoria)
                           select p;

            if (!string.IsNullOrEmpty(categoriaSelecionada))
            {
                produtos = produtos.Where(p => p.Categoria.Nome == categoriaSelecionada);
            }

       
            ViewBag.Categorias = await _context.Categorias.ToListAsync();

            return View(await produtos.ToListAsync());
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) return NotFound();

            var produto = await _context.Produtos
                .Include(p => p.Categoria)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (produto == null) return NotFound();

            return View(produto);
        }

      
    }
}
