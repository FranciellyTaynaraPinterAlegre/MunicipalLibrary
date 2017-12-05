using MunicipalLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MunicipalLibrary.Controllers {
    public class ClientController : Controller{

        private ApplicationDbContext _context;

        public ClientController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult Index() {
            var clients = _context.Clients.ToList();
            
            return View(clients);
        }

        public ActionResult New()
        {
            var clientmodel = new Client();
            return View("ClientForm", clientmodel);
        }
    }
}