using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MunicipalLibrary.Models;

namespace MunicipalLibrary.ViewModels
{
    public class RentFormViewModel
    {
        public IEnumerable<Client> Client { get; set; }
        public IEnumerable<Book> Book { get; set; }
        public Rent Rent { get; set; }
        public string Title
        {
            get
            {
                if (Rent != null && Rent.Id != 0)
                {
                    return "Editar Emprestimo";
                }
                else
                {
                    return "Novo Emprestimo";
                }
            }
        }

    }
}
