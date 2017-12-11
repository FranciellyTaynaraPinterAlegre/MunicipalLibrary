using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MunicipalLibrary.Models;

namespace MunicipalLibrary.ViewModels
{
    public class AuthorFormViewModel
    {
        public IEnumerable<Book> Book { get; set; }
        public Author Author { get; set; }
        public string Title
        {
            get
            {
                if (Author != null && Author.Id != 0)
                {
                    return "Editar Autor";
                }
                else
                {
                    return "Novo Autor";
                }
            }
        }
    }
}