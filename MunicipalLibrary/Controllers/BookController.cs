using MunicipalLibrary.Models;
using System.Web.Mvc;

namespace MunicipalLibrary.Controllers {
    public class BookController : Controller {

        public ActionResult Index() {
            var book = new Book() { Title = "Shrek!" };
            return View(book);
        }

    }
}