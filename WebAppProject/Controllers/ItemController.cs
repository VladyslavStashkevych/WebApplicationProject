﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppProject.Data;
using WebAppProject.Models;

namespace WebAppProject.Controllers {
    public class ItemController : Controller {
        private readonly ApplicationDbContext _db;

        public ItemController(ApplicationDbContext db) {
            _db = db;
        }

        public IActionResult Index() {
            IEnumerable<Item> objList = _db.Items;
            return View(objList);
        }
        public IActionResult Create() {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Item obj) {
            _db.Items.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
