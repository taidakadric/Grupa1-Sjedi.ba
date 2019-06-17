﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SjediBa.Models;

namespace SjediBa.Controllers
{
    public class RegisteredUserController : Controller
    {
        private readonly DatabaseContext _context;

        public RegisteredUserController(DatabaseContext context)
        {
            _context = context;
        }

        // GET: RegisteredUser
        public async Task<IActionResult> Index()
        {
            var databaseContext = _context.Registrovani.Include(r => r.AccountModel);
            return View(await databaseContext.ToListAsync());
        }

        // GET: RegisteredUser/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var registeredUserModel = await _context.Registrovani
                .Include(r => r.AccountModel)
                .FirstOrDefaultAsync(m => m.UserModelId == id);
            if (registeredUserModel == null)
            {
                return NotFound();
            }

            return View(registeredUserModel);
        }

        // GET: RegisteredUser/Create
        public IActionResult Create()
        {
            ViewData["AccountModelId"] = new SelectList(_context.racuni, "AccountModelId", "Password");
            return View();
        }

        // POST: RegisteredUser/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AccountModelId,UserModelId,Name,Surname,Address,DateOfBirth")] RegisteredUserModel registeredUserModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(registeredUserModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["AccountModelId"] = new SelectList(_context.racuni, "AccountModelId", "Password", registeredUserModel.AccountModelId);
            return View(registeredUserModel);
        }

        // GET: RegisteredUser/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var registeredUserModel = await _context.Registrovani.FindAsync(id);
            if (registeredUserModel == null)
            {
                return NotFound();
            }
            ViewData["AccountModelId"] = new SelectList(_context.racuni, "AccountModelId", "Password", registeredUserModel.AccountModelId);
            return View(registeredUserModel);
        }

        // POST: RegisteredUser/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("AccountModelId,UserModelId,Name,Surname,Address,DateOfBirth")] RegisteredUserModel registeredUserModel)
        {
            if (id != registeredUserModel.UserModelId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(registeredUserModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RegisteredUserModelExists(registeredUserModel.UserModelId))
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
            ViewData["AccountModelId"] = new SelectList(_context.racuni, "AccountModelId", "Password", registeredUserModel.AccountModelId);
            return View(registeredUserModel);
        }

        // GET: RegisteredUser/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var registeredUserModel = await _context.Registrovani
                .Include(r => r.AccountModel)
                .FirstOrDefaultAsync(m => m.UserModelId == id);
            if (registeredUserModel == null)
            {
                return NotFound();
            }

            return View(registeredUserModel);
        }

        // POST: RegisteredUser/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var registeredUserModel = await _context.Registrovani.FindAsync(id);
            _context.Registrovani.Remove(registeredUserModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RegisteredUserModelExists(int id)
        {
            return _context.Registrovani.Any(e => e.UserModelId == id);
        }
    }
}