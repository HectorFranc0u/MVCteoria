using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using firstApplication.Models;

namespace firstApplication.Controllers
{
    public class PartesAutosController : Controller
    {
        private readonly PartesAutosContext _context;

        public PartesAutosController(PartesAutosContext context)
        {
            _context = context;
        }

        // GET: PartesAutos
        public async Task<IActionResult> Index()
        {
            return View(await _context.PartesAutos.ToListAsync());
        }

        // GET: PartesAutos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var partesAutos = await _context.PartesAutos
                .FirstOrDefaultAsync(m => m.PartId == id);
            if (partesAutos == null)
            {
                return NotFound();
            }

            return View(partesAutos);
        }

        // GET: PartesAutos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PartesAutos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PartId,ParteNombre,ParteModelo,PartePrecio")] PartesAutos partesAutos)
        {
            if (ModelState.IsValid)
            {
                _context.Add(partesAutos);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(partesAutos);
        }

        // GET: PartesAutos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var partesAutos = await _context.PartesAutos.FindAsync(id);
            if (partesAutos == null)
            {
                return NotFound();
            }
            return View(partesAutos);
        }

        // POST: PartesAutos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PartId,ParteNombre,ParteModelo,PartePrecio")] PartesAutos partesAutos)
        {
            if (id != partesAutos.PartId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(partesAutos);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PartesAutosExists(partesAutos.PartId))
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
            return View(partesAutos);
        }

        // GET: PartesAutos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var partesAutos = await _context.PartesAutos
                .FirstOrDefaultAsync(m => m.PartId == id);
            if (partesAutos == null)
            {
                return NotFound();
            }

            return View(partesAutos);
        }

        // POST: PartesAutos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var partesAutos = await _context.PartesAutos.FindAsync(id);
            _context.PartesAutos.Remove(partesAutos);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PartesAutosExists(int id)
        {
            return _context.PartesAutos.Any(e => e.PartId == id);
        }
    }
}
