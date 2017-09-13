using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MunicipalLibrary.Models;
using MunicipalLibrary.Controllers;
using MunicipalLibrary.ViewModels;

namespace Vidly.Controllers
{
    public class BooksController : Controller
    {
        public IEnumerable<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book {  Title = "A culpa é das estrelas", Id = 1},
                new Book { Title = "The last song", Id = 2}
            };
        }

        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Book()
            {
                Title = "A culpa é das estrelas"
            };

            var customers = new List<Client>
            {
                new Client { Id = 1 },
                new Client { Id = 2 }
            };

            var viewModel = new RandomBookViewModel
            {
                Book = books,
                Client = clients
            };

            return View(viewModel);
        }

        public ActionResult Index()
        {
            var movies = GetBooks();

            return View(movies);
        }

        public ActionResult Details(int id)
        {
            var movie = GetBooks().SingleOrDefault(m => m.Id == id);

            if (movie == null)
                return HttpNotFound();

            return View(movie);
        }

    }
}