using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MunicipalLibrary.Models;

namespace MunicipalLibrary.ViewModels
{
    public class AuthorFormViewModel
    {
        
        public IEnumerable<Sex> Sex { get; set; }
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

        public AuthorFormViewModel() : base()
        {
            Sex = new List<Sex>() {
                Models.Sex.Feminine,
                Models.Sex.Masculine,
                Models.Sex.Other
            };
        }
    }
}