using MunicipalLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MunicipalLibrary.Controllers {
    public class ClientController : Controller{
        public ActionResult Index() {
            var client = new Client() { Name = "Fernado" };
            return View(client);
        }
    }
}