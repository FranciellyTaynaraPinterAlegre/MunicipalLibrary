using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MunicipalLibrary.Models;
using MunicipalLibrary.Controllers;
using MunicipalLibrary.ViewModels;

namespace MunicipalLibrary.Controllers
{
    [Authorize]
    public class BookController : Controller
    {
        

        private ApplicationDbContext _context;

        public BookController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult Index()
        {
            var books = _context.Books.ToList();

            return View(books);
        }
        public ActionResult New()
        {
            var bookmodel = new BookFormViewModel
            {
                Book = new Book()
            };
            return View("BookForm", bookmodel);
        }
        [HttpPost] // só será acessada com POST
        [ValidateAntiForgeryToken]
        public ActionResult Save(Book book) // recebemos um booke
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new BookFormViewModel
                {
                    Book = book
                };

                return View("BookForm", viewModel);
            }

            if (book.Id == 0)
            {
                // armazena o booke em memória
                _context.Books.Add(book);
            }
            else
            {
                var bookInDb = _context.Books.Single(c => c.Id == book.Id);

                bookInDb.Title = book.Title;
                bookInDb.Subtitle = book.Subtitle;
                bookInDb.Category = book.Category;
            }

            // faz a persistência
            _context.SaveChanges();
            // Voltamos para a lista de bookes
            return RedirectToAction("Index");
        }
        public ActionResult Edit(int id)
        {
            var bookInDb = _context.Books.SingleOrDefault(c => c.Id == id);

            if (bookInDb == null)
                return HttpNotFound();

            var viewModel = new BookFormViewModel
            {
                Book = bookInDb
            };

            return View("BookForm", viewModel);
        }
        public ActionResult Delete(int id)
        {
            var book = _context.Books.SingleOrDefault(c => c.Id == id);

            if (book == null)
                return HttpNotFound();

            _context.Books.Remove(book);
            _context.SaveChanges();

            return new HttpStatusCodeResult(200);
        }
    }
}