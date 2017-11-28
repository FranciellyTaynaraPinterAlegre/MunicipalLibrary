using MunicipalLibrary.Models;
using System;
using System.Linq;
using System.Web.Mvc;

namespace MunicipalLibrary.Controllers
{
    public class RentController : Controller
    {
        private ApplicationDbContext _context;

        public RentController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult Index()
        {
            var rents = _context.Rents.ToList();

            return View(rents);
        }
    }
}