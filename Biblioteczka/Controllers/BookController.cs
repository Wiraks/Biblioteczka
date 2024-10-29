using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Biblioteczka.Models;

namespace Biblioteczka.Controllers
{
    public class BookController : Controller
    {

        [NonAction]
        public List<Book> GetBooksList()
        {
            return new List<Book>{
                  new Book{
                     ID = 1,
                     Name = "Gra o tron",
                     Author = "Martin George R. R.",
                     PublishingHouse = "Wydawnictwo Zysk i S-ka",
                     ReleaseDate = 2011,
                     NumberOfPages= 844,
                     BookBinding = "Miękka",
                     ISBN = "978-83-7506-729-3",
                     OwnerID = 1,
                  },
                  new Book{
                     ID = 2,
                     Name = "Starcie królów",
                     Author = "Martin George R. R.",
                     PublishingHouse = "Wydawnictwo Zysk i S-ka",
                     ReleaseDate = 2012,
                     NumberOfPages= 1024,
                     BookBinding = "Twarda",
                     ISBN = "978-83-8335-275-6",
                     OwnerID = 1,
                  },
            };
        }
        // GET: Book
        public ActionResult Index()
        {
            var books = from e in GetBooksList()
                           orderby e.ID
                           select e;
            return View(books);
        }

        // GET: Book/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Book/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Book/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

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
            List<Book> bkList = GetBooksList();
            var bk = bkList.Single(m => m.ID == id);
            return View(bk);
        }

        // POST: Book/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Book/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Book/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
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
