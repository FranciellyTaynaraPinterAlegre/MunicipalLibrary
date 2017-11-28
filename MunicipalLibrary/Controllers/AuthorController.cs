using MunicipalLibrary.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace MunicipalLibrary.Controllers {
    public class AuthorController : Controller {
        // GET: Author
        private ApplicationDbContext _context;

        public AuthorController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult Index()
        {
            var authors = _context.Authors.ToList();

            return View(authors);
        }
    }
}