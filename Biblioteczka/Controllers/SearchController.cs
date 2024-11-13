using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Biblioteczka.Models;
using Microsoft.AspNet.Identity;

namespace Biblioteczka.Controllers
{
    [Authorize]
    public class SearchController : Controller
    {

        private BookDBContext db = new BookDBContext();

        // GET: Search
        public ActionResult Index()
        {
            string ownID = User.Identity.GetUserId();
            var bk = from e in db.Books
                     where e.OwnerID == ownID
                     orderby e.ID
                     select e;
            return View(bk);
        }

        // GET: Search/Details/5
        public ActionResult Details(int id)
        {
            var bk = db.Books.Single(m => m.ID == id);
            return View(bk);
        }
    }
}
