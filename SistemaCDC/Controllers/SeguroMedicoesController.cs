using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SistemaCDC.Data;
using SistemaCDC.Models;

namespace SistemaCDC.Controllers
{
    public class SeguroMedicoesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SeguroMedicoesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: SeguroMedicoes      
        public async Task<IActionResult> Index()
        {
             return View(await _context.SeguroMedico.ToListAsync());
            //return View(await _context.Users.ToListAsync());
        }

        // GET: SeguroMedicoes/Details/5
        
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var seguroMedico = await _context.SeguroMedico
                .SingleOrDefaultAsync(m => m.SeguroID == id);
            if (seguroMedico == null)
            {
                return NotFound();
            }

            return View(seguroMedico);
        }

        // GET: SeguroMedicoes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: SeguroMedicoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SeguroID,Nombre,Apellidos,Sexo,Edad,FechaNacimemto,NombrePadre,Estado")] SeguroMedico seguroMedico)
        {
            if (ModelState.IsValid)
            {
                _context.Add(seguroMedico);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(seguroMedico);
        }

        // GET: SeguroMedicoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var seguroMedico = await _context.SeguroMedico.SingleOrDefaultAsync(m => m.SeguroID == id);
            if (seguroMedico == null)
            {
                return NotFound();
            }
            return View(seguroMedico);
        }

        // POST: SeguroMedicoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("SeguroID,Nombre,Apellidos,Sexo,Edad,FechaNacimemto,NombrePadre,Estado")] SeguroMedico seguroMedico)
        {
            if (id != seguroMedico.SeguroID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(seguroMedico);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SeguroMedicoExists(seguroMedico.SeguroID))
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
            return View(seguroMedico);
        }

        // GET: SeguroMedicoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var seguroMedico = await _context.SeguroMedico
                .SingleOrDefaultAsync(m => m.SeguroID == id);
            if (seguroMedico == null)
            {
                return NotFound();
            }

            return View(seguroMedico);
        }

        // POST: SeguroMedicoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var seguroMedico = await _context.SeguroMedico.SingleOrDefaultAsync(m => m.SeguroID == id);
            _context.SeguroMedico.Remove(seguroMedico);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SeguroMedicoExists(int id)
        {
            return _context.SeguroMedico.Any(e => e.SeguroID == id);
        }
    }
}
