﻿using System;
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
        public ActionResult Create()//route to create page, render view
        {
            return View();
        }
      
        [HttpGet]
        public async Task<List<Account>> GetData(int id)
        {
            List<Account> fetchedList = new List<Account>();
            if (id > 0)
            {
                fetchedList = await _context.Accounts.Where(n => n.Id == id).ToListAsync();
            }
            else
            {
                fetchedList = await _context.Accounts.ToListAsync();
            }

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

        [HttpPut]
        public async Task<string> EditData(int id, string firstName, string lastName, string email, string gender, string dateOfBirth, bool isComplete)
        {
            Account toEdit = _context.Accounts.FirstOrDefault(n=>n.Id==id);
            toEdit.firstName = firstName;
            toEdit.lastName = lastName;
            toEdit.email = email;
            toEdit.gender = gender;
            toEdit.dateOfBirth = DateTime.Now;//Convert.ToDateTime(dateOfBirth);
            toEdit.isComplete = isComplete;
            _context.Update(toEdit);
            await _context.SaveChangesAsync();
            return "Okay";
        }

        [HttpDelete]
       public void DeleteData(int id)
        {
            var objectToDelete = _context.Accounts.FirstOrDefault(n => n.Id == id);
            _context.Remove(objectToDelete);
             _context.SaveChanges();
        } 
    }
}
