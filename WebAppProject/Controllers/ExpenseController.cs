﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppProject.Data;
using WebAppProject.Models;

namespace WebAppProject.Controllers {
    public class ExpenseController : Controller {
        private readonly ExpensesDbContext _db;

        public ExpenseController(ExpensesDbContext db) {
            _db = db;
        }

        public IActionResult Index() {
            IEnumerable<Expense> objList = _db.Expenses;
            return View(objList);
        }
        public IActionResult Create() {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Expense obj) {
            if (ModelState.IsValid) {
                _db.Expenses.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        public IActionResult Delete(int? id) {
            if (id == null || id == 0)
                return NotFound();

            var obj = _db.Expenses.Find(id);
            if (obj == null)
                return NotFound();

            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePost(int? id) {
            var obj = _db.Expenses.Find(id);
            if(obj == null)
                return NotFound();
           
            _db.Expenses.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Update(int? id) {
            if (id == null || id == 0)
                return NotFound();

            var obj = _db.Expenses.Find(id);
            if (obj == null)
                return NotFound();

            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(Expense obj) {
            if (ModelState.IsValid) {
                _db.Expenses.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }
    }
}
