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
        public ActionResult New()
        {
            var clientmodel = new ClientFormViewModel
            {
                Client = new Client()
            };
            return View("ClientForm", clientmodel);
        }
        [HttpPost] // só será acessada com POST
        [ValidateAntiForgeryToken]
        public ActionResult Save(Client client) // recebemos um cliente
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new ClientFormViewModel
                {
                    Client = client
                };

                return View("ClientForm", viewModel);
            }

            if (client.Id == 0)
            {
                // armazena o cliente em memória
                _context.Clients.Add(client);
            }
            else
            {
                var clientInDb = _context.Clients.Single(c => c.Id == client.Id);

                clientInDb.Name = client.Name;
                clientInDb.Document = client.Document;
                clientInDb.BirthDate = client.BirthDate;
                clientInDb.CivilState = client.CivilState;
                clientInDb.Sex = client.Sex;
            }

            // faz a persistência
            _context.SaveChanges();
            // Voltamos para a lista de clientes
            return RedirectToAction("Index");
        }
        public ActionResult Edit(int id)
        {
            var clientInDb = _context.Clients.SingleOrDefault(c => c.Id == id);

            if (clientInDb == null)
                return HttpNotFound();

            var viewModel = new ClientFormViewModel
            {
                Client = clientInDb
            };

            return View("ClientForm", viewModel);
        }
        public ActionResult Delete(int id)
        {
            var client = _context.Clients.SingleOrDefault(c => c.Id == id);

            if (client == null)
                return HttpNotFound();

            _context.Clients.Remove(client);
            _context.SaveChanges();

            return new HttpStatusCodeResult(200);
        }
    }
}