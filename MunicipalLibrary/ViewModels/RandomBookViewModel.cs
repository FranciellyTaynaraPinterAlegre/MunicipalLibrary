using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MunicipalLibrary.Models;

namespace Vidly.ViewModels
{
    public class RandomBookViewModel
    {
        public Book Book { get; set; }
        public List<Client> Clients { get; set; }
    }
}