using MunicipalLibrary.Models;
using System;
using System.Web.Mvc;

namespace MunicipalLibrary.Controllers {
    public class RentController : Controller {
        public ActionResult Index() {
            var rent = new Rent() { RentDate = new DateTimeOffset(2017, 12, 17, 23, 59, 00, new TimeSpan(-3, 0, 0)) };
            return View(rent);
        }
    }
}