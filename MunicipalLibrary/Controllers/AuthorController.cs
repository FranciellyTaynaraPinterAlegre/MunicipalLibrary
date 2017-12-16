using MunicipalLibrary.Models;
using MunicipalLibrary.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace MunicipalLibrary.Controllers {
    [Authorize]
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
        public ActionResult New()
        {
            var authormodel = new AuthorFormViewModel
            {
                Author = new Author()
            };
            return View("AuthorForm", authormodel);
        }
        [HttpPost] // só será acessada com POST
        [ValidateAntiForgeryToken]
        public ActionResult Save(Author autor) // recebemos um authore
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new AuthorFormViewModel
                {
                    Author = autor
                };

                return View("AuthorForm", viewModel);
            }

            if (autor.Id == 0)
            {
                // armazena o authore em memória
                _context.Authors.Add(autor);
            }
            else
            {
                var authorInDb = _context.Authors.Single(c => c.Id == autor.Id);

                authorInDb.Name = autor.Name;
                authorInDb.Document = autor.Document;
                authorInDb.Sex = autor.Sex;
            }

            // faz a persistência
            _context.SaveChanges();
            // Voltamos para a lista de authores
            return RedirectToAction("Index");
        }
        public ActionResult Edit(int id)
        {
            var authorInDb = _context.Authors.SingleOrDefault(c => c.Id == id);

            if (authorInDb == null)
                return HttpNotFound();

            var viewModel = new AuthorFormViewModel
            {
                Author = authorInDb
            };

            return View("AuthorForm", viewModel);
        }
        public ActionResult Delete(int id)
        {
            var author = _context.Authors.SingleOrDefault(c => c.Id == id);

            if (author == null)
                return HttpNotFound();

            _context.Authors.Remove(author);
            _context.SaveChanges();

            return new HttpStatusCodeResult(200);
        }
    }
}