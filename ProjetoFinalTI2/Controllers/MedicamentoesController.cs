using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProjetoFinalTI2.Data;
using ProjetoFinalTI2.Models;

namespace ProjetoFinalTI2.Controllers
{
    public class MedicamentoesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MedicamentoesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Medicamentoes
        public async Task<IActionResult> Index()
        {
            return View(await _context.Medicamento.ToListAsync());
        }

        // GET: Medicamentoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var medicamento = await _context.Medicamento
                .FirstOrDefaultAsync(m => m.MedicId == id);
            if (medicamento == null)
            {
                return NotFound();
            }

            return View(medicamento);
        }

        // GET: Medicamentoes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Medicamentoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MedicId,Nome,Preco")] Medicamento medicamento)
        {
            if (ModelState.IsValid)
            {
                _context.Add(medicamento);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(medicamento);
        }

        // GET: Medicamentoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var medicamento = await _context.Medicamento.FindAsync(id);
            if (medicamento == null)
            {
                return NotFound();
            }
            return View(medicamento);
        }

        // POST: Medicamentoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MedicId,Nome,Preco")] Medicamento medicamento)
        {
            if (id != medicamento.MedicId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(medicamento);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MedicamentoExists(medicamento.MedicId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(medicamento);
        }

        // GET: Medicamentoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var medicamento = await _context.Medicamento
                .FirstOrDefaultAsync(m => m.MedicId == id);
            if (medicamento == null)
            {
                return NotFound();
            }

            return View(medicamento);
        }

        // POST: Medicamentoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var medicamento = await _context.Medicamento.FindAsync(id);
            _context.Medicamento.Remove(medicamento);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MedicamentoExists(int id)
        {
            return _context.Medicamento.Any(e => e.MedicId == id);
        }
    }
}
