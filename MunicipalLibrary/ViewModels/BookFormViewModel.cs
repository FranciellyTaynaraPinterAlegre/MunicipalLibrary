using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MunicipalLibrary.Models;

namespace MunicipalLibrary.ViewModels
{
    public class BookFormViewModel
    {
        public Book Book { get; set; }
        public string Title
        {
            get
            {
                if (Book != null && Book.Id != 0)
                {
                    return "Editar Cliente";
                }
                else
                {
                    return "Novo Cliente";
                }
            }
        }
        public IEnumerable<Category> Category { get; set; }

        public BookFormViewModel() : base()
        {
            Category = new List<Category>() {
                Models.Category.Action,
                Models.Category.Adventure,
                Models.Category.Drama,
                Models.Category.Fiction,
                Models.Category.NonFiction,
                Models.Category.Romance,
                Models.Category.SelfHelp,
                Models.Category.TeenDrama,
                Models.Category.TeenFiction,
                Models.Category.TeenRomance
            };

        }
    }
}

