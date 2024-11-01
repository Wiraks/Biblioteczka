﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Biblioteczka.Models;

namespace Biblioteczka.Controllers
{
    [Authorize]
    public class BookController : Controller
    {
        private BookDBContext db = new BookDBContext();
        
        // GET: Book
        public ActionResult Index()
        {
            var bk = from e in db.Books
                            orderby e.ID
                            select e;
            return View(bk);
        }

        // GET: Book/Details/5
        public ActionResult Details(int id)
        {
            var bk = db.Books.Single(m => m.ID == id);
            return View(bk);
        }

        // GET: Book/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Book/Create
        [HttpPost]
        public ActionResult Create(Book bk)
        {
            try
            {
                bk.OwnerID = 1;
                db.Books.Add(bk);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Book/Edit/5
        public ActionResult Edit(int id)
        {
            var bk = db.Books.Single(m => m.ID == id);
            return View(bk);
        }

        // POST: Book/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                var bk = db.Books.Single(m => m.ID == id);
                if (TryUpdateModel(bk))
                {
                    //To Do:- database code
                    return RedirectToAction("Index");
                }
                return View(bk);
            }
            catch
            {
                return View();
            }
        }

        // GET: Book/Delete/5
        public ActionResult Delete(int id)
        {
            var bk = db.Books.Single(m => m.ID == id);
            return View(bk);
        }

        // POST: Book/Delete/5
        [HttpPost]
        public ActionResult Delete(Book bk)
        {
            try
            {
                db.Books.Remove(bk);
                db.SaveChanges();
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

    }
}
