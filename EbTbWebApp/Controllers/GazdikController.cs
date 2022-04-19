using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EbTbWebApp.Data;
using EbTbWebApp.Models;

namespace EbTbWebApp.Controllers
{
    public class GazdikController : Controller
    {
        private readonly ApplicationDbContext _context;

        public GazdikController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Gazdik
        public async Task<IActionResult> Index()
        {
            return View(await _context.Gazdi.ToListAsync());
        }

        // GET: Gazdik/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gazdi = await _context.Gazdi
                .FirstOrDefaultAsync(m => m.id == id);
            if (gazdi == null)
            {
                return NotFound();
            }

            return View(gazdi);
        }

        // GET: Gazdik/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Gazdik/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,GazdiNev,GazdiCim,GazdiTelefon,AllatId,AllatNev,SzulIdo,FajId,OltasId")] Gazdi gazdi)
        {
            if (ModelState.IsValid)
            {
                _context.Add(gazdi);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(gazdi);
        }

        // GET: Gazdik/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gazdi = await _context.Gazdi.FindAsync(id);
            if (gazdi == null)
            {
                return NotFound();
            }
            return View(gazdi);
        }

        // POST: Gazdik/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,GazdiNev,GazdiCim,GazdiTelefon,AllatId,AllatNev,SzulIdo,FajId,OltasId")] Gazdi gazdi)
        {
            if (id != gazdi.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(gazdi);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GazdiExists(gazdi.id))
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
            return View(gazdi);
        }

        // GET: Gazdik/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gazdi = await _context.Gazdi
                .FirstOrDefaultAsync(m => m.id == id);
            if (gazdi == null)
            {
                return NotFound();
            }

            return View(gazdi);
        }

        // POST: Gazdik/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var gazdi = await _context.Gazdi.FindAsync(id);
            _context.Gazdi.Remove(gazdi);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GazdiExists(int id)
        {
            return _context.Gazdi.Any(e => e.id == id);
        }
    }
}
