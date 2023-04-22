using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PracticaMVC.Models;

namespace PracticaMVC.Controllers
{
    public class estados_EquipoController : Controller
    {
        private readonly equiposDbContext _context;

        public estados_EquipoController(equiposDbContext context)
        {
            _context = context;
        }


        public async Task<IActionResult> Index()
        {
              return _context.estados_Equipo != null ? 
                          View(await _context.estados_Equipo.ToListAsync()) :
                          Problem("Entity set 'equiposDbContext.estados_Equipo'  is null.");
        }


        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.estados_Equipo == null)
            {
                return NotFound();
            }

            var estados_Equipo = await _context.estados_Equipo
                .FirstOrDefaultAsync(m => m.id_estados_equipo == id);
            if (estados_Equipo == null)
            {
                return NotFound();
            }

            return View(estados_Equipo);
        }


        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id_estados_equipo,descripcion,estado")] estados_Equipo estados_Equipo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(estados_Equipo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(estados_Equipo);
        }

        // GET: estados_Equipo/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.estados_Equipo == null)
            {
                return NotFound();
            }

            var estados_Equipo = await _context.estados_Equipo.FindAsync(id);
            if (estados_Equipo == null)
            {
                return NotFound();
            }
            return View(estados_Equipo);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id_estados_equipo,descripcion,estado")] estados_Equipo estados_Equipo)
        {
            if (id != estados_Equipo.id_estados_equipo)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(estados_Equipo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!estados_EquipoExists(estados_Equipo.id_estados_equipo))
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
            return View(estados_Equipo);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.estados_Equipo == null)
            {
                return NotFound();
            }

            var estados_Equipo = await _context.estados_Equipo
                .FirstOrDefaultAsync(m => m.id_estados_equipo == id);
            if (estados_Equipo == null)
            {
                return NotFound();
            }

            return View(estados_Equipo);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.estados_Equipo == null)
            {
                return Problem("Entity set 'equiposDbContext.estados_Equipo'  is null.");
            }
            var estados_Equipo = await _context.estados_Equipo.FindAsync(id);
            if (estados_Equipo != null)
            {
                _context.estados_Equipo.Remove(estados_Equipo);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool estados_EquipoExists(int id)
        {
          return (_context.estados_Equipo?.Any(e => e.id_estados_equipo == id)).GetValueOrDefault();
        }
    }
}
