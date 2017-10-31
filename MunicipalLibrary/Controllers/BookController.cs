﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MunicipalLibrary.Models;
using MunicipalLibrary.Controllers;
using MunicipalLibrary.ViewModels;

namespace MunicipalLibrary.Controllers
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
        public ApplicationDbContext _context;

        public BooksController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Books/Random
        public ActionResult Index()
        {
            var books = new Book()
            {
                Title = "A culpa é das estrelas"
            };

            
            var clients = new List<Client>
            {
                new Client { Id = 1 },
                new Client { Id = 2 }
            };

            var viewModel = new RandomBookViewModel
            {
                Books = books,
                Clients = clients
            };

            return View(books);
        }

        public ActionResult Random()
        {
            var books = _context.Books.ToList();

            return View(books);
        }

        public ActionResult Details(int id)
        {
            var books = GetBooks().SingleOrDefault(m => m.Id == id);

            if (books == null)
                return HttpNotFound();

            return View(books);
        }

    }
}