using MunicipalLibrary.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace MunicipalLibrary.Controllers {
    public class AuthorController : Controller {
        // GET: Author
        public ActionResult Index() {
            return View(new List<Author>() {
                new Author() {Name = "Francielly", Sex = Sex.Feminine },
                new Author() {Name = "Fernando", Sex = Sex.Masculine }
            });
        }
    }
}