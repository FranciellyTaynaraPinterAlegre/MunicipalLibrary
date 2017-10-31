using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MunicipalLibrary.Models;

namespace MunicipalLibrary.ViewModels
{
    public class RandomBookViewModel
    {
        public Book Books { get; set; }
        public List<Client> Clients { get; set; }
    }
}