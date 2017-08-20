using MunicipalLibrary.Models;
using System.Web.Mvc;

namespace MunicipalLibrary.Controllers {
    public class PersonController : Controller {
        public ActionResult Index() {
            var person = new Person() { Name = "Fernado" };
            return View(person);

        }
    }
}