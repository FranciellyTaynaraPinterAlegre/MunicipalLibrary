using MunicipalLibrary.Models;
using MunicipalLibrary.ViewModels;
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
        public ActionResult New()
        {
            var rentmodel = new RentFormViewModel
            {
                Rent = new Rent()
            };
            return View("RentForm", rentmodel);
        }
        [HttpPost] // só será acessada com POST
        [ValidateAntiForgeryToken]
        public ActionResult Save(Rent rent) // recebemos um rente
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new RentFormViewModel
                {
                    Rent = rent
                };

                return View("RentForm", viewModel);
            }

            if (rent.Id == 0)
            {
                // armazena o rente em memória
                _context.Rents.Add(rent);
            }
            else
            {
                var rentInDb = _context.Rents.Single(c => c.Id == rent.Id);

                rentInDb.RentDate = rent.RentDate;
                rentInDb.Book = rent.Book;
                rentInDb.Client = rent.Client;
            }

            // faz a persistência
            _context.SaveChanges();
            // Voltamos para a lista de rentes
            return RedirectToAction("Index");
        }
        public ActionResult Edit(int id)
        {
            var rentInDb = _context.Rents.SingleOrDefault(c => c.Id == id);

            if (rentInDb == null)
                return HttpNotFound();

            var viewModel = new RentFormViewModel
            {
                Rent = rentInDb
            };

            return View("rentForm", viewModel);
        }
        public ActionResult Delete(int id)
        {
            var rent = _context.Rents.SingleOrDefault(c => c.Id == id);

            if (rent == null)
                return HttpNotFound();

            _context.Rents.Remove(rent);
            _context.SaveChanges();

            return new HttpStatusCodeResult(200);
        }
    }
}