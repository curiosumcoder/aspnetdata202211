﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Northwind.Data;
using Northwind.Model;

namespace Northwind.UI.Intranet.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class RegionController : Controller
    {
        private readonly NWContext _context;

        public RegionController(NWContext context)
        {
            _context = context;
        }

        // GET: Admin/Region
        public async Task<IActionResult> Index()
        {
              return View(await _context.Regions.ToListAsync());
        }

        // GET: Admin/Region/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Regions == null)
            {
                return NotFound();
            }

            var region = await _context.Regions
                .FirstOrDefaultAsync(m => m.RegionId == id);
            if (region == null)
            {
                return NotFound();
            }

            return View(region);
        }

        // GET: Admin/Region/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/Region/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("RegionId,RegionDescription")] Region region)
        {
            if (ModelState.IsValid)
            {
                _context.Add(region);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(region);
        }

        // GET: Admin/Region/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Regions == null)
            {
                return NotFound();
            }

            var region = await _context.Regions.FindAsync(id);
            if (region == null)
            {
                return NotFound();
            }
            return View(region);
        }

        // POST: Admin/Region/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("RegionId,RegionDescription")] Region region)
        {
            if (id != region.RegionId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(region);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RegionExists(region.RegionId))
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
            return View(region);
        }

        // GET: Admin/Region/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Regions == null)
            {
                return NotFound();
            }

            var region = await _context.Regions
                .FirstOrDefaultAsync(m => m.RegionId == id);
            if (region == null)
            {
                return NotFound();
            }

            return View(region);
        }

        // POST: Admin/Region/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Regions == null)
            {
                return Problem("Entity set 'NWContext.Regions'  is null.");
            }
            var region = await _context.Regions.FindAsync(id);
            if (region != null)
            {
                _context.Regions.Remove(region);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RegionExists(int id)
        {
          return _context.Regions.Any(e => e.RegionId == id);
        }
    }
}
