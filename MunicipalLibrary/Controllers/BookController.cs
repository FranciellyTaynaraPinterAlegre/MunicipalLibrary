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
    }
}