using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AccountManagementApp2.Models;

namespace AccountManagementApp2.Controllers
{
    public class AccountsController : Controller
    {
        private readonly AccountManagementDbContext _context;

        public AccountsController(AccountManagementDbContext context)
        {
            _context = context;
        }

        // GET: Accounts
        public async Task<IActionResult> Index()
        {
            return View(await _context.Accounts.ToListAsync());
        }
        [HttpGet]
        public async Task<List<Account>> GetData()
        {
            var fetchedList = await _context.Accounts.ToListAsync();
            return fetchedList;
        }
        [HttpGet]
        public async Task<Account> GetData(int id) //returning one account which matches the id 
        {
            var fetchedList = await _context.Accounts.FirstOrDefaultAsync(n => n.Id == id);
            return fetchedList;
        }


        [HttpPost]
        public async Task<string> SaveData(string firstName, string lastName, string email, string gender, string dateOfBirth, bool isComplete )
        {
            Account toSave = new Account();
            toSave.firstName = firstName;
            toSave.lastName = lastName;
            toSave.email = email;
            toSave.gender = gender;
            toSave.dateOfBirth = DateTime.Now;//Convert.ToDateTime(dateOfBirth);
            toSave.isComplete = isComplete;
            _context.Add(toSave);
            await _context.SaveChangesAsync();
            return "Okay";
            
        }
        // GET: Accounts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var account = await _context.Accounts.FindAsync(id);
            if (account == null)
            {
                return NotFound();
            }
            return View(account);
        }

        // POST: Accounts/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FirstName,LastName,Email,Gender,DateOfBirth,CreatedDate,LastUpdatedDate,DeletionDate,IsComplete")] Account account)
        {
            if (id != account.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(account);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AccountExists(account.Id))
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
            return View(account);
        }

        // GET: Accounts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var account = await _context.Accounts
                .FirstOrDefaultAsync(m => m.Id == id);
            if (account == null)
            {
                return NotFound();
            }

            return View(account);
        }

        // POST: Accounts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var account = await _context.Accounts.FindAsync(id);
            _context.Accounts.Remove(account);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AccountExists(int id)
        {
            return _context.Accounts.Any(e => e.Id == id);
        }
    }
}
